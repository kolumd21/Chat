#pragma checksum "C:\Users\Пользователь\Downloads\WebApplication1\WebApplication1\WebApplication1\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "232be11fb1846b99b1ab95a6e4c73804510c08e2c1814257d31568461645c494"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Пользователь\Downloads\WebApplication1\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Пользователь\Downloads\WebApplication1\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"232be11fb1846b99b1ab95a6e4c73804510c08e2c1814257d31568461645c494", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1ab90e8470766233fccc8125bfca8455edb1ed725efd274e9e7669ed274bb2d6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChatModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("send_message"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Пользователь\Downloads\WebApplication1\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <main>
    <div class=""header"">
        <div class=""hamburger-menu"">
            <input id=""menu__toggle"" type=""checkbox"" />
            <label class=""menu__btn"" for=""menu__toggle"">
                <span></span>
            </label>
            <ul class=""menu__box"">
                <li>
                    <a class=""menu__item first"" href=""#"">
                        <svg width=""20px"" height=""20px"" viewBox=""0 0 16 16"" xmlns=""http://www.w3.org/2000/svg"" fill=""none"">
                            <g fill=""#db1414"">
                                <path d=""M1 8a6 6 0 018.514-5.45.75.75 0 01-.629 1.363 4.5 4.5 0 100 8.175.75.75 0 11.63 1.361A6 6 0 011 8z"" />
                                <path d=""M11.245 4.695a.75.75 0 00-.05 1.06l1.36 1.495H6.75a.75.75 0 000 1.5h5.805l-1.36 1.495a.75.75 0 001.11 1.01l2.5-2.75a.748.748 0 00-.002-1.012l-2.498-2.748a.75.75 0 00-1.06-.05z"" />
                            </g>
                        </svg>
                        Покинуть чат
                   ");
            WriteLiteral(" </a>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n    <div class=\"chat_wrapper\">\r\n        <section class=\"groups\">\r\n");
#nullable restore
#line 29 "C:\Users\Пользователь\Downloads\WebApplication1\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
             if(Model.groups != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Пользователь\Downloads\WebApplication1\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                 foreach(var grop in Model.groups)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"group\"");
            BeginWriteAttribute("id", " id=\"", 1386, "\"", 1415, 1);
#nullable restore
#line 33 "C:\Users\Пользователь\Downloads\WebApplication1\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
WriteAttributeValue("", 1391, "group"+grop.id_group, 1391, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""image_group"">
                            <img src=""/image/monkey.jpg"" />
                        </div>
                        <div class=""text_group"">
                            <h2>Название</h2>
                            <p>Сообщение</p>
                        </div>
                    </div>
");
#nullable restore
#line 42 "C:\Users\Пользователь\Downloads\WebApplication1\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Пользователь\Downloads\WebApplication1\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </section>\r\n        <section class=\"chat\">\r\n            <div class=\"messages\" id=\"messagesList\">\r\n");
#nullable restore
#line 47 "C:\Users\Пользователь\Downloads\WebApplication1\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                 if (Model.messages != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\Пользователь\Downloads\WebApplication1\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                     foreach (var message in Model.messages)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"wrapp\">\r\n                            <div class=\"wrapp_message\">\r\n                                <span class=\"name\">");
#nullable restore
#line 53 "C:\Users\Пользователь\Downloads\WebApplication1\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                                              Write(message.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <p class=\"message\">");
#nullable restore
#line 54 "C:\Users\Пользователь\Downloads\WebApplication1\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                                              Write(message.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            </div>
                            <svg width=""10"" height=""8"" viewBox=""0 0 50 43"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                                <path d=""M49.5 1H1V42.5C1 24.1 33.3333 7.16667 49.5 1Z"" fill=""#4260b3"" stroke=""#4260b3"" />
                            </svg>
                        </div>
");
#nullable restore
#line 60 "C:\Users\Пользователь\Downloads\WebApplication1\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\Пользователь\Downloads\WebApplication1\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "232be11fb1846b99b1ab95a6e4c73804510c08e2c1814257d31568461645c4949452", async() => {
                WriteLiteral("\r\n                <input type=\"text\" id=\"messageInput\" name=\"message\">\r\n                <button class=\"send\" id=\"sendButton\">Отправить</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </section>
    </div>
    

</main>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/microsoft-signalr/3.1.7/signalr.min.js""></script>
<script>
    function scroll() {
        let chat = document.getElementById('messagesList');
        chat.scrollTop = chat.scrollHeight;
    }
    document.addEventListener(""DOMContentLoaded"", scroll());
        var grops = document.querySelectorAll('group');
        var id;
        Array.from(grops).forEach(function (group) {
            group.classList.remove('active');
            group.addEventListener('click', function (e) {
                id = e.id;
                e.classList.Add('active');
            });
        });
    const btn = document.getElementById('messageInput');
    btn.addEventListener('click', function () {
        var message = document.getElementById('messageInput').value;
        connection.invoke(""SendMessage"", message, id).catch(function (err) {
            return console.error(err.toString());
        });
    ");
            WriteLiteral("});\r\n</script>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChatModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
