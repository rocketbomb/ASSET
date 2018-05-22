using ASSET.Models.Master;
using Microsoft.EntityFrameworkCore;

namespace ASSET.Data
{
	public class ASSETContext : DbContext
	{
		public ASSETContext(DbContextOptions<ASSETContext> options) : base(options)
		{
		}


		public DbSet<AssetCategory> AssetCategory { get; set; }
		public DbSet<Asset> Asset { get; set; }
		public DbSet<AssetGroup> AssetGroup { get; set; }
		public DbSet<AssetType> AssetType { get; set; }


		public DbSet<AssetUnit> AssetUnit { get; set; }
		public DbSet<AssetWarranty> AssetWarranty { get; set; }
		public DbSet<AssetWarrantyCompany> AssetWarrantyCompany { get; set; }

		public DbSet<Employee> Employee { get; set; }
		public DbSet<EmployeeFaculty> EmployeeFaculty { get; set; }

		public DbSet<EmployeeMajor> EmployeeMajor { get; set; }
		public DbSet<Supplier> Supplier { get; set; }
		public DbSet<EmployeeUniversity> EmployeeUniversity { get; set; }



		//public DbSet<Company> Companies { get; set; }
		//public DbSet<CustomerWarrantyTransaction> CustomerWarrantTransactions { get; set; }
		//public DbSet<Device> Devices { get; set; }
		//public DbSet<Distributor> Distributors { get; set; }
		//public DbSet<DistributorUser> DistributorUsers { get; set; }
		//public DbSet<WarrantyTransaction> WarrantyTransactions { get; set; }

		//public DbSet<DeviceBrand> DeviceBrands { get; set; }
		//public DbSet<DeviceCategory> DeviceCategories { get; set; }
		//public DbSet<DeviceModel> DeviceModels { get; set; }
		//public DbSet<Service> Services { get; set; }
		//public DbSet<ServiceModule> ServiceModules { get; set; }
		//public DbSet<ServiceType> ServiceTypes { get; set; }
		//public DbSet<Status> Statuses { get; set; }
		//public DbSet<TicketAttatchmentType> TicketAttatchmentTypes { get; set; }
		//public DbSet<TicketTransactionType> TicketTransactionTypes { get; set; }
		//public DbSet<WarrantyType> WarrantyTypes { get; set; }

		//public DbSet<Permission> Permissions { get; set; }
		//public DbSet<Role> Roles { get; set; }
		//public DbSet<RolePermission> RolePermissions { get; set; }
		//public DbSet<User> Users { get; set; }
		//public DbSet<UserType> UserTypes { get; set; }

		//public DbSet<MaintainanceTicket> MaintainanceTickets { get; set; }
		//public DbSet<Ticket> Tickets { get; set; }
		//public DbSet<TicketAttatchment> TicketAttatchments { get; set; }
		//public DbSet<TicketStatusLog> TicketStatusLogs { get; set; }
		//public DbSet<TicketTransaction> TicketTransactions { get; set; }
		//public DbSet<TicketTransactionAttatchment> TicketTransactionAttatchments { get; set; }
	}
}
