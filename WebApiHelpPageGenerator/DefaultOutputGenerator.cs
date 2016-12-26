using System;
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

        public void GenerateResourceModel(HelpPageApiModel apiModel)
        {
            var resourceModelTemplate = new ResourceModel
            {
                Model = apiModel,
                HomePageLink = fileName,
            };

            string helpPage = resourceModelTemplate.TransformText();
            WriteFile($"RES-{apiModel.ResourceDescription.Name}.html", helpPage);
        }

        private static void WriteFile(string fileName, String pageContent)
        {
            Console.WriteLine("writing file: {0}", fileName);
            File.WriteAllText(fileName, pageContent);
        }
    }
}