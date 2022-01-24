#pragma checksum "C:\Users\Дмитрий\Documents\нет\ClinicService\ClinicService\Views\Appointment\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8001630cd6168b2a2f4c514c793e158f930540c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Appointment_Details), @"mvc.1.0.view", @"/Views/Appointment/Details.cshtml")]
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
#line 1 "C:\Users\Дмитрий\Documents\нет\ClinicService\ClinicService\Views\_ViewImports.cshtml"
using ClinicService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Дмитрий\Documents\нет\ClinicService\ClinicService\Views\_ViewImports.cshtml"
using ClinicService.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Дмитрий\Documents\нет\ClinicService\ClinicService\Views\Appointment\Details.cshtml"
using Domain.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8001630cd6168b2a2f4c514c793e158f930540c9", @"/Views/Appointment/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d274277d1ef3792d2e11b0e9cd30f50e5eb568", @"/Views/_ViewImports.cshtml")]
    public class Views_Appointment_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Domain.Entities.Appointment>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Дмитрий\Documents\нет\ClinicService\ClinicService\Views\Appointment\Details.cshtml"
  
    ViewBag.Title = Model.Id;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>Идентификатор</dt>\r\n        <dd>");
#nullable restore
#line 9 "C:\Users\Дмитрий\Documents\нет\ClinicService\ClinicService\Views\Appointment\Details.cshtml"
       Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt>Доктор</dt>\r\n        <dd>");
#nullable restore
#line 12 "C:\Users\Дмитрий\Documents\нет\ClinicService\ClinicService\Views\Appointment\Details.cshtml"
       Write(Model.Doctor.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 12 "C:\Users\Дмитрий\Documents\нет\ClinicService\ClinicService\Views\Appointment\Details.cshtml"
                               Write(Model.Doctor.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt>Дата </dt>\r\n        <dd>");
#nullable restore
#line 15 "C:\Users\Дмитрий\Documents\нет\ClinicService\ClinicService\Views\Appointment\Details.cshtml"
       Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt>Статус </dt>\r\n        <dd>");
#nullable restore
#line 18 "C:\Users\Дмитрий\Documents\нет\ClinicService\ClinicService\Views\Appointment\Details.cshtml"
       Write(Model.Status.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    </dl>\r\n    <ul>\r\n        <dt>Услуги</dt>\r\n");
#nullable restore
#line 22 "C:\Users\Дмитрий\Documents\нет\ClinicService\ClinicService\Views\Appointment\Details.cshtml"
         foreach (Procedure p in Model.Procedures)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 24 "C:\Users\Дмитрий\Documents\нет\ClinicService\ClinicService\Views\Appointment\Details.cshtml"
           Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 25 "C:\Users\Дмитрий\Documents\нет\ClinicService\ClinicService\Views\Appointment\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Domain.Entities.Appointment> Html { get; private set; }
    }
}
#pragma warning restore 1591