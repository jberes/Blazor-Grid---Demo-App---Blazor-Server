namespace Blazor_Grid_Demo_App_Blazor_Server.Northwind
{
    public class MockNorthwindService : INorthwindService
    {
        public Task<List<EmployeesType>?> GetEmployees()
        {
            return Task.FromResult<List<EmployeesType>?>(new());
        }
    }
}