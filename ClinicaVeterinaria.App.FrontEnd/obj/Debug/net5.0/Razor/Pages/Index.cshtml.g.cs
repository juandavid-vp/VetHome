#pragma checksum "C:\Users\ya-ke\OneDrive\Documentos\GitHub\Vethouse\ClinicaVeterinaria.App.FrontEnd\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e506cc88855ebf091e5b90121883daa4abc6dff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ClinicaVeterinaria.App.FrontEnd.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ClinicaVeterinaria.App.FrontEnd.Pages
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
#line 1 "C:\Users\ya-ke\OneDrive\Documentos\GitHub\Vethouse\ClinicaVeterinaria.App.FrontEnd\Pages\_ViewImports.cshtml"
using ClinicaVeterinaria.App.FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e506cc88855ebf091e5b90121883daa4abc6dff", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"906017001009d616ac6d168917139bbc2fd1c531", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\ya-ke\OneDrive\Documentos\GitHub\Vethouse\ClinicaVeterinaria.App.FrontEnd\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(" <!-- img src=\"Imágenes/ensayo fondo.png\" alt=\"Sample Photo\" /-->\r\n\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e506cc88855ebf091e5b90121883daa4abc6dff3493", async() => {
                WriteLiteral(@"
    <meta charset='utf-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1, shrink-to-fit=no'>
    <link href='https://unpkg.com/boxicons@2.0.9/css/boxicons.min.css' rel='stylesheet'>
    <title>Vet Home</title>
    <link rel=""icon"" type=""image/jpg"" href=""Imagenes/Logo VetHome_Mesa de trabajo 1.jpg"">
    <link rel=""stylesheet"" href=""VetHomeStyles.css"">
    <script src=""funcionalidades.js"" defer></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e506cc88855ebf091e5b90121883daa4abc6dff4908", async() => {
                WriteLiteral(@"

    <!--  Barra Horizontal  -->

    <header>
    <nav class=""menu"">
        <div class=""menutotal"">
            <a href=""#Home""><div><img src=""Imagenes/WebPage_Mesa de trabajo 1 copia 5.png"" class=""logoprofile""></div></a>
            <div class=""subpages"">
                <a href=""#Home"">
                    <div class=""subpaginas"">HOME</div>
                </a>
                <a");
                BeginWriteAttribute("href", " href=\"", 1029, "\"", 1036, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                <div class=""subpaginas"">ABOUT US</div>
                </a>
                <div class=""subpaginas"">SERVICES</div>
                <div class=""subpaginas"">CONTACT</div>
                <div class=""subpaginas"">SIGN UP</div>
                <div class=""hamburguer-menu"">
                    <i class=""bx bx-menu""></i>
                </div>
            </div>
        </div>
    </nav>
    </header>
    
    <!--  Pagina Inicio  -->

    <section id=""Home"" class=""seccion1"">
            <div>
                 <img src=""Imagenes/Letras-02.png"" class=""tipografia"">
                 <p>Tecnología de punta, experiencia,
                     técnicas vanguardistas y constante 
                     capacitación para prestar el
                     mejor servicio
                 </p>
                 <div class=""buttons"">
                 <button>Log In</button>
                 <button>Sign Up</button>
                </div>
                <div class=""circle"">
             ");
                WriteLiteral(@"       <i class='bx bxs-circle bx-rotate-90' style='color:#ff974b' ></i>
                    <i class='bx bxs-circle bx-rotate-90' style='color:#ff974b' ></i>
                    <i class='bx bxs-circle bx-rotate-90' style='color:#ff974b' ></i>
                    <i class='bx bxs-circle bx-rotate-90' style='color:#ff974b' ></i>
                    <i class='bx bxs-circle bx-rotate-90' style='color:#ff974b' ></i>
                </div>
            </div>
        <div class=""imagen"">
            <img src=""Imagenes/Imagen Principal_Mesa de trabajo 1 copia.png"" class=""imagen-inicio"">
        </div>
        
    </section>


");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n <!-- <div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div> -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
