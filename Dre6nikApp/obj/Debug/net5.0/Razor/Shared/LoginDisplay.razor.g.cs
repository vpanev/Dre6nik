#pragma checksum "D:\VISUAL STUDIO PROJECTS\Dre6nikApp\Dre6nikApp\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5c29fdedafa052aad02239c0179f7ac36e46f89"
// <auto-generated/>
#pragma warning disable 1591
namespace Dre6nikApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\VISUAL STUDIO PROJECTS\Dre6nikApp\Dre6nikApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VISUAL STUDIO PROJECTS\Dre6nikApp\Dre6nikApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\VISUAL STUDIO PROJECTS\Dre6nikApp\Dre6nikApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\VISUAL STUDIO PROJECTS\Dre6nikApp\Dre6nikApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\VISUAL STUDIO PROJECTS\Dre6nikApp\Dre6nikApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\VISUAL STUDIO PROJECTS\Dre6nikApp\Dre6nikApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\VISUAL STUDIO PROJECTS\Dre6nikApp\Dre6nikApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\VISUAL STUDIO PROJECTS\Dre6nikApp\Dre6nikApp\_Imports.razor"
using Dre6nikApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\VISUAL STUDIO PROJECTS\Dre6nikApp\Dre6nikApp\_Imports.razor"
using Dre6nikApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\VISUAL STUDIO PROJECTS\Dre6nikApp\Dre6nikApp\_Imports.razor"
using CoreBusiness;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\VISUAL STUDIO PROJECTS\Dre6nikApp\Dre6nikApp\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\VISUAL STUDIO PROJECTS\Dre6nikApp\Dre6nikApp\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\VISUAL STUDIO PROJECTS\Dre6nikApp\Dre6nikApp\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\VISUAL STUDIO PROJECTS\Dre6nikApp\Dre6nikApp\Shared\LoginDisplay.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(2);
                __builder2.AddAttribute(3, "class", "py-2 d-none d-md-inline-block");
                __builder2.AddAttribute(4, "href", "transactions");
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(6, "a");
                    __builder3.AddAttribute(7, "class", "py-2 d-none d-md-inline-block");
                    __builder3.AddAttribute(8, "href", "Identity/Account/Manage");
                    __builder3.AddContent(9, "Hello, ");
                    __builder3.AddContent(10, 
#nullable restore
#line 5 "D:\VISUAL STUDIO PROJECTS\Dre6nikApp\Dre6nikApp\Shared\LoginDisplay.razor"
                                                                                            context.User.Identity.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(11, "!");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(12, "\r\n            ");
                    __builder3.AddMarkupContent(13, "<form class=\"py-2 d-none d-md-inline-block\" action=\"/Identity/Account/Logout?returnUrl=%2F\" method=\"post\"><button type=\"submit\" class=\"nav-link btn btn-link\">??????????</button></form>");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(14, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(15);
                __builder2.AddAttribute(16, "class", "py-2 d-none d-md-inline-block");
                __builder2.AddAttribute(17, "href", "Identity/Account/Login");
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(19, "<span class=\"oi oi-plus\" aria-hidden=\"true\"></span> ????????\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(21);
                __builder2.AddAttribute(22, "class", "py-2 d-none d-md-inline-block");
                __builder2.AddAttribute(23, "href", "Identity/Account/Register");
                __builder2.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(25, "<span class=\"oi oi-plus\" aria-hidden=\"true\"></span> ??????????????????????\r\n        ");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
