using System;
using System.Collections.Generic;
using System.Web.Http.Description;
using WebApiHelpPage.ModelDescriptions;
using WebApiHelpPage.Models;

namespace WebApiHelpPage
{
    public partial class ResourceModel
    {
        public ModelDescription Model { get; set; }
        public IList<ParameterDescription> Parameters { get; set; }
        public string HomePageLink { get; set; }
        public Func<string, string> ResourceModelLinkFactory { get; set; }
    }
}
