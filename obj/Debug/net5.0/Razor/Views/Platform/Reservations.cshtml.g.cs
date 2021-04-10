#pragma checksum "D:\Coding\Hotel_Reservation_Manager\Views\Platform\Reservations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e69db90a5a0248b937f2d176939fe86a26de322"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Platform_Reservations), @"mvc.1.0.view", @"/Views/Platform/Reservations.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Coding\Hotel_Reservation_Manager\Views\_ViewImports.cshtml"
using Hotel_Reservation_Manager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Coding\Hotel_Reservation_Manager\Views\_ViewImports.cshtml"
using Hotel_Reservation_Manager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e69db90a5a0248b937f2d176939fe86a26de322", @"/Views/Platform/Reservations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee50c8567e428755dfd0a7bab6735130bf0dcc00", @"/Views/_ViewImports.cshtml")]
    public class Views_Platform_Reservations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<Hotel_Reservation_Manager.Models.Data.Reservation>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e69db90a5a0248b937f2d176939fe86a26de3223155", async() => {
                WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">Reservations</h1>\r\n    </div>\r\n    <input type=\"button\" class=\"btn btn-outline-success\" value=\"Create\"");
                BeginWriteAttribute("onclick", " onclick=\"", 244, "\"", 311, 3);
                WriteAttributeValue("", 254, "location.href=\'", 254, 15, true);
#nullable restore
#line 7 "D:\Coding\Hotel_Reservation_Manager\Views\Platform\Reservations.cshtml"
WriteAttributeValue("", 269, Url.Action("CreateMenu", "Reservations"), 269, 41, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 310, "\'", 310, 1, true);
                EndWriteAttribute();
                WriteLiteral(@" />
    <table class=""table"">
        <thead class=""thead-dark"">
            <tr align=""center"">
                <th scope=""col"">#</th>
                <th scope=""col"">First</th>
                <th scope=""col"">Last</th>
                <th scope=""col"">Handle</th>
                <th scope=""col"">Options</th>
            </tr>
        </thead>
");
#nullable restore
#line 18 "D:\Coding\Hotel_Reservation_Manager\Views\Platform\Reservations.cshtml"
         if (Model != null){
            int rows = 1;
            foreach(var reservation in Model){

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tbody align=\"center\">\r\n                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 23 "D:\Coding\Hotel_Reservation_Manager\Views\Platform\Reservations.cshtml"
                                   Write(rows);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 24 "D:\Coding\Hotel_Reservation_Manager\Views\Platform\Reservations.cshtml"
                       Write(Hotel_Reservation_Manager.Controllers.SharedData.GetRoomNumber(reservation.RoomID));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 25 "D:\Coding\Hotel_Reservation_Manager\Views\Platform\Reservations.cshtml"
                       Write(Hotel_Reservation_Manager.Controllers.SharedData.GetUsernameAppointer(reservation.IDOfAppointer));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 26 "D:\Coding\Hotel_Reservation_Manager\Views\Platform\Reservations.cshtml"
                       Write(reservation.DateOfAccommodation);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 27 "D:\Coding\Hotel_Reservation_Manager\Views\Platform\Reservations.cshtml"
                       Write(Html.ActionLink("Edit", "EditMenu", new { controller = "Reservations", action = "EditMenu", reservation_id=reservation.Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" | ");
#nullable restore
#line 27 "D:\Coding\Hotel_Reservation_Manager\Views\Platform\Reservations.cshtml"
                                                                                                                                                       Write(Html.ActionLink("Details", "ShowDetails", new { controller = "Reservations", action = "ShowDetails", reservation_id=reservation.Id}));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    </tr>\r\n                </tbody>\r\n");
#nullable restore
#line 30 "D:\Coding\Hotel_Reservation_Manager\Views\Platform\Reservations.cshtml"

                rows++;

            }
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n    \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<Hotel_Reservation_Manager.Models.Data.Reservation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
