using System.Web.Http.Description;
using WebApiHelpPage.ModelDescriptions;
using WebApiHelpPage.Models;

namespace WebApiHelpPage
{
    public partial class ResourceModel
    {
        public HelpPageApiModel Model { get; set; }
        public string HomePageLink { get; set; }
    }
}
