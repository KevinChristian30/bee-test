#pragma checksum "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Questions\AddQuestion.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51675077670d246a5520b0e95dce9c2215ec7a32"
// <auto-generated/>
#pragma warning disable 1591
namespace BeeTest.Pages.Questions
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
#line 4 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Questions\AddQuestion.razor"
using BeeTest.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Questions\AddQuestion.razor"
using BeeTest.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Questions\AddQuestion.razor"
using BeeTest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Questions\AddQuestion.razor"
using BeeTest.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Questions\AddQuestion.razor"
using BeeTest.Pages.Components.QuestionForms;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AuthenticatedLayout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/tests/{id}/questions/add")]
    public partial class AddQuestion : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Web.PageTitle>(0);
            __builder.AddAttribute(1, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(2, "BeeTest | Manage Test");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(4);
            __builder.AddAttribute(5, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 19 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Questions\AddQuestion.razor"
         if (IsLoading)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::BeeTest.Pages.Components.LoadingView>(6);
                __builder2.CloseComponent();
#nullable restore
#line 22 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Questions\AddQuestion.razor"
        } else if (test == null)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(7, "<h2 b-6xqzjbu8bs>The Test You\'re Looking for isn\'t Available</h2>");
#nullable restore
#line 25 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Questions\AddQuestion.razor"
        } else
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::BeeTest.Pages.Components.PageHeader>(8);
                __builder2.AddAttribute(9, "Text", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 27 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Questions\AddQuestion.razor"
                                "Add Question - " + @test.Name

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.OpenElement(10, "form");
                __builder2.AddAttribute(11, "class", "question-form");
                __builder2.AddAttribute(12, "b-6xqzjbu8bs");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "line");
                __builder2.AddAttribute(15, "b-6xqzjbu8bs");
                __builder2.AddMarkupContent(16, "<label for=\"question-type\" b-6xqzjbu8bs>Question Type</label>\r\n                    ");
                __builder2.OpenElement(17, "select");
                __builder2.AddAttribute(18, "id", "question-type");
                __builder2.AddAttribute(19, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Questions\AddQuestion.razor"
                                                       questionType

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => questionType = __value, questionType));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(21, "b-6xqzjbu8bs");
#nullable restore
#line 33 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Questions\AddQuestion.razor"
                         foreach (var questionType in @questionTypes)
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(22, "option");
                __builder2.AddAttribute(23, "value", 
#nullable restore
#line 35 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Questions\AddQuestion.razor"
                                            questionType.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(24, "b-6xqzjbu8bs");
#nullable restore
#line (35,65)-(35,82) 26 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Questions\AddQuestion.razor"
__builder2.AddContent(25, questionType.Name);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 36 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Questions\AddQuestion.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n            <br b-6xqzjbu8bs>");
                __builder2.OpenComponent<global::BeeTest.Pages.Components.QuestionForms.QuestionFormFactory>(27);
                __builder2.AddAttribute(28, "QuestionType", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 42 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Questions\AddQuestion.razor"
                                                questionType

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(29, "TestId", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 42 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Questions\AddQuestion.razor"
                                                                        int.Parse(@id)

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
#nullable restore
#line 43 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Questions\AddQuestion.razor"
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
#line 47 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Questions\AddQuestion.razor"
       
    [Parameter]
    public string id { get; set; }

    [CascadingParameter]
    private Task<AuthenticationState> authenticationState { get; set; }

    private bool IsLoading = false;
    private Test test = new Test();
    private List<QuestionType> questionTypes = new List<QuestionType>();
    private string questionType = "";

    protected override async Task OnInitializedAsync()
    {
        var authState = await authenticationState;
        AuthStateProvider.AllowAdminOnly(authState, navigationManager);

        test = await testService.Get(int.Parse(id));
        questionTypes = await questionTypeService.GetAllQuestionTypes();
        if (questionTypes != null && questionTypes.Count() > 0) 
            questionType = questionTypes[0].Name;

        await base.OnInitializedAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IQuestionTypeService questionTypeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITestService testService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
