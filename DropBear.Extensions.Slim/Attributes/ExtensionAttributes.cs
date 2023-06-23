namespace DropBear.Extensions.Slim;

// This attribute is used to mark a class for processing by the squeeze method.
[AttributeUsage(AttributeTargets.Class)]
public class SqueezableAttribute : Attribute
{
}

// This attribute is used to mark a property to be kept during the squeeze process.
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class KeepAttribute : Attribute
{
}

