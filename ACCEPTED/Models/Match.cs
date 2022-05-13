using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ACCEPTED.Models
{
	public class Match
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int MatchID { get; set; }
		public string Description { get; set; }
		public DateTime MatchDate { get; set; }
		public DateTime MatchTime { get; set; }
		public string TeamA { get; set; }
		public string TeamB { get; set; }
		public int Sport { get; set; }


	}
}
