#pragma checksum "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\AddSchedule.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9dc54056137553936e2e7cb5470c7cd929ffae5"
// <auto-generated/>
#pragma warning disable 1591
namespace BeeTest.Pages.Admin.Schedules
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\_Imports.razor"
using BeeTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\_Imports.razor"
using BeeTest.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\AddSchedule.razor"
using BeeTest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\AddSchedule.razor"
using BeeTest.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\AddSchedule.razor"
using BeeTest.Pages.Components.Gates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\AddSchedule.razor"
using BeeTest.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\AddSchedule.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AuthenticatedLayout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/schedules/add")]
    public partial class AddSchedule : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::BeeTest.Pages.Components.Gates.AdminOnlyGate>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Web.PageTitle>(2);
            __builder.AddAttribute(3, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(4, "BeeTest | Add Schedule");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(6);
            __builder.AddAttribute(7, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "add-schedules");
                __builder2.AddAttribute(10, "b-qyjsgvt226");
                __builder2.OpenComponent<global::BeeTest.Pages.Components.PageHeader>(11);
                __builder2.AddAttribute(12, "Text", (object)("Add Schedule"));
                __builder2.CloseComponent();
#nullable restore
#line 23 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\AddSchedule.razor"
             if (IsLoading)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::BeeTest.Pages.Components.LoadingView>(13);
                __builder2.CloseComponent();
#nullable restore
#line 26 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\AddSchedule.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(14, "form");
                __builder2.AddAttribute(15, "class", "schedule-form");
                __builder2.AddAttribute(16, "b-qyjsgvt226");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "line");
                __builder2.AddAttribute(19, "b-qyjsgvt226");
                __builder2.OpenElement(20, "input");
                __builder2.AddAttribute(21, "class", "form-control");
                __builder2.AddAttribute(22, "list", "datalistOptions");
                __builder2.AddAttribute(23, "placeholder", "Test Name");
                __builder2.AddAttribute(24, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\AddSchedule.razor"
                                                                                                          testName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => testName = __value, testName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(26, "b-qyjsgvt226");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n                        ");
                __builder2.OpenElement(28, "datalist");
                __builder2.AddAttribute(29, "id", "datalistOptions");
                __builder2.AddAttribute(30, "b-qyjsgvt226");
#nullable restore
#line 33 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\AddSchedule.razor"
                             foreach(Test test in tests)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(31, "option");
                __builder2.AddAttribute(32, "value", 
#nullable restore
#line 35 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\AddSchedule.razor"
                                                test.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(33, "b-qyjsgvt226");
                __builder2.CloseElement();
#nullable restore
#line 36 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\AddSchedule.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n                    ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "line");
                __builder2.AddAttribute(37, "b-qyjsgvt226");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "b-qyjsgvt226");
                __builder2.AddMarkupContent(40, "<label for=\"start-datetime\" b-qyjsgvt226>Start DateTime</label>\r\n                            ");
                __builder2.OpenElement(41, "input");
                __builder2.AddAttribute(42, "type", "datetime-local");
                __builder2.AddAttribute(43, "id", "start-datetime");
                __builder2.AddAttribute(44, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\AddSchedule.razor"
                                                                                    Schedule.StartTime

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-ddTHH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(45, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Schedule.StartTime = __value, Schedule.StartTime, format: "yyyy-MM-ddTHH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(46, "b-qyjsgvt226");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                        ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "b-qyjsgvt226");
                __builder2.AddMarkupContent(50, "<label for=\"end-datetime\" b-qyjsgvt226>End DateTime</label>\r\n                            ");
                __builder2.OpenElement(51, "input");
                __builder2.AddAttribute(52, "type", "datetime-local");
                __builder2.AddAttribute(53, "id", "end-datetime");
                __builder2.AddAttribute(54, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 46 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\AddSchedule.razor"
                                                                                  Schedule.EndTime

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-ddTHH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(55, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Schedule.EndTime = __value, Schedule.EndTime, format: "yyyy-MM-ddTHH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(56, "b-qyjsgvt226");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n\r\n                    ");
                __builder2.OpenComponent<global::MudBlazor.MudButton>(58);
                __builder2.AddAttribute(59, "Variant", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 50 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\AddSchedule.razor"
                                        Variant.Filled

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(60, "StartIcon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 50 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\AddSchedule.razor"
                                                                    Icons.Material.Filled.Save

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(61, "Size", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Size>(
#nullable restore
#line 50 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\AddSchedule.razor"
                                                                                                      Size.Large

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(62, "OnClick", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\AddSchedule.razor"
                                                                                                                           Save

#line default
#line hidden
#nullable disable
                ))));
                __builder2.AddAttribute(63, "Style", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 50 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\AddSchedule.razor"
                                                                                                                                          $"background-color:{Colors.Blue.Default}; color:{Colors.Grey.Lighten5};border-radius:2px;"

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(64, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(65, "Save Schedule");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
#nullable restore
#line 52 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\AddSchedule.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\AddSchedule.razor"
       
    private bool IsLoading = false;

    private Schedule Schedule = new Schedule();
    private List<Test> tests = new List<Test>();
    private string testName = "";

    protected override async Task OnInitializedAsync()
    {
        tests = await testService.GetAllTests();

        Schedule.StartTime = DateTime.Now;
        Schedule.EndTime = DateTime.Now;

        await base.OnInitializedAsync();
    }

    private async Task Save()
    {
        IsLoading = true;
        await Task.Delay(1);

        if (!(await AreFormValuesValid()))
        {
            IsLoading = false;
            await Task.Delay(1);

            return;
        }

        Schedule.Id = 0;
        Schedule.Test = await testService.Get(testName);

        if (await scheduleService.AddOrUpdate(Schedule))
        {
            await js.InvokeVoidAsync("alert", "Schedule Added Successfully");

            Schedule = new Schedule();
            Schedule.StartTime = DateTime.Now;
            Schedule.EndTime = DateTime.Now;
            testName = "";
        }
        else await js.InvokeVoidAsync("alert", "Couldn't Save Schedule");

        IsLoading = false;
        await Task.Delay(1);
    }

    private async Task<bool> AreFormValuesValid()
    {
        if (testName == null || testName == "")
        {
            await js.InvokeVoidAsync("alert", "Test Name Must be Filled");
            return false;
        }

        Test test = await testService.Get(testName);
        if (test == null)
        {
            await js.InvokeVoidAsync("alert", "Test Doesn't Exist");
            return false;
        }

        if (Schedule.StartTime < DateTime.Now)
        {
            await js.InvokeVoidAsync("alert", "Test Start Time must be in the Future");
            return false;
        }

        if (Schedule.EndTime < Schedule.StartTime)
        {
            await js.InvokeVoidAsync("alert", "Test EndTime must be after Start Time");
            return false;
        }

        return true;    
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IScheduleService scheduleService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITestService testService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
