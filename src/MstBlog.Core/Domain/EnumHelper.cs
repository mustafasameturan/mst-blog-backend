namespace MstBlog.Core.Domain;

using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

public static class EnumHelper
{
    public static string GetDisplayName(Enum value)
    {
        FieldInfo field = value.GetType().GetField(value.ToString());

        if (field != null)
        {
            if (Attribute.GetCustomAttribute(field, typeof(DisplayAttribute)) is DisplayAttribute attribute)
            {
                return attribute.Name;
            }
        }

        return value.ToString();
    }
}
