#pragma checksum "C:\Users\Mekafukame\source\repos\Zamowienia_w_restauracji\Zamowienia_w_restauracji\Pages\Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "121d2e86f744e5438e3b521cc32ce5e9e2919c16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Zamowienia_w_restauracji.Pages.Pages_Menu), @"mvc.1.0.razor-page", @"/Pages/Menu.cshtml")]
namespace Zamowienia_w_restauracji.Pages
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
#line 1 "C:\Users\Mekafukame\source\repos\Zamowienia_w_restauracji\Zamowienia_w_restauracji\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mekafukame\source\repos\Zamowienia_w_restauracji\Zamowienia_w_restauracji\Pages\_ViewImports.cshtml"
using Zamowienia_w_restauracji;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mekafukame\source\repos\Zamowienia_w_restauracji\Zamowienia_w_restauracji\Pages\_ViewImports.cshtml"
using Zamowienia_w_restauracji.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"121d2e86f744e5438e3b521cc32ce5e9e2919c16", @"/Pages/Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c12752b869d1ca8e171c3eb6fb2d33ad5a03d494", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Menu : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Danie"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("center-height"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "buynow", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Mekafukame\source\repos\Zamowienia_w_restauracji\Zamowienia_w_restauracji\Pages\Menu.cshtml"
  
    ViewData["Title"] = "Menu";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"content\">\r\n    <h1 class=\"page-header\">Menu</h1>\r\n\r\n");
            WriteLiteral("        <div class=\"filters\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "121d2e86f744e5438e3b521cc32ce5e9e2919c165596", async() => {
                WriteLiteral("\r\n                <p>\r\n                    <input type=\"submit\" value=\"Wszystkie\" />\r\n                </p>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 18 "C:\Users\Mekafukame\source\repos\Zamowienia_w_restauracji\Zamowienia_w_restauracji\Pages\Menu.cshtml"
             foreach (var category in Model.Kategorie)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "121d2e86f744e5438e3b521cc32ce5e9e2919c167255", async() => {
                WriteLiteral("\r\n                    <p>\r\n                        <input type=\"submit\" name=\"SearchString\"");
                BeginWriteAttribute("value", " value=\"", 579, "\"", 622, 1);
#nullable restore
#line 22 "C:\Users\Mekafukame\source\repos\Zamowienia_w_restauracji\Zamowienia_w_restauracji\Pages\Menu.cshtml"
WriteAttributeValue("", 587, Html.DisplayFor(Model => category), 587, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </p>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 25 "C:\Users\Mekafukame\source\repos\Zamowienia_w_restauracji\Zamowienia_w_restauracji\Pages\Menu.cshtml"
            }            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 27 "C:\Users\Mekafukame\source\repos\Zamowienia_w_restauracji\Zamowienia_w_restauracji\Pages\Menu.cshtml"
        foreach (var category in Model.Kategorie)
        {
            if (string.IsNullOrEmpty(Model.Kategoria))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"Category\">\r\n                    <h2>");
#nullable restore
#line 32 "C:\Users\Mekafukame\source\repos\Zamowienia_w_restauracji\Zamowienia_w_restauracji\Pages\Menu.cshtml"
                   Write(Html.DisplayFor(Model => category));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <hr />\r\n                </div>\r\n");
#nullable restore
#line 35 "C:\Users\Mekafukame\source\repos\Zamowienia_w_restauracji\Zamowienia_w_restauracji\Pages\Menu.cshtml"
            }
            else if (Model.Kategoria == category)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"Category\">\r\n                    <h2>");
#nullable restore
#line 39 "C:\Users\Mekafukame\source\repos\Zamowienia_w_restauracji\Zamowienia_w_restauracji\Pages\Menu.cshtml"
                   Write(Html.DisplayFor(Model => category));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <hr />\r\n                </div>\r\n");
#nullable restore
#line 42 "C:\Users\Mekafukame\source\repos\Zamowienia_w_restauracji\Zamowienia_w_restauracji\Pages\Menu.cshtml"
            }
            foreach (var item in Model.Danie)
            {
                if (item.Rodzaj == category)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row menu\">\r\n                        <div>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "121d2e86f744e5438e3b521cc32ce5e9e2919c1611229", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1507, "~/Grafiki/Menu/", 1507, 15, true);
#nullable restore
#line 49 "C:\Users\Mekafukame\source\repos\Zamowienia_w_restauracji\Zamowienia_w_restauracji\Pages\Menu.cshtml"
AddHtmlAttributeValue("", 1522, Html.DisplayFor(modelItem => item.Zdjecie), 1522, 43, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-8\">\r\n                            <div class=\"row col-12\">\r\n                                <div class=\"menu-name\">\r\n                                    ");
#nullable restore
#line 54 "C:\Users\Mekafukame\source\repos\Zamowienia_w_restauracji\Zamowienia_w_restauracji\Pages\Menu.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Nazwa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"row col-12\">\r\n                                ");
#nullable restore
#line 58 "C:\Users\Mekafukame\source\repos\Zamowienia_w_restauracji\Zamowienia_w_restauracji\Pages\Menu.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Sklad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"col-1\">\r\n                            <p class=\"center-height\">");
#nullable restore
#line 63 "C:\Users\Mekafukame\source\repos\Zamowienia_w_restauracji\Zamowienia_w_restauracji\Pages\Menu.cshtml"
                                                Write(Html.DisplayFor(modelItem => item.Cena));

#line default
#line hidden
#nullable disable
            WriteLiteral("zł</p>\r\n                        </div>\r\n                        <div class=\"col-1 \">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "121d2e86f744e5438e3b521cc32ce5e9e2919c1614464", async() => {
                WriteLiteral("<span class=\"material-icons-outlined menu-add-icon center-height md-48\">shopping_bag</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "C:\Users\Mekafukame\source\repos\Zamowienia_w_restauracji\Zamowienia_w_restauracji\Pages\Menu.cshtml"
                                                                                                 WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <br />\r\n");
#nullable restore
#line 70 "C:\Users\Mekafukame\source\repos\Zamowienia_w_restauracji\Zamowienia_w_restauracji\Pages\Menu.cshtml"
                }
            }
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Zamowienia_w_restauracji.Pages.MenuModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Zamowienia_w_restauracji.Pages.MenuModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Zamowienia_w_restauracji.Pages.MenuModel>)PageContext?.ViewData;
        public Zamowienia_w_restauracji.Pages.MenuModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
