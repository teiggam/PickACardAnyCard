#pragma checksum "C:\Users\Maggie\Documents\Grand Circus\Projects\DeckOfCards\DeckOfCards\Views\Home\Draw.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f61286e175006a3860158d10435e883014853ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Draw), @"mvc.1.0.view", @"/Views/Home/Draw.cshtml")]
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
#line 1 "C:\Users\Maggie\Documents\Grand Circus\Projects\DeckOfCards\DeckOfCards\Views\_ViewImports.cshtml"
using DeckOfCards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Maggie\Documents\Grand Circus\Projects\DeckOfCards\DeckOfCards\Views\_ViewImports.cshtml"
using DeckOfCards.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f61286e175006a3860158d10435e883014853ab", @"/Views/Home/Draw.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55cabaf756ea0be82cbdde0c677683c926f49d61", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Draw : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DeckOfCards.Models.Draw>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("DrawAgain"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div style=\"padding-left: 25%; padding-right: 25%\">\r\n        <h3>These are your cards!</h3>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 5 "C:\Users\Maggie\Documents\Grand Circus\Projects\DeckOfCards\DeckOfCards\Views\Home\Draw.cshtml"
             foreach (Card c in Model.cards)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"column\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 279, "\"", 293, 1);
#nullable restore
#line 8 "C:\Users\Maggie\Documents\Grand Circus\Projects\DeckOfCards\DeckOfCards\Views\Home\Draw.cshtml"
WriteAttributeValue("", 285, c.image, 285, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100px\" style=\"padding: 4px\" /><br />\r\n                    <center>\r\n                        ");
#nullable restore
#line 10 "C:\Users\Maggie\Documents\Grand Circus\Projects\DeckOfCards\DeckOfCards\Views\Home\Draw.cshtml"
                   Write(c.value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />of<br /> ");
#nullable restore
#line 10 "C:\Users\Maggie\Documents\Grand Circus\Projects\DeckOfCards\DeckOfCards\Views\Home\Draw.cshtml"
                                           Write(c.suit);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </center>\r\n                </div>\r\n");
#nullable restore
#line 13 "C:\Users\Maggie\Documents\Grand Circus\Projects\DeckOfCards\DeckOfCards\Views\Home\Draw.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            }\r\n        </div>\r\n        <br />\r\n        <p>Cards remaining: ");
#nullable restore
#line 19 "C:\Users\Maggie\Documents\Grand Circus\Projects\DeckOfCards\DeckOfCards\Views\Home\Draw.cshtml"
                       Write(Model.remaining);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <br />\r\n        <h4>Draw again?</h4>\r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f61286e175006a3860158d10435e883014853ab5802", async() => {
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 840, "\"", 862, 1);
#nullable restore
#line 24 "C:\Users\Maggie\Documents\Grand Circus\Projects\DeckOfCards\DeckOfCards\Views\Home\Draw.cshtml"
WriteAttributeValue("", 848, Model.deck_id, 848, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <input type=\"submit\" value=\"Same deck, new cards!\" />\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f61286e175006a3860158d10435e883014853ab7699", async() => {
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"Id\" value=\"new\" />\r\n                <input type=\"submit\" value=\"New deck, new cards!\" />\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DeckOfCards.Models.Draw> Html { get; private set; }
    }
}
#pragma warning restore 1591
