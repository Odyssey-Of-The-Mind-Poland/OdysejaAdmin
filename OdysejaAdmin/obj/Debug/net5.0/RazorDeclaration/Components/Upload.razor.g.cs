// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace OdysejaAdmin.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\projects\OdysejaAdmin\OdysejaAdmin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\projects\OdysejaAdmin\OdysejaAdmin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\projects\OdysejaAdmin\OdysejaAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\projects\OdysejaAdmin\OdysejaAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\projects\OdysejaAdmin\OdysejaAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\projects\OdysejaAdmin\OdysejaAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\projects\OdysejaAdmin\OdysejaAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\projects\OdysejaAdmin\OdysejaAdmin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\projects\OdysejaAdmin\OdysejaAdmin\_Imports.razor"
using OdysejaAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\projects\OdysejaAdmin\OdysejaAdmin\_Imports.razor"
using OdysejaAdmin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\projects\OdysejaAdmin\OdysejaAdmin\_Imports.razor"
using OdysejaAdmin.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\projects\OdysejaAdmin\OdysejaAdmin\_Imports.razor"
using OdysejaAdmin.Pages.Login;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\projects\OdysejaAdmin\OdysejaAdmin\_Imports.razor"
using OdysejaAdmin.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\projects\OdysejaAdmin\OdysejaAdmin\_Imports.razor"
using OdysejaAdmin.Stores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\projects\OdysejaAdmin\OdysejaAdmin\_Imports.razor"
using OdysejaAdmin.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\projects\OdysejaAdmin\OdysejaAdmin\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\projects\OdysejaAdmin\OdysejaAdmin\Components\Upload.razor"
using ExcelDataReader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\projects\OdysejaAdmin\OdysejaAdmin\Components\Upload.razor"
using OfficeOpenXml;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\projects\OdysejaAdmin\OdysejaAdmin\Components\Upload.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\projects\OdysejaAdmin\OdysejaAdmin\Components\Upload.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\projects\OdysejaAdmin\OdysejaAdmin\Components\Upload.razor"
using OdysejaAdmin.Data;

#line default
#line hidden
#nullable disable
    public partial class Upload : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "D:\projects\OdysejaAdmin\OdysejaAdmin\Components\Upload.razor"
 
    [Parameter]
    public EventCallback AfterLoad { get; set; }

    private int _selectedCity = 0;
    private List<IdNameModel> cities = new List<IdNameModel>();
    protected string name { get; set; } = "Nie wybrano pliku";
    IFileListEntry file;
    ExcelWorksheet sheet;

    protected override async void OnInitialized()
    {
        string cities = await RestService.Get("/city");
        this.cities = JsonSerializer.Deserialize<List<IdNameModel>>(cities);
        StateHasChanged();
    }

    protected async Task SendHarmonogram()
    {
        try
        {
            await BytesToExcel();
            List<Performance> performances = new List<Performance>();
            List<StageModel> stages = new List<StageModel>();
            List<Coordinate> corners = FindCorners();
            foreach (var corner in corners)
            {
                ReadStage(performances, corner, stages);
            }
            await RestService.Post("/timeTable", performances);
            await RestService.Put("/stage", stages);
            AfterLoad.InvokeAsync();
        }
        catch(Exception e)
        {
            Console.Write($"Messega: {e.Message} \n StackTrace {e.StackTrace}");
        }
    }

    private void ReadStage(List<Performance> perf, Coordinate corner, List<StageModel> stages)
    {
        int x = corner.X;
        int y = corner.Y;
        string[] stage = GetCellValue(x + 1, y).Split("-");
        int stageNumber = Int32.Parse(stage[0].Split(" ")[1]);
        stages.Add(new StageModel(0, stage[stage.Length - 1], _selectedCity, stageNumber));
        y += 2;
        int problem = 0;
        int age = 0;
        do
        {
            string val = GetCellValue(x, y);
            if (val == null)
            {
                val = GetCellValue(x + 1, y);
                string[] splited = val.Split(" ");
                problem = 0;
                try
                {
                    problem = Int32.Parse(splited[1].ToCharArray()[0].ToString());
                }
                catch (Exception e)
                {
                }
                age = Roman.RomanToInteger(splited[splited.Length - 1]);
            }
            else
            {
                string cityName = cities.Find(c => c.id == _selectedCity).name;
                Performance performance = new Performance(0,
                    cityName, GetCellValue(x + 1, y), problem, age, stageNumber,
                    GetCellValue(x, y).Substring(GetCellValue(x, y).Length >= 11 ? 11 : 0, 
                        GetCellValue(x, y).Length >= 5 ? 5 : GetCellValue(x, y).Length), 
                    GetCellValue(x + 2, y).Substring(GetCellValue(x+2, y).Length >= 11 ? 11 : 0, 
                        GetCellValue(x+2, y).Length >= 5 ? 5 : GetCellValue(x+2, y).Length));
                perf.Add(performance);
            }
            y++;
        } while (GetCellValue(x, y) != null || GetCellValue(x + 1, y) != null);
    }

    private string GetCellValue(int x, int y)
    {
        return sheet.Cells[y, x]?.Value?.ToString();
    }

    protected async Task ChooseFile(IFileListEntry[] files)
    {
        file = files.FirstOrDefault();
        name = file.Name;
    }

    public List<Coordinate> FindCorners()
    {
        List<Coordinate> corners = new List<Coordinate>();
        for (int y = sheet.Dimension.Start.Row; y <= sheet.Dimension.End.Row; y++)
        {
            for (int x = sheet.Dimension.Start.Column; x <= sheet.Dimension.End.Column; x++)
            {
                try
                {
                    string currentCellValue = sheet.Cells[y, x]?.Value?.ToString();
                    if (currentCellValue == "Godzina występu") corners.Add(new Coordinate(x, y));
                }
                catch (Exception e)
                {
                }
            }
        }
        return corners;
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

    public async Task BytesToExcel()
    {
        byte[] bin = await ReadFully(file.Data);
        MemoryStream ms = new MemoryStream(bin);
        ExcelPackage package = new ExcelPackage(ms);
        sheet = package.Workbook.Worksheets.FirstOrDefault();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RestService RestService { get; set; }
    }
}
#pragma warning restore 1591
