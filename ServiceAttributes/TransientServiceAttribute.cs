namespace DynamicStrategyPattern.ServiceAttributes
{
    /// <summary>
    /// Need to register service as Transient
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class TransientServiceAttribute : Attribute { }
}
