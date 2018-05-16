using System;



namespace ASSET.Models.Master
{
    public class AssetWarranty
    {
        public int AssetWarrantyId { get; set; }
        public string InvoiceNumber { get; set; }
        public string VoucherNumber { get; set; }
        public int SupplierId { get; set; }
        public string PolicyNumber { get; set; }
        public string ContractNumber { get; set; }

        public virtual AssetWarrantyCompany WarrantyCompany { get; set; }
        public string Address { get; set; }
        public string Telphone { get; set; }
        public string WarrantyDuration { get; set; }

		public DateTime WarrantyStart { get; set; }
		public DateTime WarrantyEnd { get; set; }

		public double Premium { get; set; }
		public string Remark { get; set; }


	

    }
}
