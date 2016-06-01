using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace FengNiao.GameTools.Util
{
    public class XmlConfig
    {
        private string xmlPath;
        private XmlDocument myDc = new XmlDocument();
        public XmlConfig(string INIPath)
        {
            xmlPath = INIPath;
            if (!System.IO.File.Exists(INIPath))
            {

            }
            myDc.Load(xmlPath);
        }
        public string GetXmlReader(string Section, string Key)
        {

            string ConfigValue = myDc.SelectSingleNode(Section).SelectSingleNode(Key).InnerText;

            return ConfigValue;

        }

        public XmlNodeList GetXmlNodes(string section, string key)
        {
            return myDc.SelectSingleNode(section).SelectNodes(key);
        }


        public void SetXmlReader(string Section, string Key, string Value)
        {
            myDc.SelectSingleNode(Section).SelectSingleNode(Key).InnerText = Value;
        }
        public string XMLSave()
        {
            try
            {
                myDc.Save(xmlPath);
                return ("Success");
            }
            catch (Exception ex)
            {
                return (ex.Message);
            }
        }
    }
}
