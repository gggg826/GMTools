using System;
using System.Collections.Generic;
using System.Text;

namespace FengNiao.GameToolsCommon
{
    public class HttpInterfaceSqlParameter
    {
        public HttpInterfaceSqlParameter(string name, object value, SqlCompareType compareType)
        {
            this.Name = name;
            this.Value = value;
            this.CompareType = compareType;
        }
        public string Name { set; get; }
        public object Value { set; get; }
        public SqlCompareType CompareType { set; get; }


        public string FillValue(bool isPaddingQuotes = true)
        {
            Type valueType = Value.GetType();
            if (valueType.Name.ToLower().IndexOf("int") != -1 || valueType == typeof(float) || valueType == typeof(double) || valueType == typeof(decimal) || !isPaddingQuotes)
            {
                return this.Value.ToString();
            }
            return "\'" + this.Value.ToString() + "\'";
        }

        public new string ToString()
        {
            string strResult = string.Empty;

            if (CompareType == SqlCompareType.Equal)
            {
                strResult = string.Format("{0}={1}", Name, FillValue());
            }
            else if (CompareType == SqlCompareType.LessThan)
            {
                strResult = string.Format("{0}<{1}", Name, FillValue());
            }
            else if (CompareType == SqlCompareType.MoreThan)
            {
                strResult = string.Format("{0}>{1}", Name, FillValue());
            }
            else if (CompareType == SqlCompareType.LessThanAndEqual)
            {
                strResult = string.Format("{0}<={1}", Name, FillValue());
            }
            else if (CompareType == SqlCompareType.MoreThanAndEqual)
            {
                strResult = string.Format("{0}>={1}", Name, FillValue());
            }
            else if (CompareType == SqlCompareType.NotEqual)
            {
                strResult = string.Format("{0}!={1}", Name, FillValue());
            }
            else if (CompareType == SqlCompareType.Like)
            {
                strResult = string.Format("{0} LIKE '%{1}%'", Name, FillValue(false));
            }
            return strResult;
        }
    }
}
