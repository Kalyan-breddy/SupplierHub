using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace SupplierHub.Models
{
	public class Requisition
	{
		[Key]
		public long PRID { get; set; }

		[Required]
		public long RequesterID { get; set; }

		[Required]
		public long OrgID { get; set; }

		[StringLength(100)]
		public string CostCenter { get; set; }

		public string Justification { get; set; }

		[Required]
		public DateTimeOffset RequestedDate { get; set; } = DateTimeOffset.Now;

		public DateTimeOffset? NeededByDate { get; set; }

		[Required]
		[StringLength(20)]
		public string Status { get; set; } = "Draft"; // Default as per your schema

		
	}
}