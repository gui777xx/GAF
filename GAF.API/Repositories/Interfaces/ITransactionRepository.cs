namespace GAF.API.Models;

public interface ITransactionRepository
{
    Task<IEnumerable<Transaction>> GetAllByUserIdAsync(string userId);
    Task<Transaction> GetByIdAsync(int id, string userId);
    Task<IEnumerable<Transaction>> GetbyDateRangeAsync(
        string userId, DateTime startDate, DateTime endDate);
        Task<IEnumerable<Transaction>> GetbyCategoryAsync(
            string userId, int categoryId);
    Task<Transaction> CreateAsync(Transaction transaction);
    Task<Transaction> UpdateAsync(Transaction transaction);
    Task<bool> DeleteAsync(int id, string userId);
    Task<decimal> GetTotalincomeByMonthAsync(
        string userId, int month, int year);
    Task<decimal> GetTotalExpensesByMonthAsync(
        string userId, int month, int year);
    Task<IEnumerable<Transaction>> GetRecentTransactionAsync(
        string userId, int count = 10);
}