namespace DynamicStrategyPattern.Models
{
    /// <summary>
    /// Define possible actions you support
    /// </summary>
    public enum EnumNotificationType
    {
        /// <summary>
        /// Email send strategy
        /// </summary>
        Email = 1,

        /// <summary>
        /// SMS send strategy
        /// </summary>
        SMS = 2
    }
}