using System;
using System.ComponentModel;
using System.Linq;

namespace DropkicKExample
{
    /// <summary>
    /// Extensions for enumerations
    /// </summary>
    public static class EnumerationExtensions
    {

        /// <summary>
        /// Gets the description [Description("")] or ToString() value of an enumeration.
        /// </summary>
        /// <param name="enumeration">The enumeration item.</param>
        public static string GetDescriptionOrValue(this Enum enumeration)
        {
            string description = enumeration.ToString();
            
            Type type = enumeration.GetType();
            System.Reflection.MemberInfo[] memInfo = type.GetMember(description);

            if (memInfo != null && memInfo.Length > 0)
            {
                var attrib = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute),false).Cast<DescriptionAttribute>().SingleOrDefault();

                if (attrib != null)
                {
                    description =  attrib.Description;
                }
                
            }

            return description;
        }

    }
}