using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace GameToolsCommon
{
    public class DataCheck
    {
        public static string sqlPattern = "select|update|delete|[\\s()]+and[\\s()]+|[\\s()]+or[\\s()]+|'|''";
        public static bool CheckDataIsvalid(object value)
        {
            if (value != null)
            {
                string strValue = value.ToString();
                return !System.Text.RegularExpressions.Regex.IsMatch(strValue, sqlPattern);
            }
            return true;
        }

        public static bool CheckObjectIsvalid(object obj, string filterName = "")
        {
            PropertyInfo[] infos = obj.GetType().GetProperties();
            for (int i = 0; i < infos.Length; i++)
            {
                if (!filterName.Equals("") && !filterName.Equals(infos[i].Name))
                {
                    continue;
                }
                object val = infos[i].GetValue(obj, null);
                if (!CheckDataIsvalid(val))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
