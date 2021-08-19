using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NoInc.Models
{
	/// <summary>
	/// Reperesents an Interest of a user (meaning an activity that a user enjoys)
	/// </summary>
	public class Interest : EntityBase
	{
		/// <summary>
		/// The Id (key) of the User associated with this interest
		/// </summary>
		[Required]
		public long UserId { get; set; }

		/// <summary>
		/// The name of the interest
		/// </summary>
		[Required]
		public string Name { get; set; }

		/// <summary>
		/// The type of interest
		/// </summary>
		public InterestType Type { get; set; }

		/// <summary>
		/// Whether the interest is current
		/// </summary>
		public bool Current { get; set; }

		/// <summary>
		/// Details about the interest
		/// </summary>
		[Required]
		public string Detail { get; set; }

		/// <summary>
		/// Represents a type of interest
		/// </summary>
		public enum InterestType
		{
			Sport, Game
	}
}
}
