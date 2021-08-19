using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NoInc.Models
{
	/// <summary>
	/// Reperesents a skill of a user
	/// </summary>
	public class Skill : EntityBase
	{
		/// <summary>
		/// The Id (key) of the User associated with this skill
		/// </summary>
		[Required]
		public long UserId { get; set; }

		/// <summary>
		/// The name of the skill
		/// </summary>
		[Required]
		public string Name { get; set; }

		/// <summary>
		/// The type of skill
		/// </summary>
		public SkillType Type { get; set; }

		/// <summary>
		/// The date the skill was leared
		/// </summary>
		public DateTime DateLeared { get; set; }

		/// <summary>
		/// Details about the skill
		/// </summary>
		[Required]
		public string Detail { get; set; }

		/// <summary>
		/// Represents a type of skill
		/// </summary>
		public enum SkillType
		{
			Essential, Practical
	}
}
}
