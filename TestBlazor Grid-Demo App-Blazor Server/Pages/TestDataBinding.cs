using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Blazor_Grid_Demo_App_Blazor_Server.Pages;
using Blazor_Grid_Demo_App_Blazor_Server.AutoUsers;

namespace TestBlazor_Grid_Demo_App_Blazor_Server
{
	public class TestDataBinding
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbGridModule));
			ctx.Services.AddScoped<IAutoUsersService>(sp => new MockAutoUsersService());
			var componentUnderTest = ctx.RenderComponent<DataBinding>();
			Assert.NotNull(componentUnderTest);
		}
	}
}