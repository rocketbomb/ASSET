using ASSET.Models.Master;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASSET.Data
{
	public class ASSETContext : DbContext
	{
		public ASSETContext(DbContextOptions<ASSETContext> options) : base(options)
		{
		}


		
		public DbSet<Asset> Asset { get; set; }
		public DbSet<AssetBrand> AssetBrand { get; set; }
		public DbSet<AssetCategory> AssetCategory { get; set; }
		public DbSet<AssetDepreciation> AssetDepreciation { get; set; }
		public DbSet<AssetGroup> AssetGroup { get; set; }
		public DbSet<AssetType> AssetType { get; set; }
		public DbSet<AssetUnit> AssetUnit { get; set; }
		public DbSet<AssetWarranty> AssetWarranty { get; set; }
		public DbSet<AssetWarrantyCompany> AssetWarrantyCompany { get; set; }

		public DbSet<Employee> Employee { get; set; }
		public DbSet<EmployeeFaculty> EmployeeFaculty { get; set; }
		public DbSet<EmployeeMajor> EmployeeMajor { get; set; }
		public DbSet<EmployeeUniversity> EmployeeUniversity { get; set; }
		public DbSet<Location> Location { get; set; }
		public DbSet<LocationGroup> LocationGroup { get; set; }

		public DbSet<Supplier> Supplier { get; set; }
		public DbSet<SupplierGroup> SupplierGroup { get; set; }

		public DbSet<Ownership> Ownership { get; set; }



		private readonly ASSETContext _context;

		public List<EmployeeUniversity> GetUniversity()
		{
			var data = _context.EmployeeUniversity.ToList<EmployeeUniversity>();

			return data;
		}




	}
}
