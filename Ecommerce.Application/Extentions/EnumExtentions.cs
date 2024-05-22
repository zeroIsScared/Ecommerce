

using System.ComponentModel;

namespace Ecommerce.Application.Extentions
{
    public static class EnumExtentions
    {
        public static string? GetDescription(this Enum value)
        {
            Type type = value.GetType();
            var name = Enum.GetName(type, value);

            if (name != null)
            {
                var field = type.GetField(name);
                if (field == null) return null;

                var attr = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
                return attr?.Description;
            }

            return null;
        }
    }
}
