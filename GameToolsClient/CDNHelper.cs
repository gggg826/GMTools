using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace GameToolsClient
{
    public class CDNHelper
    {
        public static byte[] EncodeCDNFiles(List<string> fileList, Dictionary<string, byte[]> fileDatas = null)
        {
            ZipFile zipFile = new ZipFile();
            if (fileDatas != null)
            {
                foreach (string fileName in fileDatas.Keys)
                {
                    FileInfo fi = new FileInfo(fileName);
                    string strName = fi.Name;
                    zipFile.AddEntry(strName, fileDatas[fileName]);
                }
            }
            byte[] data = null;
            for (int i = 0; i < fileList.Count; i++)
            {
                string fileName = fileList[i];
                if (File.Exists(fileName))
                {
                    FileInfo fi = new FileInfo(fileName);
                    using (FileStream fs = File.Open(fileName, FileMode.Open))
                    {
                        long len = fs.Length;
                        byte[] datas = new byte[len];
                        fs.Read(datas, 0, datas.Length);
                        zipFile.AddEntry(fi.Name, datas);
                    }
                }
            }


            using (MemoryStream output = new MemoryStream())
            {
                zipFile.Save(output);
                data = output.ToArray();
            }
            return data;
        }
    }
}
