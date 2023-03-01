namespace Blazor_Grid_Demo_App_Blazor_Server.AutoUsers
{
    public interface IAutoUsersService
    {
        Task<List<PeopleWithCarsType>?> GetPeopleWithCars();
    }
}