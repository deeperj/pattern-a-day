#pragma checksum "/Users/johnalamina/Dropbox/rtmp/src/pattern-a-day/blazor/tictactoeweb/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b62e39f71cacb5db75e3c1b7fafe8ed873bfb80b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace blazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/johnalamina/Dropbox/rtmp/src/pattern-a-day/blazor/tictactoeweb/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/johnalamina/Dropbox/rtmp/src/pattern-a-day/blazor/tictactoeweb/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/johnalamina/Dropbox/rtmp/src/pattern-a-day/blazor/tictactoeweb/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/johnalamina/Dropbox/rtmp/src/pattern-a-day/blazor/tictactoeweb/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/johnalamina/Dropbox/rtmp/src/pattern-a-day/blazor/tictactoeweb/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/johnalamina/Dropbox/rtmp/src/pattern-a-day/blazor/tictactoeweb/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/johnalamina/Dropbox/rtmp/src/pattern-a-day/blazor/tictactoeweb/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/johnalamina/Dropbox/rtmp/src/pattern-a-day/blazor/tictactoeweb/_Imports.razor"
using blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/johnalamina/Dropbox/rtmp/src/pattern-a-day/blazor/tictactoeweb/_Imports.razor"
using blazor.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "/Users/johnalamina/Dropbox/rtmp/src/pattern-a-day/blazor/tictactoeweb/Shared/NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
