#pragma checksum "C:\Users\Samet UCA\source\repos\BlazorMediatR\BlazorMediatR\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03711478723a04fea9044832d82d677fd597e131"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMediatR.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Samet UCA\source\repos\BlazorMediatR\BlazorMediatR\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Samet UCA\source\repos\BlazorMediatR\BlazorMediatR\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Samet UCA\source\repos\BlazorMediatR\BlazorMediatR\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Samet UCA\source\repos\BlazorMediatR\BlazorMediatR\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Samet UCA\source\repos\BlazorMediatR\BlazorMediatR\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Samet UCA\source\repos\BlazorMediatR\BlazorMediatR\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Samet UCA\source\repos\BlazorMediatR\BlazorMediatR\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Samet UCA\source\repos\BlazorMediatR\BlazorMediatR\_Imports.razor"
using BlazorMediatR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Samet UCA\source\repos\BlazorMediatR\BlazorMediatR\_Imports.razor"
using BlazorMediatR.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Samet UCA\source\repos\BlazorMediatR\BlazorMediatR\Pages\Index.razor"
using BlazorMediatR.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : SelfContained
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Blazor MediatR</h1> \r\n\r\n");
#nullable restore
#line 8 "C:\Users\Samet UCA\source\repos\BlazorMediatR\BlazorMediatR\Pages\Index.razor"
 if (Model!=null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\Samet UCA\source\repos\BlazorMediatR\BlazorMediatR\Pages\Index.razor"
                 Model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.AddMarkupContent(5, "<label for=\"role\">Roles :</label>\r\n    ");
                __Blazor.BlazorMediatR.Pages.Index.TypeInference.CreateInputSelect_0(__builder2, 6, 7, "role", 8, 
#nullable restore
#line 12 "C:\Users\Samet UCA\source\repos\BlazorMediatR\BlazorMediatR\Pages\Index.razor"
                                        Model.SelectedRole

#line default
#line hidden
#nullable disable
                , 9, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Model.SelectedRole = __value, Model.SelectedRole)), 10, () => Model.SelectedRole, 11, (__builder3) => {
                    __builder3.AddMarkupContent(12, "\r\n        ");
                    __builder3.AddMarkupContent(13, "<option value>select Role</option>\r\n");
#nullable restore
#line 14 "C:\Users\Samet UCA\source\repos\BlazorMediatR\BlazorMediatR\Pages\Index.razor"
         foreach (var role in Model.Roles)
            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(14, "            ");
                    __builder3.OpenElement(15, "options");
                    __builder3.AddAttribute(16, "value", 
#nullable restore
#line 16 "C:\Users\Samet UCA\source\repos\BlazorMediatR\BlazorMediatR\Pages\Index.razor"
                             role

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(17, 
#nullable restore
#line 16 "C:\Users\Samet UCA\source\repos\BlazorMediatR\BlazorMediatR\Pages\Index.razor"
                                    role

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(18, "\r\n");
#nullable restore
#line 17 "C:\Users\Samet UCA\source\repos\BlazorMediatR\BlazorMediatR\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(19, "\r\n    ");
                }
                );
                __builder2.AddMarkupContent(20, "\r\n    ");
                __builder2.AddMarkupContent(21, "<label for=\"role\">Names :</label>\r\n    ");
                __Blazor.BlazorMediatR.Pages.Index.TypeInference.CreateInputSelect_1(__builder2, 22, 23, "name", 24, 
#nullable restore
#line 21 "C:\Users\Samet UCA\source\repos\BlazorMediatR\BlazorMediatR\Pages\Index.razor"
                                        Model.SelectedName

#line default
#line hidden
#nullable disable
                , 25, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Model.SelectedName = __value, Model.SelectedName)), 26, () => Model.SelectedName, 27, (__builder3) => {
                    __builder3.AddMarkupContent(28, "\r\n        ");
                    __builder3.AddMarkupContent(29, "<option value>select Name</option>\r\n");
#nullable restore
#line 23 "C:\Users\Samet UCA\source\repos\BlazorMediatR\BlazorMediatR\Pages\Index.razor"
         foreach (var name in Model.Names)
            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(30, "            ");
                    __builder3.OpenElement(31, "options");
                    __builder3.AddAttribute(32, "value", 
#nullable restore
#line 25 "C:\Users\Samet UCA\source\repos\BlazorMediatR\BlazorMediatR\Pages\Index.razor"
                             name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(33, 
#nullable restore
#line 25 "C:\Users\Samet UCA\source\repos\BlazorMediatR\BlazorMediatR\Pages\Index.razor"
                                    name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(34, "\r\n");
#nullable restore
#line 26 "C:\Users\Samet UCA\source\repos\BlazorMediatR\BlazorMediatR\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(35, "\r\n    ");
                }
                );
                __builder2.AddMarkupContent(36, "\r\n    ");
                __builder2.OpenElement(37, "button");
                __builder2.AddAttribute(38, "class", "btn btn-danger");
                __builder2.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\Samet UCA\source\repos\BlazorMediatR\BlazorMediatR\Pages\Index.razor"
                                              VerifySelections

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(40, "Verify");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(42, "\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(43, "span");
            __builder.AddMarkupContent(44, "<strong>Result :</strong>");
            __builder.AddContent(45, 
#nullable restore
#line 33 "C:\Users\Samet UCA\source\repos\BlazorMediatR\BlazorMediatR\Pages\Index.razor"
                                Result

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 34 "C:\Users\Samet UCA\source\repos\BlazorMediatR\BlazorMediatR\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.BlazorMediatR.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
