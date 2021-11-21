using System;
using System.ComponentModel.DataAnnotations;

namespace PSR_Automation.Data.Model
{
	public class AllSubmission
	{
		[Key]
		public int EvaluatioId { get; set; }
		[Required]
		[StringLength(100)]
		public string SolutionName { get; set; }
		public string ApplicationID { get; set; }
		public string ExecutiveSponsor { get; set; }
		[Required]
		public string Forum { get; set; }
		public DateTime? ForumDate { get; set; } = DateTime.UtcNow;
		public string BusinessDivision { get; set; }
		public string BusinessDivisionLevel2 { get; set; }
		public string DataSteward { get; set; }
		[Required]
		[EmailAddress(ErrorMessage = "Enter Valid Email ID")]
		public string DataOperationsContact { get; set; }
		[Required]
		public string ReviewType { get; set; }
		public string RequestType { get; set; }
		public string ClarityCode { get; set; }
		[Required]
		public string DataContentSolution { get; set; }
		public string CriticalityQuestions { get; set; } = "Not Applicable";
		public string PSRChecklistQuestions { get; set; } = "Not Applicable";
		public string Comments { get; set; }

		public string SubmittedDate { get; set; }

	}
}
