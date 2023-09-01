using DynamicStrategyPattern.Models;

namespace DynamicStrategyPattern.Strategies
{
    /// <summary>
    /// Action strategy
    /// </summary>
    public interface INotificationStrategy
    {
        /// <summary>
        /// Handle the action
        /// </summary>
        /// <param name="recipient"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        Task<bool> SendNotificationAsync(string recipient, string message);
        /// <summary>
        /// Target Action to handle
        /// </summary>
        EnumNotificationType NotificationType { get; }
    }
}