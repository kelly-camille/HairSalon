#pragma checksum "C:\Users\kelly\OneDrive\Desktop\HairSalon\Claires_Salon\Views\Clients\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91a68928d34900a3e3da4662a07b98f0d979a5db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Details), @"mvc.1.0.view", @"/Views/Clients/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91a68928d34900a3e3da4662a07b98f0d979a5db", @"/Views/Clients/Details.cshtml")]
    public class Views_Clients_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Claires_Salon.Models.Client>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\kelly\OneDrive\Desktop\HairSalon\Claires_Salon\Views\Clients\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>client Details</h2>\r\n<hr />\r\n<h3>");
#nullable restore
#line 10 "C:\Users\kelly\OneDrive\Desktop\HairSalon\Claires_Salon\Views\Clients\Details.cshtml"
Write(Html.DisplayNameFor(model => model.ClientName));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 10 "C:\Users\kelly\OneDrive\Desktop\HairSalon\Claires_Salon\Views\Clients\Details.cshtml"
                                                Write(Html.DisplayFor(model => model.ClientName));

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>\r\n<p>");
#nullable restore
#line 11 "C:\Users\kelly\OneDrive\Desktop\HairSalon\Claires_Salon\Views\Clients\Details.cshtml"
Write(Html.ActionLink("Edit Client", "Edit", new { id = Model.ClientId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 12 "C:\Users\kelly\OneDrive\Desktop\HairSalon\Claires_Salon\Views\Clients\Details.cshtml"
Write(Html.ActionLink("Delete Client", "Delete", new { id = Model.ClientId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 13 "C:\Users\kelly\OneDrive\Desktop\HairSalon\Claires_Salon\Views\Clients\Details.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Claires_Salon.Models.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591
