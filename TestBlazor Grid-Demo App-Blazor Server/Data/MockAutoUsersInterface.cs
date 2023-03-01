namespace Blazor_Grid_Demo_App_Blazor_Server.AutoUsers
{
    public class MockAutoUsersService : IAutoUsersService
    {
        public Task<List<PeopleWithCarsType>?> GetPeopleWithCars()
        {
            return Task.FromResult<List<PeopleWithCarsType>?>(new());
        }
    }
}