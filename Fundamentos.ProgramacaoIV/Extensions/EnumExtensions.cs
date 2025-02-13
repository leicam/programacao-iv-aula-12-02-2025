using System.ComponentModel;

namespace Fundamentos.ProgramacaoIV.Extensions;

internal static class EnumExtensions
{
    internal static string GetDescription(this Enum value)
    {
        var field = value.GetType().GetField(value.ToString());

        if (field != null)
        {
            var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));

            if (attribute != null)
                return attribute.Description;
        }

        return value.ToString();
    }
}