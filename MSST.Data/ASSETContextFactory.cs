using ASSET.Models.Master;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ASSET.Data
{
	public class ASSETContextFactory : IDesignTimeDbContextFactory<ASSETContext>
	{
		public ASSETContext CreateDbContext(string[] args)
		{
			Directory.SetCurrentDirectory(@"..\MSST.WebSite\");

			IConfiguration configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();


			var builder = new DbContextOptionsBuilder<ASSETContext>();

			var connectionString = configuration.GetConnectionString("Development");


			builder.UseSqlServer(connectionString);

			return new ASSETContext(builder.Options);
		}
	}
}
