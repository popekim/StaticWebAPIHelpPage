using System;
using System.IO;
using System.Web.Http.Description;
using WebApiHelpPage.Models;
using WebApiHelpPageGenerator;

namespace WebApiJsClientGenerator
{
    public class JsClientGenrator : IOutputGenerator
    {
        public void GenerateApiDetails(HelpPageApiModel apiModel)
        {
        }
        public void GenerateResourceModel(HelpPageApiModel modelDescription)
        {
        }

        public void GenerateIndex(System.Collections.ObjectModel.Collection<ApiDescription> apis, IDocumentationProvider documentationProvider)
        {
            JsClientTemplate jsClientTemplate = new JsClientTemplate
            {
                Apis = apis
            };
            string jsClient = jsClientTemplate.TransformText();
            WriteFile("client.js", jsClient);
        }

        private static void WriteFile(string fileName, String pageContent)
        {
            Console.WriteLine("writing file: {0}", fileName);
            File.WriteAllText(fileName, pageContent);
        }
    }
}