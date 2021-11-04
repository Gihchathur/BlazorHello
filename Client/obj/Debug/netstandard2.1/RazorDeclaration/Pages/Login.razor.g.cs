// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HelloBlazor.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gihan.c\source\repos\HelloBlazor\HelloBlazor\HelloBlazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gihan.c\source\repos\HelloBlazor\HelloBlazor\HelloBlazor\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gihan.c\source\repos\HelloBlazor\HelloBlazor\HelloBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gihan.c\source\repos\HelloBlazor\HelloBlazor\HelloBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gihan.c\source\repos\HelloBlazor\HelloBlazor\HelloBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gihan.c\source\repos\HelloBlazor\HelloBlazor\HelloBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gihan.c\source\repos\HelloBlazor\HelloBlazor\HelloBlazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gihan.c\source\repos\HelloBlazor\HelloBlazor\HelloBlazor\Client\_Imports.razor"
using HelloBlazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gihan.c\source\repos\HelloBlazor\HelloBlazor\HelloBlazor\Client\_Imports.razor"
using HelloBlazor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gihan.c\source\repos\HelloBlazor\HelloBlazor\HelloBlazor\Client\Pages\Login.razor"
using HelloBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gihan.c\source\repos\HelloBlazor\HelloBlazor\HelloBlazor\Client\Pages\Login.razor"
using HelloBlazor.ViewModels;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\gihan.c\source\repos\HelloBlazor\HelloBlazor\HelloBlazor\Client\Pages\Login.razor"
       

    private ProfileViewModel _profileViewModel = new ProfileViewModel();
    private List<UserDetails> Userdetail { get; set; } = new List<UserDetails>();
    public int count = 0, nav = 0;

    protected override async Task OnInitializedAsync()
    {

        Userdetail.Add(new UserDetails(0, "Ashan", "Saranga", "Ashan@gmail.com"));
        Userdetail.Add(new UserDetails(1, "Kasun", "Kalhara", "Kasun@gmail.com"));
        Userdetail.Add(new UserDetails(2, "kamal", "aththanayaka", "Kamal@gmail.com"));
        nav = 2;
    }

    public void UpdateProfile()
    {
        nav++;
        Userdetail.Add(new UserDetails(nav, _profileViewModel.FirstName, _profileViewModel.LastName, _profileViewModel.EmailAddress));
        _profileViewModel.Message = "profile updated successfully";

    }

    public void GetProfile()
    {
        _profileViewModel.FirstName = Userdetail[0].FirstName;
        _profileViewModel.LastName = Userdetail[0].LastName;
        _profileViewModel.EmailAddress = Userdetail[0].Email;
        _profileViewModel.Message = "profile loaded successfully";
        count = 1;
    }

    public void GetNextUser()
    {
        if (count <= nav)
        {
            _profileViewModel.FirstName = Userdetail[count].FirstName;
            _profileViewModel.LastName = Userdetail[count].LastName;
            _profileViewModel.EmailAddress = Userdetail[count].Email;
            _profileViewModel.Message = "Next User loaded successfully";
            count++;
        }
        else
        {
            _profileViewModel.Message = "No more users in the List..!";
        }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591