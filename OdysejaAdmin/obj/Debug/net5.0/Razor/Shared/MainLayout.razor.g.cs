#pragma checksum "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e93d43dbcdad8ccad985d87f91dd99b58e5b8e40"
// <auto-generated/>
#pragma warning disable 1591
namespace OdysejaAdmin.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/_Imports.razor"
using OdysejaAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/_Imports.razor"
using OdysejaAdmin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/_Imports.razor"
using OdysejaAdmin.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/_Imports.razor"
using OdysejaAdmin.Pages.Login;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/_Imports.razor"
using OdysejaAdmin.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/_Imports.razor"
using OdysejaAdmin.Stores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/_Imports.razor"
using OdysejaAdmin.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : Microsoft.AspNetCore.Components.LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-bpo4djd9qh");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-bpo4djd9qh");
            __builder.OpenComponent<OdysejaAdmin.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-bpo4djd9qh");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "top-row px-4");
            __builder.AddAttribute(13, "b-bpo4djd9qh");
            __builder.OpenElement(14, "a");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Shared/MainLayout.razor"
                         logout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "b-bpo4djd9qh");
            __builder.AddContent(17, "Logout");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "content px-4");
            __builder.AddAttribute(21, "b-bpo4djd9qh");
#nullable restore
#line 15 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Shared/MainLayout.razor"
__builder.AddContent(22, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Shared/MainLayout.razor"
 
    private void logout()
    {
        AuthenticationService.Logout();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationService AuthenticationService { get; set; }
    }
}
#pragma warning restore 1591
