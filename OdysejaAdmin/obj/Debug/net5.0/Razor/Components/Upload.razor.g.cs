#pragma checksum "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Components/Upload.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b3a63b9d844ee7b439e770e6567714cd9fa1eed"
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
#line 1 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Components/Upload.razor"
using ExcelDataReader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Components/Upload.razor"
using OfficeOpenXml;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Components/Upload.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    public partial class Upload : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "file has-name");
            __builder.AddAttribute(2, "style", "display: inline-block;");
            __builder.OpenElement(3, "label");
            __builder.AddAttribute(4, "class", "file-label");
            __builder.OpenComponent<BlazorInputFile.InputFile>(5);
            __builder.AddAttribute(6, "class", "file-input");
            __builder.AddAttribute(7, "OnChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 9 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Components/Upload.razor"
                                              ChooseFile

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\n        ");
            __builder.AddMarkupContent(9, "<span class=\"file-cta\"><span class=\"file-icon\"><i class=\"fas fa-upload\"></i></span>\n            <span class=\"file-label\">\n                Wybierz plik…\n            </span></span>\n        ");
            __builder.OpenElement(10, "span");
            __builder.AddAttribute(11, "class", "file-name");
#nullable restore
#line 19 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Components/Upload.razor"
__builder.AddContent(12, name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n\n");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "class", "button is-primary");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Components/Upload.razor"
                  SendHarmonogram

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "style", "display: inline-block;");
            __builder.AddMarkupContent(18, "\n    Wyślij harmonogram\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "/home/grzybek/projects/OdysejaAdmin/OdysejaAdmin/Components/Upload.razor"
 
    protected string name { get; set; } = "Nie wybrano pliku";
    IFileListEntry file;

    protected async Task ChooseFile(IFileListEntry[] files)
    {
        file = files.FirstOrDefault();
        name = file.Name;
    }

    protected async Task SendHarmonogram()
    {
        byte[] bin = await ReadFully(file.Data);

        using (MemoryStream ms = new MemoryStream(bin))
        using (ExcelPackage package = new ExcelPackage(ms))
        {
            ExcelWorksheet sheet = package.Workbook.Worksheets.FirstOrDefault();
            
            for (int i = sheet.Dimension.Start.Row; i <= sheet.Dimension.End.Row; i++)
            {
                for (int j = sheet.Dimension.Start.Column; j <= sheet.Dimension.End.Column; j++)
                {
                    try
                    {
                        string currentCellValue = sheet.Cells[i, j]?.Value?.ToString();
                        Console.WriteLine(currentCellValue);
                    }
                    catch(Exception e)
                    {
                        
                    }
                }
            }
        }
    }

    public static async Task<byte[]> ReadFully(Stream input)
    {
        byte[] buffer = new byte[16 * 1024];
        using (MemoryStream ms = new MemoryStream())
        {
            int read;
            while ((read = await input.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                ms.Write(buffer, 0, read);
            }
            return ms.ToArray();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
