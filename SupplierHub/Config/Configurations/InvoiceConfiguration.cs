using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SupplierHub.Constants.Enum;
using SupplierHub.Models;

namespace SupplierHub.Config.Configurations
{
	public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
	{
		public void Configure(EntityTypeBuilder<Invoice> builder)
		{
			builder.ToTable("invoice");

			builder.Property(x => x.InvoiceNo).IsRequired().HasMaxLength(100);
			builder.Property(x => x.TotalAmount).HasPrecision(18, 2);

			builder.Property(x => x.Status).IsRequired()
				.HasConversion<string>().HasMaxLength(30)
				.HasDefaultValue(InvoiceStatus.Submitted.ToString());

			builder.Property(x => x.IsDeleted).IsRequired().HasDefaultValue(false);
			builder.Property(x => x.CreatedOn).IsRequired().HasDefaultValueSql("GETUTCDATE()");

			builder.HasIndex(x => x.InvoiceNo).IsUnique().HasDatabaseName("ux_invoice_no");
			builder.HasIndex(x => x.IsDeleted).HasDatabaseName("idx_contract_isdeleted");
		}
	}
}