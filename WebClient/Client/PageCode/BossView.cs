using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using WebClient.Shared.AuxClasses;
using WebClient.Shared.Models;

namespace WebClient.Client.Pages.Bosses
{
    public partial class BossView
    {
        [Inject]
        private NavigationManager NavigationManager { get; set; }

        [Inject]
        private HttpClient Http { get; set; }
        private List<BossDetailsModel> Bosses { get; set; }

        private DateTimeFormatInfo TimeSpanFormat = new();

        protected override async Task OnInitializedAsync()
        {
            try
            {
                await Load();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
        }

        protected async Task Load()
        {
            try
            {
                
                var res = await Http.GetFromJsonAsync<IEnumerable<BossDetailsModel>>("api/Bosses/GetList/");
                Bosses = res.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        protected void GoToCreate()
        {
            NavigationManager.NavigateTo("boss/create");
        }
    }
}