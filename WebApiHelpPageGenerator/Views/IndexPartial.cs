using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Web.Http.Description;

namespace WebApiHelpPage
{
    public partial class Index
    {
        public IEnumerable<ApiDescription> Model { get; set; }
        public IDocumentationProvider DocumentationProvider { get; set; }

        public Func<string, string> ApiLinkFactory { get; set; }
    }
}