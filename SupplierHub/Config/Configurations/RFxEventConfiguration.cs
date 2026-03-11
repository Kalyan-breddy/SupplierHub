using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SupplierHub.Constants.Enum;
using SupplierHub.Models;
namespace SupplierHub.Config.Configurations
{
	public class RFxEventConfiguration : IEntityTypeConfiguration<RFxEvent>
	{
		public void Configure(EntityTypeBuilder<RFxEvent> builder) {
			builder.HasKey(e => e.RFxID);

			
			builder.Property(e => e.Status)
				   .HasDefaultValue(RFxStatus.Open) 
				   .HasConversion<string>();       

			builder.Property(e => e.IsDeleted)
				   .HasDefaultValue(false);

			
			builder.HasQueryFilter(e => e.IsDeleted == false);

			
			builder.HasOne(e => e.Category)
				   .WithMany(x=>x.Events) 
				   .HasForeignKey(e => e.CategoryID)
				   .OnDelete(DeleteBehavior.Restrict);

			
			builder.HasOne(e => e.User)
				   .WithMany(e=>e.Events)
				   .HasForeignKey(e => e.CreatedBy)
				   .OnDelete(DeleteBehavior.SetNull);

			
			builder.HasOne(e => e.Award)
				   .WithOne(a => a.RFxEvent)
				   .HasForeignKey<Award>(a => a.RFxID)
				   .OnDelete(DeleteBehavior.Cascade); 

			
		}
	}
}
