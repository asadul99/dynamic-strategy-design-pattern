namespace DynamicStrategyPattern.IServices
{
    /// <summary>
    /// Newspaper services
    /// </summary>
    public interface IEmailSenderService
    {
        /// <summary>
        /// Newspaper save service
        /// </summary>
        /// <param name="recipient"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        Task<bool> SendEmailAsync(string recipient, string message);
    }
}