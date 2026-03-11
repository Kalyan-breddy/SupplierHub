using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SupplierHub.Constants.Enum;
using SupplierHub.Models;

namespace SupplierHub.Config.Configurations
{
	public class MatchRefConfiguration : IEntityTypeConfiguration<MatchRef>
	{
		public void Configure(EntityTypeBuilder<MatchRef> builder)
		{
			builder.ToTable("match_ref");

			builder.Property(x => x.Result)
				.HasConversion<string>().HasMaxLength(20)
				.HasDefaultValue(MatchResult.Pending.ToString());

			builder.Property(x => x.Status)
				.HasConversion<string>().HasMaxLength(30)
				.HasDefaultValue(MatchStatus.Active.ToString());

			builder.Property(x => x.Notes).HasMaxLength(500);

			builder.Property(x => x.CreatedOn).HasDefaultValueSql("GETUTCDATE()");
			builder.Property(x => x.IsDeleted).IsRequired().HasDefaultValue(false);
			builder.HasIndex(x => x.IsDeleted).HasDatabaseName("idx_contract_isdeleted");
		}
	}
}