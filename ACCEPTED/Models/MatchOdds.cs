using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ACCEPTED.Models
{

	public class MatchOdds
	{

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ID { get; set; }
		[ForeignKey("MatchID")]
		public int MatchID { get; set; }
		public string Specifier { get; set; }
		public double Odd { get; set; }




	}
}
