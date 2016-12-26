using System.Collections.ObjectModel;
using System.Web.Http.Description;
using WebApiHelpPage.ModelDescriptions;
using WebApiHelpPage.Models;

namespace WebApiHelpPageGenerator
{
    public interface IOutputGenerator
    {
        void GenerateIndex(Collection<ApiDescription> apis, IDocumentationProvider documentationProvider);

        void GenerateApiDetails(HelpPageApiModel apiModel);

        void GenerateResourceModel(HelpPageApiModel modelDescription);
    }
}