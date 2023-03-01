using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Blazor_Grid_Demo_App_Blazor_Server.Pages;
using Blazor_Grid_Demo_App_Blazor_Server.Northwind;

namespace TestBlazor_Grid_Demo_App_Blazor_Server
{
	public class TestColumnInteractions
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbGridModule));
			ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
			var componentUnderTest = ctx.RenderComponent<ColumnInteractions>();
			Assert.NotNull(componentUnderTest);
		}
	}
}