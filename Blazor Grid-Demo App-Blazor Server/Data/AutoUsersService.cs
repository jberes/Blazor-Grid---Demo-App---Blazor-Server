using System.Net.Http.Json;

namespace Blazor_Grid_Demo_App_Blazor_Server.AutoUsers
{
    public class AutoUsersService: IAutoUsersService
    {
        private readonly HttpClient _http;

        public AutoUsersService(HttpClient http)
        {
            this._http = http;
        }

        public async Task<List<PeopleWithCarsType>?> GetPeopleWithCars()
        {
            using HttpResponseMessage response = await this._http.GetAsync("https://excel2json.io/api/share/8bf0acfa-7fd8-468e-0478-08daa4a8d995").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<PeopleWithCarsType>>().ConfigureAwait(false);
            }

            return null;
        }
    }
}