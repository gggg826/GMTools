using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection;

namespace FengNiao.GameTools.Json
{
    public class Serialize
    {
        int obj;
        public static string ConvertObjectToJson<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj).ToString();
        }

        public static string ConvertObjectToJsonList<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj).ToString();
        }

        public static List<T> ConvertJsonToObjectList<T>(string str)
        {
            return JsonConvert.DeserializeObject<List<T>>(str);
        }
        public static T ConvertJsonToObject<T>(string str)
        {
            return JsonConvert.DeserializeObject<T>(str);
        }

        public static JObject ConvertJsonToObject(string str)
        {
            JObject jobject = JObject.Parse(str);
            return jobject;
        }


        public static T GetJsonObject<T>(object obj, string key)
        {
            Type valueType = typeof(T);
            if (obj is JObject)
            {

                JObject jObject = (JObject)obj;
                JToken jToken = null;
                if (jObject.TryGetValue(key, out jToken))
                {
                    if (jToken is JValue)
                    {

                        if (valueType == typeof(JObject))
                        {
                            return (T)(object)ConvertJsonToObject(jToken.Value<string>());
                        }
                        else if (valueType == typeof(JArray) && jToken.Type == JTokenType.String)
                        {
                            return (T)(object)JArray.Parse(jToken.Value<string>());
                        }
                        else
                        {
                            return jToken.Value<T>();
                        }
                        /*
                        MethodInfo methodInfo = valueType.GetMethod("TryParse", new Type[] { typeof(string), typeof(T).MakeByRefType() });
                        if (methodInfo != null)
                        {
                            T outValue = default(T);
                            object[] invokeArgs = new object[] { jValue.Value.ToString(), outValue };
                            methodInfo.Invoke(null, invokeArgs);
                            return (T)invokeArgs[1];
                        }*/
                    }
                    else if (jToken is JArray)
                    {
                        return (T)(object)jToken;
                    }
                }
            }
            if (valueType == typeof(int))
            {
                return (T)(object)-1;
            }
            else
            {
                return default(T);
            }
        }

    }
}
