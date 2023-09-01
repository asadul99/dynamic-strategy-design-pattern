using DynamicStrategyPattern.Models;
using DynamicStrategyPattern.ServiceAttributes;
using DynamicStrategyPattern.Strategies;

namespace DynamicStrategyPattern.NotificationContext
{
    /// <summary>
    /// Provide the target Strategy
    /// </summary>
    /// 
    [ScopedService]
    public class NotificationTypeContext : INotificationTypeContext
    {
        private readonly IEnumerable<INotificationStrategy> _notificationStrategy;

        /// <summary>
        /// Init all possible Strategies
        /// </summary>
        /// <param name="notificationStrategy"></param>
        public NotificationTypeContext(IEnumerable<INotificationStrategy> notificationStrategy)
        {
            _notificationStrategy = notificationStrategy;
        }

        /// <summary>
        /// Get target strategy by action id
        /// </summary>
        /// <param name="notificationType"></param>
        /// <returns></returns>
        public INotificationStrategy GetNotificationTypeStrategy(EnumNotificationType notificationType)
        {
            var notificationTypeStrategy = _notificationStrategy.FirstOrDefault(t => t.NotificationType == notificationType);
            return notificationTypeStrategy;
        }
    }
}