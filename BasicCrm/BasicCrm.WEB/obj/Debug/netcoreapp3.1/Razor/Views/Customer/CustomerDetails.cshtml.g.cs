#pragma checksum "C:\Users\serkan\Desktop\BasicCrm\BasicCrm\BasicCrm.WEB\Views\Customer\CustomerDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef0f0c2424e0d6ef46d6aa0d3babcc39de12c6f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_CustomerDetails), @"mvc.1.0.view", @"/Views/Customer/CustomerDetails.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\serkan\Desktop\BasicCrm\BasicCrm\BasicCrm.WEB\Views\_ViewImports.cshtml"
using BasicCrm.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\serkan\Desktop\BasicCrm\BasicCrm\BasicCrm.WEB\Views\_ViewImports.cshtml"
using BasicCrm.WEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef0f0c2424e0d6ef46d6aa0d3babcc39de12c6f8", @"/Views/Customer/CustomerDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"940005bd1b7cf0faf185de2ee979554c206b20a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_CustomerDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BasicCrm.Entities.Concrete.Customer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Customers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\serkan\Desktop\BasicCrm\BasicCrm\BasicCrm.WEB\Views\Customer\CustomerDetails.cshtml"
  
    ViewData["Title"] = "Customer Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Customer Details</h1>\r\n\r\n<div>\r\n    <h4>Customer</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2 border rounded-left\">\r\n            ");
#nullable restore
#line 14 "C:\Users\serkan\Desktop\BasicCrm\BasicCrm\BasicCrm.WEB\Views\Customer\CustomerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10 border-top\">\r\n            ");
#nullable restore
#line 17 "C:\Users\serkan\Desktop\BasicCrm\BasicCrm\BasicCrm.WEB\Views\Customer\CustomerDetails.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2 border rounded-left\">\r\n            ");
#nullable restore
#line 20 "C:\Users\serkan\Desktop\BasicCrm\BasicCrm\BasicCrm.WEB\Views\Customer\CustomerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10 border-top\">\r\n            ");
#nullable restore
#line 23 "C:\Users\serkan\Desktop\BasicCrm\BasicCrm\BasicCrm.WEB\Views\Customer\CustomerDetails.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2 border rounded-left\">\r\n            ");
#nullable restore
#line 26 "C:\Users\serkan\Desktop\BasicCrm\BasicCrm\BasicCrm.WEB\Views\Customer\CustomerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.SurName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10 border-top\">\r\n            ");
#nullable restore
#line 29 "C:\Users\serkan\Desktop\BasicCrm\BasicCrm\BasicCrm.WEB\Views\Customer\CustomerDetails.cshtml"
       Write(Html.DisplayFor(model => model.SurName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2 border rounded-left\">\r\n            ");
#nullable restore
#line 32 "C:\Users\serkan\Desktop\BasicCrm\BasicCrm\BasicCrm.WEB\Views\Customer\CustomerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10 border-top\">\r\n            ");
#nullable restore
#line 35 "C:\Users\serkan\Desktop\BasicCrm\BasicCrm\BasicCrm.WEB\Views\Customer\CustomerDetails.cshtml"
       Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2 border rounded-left\">\r\n            ");
#nullable restore
#line 38 "C:\Users\serkan\Desktop\BasicCrm\BasicCrm\BasicCrm.WEB\Views\Customer\CustomerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10 border-top\">\r\n            ");
#nullable restore
#line 41 "C:\Users\serkan\Desktop\BasicCrm\BasicCrm\BasicCrm.WEB\Views\Customer\CustomerDetails.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2 border rounded-left\">\r\n            ");
#nullable restore
#line 44 "C:\Users\serkan\Desktop\BasicCrm\BasicCrm\BasicCrm.WEB\Views\Customer\CustomerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Job));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10 border-top\">\r\n            ");
#nullable restore
#line 47 "C:\Users\serkan\Desktop\BasicCrm\BasicCrm\BasicCrm.WEB\Views\Customer\CustomerDetails.cshtml"
       Write(Html.DisplayFor(model => model.Job));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2 border rounded-left\">\r\n            ");
#nullable restore
#line 50 "C:\Users\serkan\Desktop\BasicCrm\BasicCrm\BasicCrm.WEB\Views\Customer\CustomerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10 border-top\">\r\n            ");
#nullable restore
#line 53 "C:\Users\serkan\Desktop\BasicCrm\BasicCrm\BasicCrm.WEB\Views\Customer\CustomerDetails.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 58 "C:\Users\serkan\Desktop\BasicCrm\BasicCrm\BasicCrm.WEB\Views\Customer\CustomerDetails.cshtml"
Write(Html.ActionLink("Edit", "EditCustomer", new { id = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef0f0c2424e0d6ef46d6aa0d3babcc39de12c6f89003", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BasicCrm.Entities.Concrete.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591