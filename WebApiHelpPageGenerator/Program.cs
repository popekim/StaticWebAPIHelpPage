using System;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Web.Http;
using System.Web.Http.Description;
using CommandLine;
using WebApiHelpPage;
using WebApiHelpPage.Models;
using System.IO;

namespace WebApiHelpPageGenerator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var options = new CommandLineOptions();
            try
            {
                if (CommandLineParser.Default.ParseArguments(args, options))
                {
                    LoadReferences(options);

                    string assemblyPath = options.AssemblyPath;
                    HttpConfiguration config = HttpConfigurationImporter.ImportConfiguration(assemblyPath);
                    IDocumentationProvider documentationProvider = null;
                    if (!string.IsNullOrWhiteSpace(options.XmlDocumentPath))
                    {
                        var documentPath = Path.Combine(Environment.CurrentDirectory, options.XmlDocumentPath);
                        documentationProvider = new XmlDocumentationProvider(documentPath);
                        config.SetDocumentationProvider(documentationProvider);
                    }
                    config.EnsureInitialized();
                    Collection<ApiDescription> descriptions = config.Services.GetApiExplorer().ApiDescriptions;
                    IOutputGenerator outputGenerator = LoadOutputGenerator(options);

                    outputGenerator.GenerateIndex(descriptions, documentationProvider);

                    foreach (var api in descriptions)
                    {
                        HelpPageApiModel apiModel = HelpPageConfigurationExtensions.GenerateApiModel(api, config);
                        if (apiModel != null)
                        {
                            outputGenerator.GenerateApiDetails(apiModel);

                            if (apiModel.ResourceDescription != null)
                            {
                                outputGenerator.GenerateResourceModel(apiModel.ResourceDescription);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
        }

        private static IOutputGenerator LoadOutputGenerator(CommandLineOptions options)
        {
            IOutputGenerator outputGenerator = null;
            string extensionAssemblyPath = options.ExtensionAssemblyPath;
            if (!String.IsNullOrEmpty(extensionAssemblyPath))
            {
                var assembly = Assembly.LoadFrom(extensionAssemblyPath);
                foreach (var type in assembly.GetTypes())
                {
                    if ((typeof(IOutputGenerator)).IsAssignableFrom(type))
                    {
                        outputGenerator = (IOutputGenerator)Activator.CreateInstance(type);
                    }
                }
            }
            if (outputGenerator == null)
            {
                outputGenerator = new DefaultOutputGenerator();
            }
            return outputGenerator;
        }

        private static void LoadReferences(CommandLineOptions options)
        {
            foreach (var reference in options.References)
            {
                Assembly.LoadFrom(reference);
            }
        }
    }
}