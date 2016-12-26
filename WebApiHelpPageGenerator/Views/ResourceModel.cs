﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace WebApiHelpPage
{
    using System.Web.Http.Description;
    using System.Web.Http.Controllers;
    using System.Collections.ObjectModel;
    using WebApiHelpPage.Models;
    using WebApiHelpPage.ModelDescriptions;
    using System.Web.Http;
    using System.Web;
    using System.Linq;
    using System.Threading;
    using System.Net.Http.Headers;
    using System.Collections.Generic;
    using WebApiHelpPage;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\dev\StaticWebAPIHelpPage\WebApiHelpPageGenerator\Views\ResourceModel.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class ResourceModel : ResourceModelBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            
            #line 14 "C:\dev\StaticWebAPIHelpPage\WebApiHelpPageGenerator\Views\ResourceModel.tt"

	var modelDesc = Model;
    var title = modelDesc.Name;

            
            #line default
            #line hidden
            this.Write("\r\n<html>\r\n<head>\r\n    <title>");
            
            #line 21 "C:\dev\StaticWebAPIHelpPage\WebApiHelpPageGenerator\Views\ResourceModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(title));
            
            #line default
            #line hidden
            this.Write("</title>\r\n\t<style type=\"text/css\">\r\n\t\t");
            this.Write("pre.wrapped {\n    white-space: -moz-pre-wrap;\n    white-space: -pre-wrap;\n    whi" +
                    "te-space: -o-pre-wrap;\n    white-space: pre-wrap;\n}\n\n.warning-message-container " +
                    "{\n    margin-top: 20px;\n    padding: 0 10px;\n    color: #525252;\n    background:" +
                    " #EFDCA9;\n    border: 1px solid #CCCCCC;\n}\n\n.help-page-table {\n    width: 100%;\n" +
                    "    border-collapse: collapse;\n    text-align: left;\n    margin: 0px 0px 20px 0p" +
                    "x;\n    border-top: 2px solid #D4D4D4;\n}\n\n    .help-page-table th {\n        text-" +
                    "align: left;\n        font-weight: bold;\n        border-bottom: 2px solid #D4D4D4" +
                    ";\n        padding: 8px 6px 8px 6px;\n    }\n\n    .help-page-table td {\n        bor" +
                    "der-bottom: 2px solid #D4D4D4;\n        padding: 15px 8px 15px 8px;\n        verti" +
                    "cal-align: top;\n    }\n\n    .help-page-table pre, .help-page-table p {\n        ma" +
                    "rgin: 0px;\n        padding: 0px;\n        font-family: inherit;\n        font-size" +
                    ": 100%;\n    }\n\n    .help-page-table tbody tr:hover td {\n        background-color" +
                    ": #F3F3F3;\n    }\n\na:hover {\n    background-color: transparent;\n}\n\n.sample-header" +
                    " {\n    border: 2px solid #D4D4D4;\n    background: #76B8DB;\n    color: #FFFFFF;\n " +
                    "   padding: 8px 15px;\n    border-bottom: none;\n    display: inline-block;\n    ma" +
                    "rgin: 10px 0px 0px 0px;\n}\n\n.sample-content {\n    display: block;\n    border-widt" +
                    "h: 0;\n    padding: 15px 20px;\n    background: #FFFFFF;\n    border: 2px solid #D4" +
                    "D4D4;\n    margin: 0px 0px 10px 0px;\n}\n\n.api-name {\n    width: 40%;\n}\n\n.api-docum" +
                    "entation {\n    width: 60%;\n}\n\n.parameter-name {\n    width: 20%;\n}\n\n.parameter-do" +
                    "cumentation {\n    width: 50%;\n}\n\n.parameter-source {\n    width: 30%;\n}");
            this.Write("\r\n\t</style>\r\n</head>\r\n<body>\r\n<div id=\"body\">\r\n   <section class=\"featured\">\r\n   " +
                    "     <div class=\"content-wrapper\">\r\n            <p>\r\n                <a href=\"");
            
            #line 31 "C:\dev\StaticWebAPIHelpPage\WebApiHelpPageGenerator\Views\ResourceModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(HomePageLink));
            
            #line default
            #line hidden
            this.Write("\">Help Page Home</a>\r\n            </p>\r\n        </div>\r\n    </section>\r\n    <h1>");
            
            #line 35 "C:\dev\StaticWebAPIHelpPage\WebApiHelpPageGenerator\Views\ResourceModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(modelDesc.Name));
            
            #line default
            #line hidden
            this.Write("</h1>\r\n\t");
            
            #line 36 "C:\dev\StaticWebAPIHelpPage\WebApiHelpPageGenerator\Views\ResourceModel.tt"
if (modelDesc.Documentation != null)
	{
            
            #line default
            #line hidden
            this.Write("\t\t<p>");
            
            #line 38 "C:\dev\StaticWebAPIHelpPage\WebApiHelpPageGenerator\Views\ResourceModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(modelDesc.Documentation));
            
            #line default
            #line hidden
            this.Write("</p>\r\n\t");
            
            #line 39 "C:\dev\StaticWebAPIHelpPage\WebApiHelpPageGenerator\Views\ResourceModel.tt"
}
            
            #line default
            #line hidden
            this.Write("    <section class=\"content-wrapper main-content clear-fix\">\r\n\t\t");
            
            #line 41 "C:\dev\StaticWebAPIHelpPage\WebApiHelpPageGenerator\Views\ResourceModel.tt"
if (Parameters.Count > 0)
		{ 
            
            #line default
            #line hidden
            this.Write("\t\t\t");
            
            #line 43 "C:\dev\StaticWebAPIHelpPage\WebApiHelpPageGenerator\Views\ResourceModel.tt"
var parameters = Parameters;
            
            #line default
            #line hidden
            this.Write("\t\t\t");
            this.Write("<table class=\"help-page-table\">\r\n    <thead>\r\n\t\t<tr><th>Name</th><th>Description<" +
                    "/th><th>Type</th><th>Additional information</th></tr>\r\n    </thead>\r\n    <tbody>" +
                    "\r\n    ");
            
            #line 6 "C:\dev\StaticWebAPIHelpPage\WebApiHelpPageGenerator\Views\DisplayTemplates\Parameters.tt"
 foreach (var parameter in parameters)
    {
		    ModelDescription modelDescription = parameter.TypeDescription;
		    string parameterDocumentation = parameter.Documentation != null ?
                parameter.Documentation : "No documentation available.";

        // Don't show CancellationToken because it's a special parameter
        if (!typeof(CancellationToken).IsAssignableFrom(parameter.TypeDescription.ModelType))
        { 
            
            #line default
            #line hidden
            this.Write("            <tr>\r\n                <td class=\"parameter-name\"><b>");
            
            #line 16 "C:\dev\StaticWebAPIHelpPage\WebApiHelpPageGenerator\Views\DisplayTemplates\Parameters.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameter.Name));
            
            #line default
            #line hidden
            this.Write("</b></td>\r\n                <td class=\"parameter-documentation\"><pre>");
            
            #line 17 "C:\dev\StaticWebAPIHelpPage\WebApiHelpPageGenerator\Views\DisplayTemplates\Parameters.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameterDocumentation));
            
            #line default
            #line hidden
            this.Write("</pre></td>\r\n\t\t\t\t        <td>\r\n                    ");
            
            #line 1 "C:\dev\StaticWebAPIHelpPage\WebApiHelpPageGenerator\Views\DisplayTemplates\ModelDescriptionLink.tt"
{
  if (modelDescription is ComplexTypeModelDescription || modelDescription is EnumTypeModelDescription)
  {
    if (Model.GetType() == typeof(Object))
    {
            
            #line default
            #line hidden
            this.Write("      <p>Object</p>\r\n    ");
            
            #line 7 "C:\dev\StaticWebAPIHelpPage\WebApiHelpPageGenerator\Views\DisplayTemplates\ModelDescriptionLink.tt"
}
    else
    {
            
            #line default
            #line hidden
            this.Write("      <a href=\'");
            
            #line 10 "C:\dev\StaticWebAPIHelpPage\WebApiHelpPageGenerator\Views\DisplayTemplates\ModelDescriptionLink.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ResourceModelLinkFactory("RES-" + modelDescription.Name)));
            
            #line default
            #line hidden
            this.Write("\'>");
            
            #line 10 "C:\dev\StaticWebAPIHelpPage\WebApiHelpPageGenerator\Views\DisplayTemplates\ModelDescriptionLink.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(modelDescription.Name));
            
            #line default
            #line hidden
            this.Write("</a>\r\n    ");
            
            #line 11 "C:\dev\StaticWebAPIHelpPage\WebApiHelpPageGenerator\Views\DisplayTemplates\ModelDescriptionLink.tt"
}
  }
  else if (modelDescription is CollectionModelDescription)
  {
    var collectionDescription = modelDescription as CollectionModelDescription;
    var elementDescription = collectionDescription.ElementDescription;
    modelDescription = elementDescription; 
            
            #line default
            #line hidden
            this.Write("    ");
            this.Write("  ");
            
            #line 19 "C:\dev\StaticWebAPIHelpPage\WebApiHelpPageGenerator\Views\DisplayTemplates\ModelDescriptionLink.tt"
}
  else
  {
            
            #line default
            #line hidden
            this.Write("    <p>");
            
            #line 22 "C:\dev\StaticWebAPIHelpPage\WebApiHelpPageGenerator\Views\DisplayTemplates\ModelDescriptionLink.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(modelDescription.Name));
            
            #line default
            #line hidden
            this.Write("</p>\r\n  ");
            
            #line 23 "C:\dev\StaticWebAPIHelpPage\WebApiHelpPageGenerator\Views\DisplayTemplates\ModelDescriptionLink.tt"
}
}
            
            #line default
            #line hidden
            this.Write("\r\n                </td>\r\n              \r\n                <td>\r\n                  " +
                    "  ");
            
            #line 23 "C:\dev\StaticWebAPIHelpPage\WebApiHelpPageGenerator\Views\DisplayTemplates\Parameters.tt"
if (parameter.Annotations.Count > 0)
                    {
						foreach (var annotation in parameter.Annotations)
                        {
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\t\t<p>");
            
            #line 27 "C:\dev\StaticWebAPIHelpPage\WebApiHelpPageGenerator\Views\DisplayTemplates\Parameters.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(annotation.Documentation));
            
            #line default
            #line hidden
            this.Write("</p>\r\n                        ");
            
            #line 28 "C:\dev\StaticWebAPIHelpPage\WebApiHelpPageGenerator\Views\DisplayTemplates\Parameters.tt"
}
                    }
                    else
                    {
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\t<p>None.</p>\r\n                    ");
            
            #line 33 "C:\dev\StaticWebAPIHelpPage\WebApiHelpPageGenerator\Views\DisplayTemplates\Parameters.tt"
}
            
            #line default
            #line hidden
            this.Write("                </td>\r\n            </tr>\r\n        ");
            
            #line 36 "C:\dev\StaticWebAPIHelpPage\WebApiHelpPageGenerator\Views\DisplayTemplates\Parameters.tt"
 } 
    } 
            
            #line default
            #line hidden
            this.Write("    </tbody>\r\n</table>");
            this.Write("\r\n\t\t");
            
            #line 45 "C:\dev\StaticWebAPIHelpPage\WebApiHelpPageGenerator\Views\ResourceModel.tt"

		}
		
            
            #line default
            #line hidden
            this.Write(" \r\n    </section>\r\n</div>\r\n</body>\r\n</html>");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public class ResourceModelBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
