using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SupplierHub.Models;

namespace SupplierHub.Config.Configurations
{
	public class InvoiceLineConfiguration : IEntityTypeConfiguration<InvoiceLine>
	{
		public void Configure(EntityTypeBuilder<InvoiceLine> builder)
		{
			builder.ToTable("invoice_line");

			builder.HasKey(x => x.InvLineId);
			builder.Property(x => x.InvLineId).HasColumnName("inv_line_id");

			// Decimal Precision as per your schema
			builder.Property(x => x.Qty)
				.HasColumnName("qty")
				.HasPrecision(18, 3);

			builder.Property(x => x.UnitPrice)
				.HasColumnName("unit_price")
				.HasPrecision(18, 4);

			builder.Property(x => x.LineTotal)
				.HasColumnName("line_total")
				.HasPrecision(18, 2);

			// JSON and String mappings
			builder.Property(x => x.TaxJson)
				.HasColumnName("tax_json")
				.HasColumnType("json");

			builder.Property(x => x.MatchStatus)
				.HasColumnName("match_status")
				.HasMaxLength(20);

			// Timestamps using Catalog style
			builder.Property(x => x.IsDeleted).IsRequired().HasDefaultValue(false);
			builder.Property(x => x.CreatedOn)
				.HasColumnName("createdon")
				.IsRequired()
				.HasDefaultValueSql("GETUTCDATE()");

			builder.Property(x => x.UpdatedOn)
				.HasColumnName("updatedon")
				.HasDefaultValueSql("GETUTCDATE()");

			// Relationships
			builder.HasOne(x => x.Invoice)
				.WithMany(i => i.InvoiceLines)
				.HasForeignKey(x => x.InvoiceId)
				.OnDelete(DeleteBehavior.Cascade)
				.IsRequired();

			builder.HasOne(x => x.POLine)
				.WithMany()
				.HasForeignKey(x => x.PoLineId)
				.OnDelete(DeleteBehavior.Restrict);

			// Indexes
			builder.HasIndex(x => x.InvoiceId).HasDatabaseName("idx_invline_invoice");
			builder.HasIndex(x => x.PoLineId).HasDatabaseName("idx_invline_poline");
			builder.HasIndex(x => x.IsDeleted).HasDatabaseName("idx_contract_isdeleted");
		}
	}
}