using System.Text.Json;

namespace Blazor_Grid_Demo_App_Blazor_Server.Northwind
{
    public class NorthwindService: INorthwindService
    {
        private readonly IWebHostEnvironment _env;

        public NorthwindService(IWebHostEnvironment env)
        {
            this._env = env;
        }

        public async Task<List<EmployeesType>?> GetEmployees()
        {
            var options = new JsonSerializerOptions(new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            var data = File.ReadAllText(this._env.WebRootPath + "/static-data/northwind-employees.json");
            return await Task.FromResult(JsonSerializer.Deserialize<List<EmployeesType>>(data, options));
        }
    }
}