#pragma checksum "C:\Users\kachi\OneDrive\Documents\RecipeWebSiteVersion4.0 - TESTCopy\RecipeWebSiteVersion4.0 - TESTCopy\RecipeWebSite\RecipeWebSite\Views\Crud\AddRecipe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ff482dedca32b1ba2a553a365e88e035ebc6683"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Crud_AddRecipe), @"mvc.1.0.view", @"/Views/Crud/AddRecipe.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Crud/AddRecipe.cshtml", typeof(AspNetCore.Views_Crud_AddRecipe))]
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
#line 2 "C:\Users\kachi\OneDrive\Documents\RecipeWebSiteVersion4.0 - TESTCopy\RecipeWebSiteVersion4.0 - TESTCopy\RecipeWebSite\RecipeWebSite\Views\_ViewImports.cshtml"
using RecipeWebSite.Models;

#line default
#line hidden
#line 3 "C:\Users\kachi\OneDrive\Documents\RecipeWebSiteVersion4.0 - TESTCopy\RecipeWebSiteVersion4.0 - TESTCopy\RecipeWebSite\RecipeWebSite\Views\_ViewImports.cshtml"
using RecipeWebSite.Models.ViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ff482dedca32b1ba2a553a365e88e035ebc6683", @"/Views/Crud/AddRecipe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4aef6c19a069f35b5a8e066994b0611e959b1a3d", @"/Views/_ViewImports.cshtml")]
    public class Views_Crud_AddRecipe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Recipe>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\kachi\OneDrive\Documents\RecipeWebSiteVersion4.0 - TESTCopy\RecipeWebSiteVersion4.0 - TESTCopy\RecipeWebSite\RecipeWebSite\Views\Crud\AddRecipe.cshtml"
   
    ViewBag.Title = "Add Recipe";

#line default
#line hidden
            BeginContext(62, 130, true);
            WriteLiteral("\r\n\r\n        <div class=\"card p-3 mt-3\">\r\n            <h1 class=\"text-center card-header\">Add your own recipe!</h1>\r\n\r\n            ");
            EndContext();
            BeginContext(193, 37, false);
#line 11 "C:\Users\kachi\OneDrive\Documents\RecipeWebSiteVersion4.0 - TESTCopy\RecipeWebSiteVersion4.0 - TESTCopy\RecipeWebSite\RecipeWebSite\Views\Crud\AddRecipe.cshtml"
       Write(await Html.PartialAsync("RecipeForm"));

#line default
#line hidden
            EndContext();
            BeginContext(230, 37, true);
            WriteLiteral("\r\n            \r\n        </div>\r\n   \r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Recipe> Html { get; private set; }
    }
}
#pragma warning restore 1591