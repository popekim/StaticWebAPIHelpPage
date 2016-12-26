using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Web.Http.Description;
using WebApiHelpPage;
using WebApiHelpPage.ModelDescriptions;
using WebApiHelpPage.Models;

namespace WebApiHelpPageGenerator
{
    public class DefaultOutputGenerator : IOutputGenerator
    {
        private const string fileName = "HelpPage.html";

        public void GenerateIndex(Collection<ApiDescription> apis, IDocumentationProvider documentationProvider)
        {
            Index indexTemplate = new Index
            {
                Model = apis,
                DocumentationProvider = documentationProvider,
                ApiLinkFactory = apiName =>
                {
                    return apiName + ".html";
                }
            };
            string helpPageIndex = indexTemplate.TransformText();
            WriteFile(fileName, helpPageIndex);
        }

        public void GenerateApiDetails(HelpPageApiModel apiModel)
        {
            Api apiTemplate = new Api
            {
                Model = apiModel,
                HomePageLink = fileName,
                ResourceModelLinkFactory = resourceModelName =>
                {
                    return resourceModelName + ".html";
                }
            };
            string helpPage = apiTemplate.TransformText();
            WriteFile(apiModel.ApiDescription.GetFriendlyId() + ".html", helpPage);
        }

        private HashSet<string> _processedResources = new HashSet<string>();
        public void GenerateResourceModel(ModelDescription modelDescription)
        {
            string modelDescriptionName = modelDescription.Name;

            if (_processedResources.Contains(modelDescriptionName))
            {
                return;
            }

            _processedResources.Add(modelDescriptionName);

            if (modelDescription is EnumTypeModelDescription)
            {
                var resourceModelTemplate = new EnumModel
                {
                    Model = modelDescription as EnumTypeModelDescription,
                    HomePageLink = fileName,
                };

                string helpPage = resourceModelTemplate.TransformText();
                WriteFile($"RES-{modelDescriptionName}.html", helpPage);

                return;
            }

            if (modelDescription is ComplexTypeModelDescription || modelDescription is CollectionModelDescription)
            {
                var parameters = HelpPageApiModel.GetParameterDescriptions(modelDescription);

                if (parameters != null && parameters.Count > 0)
                {
                    var resourceModelTemplate = new ResourceModel
                    {
                        Model = modelDescription,
                        Parameters = parameters,
                        HomePageLink = fileName,
                        ResourceModelLinkFactory = resourceModelName =>
                        {
                            return resourceModelName + ".html";
                        }
                    };

                    string helpPage = resourceModelTemplate.TransformText();
                    WriteFile($"RES-{modelDescriptionName}.html", helpPage);

                    foreach (var property in resourceModelTemplate.Parameters)
                    {
                        GenerateResourceModel(property.TypeDescription);
                    }
                }
            }
        }

        private static void WriteFile(string fileName, String pageContent)
        {
            Console.WriteLine("writing file: {0}", fileName);
            File.WriteAllText(fileName, pageContent);
        }
    }
}