#pragma checksum "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27b878dcf65a6ea22e5e19bccdb96056ad554ab9"
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
#line 4 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
using BeeTest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
using BeeTest.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
using BeeTest.Pages.Components.Gates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
using BeeTest.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AuthenticatedLayout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/schedules")]
    public partial class Schedules : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::BeeTest.Pages.Components.Gates.AdminOnlyGate>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Web.PageTitle>(2);
            __builder.AddAttribute(3, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(4, "BeeTest | Manage Schedules");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(6);
            __builder.AddAttribute(7, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "manage-schedules");
                __builder2.AddAttribute(10, "b-wcg13238cb");
                __builder2.OpenComponent<global::BeeTest.Pages.Components.PageHeader>(11);
                __builder2.AddAttribute(12, "Text", (object)("Manage Schedules"));
                __builder2.CloseComponent();
#nullable restore
#line 23 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
             if(IsLoading)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::BeeTest.Pages.Components.LoadingView>(13);
                __builder2.CloseComponent();
#nullable restore
#line 26 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudButton>(14);
                __builder2.AddAttribute(15, "Variant", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 28 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(16, "StartIcon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 28 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
                                                            Icons.Material.Filled.Add

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(17, "Size", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Size>(
#nullable restore
#line 28 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
                                                                                             Size.Large

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(18, "OnClick", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
                                                                                                                  NavigateToAddSchedulePage

#line default
#line hidden
#nullable disable
                ))));
                __builder2.AddAttribute(19, "Style", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 28 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
                                                                                                                                                      $"background-color:{Colors.Blue.Default};color:{Colors.Grey.Lighten5};border-radius:2px;margin-bottom:25px;"

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(20, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(21, "Add Test Schedule");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n            <br b-wcg13238cb>\r\n\r\n            ");
                __builder2.OpenElement(23, "input");
                __builder2.AddAttribute(24, "type", "date");
                __builder2.AddAttribute(25, "id", "date");
                __builder2.AddAttribute(26, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
                                                    HandleSelectedDateChange

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "b-wcg13238cb");
                __builder2.CloseElement();
#nullable restore
#line 33 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
             if (schedules.Count() == 0)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(28, "<h5 b-wcg13238cb>There Are No Schedules at this Date</h5>");
#nullable restore
#line 36 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
            } else
            {

#line default
#line hidden
#nullable disable
                global::__Blazor.BeeTest.Pages.Admin.Schedules.Schedules.TypeInference.CreateMudTable_0(__builder2, 29, 30, 
#nullable restore
#line 38 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
                                  schedules

#line default
#line hidden
#nullable disable
                , 31, 
#nullable restore
#line 38 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
                                                    true

#line default
#line hidden
#nullable disable
                , 32, 
#nullable restore
#line 38 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
                                                                      Breakpoint.Sm

#line default
#line hidden
#nullable disable
                , 33, 
#nullable restore
#line 38 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
                                                                                               true

#line default
#line hidden
#nullable disable
                , 34, 
#nullable restore
#line 38 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
                                                                                                            true

#line default
#line hidden
#nullable disable
                , 35, 
#nullable restore
#line 38 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
                                                                                                                           $"background-color:{Colors.Grey.Lighten3}; border-radius: 7px;"

#line default
#line hidden
#nullable disable
                , 36, (__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudTh>(37);
                    __builder3.AddAttribute(38, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(39, "Test Name");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(40, "\r\n                        ");
                    __builder3.OpenComponent<global::MudBlazor.MudTh>(41);
                    __builder3.AddAttribute(42, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(43, "Start Time");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(44, "\r\n                        ");
                    __builder3.OpenComponent<global::MudBlazor.MudTh>(45);
                    __builder3.AddAttribute(46, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(47, "End Time");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(48, "\r\n                        ");
                    __builder3.OpenComponent<global::MudBlazor.MudTh>(49);
                    __builder3.AddAttribute(50, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(51, "Action");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                , 52, (schedule) => (__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudTd>(53);
                    __builder3.AddAttribute(54, "DataLabel", (object)("Test Name"));
                    __builder3.AddAttribute(55, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line (46,55)-(46,73) 26 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
__builder4.AddContent(56, schedule.Test.Name);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\r\n                        ");
                    __builder3.OpenComponent<global::MudBlazor.MudTd>(58);
                    __builder3.AddAttribute(59, "DataLabel", (object)("Start Time"));
                    __builder3.AddAttribute(60, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line (47,56)-(47,74) 26 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
__builder4.AddContent(61, schedule.StartTime);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(62, "\r\n                        ");
                    __builder3.OpenComponent<global::MudBlazor.MudTd>(63);
                    __builder3.AddAttribute(64, "DataLabel", (object)("End Time"));
                    __builder3.AddAttribute(65, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line (48,54)-(48,70) 26 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
__builder4.AddContent(66, schedule.EndTime);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(67, "\r\n                        ");
                    __builder3.OpenComponent<global::MudBlazor.MudTd>(68);
                    __builder3.AddAttribute(69, "DataLabel", (object)("Action"));
                    __builder3.AddAttribute(70, "Style", (object)("width:150px"));
                    __builder3.AddAttribute(71, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<global::MudBlazor.MudIconButton>(72);
                        __builder4.AddAttribute(73, "Variant", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 50 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
                                                    Variant.Filled

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(74, "Style", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 50 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
                                                                             $"background-color:{Colors.Blue.Default};color:{Colors.Grey.Lighten5};"

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(75, "Icon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 50 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
                                                                                                                                                              Icons.Material.Filled.Edit

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(76, "OnClick", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
                                                                                                                                                                                                     () => NavigateToEditSchedulePage(@schedule.Id)

#line default
#line hidden
#nullable disable
                        ))));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(77, "\r\n                            ");
                        __builder4.OpenComponent<global::MudBlazor.MudIconButton>(78);
                        __builder4.AddAttribute(79, "Variant", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 51 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
                                                    Variant.Filled

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(80, "Style", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 51 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
                                                                             $"background-color:{Colors.Red.Default};color:{Colors.Grey.Lighten5};"

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(81, "Icon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 51 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
                                                                                                                                                             Icons.Material.Filled.Delete

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(82, "OnClick", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
                                                                                                                                                                                                      () => DeleteSchedule(@schedule)

#line default
#line hidden
#nullable disable
                        ))));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                );
#nullable restore
#line 55 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
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
#line 60 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Admin\Schedules\Schedules.razor"
       
    private bool IsLoading = false;

    private List<Schedule> schedules = new List<Schedule>();
    private DateTime selectedDate = DateTime.Today;

    protected override async Task OnInitializedAsync()
    {
        await LoadData();

        await base.OnInitializedAsync();
    }

    private async Task LoadData()
    {
        IsLoading = true;
        schedules = await scheduleService.Get(selectedDate);
        IsLoading = false;
    }

    private void NavigateToAddSchedulePage()
    {
        navigationManager.NavigateTo("/schedules/add", true);
    }

    private void NavigateToEditSchedulePage(int id)
    {
        navigationManager.NavigateTo($"/schedules/{id}/edit", true);
    }

    private async Task HandleSelectedDateChange(ChangeEventArgs e)
    {
        if (e == null)
        {
            selectedDate = DateTime.Now;
        } else if (DateTime.TryParse(e.Value.ToString(), out DateTime newDate))
        {
            selectedDate = newDate;
        }

        await LoadData();
    }

    private async Task DeleteSchedule(Schedule schedule)
    {
        IsLoading = true;

        bool isSucessful = await scheduleService.Delete(schedule.Id);
        IsLoading = false;

        if (isSucessful) schedules.Remove(schedule);
        else await js.InvokeVoidAsync("alert", "Schedule Deletion Failed");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IScheduleService scheduleService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
namespace __Blazor.BeeTest.Pages.Admin.Schedules.Schedules
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::MudBlazor.Breakpoint __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.String __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg7)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", (object)__arg0);
        __builder.AddAttribute(__seq1, "Hover", (object)__arg1);
        __builder.AddAttribute(__seq2, "Breakpoint", (object)__arg2);
        __builder.AddAttribute(__seq3, "Bordered", (object)__arg3);
        __builder.AddAttribute(__seq4, "Dense", (object)__arg4);
        __builder.AddAttribute(__seq5, "Style", (object)__arg5);
        __builder.AddAttribute(__seq6, "HeaderContent", (object)__arg6);
        __builder.AddAttribute(__seq7, "RowTemplate", (object)__arg7);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
