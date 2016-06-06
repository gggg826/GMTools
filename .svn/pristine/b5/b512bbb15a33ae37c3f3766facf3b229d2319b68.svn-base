using System;
using System.Collections.Generic;
using System.Text;

namespace FengNiao.GameTools.Util
{
    public class SystemConfig
    {
        public static T ConvertConfigValue<T>(string configValue, ref bool isSuccess)
        {

            object value = GetValueToT<T>(configValue,ref isSuccess);
            if (configValue != null)
            {
                return (T)value;
            }
            else
            {
                return default(T);
            }
        }

        private static object GetValueToT<T>(string value, ref bool isSuccess)
        {
            TypeCode typeCode = System.Type.GetTypeCode(typeof(T));
            if (value != null)
            {
                switch (typeCode)
                {
                    case TypeCode.Boolean:
                        bool flag = false;
                        if (bool.TryParse(value, out flag))
                        {
                            isSuccess = true;
                            return flag;
                        }
                        else
                        {
                            isSuccess = false;
                        }
                        break;
                    case TypeCode.Char:
                        char c;
                        if (Char.TryParse(value, out c))
                        {
                            isSuccess = true;
                            return c;
                        }
                        else
                        {
                            isSuccess = false;
                        }
                        break;
                    case TypeCode.SByte:
                        sbyte s = 0;
                        if (SByte.TryParse(value, out s))
                        {
                            isSuccess = true;
                            return s;
                        }
                        else
                        {
                            isSuccess = false;
                        }
                        break;
                    case TypeCode.Byte:
                        byte b = 0;
                        if (Byte.TryParse(value, out b))
                        {
                            isSuccess = true;
                            return b;
                        }
                        else
                        {
                            isSuccess = false;
                        }
                        break;
                    case TypeCode.Int16:
                        Int16 i16 = 0;
                        if (Int16.TryParse(value, out i16))
                        {
                            isSuccess = true;
                            return i16;
                        }
                        else
                        {
                            isSuccess = false;
                        }
                        break;
                    case TypeCode.UInt16:
                        UInt16 ui16 = 0;
                        if (UInt16.TryParse(value, out ui16))
                        {
                            isSuccess = true;
                            return ui16;
                        }
                        else
                        {
                            isSuccess = false;
                        }
                        break;
                    case TypeCode.Int32:
                        int i = 0;
                        if (Int32.TryParse(value, out i))
                        {
                            isSuccess = true;
                            return i;
                        }
                        else
                        {
                            isSuccess = false;
                        }
                        break;
                    case TypeCode.UInt32:
                        UInt32 ui32 = 0;
                        if (UInt32.TryParse(value, out ui32))
                        {
                            isSuccess = true;
                            return ui32;
                        }
                        else
                        {
                            isSuccess = false;
                        }
                        break;
                    case TypeCode.Int64:
                        Int64 i64 = 0;
                        if (Int64.TryParse(value, out i64))
                        {
                            isSuccess = true;
                            return i64;
                        }
                        else
                        {
                            isSuccess = false;
                        }
                        break;
                    case TypeCode.UInt64:
                        UInt64 ui64 = 0;
                        if (UInt64.TryParse(value, out ui64))
                        {
                            isSuccess = true;
                            return ui64;
                        }
                        else
                        {
                            isSuccess = false;
                        }
                        break;
                    case TypeCode.Single:
                        Single single = 0;
                        if (Single.TryParse(value, out single))
                        {
                            isSuccess = true;
                            return single;
                        }
                        else
                        {
                            isSuccess = false;
                        }
                        break;
                    case TypeCode.Double:
                        double d = 0;
                        if (Double.TryParse(value, out d))
                        {
                            isSuccess = true;
                            return d;
                        }
                        else
                        {
                            isSuccess = false;
                        }
                        break;
                    case TypeCode.Decimal:
                        decimal de = 0;
                        if (Decimal.TryParse(value, out de))
                        {
                            isSuccess = true;
                            return de;
                        }
                        else
                        {
                            isSuccess = false;
                        }
                        break;
                    case TypeCode.DateTime:
                        DateTime dt;
                        if (DateTime.TryParse(value, out dt))
                        {
                            isSuccess = true;
                            return dt;
                        }
                        else
                        {
                            isSuccess = false;
                        }
                        break;
                    case TypeCode.String:
                        if (!string.IsNullOrEmpty(value))
                        {
                            isSuccess = true;
                            return value.ToString();
                        }
                        else
                        {
                            isSuccess = false;
                        }
                        break;
                }
            }
            return null;
        }
    }
}
