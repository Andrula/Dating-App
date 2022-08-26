using Microsoft.AspNetCore.Components;

namespace Dating_App.Data
{

    public class Matches : ComponentBase
    {
        public IEnumerable<Profile> Profiles { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadProfiles);
        }

        #region loadprofiles
        private void LoadProfiles()
        {

            System.Threading.Thread.Sleep(3000);


        }
        #endregion
    }
}
