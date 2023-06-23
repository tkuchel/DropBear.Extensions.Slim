using System.Dynamic;

namespace DropBear.Extensions.Slim;

public static class SlimExtension
{


    public static dynamic Squeeze(this object obj)
    {
        dynamic slim = new ExpandoObject();
        var slimDict = (IDictionary<string, object>)slim;

        var properties = obj.GetType().GetProperties();
        foreach (var prop in properties)
        {
            if (Attribute.IsDefined(prop, typeof(KeepAttribute)))
            {
                slimDict[prop.Name] = prop.GetValue(obj);
            }
        }

        return slim;
    }
}
