using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Blazor_Grid_Demo_App_Blazor_Server.Shared;

namespace TestBlazor_Grid_Demo_App_Blazor_Server
{
	public class TestMainLayout
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbNavbarModule),
				typeof(IgbIconButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbNavDrawerModule));
			var componentUnderTest = ctx.RenderComponent<MainLayout>();
			Assert.NotNull(componentUnderTest);
		}
	}
}