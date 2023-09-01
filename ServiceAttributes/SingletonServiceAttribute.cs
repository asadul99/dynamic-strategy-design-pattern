namespace DynamicStrategyPattern.ServiceAttributes
{
    /// <summary>
    /// Need to register service as Singleton
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class SingletonServiceAttribute : Attribute { }
}
