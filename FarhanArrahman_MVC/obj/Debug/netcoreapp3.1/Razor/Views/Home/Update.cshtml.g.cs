#pragma checksum "/Users/farhan/VSProjects/FarhanArrahman_MVC/FarhanArrahman_MVC/Views/Home/Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2e0845a51e64651ac46a731331fb7ac43783bbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Update), @"mvc.1.0.view", @"/Views/Home/Update.cshtml")]
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
#line 1 "/Users/farhan/VSProjects/FarhanArrahman_MVC/FarhanArrahman_MVC/Views/_ViewImports.cshtml"
using FarhanArrahman_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/farhan/VSProjects/FarhanArrahman_MVC/FarhanArrahman_MVC/Views/_ViewImports.cshtml"
using FarhanArrahman_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2e0845a51e64651ac46a731331fb7ac43783bbe", @"/Views/Home/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3836b2fb6749a94daa6423333672ded17bdeac23", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Pegawai>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Pegawai", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Islam", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Protestan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Katolik", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Hindu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Buddha", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Konghucu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/farhan/VSProjects/FarhanArrahman_MVC/FarhanArrahman_MVC/Views/Home/Update.cshtml"
  
    ViewData["Title"] = "Ubah Pegawai";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Ubah Pegawai</h1>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2e0845a51e64651ac46a731331fb7ac43783bbe5840", async() => {
                WriteLiteral("<= Kembali");
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
            WriteLiteral("\n</p>\n<table class=\"table\">\n\n");
#nullable restore
#line 14 "/Users/farhan/VSProjects/FarhanArrahman_MVC/FarhanArrahman_MVC/Views/Home/Update.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <th>\n                ");
#nullable restore
#line 18 "/Users/farhan/VSProjects/FarhanArrahman_MVC/FarhanArrahman_MVC/Views/Home/Update.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <td>\n                <input type=\"text\" id=\"id\" name=\"id\"");
            BeginWriteAttribute("value", " value=", 385, "", 430, 1);
#nullable restore
#line 21 "/Users/farhan/VSProjects/FarhanArrahman_MVC/FarhanArrahman_MVC/Views/Home/Update.cshtml"
WriteAttributeValue("", 392, Html.DisplayFor(modelItem => item.Id), 392, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\n            </td>\n        </tr>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 26 "/Users/farhan/VSProjects/FarhanArrahman_MVC/FarhanArrahman_MVC/Views/Home/Update.cshtml"
           Write(Html.DisplayNameFor(model => model.Nama));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <td>\n                <input type=\"text\" id=\"nama\" name=\"nama\"");
            BeginWriteAttribute("value", " value=", 652, "", 699, 1);
#nullable restore
#line 29 "/Users/farhan/VSProjects/FarhanArrahman_MVC/FarhanArrahman_MVC/Views/Home/Update.cshtml"
WriteAttributeValue("", 659, Html.DisplayFor(modelItem => item.Nama), 659, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            </td>\n        </tr>\n        <tr>\n            <th>\n                Tempat Lahir\n            </th>\n            <td>\n                <input type=\"text\" id=\"tmptlahir\" name=\"tmptlahir\"");
            BeginWriteAttribute("value", " value=", 893, "", 945, 1);
#nullable restore
#line 37 "/Users/farhan/VSProjects/FarhanArrahman_MVC/FarhanArrahman_MVC/Views/Home/Update.cshtml"
WriteAttributeValue("", 900, Html.DisplayFor(modelItem => item.TmptLahir), 900, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            </td>\n        </tr>\n        <tr>\n            <th>\n                Tanggal Lahir\n            </th>\n            <td>\n                <input type=\"date\" id=\"tgllahir\" name=\"tgllahir\"");
            BeginWriteAttribute("value", " value=", 1138, "", 1189, 1);
#nullable restore
#line 45 "/Users/farhan/VSProjects/FarhanArrahman_MVC/FarhanArrahman_MVC/Views/Home/Update.cshtml"
WriteAttributeValue("", 1145, Html.DisplayFor(modelItem => item.TglLahir), 1145, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            </td>\n        </tr>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 50 "/Users/farhan/VSProjects/FarhanArrahman_MVC/FarhanArrahman_MVC/Views/Home/Update.cshtml"
           Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <td>\n                <label for=\"radiol\">Laki-Laki</label>\n                <input type=\"radio\" id=\"radiol\" name=\"radiol\"");
            BeginWriteAttribute("value", " value=", 1463, "", 1512, 1);
#nullable restore
#line 54 "/Users/farhan/VSProjects/FarhanArrahman_MVC/FarhanArrahman_MVC/Views/Home/Update.cshtml"
WriteAttributeValue("", 1470, Html.DisplayFor(modelItem => item.Gender), 1470, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            </td>\n            <td>\n                <label for=\"radiop\">Perempuan</label>\n                <input type=\"radio\" id=\"radiop\" name=\"radiop\"");
            BeginWriteAttribute("value", " value=", 1664, "", 1713, 1);
#nullable restore
#line 58 "/Users/farhan/VSProjects/FarhanArrahman_MVC/FarhanArrahman_MVC/Views/Home/Update.cshtml"
WriteAttributeValue("", 1671, Html.DisplayFor(modelItem => item.Gender), 1671, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            </td>\n        </tr>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 63 "/Users/farhan/VSProjects/FarhanArrahman_MVC/FarhanArrahman_MVC/Views/Home/Update.cshtml"
           Write(Html.DisplayNameFor(model => model.Agama));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <td>\n                <select name=\"agama\" id=\"agama\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2e0845a51e64651ac46a731331fb7ac43783bbe11945", async() => {
#nullable restore
#line 67 "/Users/farhan/VSProjects/FarhanArrahman_MVC/FarhanArrahman_MVC/Views/Home/Update.cshtml"
                                                                                Write(Html.DisplayFor(modelItem => item.Agama));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "/Users/farhan/VSProjects/FarhanArrahman_MVC/FarhanArrahman_MVC/Views/Home/Update.cshtml"
                      WriteLiteral(Html.DisplayFor(modelItem => item.Agama));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2e0845a51e64651ac46a731331fb7ac43783bbe14147", async() => {
                WriteLiteral("Islam");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2e0845a51e64651ac46a731331fb7ac43783bbe15308", async() => {
                WriteLiteral("Protestan");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2e0845a51e64651ac46a731331fb7ac43783bbe16473", async() => {
                WriteLiteral("Katolik");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2e0845a51e64651ac46a731331fb7ac43783bbe17636", async() => {
                WriteLiteral("Hindu");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2e0845a51e64651ac46a731331fb7ac43783bbe18797", async() => {
                WriteLiteral("Buddha");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2e0845a51e64651ac46a731331fb7ac43783bbe19959", async() => {
                WriteLiteral("Konghucu");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </select>\n            </td>\n        </tr>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 79 "/Users/farhan/VSProjects/FarhanArrahman_MVC/FarhanArrahman_MVC/Views/Home/Update.cshtml"
           Write(Html.DisplayNameFor(model => model.Alamat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <td>\n                <textarea id=\"alamat\" name=\"alamat\">");
#nullable restore
#line 82 "/Users/farhan/VSProjects/FarhanArrahman_MVC/FarhanArrahman_MVC/Views/Home/Update.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Alamat));

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\n            </td>\n        </tr>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 87 "/Users/farhan/VSProjects/FarhanArrahman_MVC/FarhanArrahman_MVC/Views/Home/Update.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <td>\n                <input type=\"text\" id=\"email\" name=\"email\"");
            BeginWriteAttribute("value", " value=", 2921, "", 2969, 1);
#nullable restore
#line 90 "/Users/farhan/VSProjects/FarhanArrahman_MVC/FarhanArrahman_MVC/Views/Home/Update.cshtml"
WriteAttributeValue("", 2928, Html.DisplayFor(modelItem => item.Email), 2928, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\n            </td>\n        </tr>\n        <tr>\n            <th>\n                Nomor Handphone\n            </th>\n            <td>\n                <input type=\"text\" id=\"nohp\" name=\"nohp\"");
            BeginWriteAttribute("value", " value=", 3165, "", 3212, 1);
#nullable restore
#line 98 "/Users/farhan/VSProjects/FarhanArrahman_MVC/FarhanArrahman_MVC/Views/Home/Update.cshtml"
WriteAttributeValue("", 3172, Html.DisplayFor(modelItem => item.NoHp), 3172, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\n            </td>\n        </tr>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 103 "/Users/farhan/VSProjects/FarhanArrahman_MVC/FarhanArrahman_MVC/Views/Home/Update.cshtml"
           Write(Html.DisplayNameFor(model => model.Foto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <td>\n                <input type=\"text\" id=\"foto\" name=\"foto\"");
            BeginWriteAttribute("value", " value=", 3434, "", 3481, 1);
#nullable restore
#line 106 "/Users/farhan/VSProjects/FarhanArrahman_MVC/FarhanArrahman_MVC/Views/Home/Update.cshtml"
WriteAttributeValue("", 3441, Html.DisplayFor(modelItem => item.Foto), 3441, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            </td>\n        </tr>\n        <tr>\n            <th>\n                Posisi\n            </th>\n            <td>\n                <input type=\"text\" id=\"posisinaman\" name=\"posisinama\"");
            BeginWriteAttribute("value", " value=", 3672, "", 3725, 1);
#nullable restore
#line 114 "/Users/farhan/VSProjects/FarhanArrahman_MVC/FarhanArrahman_MVC/Views/Home/Update.cshtml"
WriteAttributeValue("", 3679, Html.DisplayFor(modelItem => item.PosisiNama), 3679, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\n            </td>\n        </tr>\n        <tr>\n            <th>\n                Kantor\n            </th>\n            <td>\n                <input type=\"text\" id=\"kantoralamat\" name=\"kantoralamat\"");
            BeginWriteAttribute("value", " value=", 3928, "", 3983, 1);
#nullable restore
#line 122 "/Users/farhan/VSProjects/FarhanArrahman_MVC/FarhanArrahman_MVC/Views/Home/Update.cshtml"
WriteAttributeValue("", 3935, Html.DisplayFor(modelItem => item.KantorAlamat), 3935, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\n            </td>\n        </tr>\n");
#nullable restore
#line 125 "/Users/farhan/VSProjects/FarhanArrahman_MVC/FarhanArrahman_MVC/Views/Home/Update.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2e0845a51e64651ac46a731331fb7ac43783bbe25605", async() => {
                WriteLiteral("Simpan");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</p>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Pegawai>> Html { get; private set; }
    }
}
#pragma warning restore 1591
