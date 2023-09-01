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
    public class SMSSendStrategy : INotificationStrategy
    {
        /// <summary>
        /// Action of news get
        /// </summary>
        public EnumNotificationType NotificationType => EnumNotificationType.SMS;

        private readonly ISMSSenderService _smsSenderService;
        /// <summary>
        /// Init EmailSenderService
        /// </summary>
        /// <param name="smsSenderService"></param>
        public SMSSendStrategy(ISMSSenderService smsSenderService)
        {
            _smsSenderService = smsSenderService;
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
            return await _smsSenderService.SendSMSAsync(recipient,message);
        }
    }
}
