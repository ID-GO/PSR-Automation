using Microsoft.EntityFrameworkCore;
using PSR_Automation.Data.DBConnection;
using PSR_Automation.Data.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PSR_Automation.Data.ViewModel
{
	public class AllSubmissionCRUDViewModel
	{
		#region Property
		private readonly AppDBContext _appDBContext;
		#endregion

		#region Constructor
		public AllSubmissionCRUDViewModel(AppDBContext appDBContext)
		{
			_appDBContext = appDBContext;
		}
		#endregion

		#region Get List of allSubmission
		public async Task<List<AllSubmission>> GetAllSubmissionsAsync()
		{

			return await _appDBContext.AllSubmissions.ToListAsync();
		}
		#endregion

		#region Insert allSubmission
		public async Task<bool> InsertSubmissionAsync(AllSubmission allSubmission)
		{
			await _appDBContext.AllSubmissions.AddAsync(allSubmission);
			await _appDBContext.SaveChangesAsync();
			return true;
		}
		#endregion

		#region Get Employee by Id
		public async Task<AllSubmission> GetSubmissionAsync(int Id)
		{
			AllSubmission allSubmission = await _appDBContext.AllSubmissions.FirstOrDefaultAsync(c => c.EvaluatioId.Equals(Id));
			return allSubmission;
		}
		#endregion

		#region Update allSubmission
		public async Task<bool> UpdateSubmissionAsync(AllSubmission allSubmission)
		{
			_appDBContext.AllSubmissions.Update(allSubmission);
			await _appDBContext.SaveChangesAsync();
			return true;
		}
		#endregion

		#region Delete allSubmission
		public async Task<bool> DeleteSubmissionAsync(AllSubmission allSubmission)
		{
			_appDBContext.Remove(allSubmission);
			await _appDBContext.SaveChangesAsync();
			return true;
		}
		#endregion
	}
}
