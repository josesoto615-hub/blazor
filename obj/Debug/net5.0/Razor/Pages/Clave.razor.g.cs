#pragma checksum "C:\dotnet\BlazorApp\Pages\Clave.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0cfd281136dff61853174f3ebdca6a08ce616bf"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\dotnet\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\dotnet\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\dotnet\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\dotnet\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\dotnet\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\dotnet\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\dotnet\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\dotnet\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\dotnet\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\dotnet\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/clave")]
    public partial class Clave : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\dotnet\BlazorApp\Pages\Clave.razor"
 if(ClaveOK==0 && TextoClave!="VIRUS")
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "divClave");
            __builder.AddMarkupContent(2, "<h1>Clave</h1>\r\n        ");
            __builder.AddMarkupContent(3, "<p>Caso enviar igual a: </p>\r\n        ");
            __builder.AddMarkupContent(4, "<p>La operaci??n no puede ser realizada. No se encuentra en un horario v??lido.</p>\r\n        ");
            __builder.AddMarkupContent(5, "<p>Si desea realizar la operaci??n, ingrese contrase??a.</p>\r\n\r\n        &nbsp;\r\n        &nbsp;\r\n        ");
            __builder.OpenElement(6, "p");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\dotnet\BlazorApp\Pages\Clave.razor"
                         TextoClave

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TextoClave = __value, TextoClave));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        &nbsp;\r\n        ");
            __builder.OpenElement(11, "p");
            __builder.AddContent(12, "TExtoClave: ");
            __builder.AddContent(13, 
#nullable restore
#line 16 "C:\dotnet\BlazorApp\Pages\Clave.razor"
                        TextoClave

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "btn btn-primary");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\dotnet\BlazorApp\Pages\Clave.razor"
                                                  AceptarClave

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Aceptar");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "btn btn-danger");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\dotnet\BlazorApp\Pages\Clave.razor"
                                                 CancelarClave

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "Cancelar");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 21 "C:\dotnet\BlazorApp\Pages\Clave.razor"

}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "id", "divArchivo");
            __builder.AddMarkupContent(26, "<h1>Archivo</h1>\r\n        ");
            __builder.AddMarkupContent(27, "<p>Enviando archivo a c??mara. </p>\r\n\r\n        &nbsp;\r\n        &nbsp;\r\n        &nbsp;\r\n        ");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "class", "btn btn-primary");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\dotnet\BlazorApp\Pages\Clave.razor"
                                                  AceptarArchivo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, "Aceptar");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "class", "btn btn-danger");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\dotnet\BlazorApp\Pages\Clave.razor"
                                                 CancelarArchivo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(36, "Cancelar");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "C:\dotnet\BlazorApp\Pages\Clave.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\dotnet\BlazorApp\Pages\Clave.razor"
 
    [Parameter]
    public string CasoEnvio { get; set; } = "";

    [Parameter]
    public int ClaveOK { get; set; } = 0;
    private string TextoClave { get; set; } = "";

    public int ArchivoOK { get; set; } = 0;
    private void AceptarClave()
    {
        TextoClave = TextoClave.ToUpper();
        ClaveOK = 1;
       
    }
    private void CancelarClave()
    {
        ClaveOK = 0;
        NavigationManager.NavigateTo("");
    }
    private void AceptarArchivo()
    {
       ArchivoOK = 1;
    }
    private void CancelarArchivo()
    {
        ArchivoOK = 0;
        NavigationManager.NavigateTo("");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
