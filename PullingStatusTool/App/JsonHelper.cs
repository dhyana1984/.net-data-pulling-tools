using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Json;
using System.IO;
using PullingStatusTool;

namespace PullingStatusTool.App
{
    class JsonHelper
    {
     
              /// <summary>
             /// JSON序列化
           /// </summary>
                     public static string JsonSerializer<T>(T t)
                   {
                        DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
                        MemoryStream ms = new MemoryStream();
                       ser.WriteObject(ms, t);
                      string jsonString = Encoding.UTF8.GetString(ms.ToArray());
                         ms.Close();
                         return jsonString;
                  }
 
                    /// <summary>
                    /// JSON反序列化
                   /// </summary>
                   public static T JsonDeserialize<T>(string jsonString)
                     {
                         string str = jsonString;
                        str=   jsonString.Replace("\\","").TrimEnd('"').TrimStart('"');
                       DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
                       MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(str));
                        T obj = (T)ser.ReadObject(ms);
                         return obj;
                    }
         
    }

}
