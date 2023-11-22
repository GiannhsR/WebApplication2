
using Microsoft.EntityFrameworkCore;
using WebApplication2.Persistence;

namespace WebApplication2;

public class Program
{
	public static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);

		builder.Services.AddControllers();

		builder.Services.AddDbContext<MyDbContext>(options => 
			options.UseSqlServer(builder.Configuration.GetConnectionString(nameof(MyDbContext))));

		var app = builder.Build();

		app.UseHttpsRedirection();

		app.UseAuthorization();

		app.MapControllers();

		app.Run();
	}
}
