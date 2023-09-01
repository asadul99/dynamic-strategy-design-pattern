using DynamicStrategyPattern.Models;
using DynamicStrategyPattern.NotificationContext;

using Microsoft.AspNetCore.Mvc;

namespace DynamicStrategyPattern.ConcreteStrategies.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationTypeContext _notificationTypeContext;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="notificationTypeContext"></param>
        public NotificationController(INotificationTypeContext notificationTypeContext)
        {
            _notificationTypeContext = notificationTypeContext;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="recipient"></param>
        /// <param name="message"></param>
        /// <param name="notificationType"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<bool> SendNotificationAsync(string recipient, string message, EnumNotificationType notificationType)
        {
            //get target strategy to handle
            var actionStrategy = _notificationTypeContext.GetNotificationTypeStrategy(notificationType);

            //handle the action
            return await actionStrategy.SendNotificationAsync(recipient, message);
        }
    }
}