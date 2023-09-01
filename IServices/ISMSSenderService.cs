namespace DynamicStrategyPattern.IServices
{
    /// <summary>
    /// Newspaper services
    /// </summary>
    public interface ISMSSenderService
    {
        /// <summary>
        /// Newspaper save service
        /// </summary>
        /// <param name="recipient"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        Task<bool> SendSMSAsync(string recipient, string message);
    }
}