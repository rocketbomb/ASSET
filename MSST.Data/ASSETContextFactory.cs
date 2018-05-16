using ASSET.Models.Master;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ASSET.Data
{
	public class DummyContextFactory : IDesignTimeDbContextFactory<ASSETContext>
	{
		public ASSETContext CreateDbContext(string[] args)
		{
			var builder = new DbContextOptionsBuilder<ASSETContext>();
			builder.UseSqlServer("Server = 122.155.10.240,1390; Database = ASSET; User Id = sa; Password = Password$1");
			return new ASSETContext(builder.Options);
		}
	}
}
