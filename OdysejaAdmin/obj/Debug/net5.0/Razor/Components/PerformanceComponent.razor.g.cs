#pragma checksum "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Components/PerformanceComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5855d8b7f75fd7a2ce946bdaedbf8c8f5955e262"
// <auto-generated/>
#pragma warning disable 1591
namespace OdysejaAdmin.Components
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
#nullable restore
#line 1 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Components/PerformanceComponent.razor"
using OdysejaAdmin.Data;

#line default
#line hidden
#nullable disable
    public partial class PerformanceComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Components/PerformanceComponent.razor"
 if (editMode)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "tr");
            __builder.OpenElement(1, "td");
#nullable restore
#line 7 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Components/PerformanceComponent.razor"
__builder.AddContent(2, Performance.city);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\n        ");
            __builder.OpenElement(4, "td");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "class", "input is-rounded");
            __builder.AddAttribute(8, "size", "50");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Components/PerformanceComponent.razor"
                          Performance.team

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Performance.team = __value, Performance.team));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n        ");
            __builder.OpenElement(12, "td");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "type", "number");
            __builder.AddAttribute(15, "class", "input is-rounded");
            __builder.AddAttribute(16, "size", "10");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Components/PerformanceComponent.razor"
                          Performance.problem

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Performance.problem = __value, Performance.problem, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n        ");
            __builder.OpenElement(20, "td");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "type", "number");
            __builder.AddAttribute(23, "size", "10");
            __builder.AddAttribute(24, "class", "input is-rounded");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Components/PerformanceComponent.razor"
                          Performance.age

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Performance.age = __value, Performance.age, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n        ");
            __builder.OpenElement(28, "td");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "type", "number");
            __builder.AddAttribute(31, "size", "10");
            __builder.AddAttribute(32, "class", "input is-rounded");
            __builder.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Components/PerformanceComponent.razor"
                          Performance.stage

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Performance.stage = __value, Performance.stage, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n        ");
            __builder.OpenElement(36, "td");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "type", "text");
            __builder.AddAttribute(39, "class", "input is-rounded");
            __builder.AddAttribute(40, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Components/PerformanceComponent.razor"
                          Performance.performance

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Performance.performance = __value, Performance.performance));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n        ");
            __builder.OpenElement(43, "td");
            __builder.OpenElement(44, "input");
            __builder.AddAttribute(45, "type", "text");
            __builder.AddAttribute(46, "class", "input is-rounded");
            __builder.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Components/PerformanceComponent.razor"
                          Performance.spontan

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Performance.spontan = __value, Performance.spontan));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n        ");
            __builder.OpenElement(50, "td");
            __builder.OpenElement(51, "button");
            __builder.AddAttribute(52, "class", "button is-success");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Components/PerformanceComponent.razor"
                              Save

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(54, "\n                Zapisz\n            ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n        ");
            __builder.OpenElement(56, "td");
            __builder.OpenElement(57, "button");
            __builder.AddAttribute(58, "class", "button is-danger");
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Components/PerformanceComponent.razor"
                              Del

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(60, "\n                Del\n            ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 55 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Components/PerformanceComponent.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(61, "tr");
            __builder.OpenElement(62, "td");
#nullable restore
#line 59 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Components/PerformanceComponent.razor"
__builder.AddContent(63, Performance.city);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\n        ");
            __builder.OpenElement(65, "td");
#nullable restore
#line 60 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Components/PerformanceComponent.razor"
__builder.AddContent(66, Performance.team);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\n        ");
            __builder.OpenElement(68, "td");
#nullable restore
#line 61 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Components/PerformanceComponent.razor"
__builder.AddContent(69, Performance.problem);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\n        ");
            __builder.OpenElement(71, "td");
#nullable restore
#line 62 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Components/PerformanceComponent.razor"
__builder.AddContent(72, Performance.age);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\n        ");
            __builder.OpenElement(74, "td");
#nullable restore
#line 63 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Components/PerformanceComponent.razor"
__builder.AddContent(75, Performance.stage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\n        ");
            __builder.OpenElement(77, "td");
#nullable restore
#line 64 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Components/PerformanceComponent.razor"
__builder.AddContent(78, Performance.performance);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\n        ");
            __builder.OpenElement(80, "td");
#nullable restore
#line 65 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Components/PerformanceComponent.razor"
__builder.AddContent(81, Performance.spontan);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\n        ");
            __builder.OpenElement(83, "td");
            __builder.OpenElement(84, "button");
            __builder.AddAttribute(85, "class", "button is-success");
            __builder.AddAttribute(86, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Components/PerformanceComponent.razor"
                              Edit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(87, "\n                Edytuj\n            ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\n        ");
            __builder.OpenElement(89, "td");
            __builder.OpenElement(90, "button");
            __builder.AddAttribute(91, "class", "button is-danger");
            __builder.AddAttribute(92, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Components/PerformanceComponent.razor"
                              Del

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(93, "\n                Del\n            ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 79 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Components/PerformanceComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Components/PerformanceComponent.razor"
 
    private bool editMode;

    [Parameter]
    public Performance Performance { get; set; }
    
    [Parameter]
    public EventCallback OnDelete { get; set; }

    private void Edit() => editMode = true;

    private void Save()
    {
        editMode = false;
        RestService.Put("/timeTable", Performance);
    }

    private async void Del()
    {
        await RestService.Delete("/timeTable", Performance.id.ToString());
        OnDelete.InvokeAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RestService RestService { get; set; }
    }
}
#pragma warning restore 1591
