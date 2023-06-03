#pragma checksum "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25783c47ee0e69db25c3a534e50385ad708f3935"
// <auto-generated/>
#pragma warning disable 1591
namespace BeeTest.Pages.Users
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
#line 4 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
using BeeTest.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
using BeeTest.Pages.Components.Gates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
using BeeTest.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
using BeeTest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
using Services.Interfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AuthenticatedLayout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/users")]
    public partial class Users : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::BeeTest.Pages.Components.Gates.AdminOnlyGate>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Web.PageTitle>(2);
            __builder.AddAttribute(3, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(4, "BeeTest | Manage Users");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(6);
            __builder.AddAttribute(7, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "manage-users");
                __builder2.OpenComponent<global::BeeTest.Pages.Components.PageHeader>(10);
                __builder2.AddAttribute(11, "Text", (object)("Manage Users"));
                __builder2.CloseComponent();
#nullable restore
#line 23 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
             if(IsLoading)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::BeeTest.Pages.Components.LoadingView>(12);
                __builder2.CloseComponent();
#nullable restore
#line 26 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
            } else if (@users.Count() == 0)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(13, "<h5>There Are No Users</h5>\r\n                ");
                __builder2.OpenComponent<global::MudBlazor.MudButton>(14);
                __builder2.AddAttribute(15, "Variant", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 29 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
                                    Variant.Filled

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(16, "StartIcon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 29 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
                                                                Icons.Material.Filled.Add

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(17, "Size", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Size>(
#nullable restore
#line 29 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
                                                                                                 Size.Large

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(18, "OnClick", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
                                                                                                                      NavigateToAddUserPage

#line default
#line hidden
#nullable disable
                ))));
                __builder2.AddAttribute(19, "Style", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 29 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
                                                                                                                                                      $"background-color:{Colors.Blue.Default}; color:{Colors.Grey.Lighten5}; border-radius: 2px;"

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(20, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(21, "Add User");
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 30 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
            } else
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudButton>(22);
                __builder2.AddAttribute(23, "Variant", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 32 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
                                    Variant.Filled

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(24, "StartIcon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 32 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
                                                                Icons.Material.Filled.Add

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(25, "Size", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Size>(
#nullable restore
#line 32 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
                                                                                                 Size.Large

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(26, "OnClick", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
                                                                                                                      NavigateToAddUserPage

#line default
#line hidden
#nullable disable
                ))));
                __builder2.AddAttribute(27, "Style", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 32 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
                                                                                                                                                      $"background-color:{Colors.Blue.Default}; color:{Colors.Grey.Lighten5}; border-radius: 2px;"

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(28, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(29, "Add User");
                }
                ));
                __builder2.CloseComponent();
                global::__Blazor.BeeTest.Pages.Users.Users.TypeInference.CreateMudTable_0(__builder2, 30, 31, 
#nullable restore
#line 34 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
                                  users

#line default
#line hidden
#nullable disable
                , 32, 
#nullable restore
#line 34 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
                                                true

#line default
#line hidden
#nullable disable
                , 33, 
#nullable restore
#line 34 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
                                                                  Breakpoint.Sm

#line default
#line hidden
#nullable disable
                , 34, 
#nullable restore
#line 34 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
                                                                                           true

#line default
#line hidden
#nullable disable
                , 35, 
#nullable restore
#line 34 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
                                                                                                        true

#line default
#line hidden
#nullable disable
                , 36, 
#nullable restore
#line 35 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
                               $"background-color:{Colors.Grey.Lighten3}; border-radius: 7px; margin-top: 10px"

#line default
#line hidden
#nullable disable
                , 37, (__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudTh>(38);
                    __builder3.AddAttribute(39, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(40, "Name");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\r\n                        ");
                    __builder3.OpenComponent<global::MudBlazor.MudTh>(42);
                    __builder3.AddAttribute(43, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(44, "Email");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(45, "\r\n                        ");
                    __builder3.OpenComponent<global::MudBlazor.MudTh>(46);
                    __builder3.AddAttribute(47, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(48, "Gender");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(49, "\r\n                        ");
                    __builder3.OpenComponent<global::MudBlazor.MudTh>(50);
                    __builder3.AddAttribute(51, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(52, "Date of Birth");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(53, "\r\n                        ");
                    __builder3.OpenComponent<global::MudBlazor.MudTh>(54);
                    __builder3.AddAttribute(55, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(56, "Action");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                , 57, (user) => (__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudTd>(58);
                    __builder3.AddAttribute(59, "DataLabel", (object)("Name"));
                    __builder3.AddAttribute(60, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line (44,50)-(44,59) 26 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
__builder4.AddContent(61, user.Name);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(62, "\r\n                        ");
                    __builder3.OpenComponent<global::MudBlazor.MudTd>(63);
                    __builder3.AddAttribute(64, "DataLabel", (object)("Email"));
                    __builder3.AddAttribute(65, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line (45,51)-(45,61) 26 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
__builder4.AddContent(66, user.Email);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(67, "\r\n                        ");
                    __builder3.OpenComponent<global::MudBlazor.MudTd>(68);
                    __builder3.AddAttribute(69, "DataLabel", (object)("Gender"));
                    __builder3.AddAttribute(70, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line (46,52)-(46,63) 26 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
__builder4.AddContent(71, user.Gender);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(72, "\r\n                        ");
                    __builder3.OpenComponent<global::MudBlazor.MudTd>(73);
                    __builder3.AddAttribute(74, "DataLabel", (object)("Date of Birth"));
                    __builder3.AddAttribute(75, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line (47,59)-(47,98) 26 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
__builder4.AddContent(76, user.DateOfBirth.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(77, "\r\n                        ");
                    __builder3.OpenComponent<global::MudBlazor.MudTd>(78);
                    __builder3.AddAttribute(79, "DataLabel", (object)("Action"));
                    __builder3.AddAttribute(80, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<global::MudBlazor.MudIconButton>(81);
                        __builder4.AddAttribute(82, "Variant", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 49 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
                                                    Variant.Filled

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(83, "Style", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 49 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
                                                                             $"background-color:{Colors.Red.Default}; color:{Colors.Grey.Lighten5};"

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(84, "Icon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 49 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
                                                                                                                                                              Icons.Material.Filled.Delete

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(85, "OnClick", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
                                                                                                                                                                                                       () => DeleteUser(@user)

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
#line 53 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
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
#line 58 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Users\Users.razor"
       
    private bool IsLoading = false;
    private List<User> users = new List<User>();

    private bool enabled = true;

    protected override async Task OnInitializedAsync()
    {
        IsLoading = true;
        users = await userService.GetAllParticipants();
        IsLoading = false;

        await base.OnInitializedAsync();
    }

    private void NavigateToAddUserPage()
    {
        navigationManager.NavigateTo("/users/add", true);
    }

    private async Task DeleteUser(User user)
    {
        IsLoading = true;

        TimeZoneInfo wibTimeZone = 
            TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
        user.DeletedAt = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, wibTimeZone);

        bool isSucessful = await userService.AddOrUpdate(user);
        IsLoading = false;

        if (isSucessful) users.Remove(user);
        else await js.InvokeVoidAsync("alert", "User Deletion Failed");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
namespace __Blazor.BeeTest.Pages.Users.Users
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
