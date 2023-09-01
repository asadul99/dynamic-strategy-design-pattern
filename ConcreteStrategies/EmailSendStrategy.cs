using DynamicStrategyPattern.IServices;
using DynamicStrategyPattern.Models;
using DynamicStrategyPattern.ServiceAttributes;
using DynamicStrategyPattern.Strategies;


namespace DynamicStrategyPattern.ConcreteStrategies
{
    /// <summary>
    /// News save business
    /// </summary>
    /// 
    [ScopedService]
    public class EmailSendStrategy : INotificationStrategy
    {
        /// <summary>
        /// Action of news get
        /// </summary>
        public EnumNotificationType NotificationType => EnumNotificationType.Email;

        private readonly IEmailSenderService _emailSenderService;
        /// <summary>
        /// Init EmailSenderService
        /// </summary>
        /// <param name="emailSenderService"></param>
        public EmailSendStrategy(IEmailSenderService emailSenderService)
        {
            _emailSenderService = emailSenderService;
        }

        /// <summary>
        /// Email send business implementation
        /// </summary>
        /// <param name="recipient"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<bool> SendNotificationAsync(string recipient, string message)
        {
            //implement your get news related business here
            return await _emailSenderService.SendEmailAsync(recipient,message);
        }
    }
}
