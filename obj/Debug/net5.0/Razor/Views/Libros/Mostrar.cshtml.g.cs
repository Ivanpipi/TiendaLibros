#pragma checksum "C:\Users\Ivan\Desktop\Proyectos Personales\TiendaLibros\PARCIAL 1 - Ivan Pipitone\TiendaLibros\Views\Libros\Mostrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a00b69b3d0bc4a9a423a9444951e064127fd92a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Libros_Mostrar), @"mvc.1.0.view", @"/Views/Libros/Mostrar.cshtml")]
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
#line 1 "C:\Users\Ivan\Desktop\Proyectos Personales\TiendaLibros\PARCIAL 1 - Ivan Pipitone\TiendaLibros\Views\_ViewImports.cshtml"
using TiendaLibros;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ivan\Desktop\Proyectos Personales\TiendaLibros\PARCIAL 1 - Ivan Pipitone\TiendaLibros\Views\_ViewImports.cshtml"
using TiendaLibros.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a00b69b3d0bc4a9a423a9444951e064127fd92a", @"/Views/Libros/Mostrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d322e8227c13f8476a900a4b85e27d215e91965d", @"/Views/_ViewImports.cshtml")]
    public class Views_Libros_Mostrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Libro>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ivan\Desktop\Proyectos Personales\TiendaLibros\PARCIAL 1 - Ivan Pipitone\TiendaLibros\Views\Libros\Mostrar.cshtml"
Write(await Html.PartialAsync("_VistaParcial",Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<br>\r\n\r\n<h4>Informacion del Libro</h4>\r\n\r\n<br>\r\n\r\n<div class=\"card text-white bg-primary mb-3\" style=\"max-width: 18rem;\">\r\n    <div class=\"card-header\"> ");
#nullable restore
#line 12 "C:\Users\Ivan\Desktop\Proyectos Personales\TiendaLibros\PARCIAL 1 - Ivan Pipitone\TiendaLibros\Views\Libros\Mostrar.cshtml"
                         Write(Model.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">");
#nullable restore
#line 14 "C:\Users\Ivan\Desktop\Proyectos Personales\TiendaLibros\PARCIAL 1 - Ivan Pipitone\TiendaLibros\Views\Libros\Mostrar.cshtml"
                          Write(Model.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</h5>\r\n        <p class=\"card-text\">Autor: ");
#nullable restore
#line 15 "C:\Users\Ivan\Desktop\Proyectos Personales\TiendaLibros\PARCIAL 1 - Ivan Pipitone\TiendaLibros\Views\Libros\Mostrar.cshtml"
                               Write(Model.Autor);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\r\n            ");
#nullable restore
#line 16 "C:\Users\Ivan\Desktop\Proyectos Personales\TiendaLibros\PARCIAL 1 - Ivan Pipitone\TiendaLibros\Views\Libros\Mostrar.cshtml"
       Write(Model.Categoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Libro> Html { get; private set; }
    }
}
#pragma warning restore 1591
