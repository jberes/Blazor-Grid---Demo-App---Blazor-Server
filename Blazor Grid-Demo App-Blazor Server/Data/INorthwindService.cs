namespace Blazor_Grid_Demo_App_Blazor_Server.Northwind
{
    public interface INorthwindService
    {
        Task<List<EmployeesType>?> GetEmployees();
    }
}