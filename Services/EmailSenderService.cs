using DynamicStrategyPattern.IServices;
using DynamicStrategyPattern.ServiceAttributes;

namespace DynamicStrategyPattern.Services
{
    /// <summary>
    /// All possible new operations handler
    /// </summary>
    /// 
    [ScopedService]
    public class EmailSenderService : IEmailSenderService
    {
        /// <summary>
        /// Save news
        /// </summary>
        /// <param name="recipient"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public async Task<bool> SendEmailAsync(string recipient, string message)
        {
            //Implement SMS sending logic
            return await Task.FromResult(true);
        }
    }
}
