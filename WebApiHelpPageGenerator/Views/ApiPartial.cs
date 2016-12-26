using System;
using System.Web.Http.Description;
using WebApiHelpPage.Models;

namespace WebApiHelpPage
{
    public partial class Api
    {
        public HelpPageApiModel Model { get; set; }

        public string HomePageLink { get; set; }
        public IDocumentationProvider DocumentationProvider { get; set; }
        public Func<string, string> ResourceModelLinkFactory { get; set; }
    }
}