#pragma checksum "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Tests\Tests.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "896f927e78311dd4d948f9573e5b21c58f3d32fd"
// <auto-generated/>
#pragma warning disable 1591
namespace BeeTest.Pages.Tests
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
#line 4 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Tests\Tests.razor"
using BeeTest.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Tests\Tests.razor"
using BeeTest.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Tests\Tests.razor"
using BeeTest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Tests\Tests.razor"
using BeeTest.Services.Interfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AuthenticatedLayout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/tests")]
    public partial class Tests : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Web.PageTitle>(0);
            __builder.AddAttribute(1, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(2, "BeeTest | Manage Tests");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(4);
            __builder.AddAttribute(5, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::BeeTest.Pages.Components.PageHeader>(6);
                __builder2.AddAttribute(7, "Text", (object)("Manage Tests"));
                __builder2.CloseComponent();
#nullable restore
#line 18 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Tests\Tests.razor"
         if (IsLoading)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::BeeTest.Pages.Components.LoadingView>(8);
                __builder2.CloseComponent();
#nullable restore
#line 21 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Tests\Tests.razor"
        }
        else if (@tests.Count() == 0)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(9, "<h3>There Are No Tests</h3>\r\n            ");
                __builder2.OpenComponent<global::BeeTest.Pages.Components.Button>(10);
                __builder2.AddAttribute(11, "Text", (object)("Add Test"));
                __builder2.AddAttribute(12, "OnClick", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, 
#nullable restore
#line 25 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Tests\Tests.razor"
                                             NavigateToAddTestPage

#line default
#line hidden
#nullable disable
                ))));
                __builder2.CloseComponent();
#nullable restore
#line 26 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Tests\Tests.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::BeeTest.Pages.Components.Button>(13);
                __builder2.AddAttribute(14, "Text", (object)("Add Test"));
                __builder2.AddAttribute(15, "OnClick", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, 
#nullable restore
#line 29 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Tests\Tests.razor"
                                             NavigateToAddTestPage

#line default
#line hidden
#nullable disable
                ))));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.OpenElement(17, "table");
                __builder2.AddAttribute(18, "class", "table table-fluid");
                __builder2.AddMarkupContent(19, "<thead><tr><th scope=\"col\">Test Name</th>\r\n                        <th scope=\"col\">Test Passing Grade</th>\r\n                        <th scope=\"col\">Action</th></tr></thead>\r\n                ");
                __builder2.OpenElement(20, "tbody");
#nullable restore
#line 39 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Tests\Tests.razor"
                     foreach (var test in tests)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(21, "tr");
                __builder2.OpenElement(22, "td");
#nullable restore
#line (42,34)-(42,43) 26 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Tests\Tests.razor"
__builder2.AddContent(23, test.Name);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                            ");
                __builder2.OpenElement(25, "td");
#nullable restore
#line (43,34)-(43,51) 26 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Tests\Tests.razor"
__builder2.AddContent(26, test.PassingScore);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n                            ");
                __builder2.OpenElement(28, "td");
                __builder2.OpenComponent<global::BeeTest.Pages.Components.Button>(29);
                __builder2.AddAttribute(30, "Text", (object)("Manage"));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n                                ");
                __builder2.OpenComponent<global::BeeTest.Pages.Components.Button>(32);
                __builder2.AddAttribute(33, "Text", (object)("Delete"));
                __builder2.AddAttribute(34, "OnClick", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, 
#nullable restore
#line 46 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Tests\Tests.razor"
                                                                 () => DeleteTest(@test)

#line default
#line hidden
#nullable disable
                ))));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 49 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Tests\Tests.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 52 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Tests\Tests.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Tests\Tests.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> authenticationState { get; set; }

    private bool IsLoading = false;
    private List<Test> tests = new List<Test>();

    protected override async Task OnInitializedAsync()
    {
        var authState = await authenticationState;
        AuthStateProvider.AllowAdminOnly(authState, navigationManager);

        tests = await testService.GetAllTests();

        await base.OnInitializedAsync();
    }

    private void NavigateToAddTestPage()
    {
        navigationManager.NavigateTo("/tests/add", true);
    }

    private async Task DeleteTest(Test test)
    {
        IsLoading = true;

        bool isSucessful = await testService.Delete(test.Id);
        IsLoading = false;

        if (isSucessful) tests.Remove(test);
        else await js.InvokeVoidAsync("alert", "User Deletion Failed");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITestService testService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591