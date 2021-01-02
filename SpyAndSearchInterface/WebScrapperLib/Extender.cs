using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace WebScrapperLib
{
    public static class Extender
    {
        public static string DateTimeFormatBrazil = "dd/MM/yyyy HH:mm:ss";
        public static string DateFormatBrazil = "dd/MM/yyyy";
        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }

        public static string GetPathAssembly(this object obj)
        {
            try
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conseguir o caminho do assembly" + ex.Message);
            }

        }
        
        public static string SerializeObjectToXml(this object obj)
        {
            try
            {
                var settings = new XmlWriterSettings
                {
                    Indent = true,
                    OmitXmlDeclaration = false,
                    Encoding = Encoding.GetEncoding("UTF-8")
                };

                var namespaces = new XmlSerializerNamespaces();
                namespaces.Add(string.Empty, string.Empty);

                var serializer = new XmlSerializer(obj.GetType());

                using (var stringWriter = new StringWriter())
                {
                    using (var xmlWriter = XmlWriter.Create(stringWriter, settings))
                        serializer.Serialize(xmlWriter, obj, namespaces);

                    return stringWriter.ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar serializar o objeto." + ex.Message);
            }
        }
        
        public static T DeserializeXmlToObject<T>(this string xml) where T : new()
        {
            T xmlObject = new T();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            StringReader stringReader = new StringReader(xml);
            xmlObject = (T)xmlSerializer.Deserialize(stringReader);
            return xmlObject;
        }
        
        public static void WriteLog(this object obj, string message, string especifyLog = null)
        {
            if (IsDebugActive())
            {
                try
                {
                    if(!File.Exists(string.Format("{0}\\logs", AssemblyDirectory)))
                        File.Create(string.Format("{0}\\logs", AssemblyDirectory));

                    if (string.IsNullOrEmpty(especifyLog))
                    {
                        using (StreamWriter sw = new StreamWriter(
                        string.Format("{0}\\logs\\Log_{1}.txt",
                        AssemblyDirectory,
                        DateTime.Now.ToString("YYYY-MM-DD")), true))
                        {
                            sw.WriteLine(string.Format("{0} - {1}", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), message));
                        }
                    }
                    else
                    {
                        using (StreamWriter sw = new StreamWriter(
                        string.Format("{0}\\logs\\Log_{1}_{2}.txt",
                        AssemblyDirectory,
                        especifyLog,
                        DateTime.Now.ToString("YYYY-MM-DD")), true))
                        {
                            sw.WriteLine(string.Format("{0} - {1}", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), message));
                        }
                    }
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }
        
        public static bool IsDebugActive()
        {
            try
            {
                string path = string.Format("{0}\\{1}", AssemblyDirectory, "NEOY62tebQrtagxlQjZw.txt");
                return File.Exists(path);
            }
            catch
            {
                return false;
            }
        }

        private static string AnalyseException(Exception ex)
        {
            if(ex.InnerException != null)
                return $"Exception Message: {ex.Message} || Inner Message: {ex.InnerException.Message} || Stack: {ex.StackTrace}";
            return $"Exception Message: {ex.Message} || Stack: {ex.StackTrace}";
        }

        public static int GetMonthNumberFromAbreviate(this string obj)
        {
            return obj.Equals("Jan") ? 1 :
                obj.Equals("Feb") ? 2 :
                obj.Equals("Mar") ? 3 :
                obj.Equals("Apr") ? 4 :
                obj.Equals("May") ? 5 :
                obj.Equals("Jun") ? 6 :
                obj.Equals("Jul") ? 7 :
                obj.Equals("Aug") ? 8 :
                obj.Equals("Sep") ? 9 :
                obj.Equals("Oct") ? 10 :
                obj.Equals("Nov") ? 11 :
                obj.Equals("Dec") ? 12 : 0;
        }
    }
}
