using FLAGS_NBA.API.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLAGS_NBA.API.Helper
{
    internal static class EnumMapper
    {
        public static string Map(SubTargetType subType)
        {
            string subTypeValue = subType.ToString();

            if (subTypeValue == SubTargetType.not_applicable.ToString())
            {
                return "";
            }
            else
            {
                string map = subTypeValue.Replace("_", "-");
                return map;
            }
        }

        public static string MapTarget(TargetTypes type)
        {
            return type.ToString().Replace("_", "-");
        }
    }
}
