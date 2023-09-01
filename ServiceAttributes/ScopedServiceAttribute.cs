namespace DynamicStrategyPattern.ServiceAttributes
{
    /// <summary>
    /// Need to register service as Scoped
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class ScopedServiceAttribute : Attribute { }
}
