#pragma checksum "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "542446763ac487d777bc6d08b1fe3e2ba4284c9b"
// <auto-generated/>
#pragma warning disable 1591
namespace BeeTest.Pages.Components.QuestionAnswerCard
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
#line 1 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
using BeeTest.Factories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
using BeeTest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
using BeeTest.Models.Answer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
using BeeTest.Models.AnswerChecker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
using BeeTest.Models.QuestionDetail;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
using BeeTest.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    public partial class MultipleChoiceAnswerCard : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h6");
            __builder.AddAttribute(1, "b-5qopteoxdk");
#nullable restore
#line (12,6)-(12,37) 24 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
__builder.AddContent(2, temporaryAnswers.Question.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "line");
            __builder.AddAttribute(6, "b-5qopteoxdk");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "id", "a");
            __builder.AddAttribute(9, "type", "radio");
            __builder.AddAttribute(10, "disabled", 
#nullable restore
#line 14 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
                                          disabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "name", 
#nullable restore
#line 14 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
                                                            temporaryAnswers.Question.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "value", "a");
            __builder.AddAttribute(13, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
                                                                                                                UpdateKey

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "checked", 
#nullable restore
#line 14 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
                                                                                                                                     IsAChecked

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "b-5qopteoxdk");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "label");
            __builder.AddAttribute(18, "for", "a");
            __builder.AddAttribute(19, "b-5qopteoxdk");
#nullable restore
#line (15,21)-(15,48) 25 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
__builder.AddContent(20, QuestionDetail.Choices['a']);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "line");
            __builder.AddAttribute(24, "b-5qopteoxdk");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "id", "b");
            __builder.AddAttribute(27, "type", "radio");
            __builder.AddAttribute(28, "disabled", 
#nullable restore
#line 18 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
                                          disabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(29, "name", 
#nullable restore
#line 18 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
                                                            temporaryAnswers.Question.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(30, "value", "b");
            __builder.AddAttribute(31, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
                                                                                                                UpdateKey

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "checked", 
#nullable restore
#line 18 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
                                                                                                                                     IsBChecked

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(33, "b-5qopteoxdk");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.OpenElement(35, "label");
            __builder.AddAttribute(36, "for", "b");
            __builder.AddAttribute(37, "b-5qopteoxdk");
#nullable restore
#line (19,21)-(19,48) 25 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
__builder.AddContent(38, QuestionDetail.Choices['b']);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "line");
            __builder.AddAttribute(42, "b-5qopteoxdk");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "id", "c");
            __builder.AddAttribute(45, "type", "radio");
            __builder.AddAttribute(46, "disabled", 
#nullable restore
#line 22 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
                                          disabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(47, "name", 
#nullable restore
#line 22 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
                                                            temporaryAnswers.Question.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(48, "value", "c");
            __builder.AddAttribute(49, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
                                                                                                                UpdateKey

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "checked", 
#nullable restore
#line 22 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
                                                                                                                                     IsCChecked

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(51, "b-5qopteoxdk");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n    ");
            __builder.OpenElement(53, "label");
            __builder.AddAttribute(54, "for", "c");
            __builder.AddAttribute(55, "b-5qopteoxdk");
#nullable restore
#line (23,21)-(23,48) 25 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
__builder.AddContent(56, QuestionDetail.Choices['c']);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "line");
            __builder.AddAttribute(60, "b-5qopteoxdk");
            __builder.OpenElement(61, "input");
            __builder.AddAttribute(62, "id", "d");
            __builder.AddAttribute(63, "type", "radio");
            __builder.AddAttribute(64, "disabled", 
#nullable restore
#line 26 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
                                          disabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(65, "name", 
#nullable restore
#line 26 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
                                                            temporaryAnswers.Question.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(66, "value", "d");
            __builder.AddAttribute(67, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
                                                                                                                UpdateKey

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "checked", 
#nullable restore
#line 26 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
                                                                                                                                     IsDChecked

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(69, "b-5qopteoxdk");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n    ");
            __builder.OpenElement(71, "label");
            __builder.AddAttribute(72, "for", "d");
            __builder.AddAttribute(73, "b-5qopteoxdk");
#nullable restore
#line (27,21)-(27,48) 25 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
__builder.AddContent(74, QuestionDetail.Choices['d']);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "line");
            __builder.AddAttribute(78, "b-5qopteoxdk");
            __builder.OpenElement(79, "input");
            __builder.AddAttribute(80, "id", "e");
            __builder.AddAttribute(81, "type", "radio");
            __builder.AddAttribute(82, "disabled", 
#nullable restore
#line 30 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
                                          disabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(83, "name", 
#nullable restore
#line 30 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
                                                            temporaryAnswers.Question.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(84, "value", "e");
            __builder.AddAttribute(85, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
                                                                                                                UpdateKey

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(86, "checked", 
#nullable restore
#line 30 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
                                                                                                                                     IsEChecked

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(87, "b-5qopteoxdk");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n    ");
            __builder.OpenElement(89, "label");
            __builder.AddAttribute(90, "for", "e");
            __builder.AddAttribute(91, "b-5qopteoxdk");
#nullable restore
#line (31,21)-(31,48) 25 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
__builder.AddContent(92, QuestionDetail.Choices['e']);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
 if (@disabled)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(93, "<br b-5qopteoxdk>\r\n    ");
            __builder.OpenElement(94, "h6");
            __builder.AddAttribute(95, "b-5qopteoxdk");
            __builder.AddContent(96, "Status: ");
#nullable restore
#line (37,18)-(37,24) 25 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
__builder.AddContent(97, result);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\Kevin\Desktop\Current Job\BeeTest\BeeTest\BeeTest\Pages\Components\QuestionAnswerCard\MultipleChoiceAnswerCard.razor"
       
    [Parameter]
    public TemporaryAnswers temporaryAnswers { get; set; }

    [Parameter]
    public bool disabled { get; set; }

    private string result = "";

    private MultipleChoiceQuestionDetail QuestionDetail;
    private MultipleChoiceAnswer Answer;

    private bool IsAChecked => Answer.choice == 'a';
    private bool IsBChecked => Answer.choice == 'b';
    private bool IsCChecked => Answer.choice == 'c';
    private bool IsDChecked => Answer.choice == 'd';
    private bool IsEChecked => Answer.choice == 'e';

    protected override async Task OnInitializedAsync()
    {
        QuestionDetail = (MultipleChoiceQuestionDetail) QuestionDetailFactory.ParseJSON(temporaryAnswers.Question.QuestionType.Name, temporaryAnswers.Question.Details);

        Answer = (MultipleChoiceAnswer) AnswerFactory.ParseJSON(temporaryAnswers.Question.QuestionType.Name, temporaryAnswers.Answer);

        if (disabled)
        {
            CalculateQuestionResult();
        }

        await base.OnInitializedAsync();
    }

    private void CalculateQuestionResult()
    {
        MultipleChoiceChecker checker = new MultipleChoiceChecker();
        if (checker.IsCorrect(QuestionDetail, Answer)) result = "Correct";
        else result = "False";
    }

    private async Task UpdateKey(ChangeEventArgs e)
    {
        if (temporaryAnswers.Participant_Schedule.Schedule.EndTime < DateTime.Now)
        {
            await js.InvokeVoidAsync("alert", "Test Already Finished");
            return;
        }

        Answer.choice = e.Value.ToString()[0];

        temporaryAnswers.Answer = Answer.ToJSONString();

        bool isSuccessful = await temporaryAnswersService.Update(temporaryAnswers);
        if (!isSuccessful)
        {
            await js.InvokeVoidAsync("alert", "Couldn't Save Answer");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITemporaryAnswerService temporaryAnswersService { get; set; }
    }
}
#pragma warning restore 1591
