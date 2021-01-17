using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using WebScrapperLib.Models;

namespace WebScrapperLib
{
    public static class Extender
    {
        private static readonly string GitHubUrlApiBaseProject = "https://api.github.com/repos/Raythan/LookAndSearch/contents/";
        private static HttpClient Client = new HttpClient();
        
        private static readonly string[] formats = new[]
        {
            "MMM dd yyyy, HH:mm CET",
            "MMM dd yyyy, HH:mm:ss CEST",
            "MMM dd yyyy, HH:mm:ss CET",
            "MMM dd yyyy"
        };

        private static readonly Dictionary<int, LocationTimeFormat> DictionaryDateFormat = new Dictionary<int, LocationTimeFormat>
        {
            { 0, new LocationTimeFormat("dd/MM/yyyy HH:mm:ss", -4) },
            { 1, new LocationTimeFormat("dd/MM/yyyy", -4) },
            { 2, new LocationTimeFormat("MM/dd/yyyy HH:mm:ss", -6) },
            { 3, new LocationTimeFormat("MM/dd/yyyy", -6) },
        };
        private static readonly Dictionary<string, Size> DictionaryDimensions = new Dictionary<string, Size>
        {
            { "IconSize16x16", new Size(16, 16) },
            { "IconSize18x18", new Size(18, 18) },
            { "IconSize32x32", new Size(32, 32) },
            { "IconSize64x64", new Size(64, 64) },
            { "IconSize170x175", new Size(170, 175) },
            { "IconSize400x400", new Size(400, 400) },
            { "SelectionSize250x250", new Size(250, 250) },
            { "PanelSize536x273", new Size(536, 273) },
            { "FullSize1920x1448", new Size(1920, 1448) }
        };

        private static readonly Dictionary<string, Action> DictionaryMethods = new Dictionary<string, Action>
        {
            { "CipSoftHeaders", AddCipsoftHeaders },
            { "GitHubHeaders", AddGitHubHeaders }
        };

        public static string GetLibVersionFromAssembly() => FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;

        private static void AddGitHubHeaders()
        {
            Client.DefaultRequestHeaders.Clear();
            Client.DefaultRequestHeaders.Add("accept", "*/*");
            Client.DefaultRequestHeaders.Add("accept-encoding", "UTF-8");
            Client.DefaultRequestHeaders.Add("accept-language", "pt-BR,pt;q=0.9,en-US;q=0.8,en;q=0.7");
            Client.DefaultRequestHeaders.Add("cache-control", "no-cache");
            Client.DefaultRequestHeaders.Add("cookie", "__cfduid=df4aba1030b9ada4d3ad6ac0addfeb06a1607818705; cf_clearance=0a6991fa94f7d778b0dcfc435281fca9995c516e-1608659141-0-150; SessionLastVisit=1608659186; DM_LandingPage=visited; DM_SessionID=ebf66963c897d3fdcf73c7ed5c915dab1609171284");
            Client.DefaultRequestHeaders.Add("pragma", "no-cache");
            Client.DefaultRequestHeaders.Add("sec-fetch-dest", "document");
            Client.DefaultRequestHeaders.Add("sec-fetch-mode", "navigate");
            Client.DefaultRequestHeaders.Add("sec-fetch-site", "none");
            Client.DefaultRequestHeaders.Add("sec-fetch-user", "?1");
            Client.DefaultRequestHeaders.Add("upgrade-insecure-requests", "1");
            Client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.88 Safari/537.36");
        }

        private static void AddCipsoftHeaders()
        {
            Client.DefaultRequestHeaders.Clear();
            Client.DefaultRequestHeaders.Add("accept", "text/html");
            Client.DefaultRequestHeaders.Add("accept-encoding", "UTF-8");
            Client.DefaultRequestHeaders.Add("accept-language", "pt-BR,pt;q=0.9,en-US;q=0.8,en;q=0.7");
            Client.DefaultRequestHeaders.Add("cache-control", "no-cache");
            Client.DefaultRequestHeaders.Add("cookie", "__cfduid=df4aba1030b9ada4d3ad6ac0addfeb06a1607818705; cf_clearance=0a6991fa94f7d778b0dcfc435281fca9995c516e-1608659141-0-150; SessionLastVisit=1608659186; DM_LandingPage=visited; DM_SessionID=ebf66963c897d3fdcf73c7ed5c915dab1609171284");
            Client.DefaultRequestHeaders.Add("pragma", "no-cache");
            Client.DefaultRequestHeaders.Add("sec-fetch-dest", "document");
            Client.DefaultRequestHeaders.Add("sec-fetch-mode", "navigate");
            Client.DefaultRequestHeaders.Add("sec-fetch-site", "none");
            Client.DefaultRequestHeaders.Add("sec-fetch-user", "?1");
            Client.DefaultRequestHeaders.Add("upgrade-insecure-requests", "1");
            Client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.88 Safari/537.36");
        }

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
                    if (!File.Exists(string.Format("{0}\\logs", AssemblyDirectory)))
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
                catch (Exception ex)
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
            if (ex.InnerException != null)
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

        public static Image RecoverImageFromUrl(string url, string sizeKey, string methodKey)
        {
            try
            {
                Client = new HttpClient()
                {
                    BaseAddress = new Uri(url)
                };
                DictionaryMethods[methodKey]();

                using (var responseTeste = Client.GetAsync(url).GetAwaiter().GetResult())
                using (var stream = responseTeste.Content.ReadAsStreamAsync().GetAwaiter().GetResult())
                    return new Bitmap(Bitmap.FromStream(stream), DictionaryDimensions
                    .Where(w => w.Key.Equals(sizeKey))
                    .Select(s => s.Value)
                    .FirstOrDefault());
            }
            catch (Exception)
            {
                return new Bitmap(
                    Image.FromFile($"{AssemblyDirectory}\\Images\\not_found_img_1990x1448.jpg"),
                    DictionaryDimensions
                    .Where(w => w.Key.Equals(sizeKey))
                    .Select(s => s.Value)
                    .FirstOrDefault());
            }
        }

        public static Icon RecoverIconFromUrl(string url, string sizeKey, string methodKey)
        {
            try
            {
                Client = new HttpClient()
                {
                    BaseAddress = new Uri(url)
                };
                DictionaryMethods[methodKey]();

                using (var responseTeste = Client.GetAsync(url).GetAwaiter().GetResult())
                using (var stream = responseTeste.Content.ReadAsStreamAsync().GetAwaiter().GetResult())
                    return new Icon(stream, DictionaryDimensions
                    .Where(w => w.Key.Equals(sizeKey))
                    .Select(s => s.Value)
                    .FirstOrDefault());
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static string RecoverStringFromUrl(string url, string methodKey)
        {
            try
            {
                Client = new HttpClient()
                {
                    BaseAddress = new Uri(url)
                };
                DictionaryMethods[methodKey]();

                using (var responseString = Client.GetAsync(url).GetAwaiter().GetResult())
                    return responseString.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<string> RecoverAdSenseUrlListFromGitHub(string pathParam)
        {
            try
            {
                Client = new HttpClient()
                {
                    BaseAddress = new Uri($"{GitHubUrlApiBaseProject}{pathParam}")
                };
                AddGitHubHeaders();

                var ResponseStringJson = Client.GetStringAsync($"{GitHubUrlApiBaseProject}{pathParam}").GetAwaiter().GetResult();
                var GitHubObjectDeserialized = JsonConvert.DeserializeObject<GitHubFileBase64>(ResponseStringJson);
                byte[] ContentFromBase64 = Convert.FromBase64String(GitHubObjectDeserialized.content);
                string DecodedContent = Encoding.UTF8.GetString(ContentFromBase64);
                return DecodedContent.Split(';').ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static string RecoverContentFromGitHub(string pathParam)
        {
            try
            {
                Client = new HttpClient()
                {
                    BaseAddress = new Uri($"{GitHubUrlApiBaseProject}{pathParam}")
                };
                AddGitHubHeaders();

                var ResponseStringJson = Client.GetStringAsync($"{GitHubUrlApiBaseProject}{pathParam}").GetAwaiter().GetResult();
                var GitHubObjectDeserialized = JsonConvert.DeserializeObject<GitHubFileBase64>(ResponseStringJson);
                byte[] ContentFromBase64 = Convert.FromBase64String(GitHubObjectDeserialized.content);
                return Encoding.UTF8.GetString(ContentFromBase64);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<string> CleanListName(this List<string> paramList)
        {
            for (int i = 0; i < paramList.Count; i++)
                paramList[i] = paramList[i].Replace("Tibia", "KNOXVILLE");

            for (int i = 0; i < paramList.Count; i++)
                paramList[i] = paramList[i].Replace("TIBIA", "KNOXVILLE");

            for (int i = 0; i < paramList.Count; i++)
                paramList[i] = paramList[i].Replace("tibia", "KNOXVILLE");

            return paramList;
        }
        
        public static string FormatAuctionDateFromEntity(string entityAuctionDate, int format)
        {
            try
            {
                entityAuctionDate = entityAuctionDate.Replace("&#160;", " ");

                LocationTimeFormat location = DictionaryDateFormat
                    .Where(w => w.Key == format)
                    .Select(s => s.Value)
                    .FirstOrDefault();

                return DateTime.ParseExact(entityAuctionDate,
                                                    formats,
                                                    CultureInfo.InvariantCulture,
                                                    DateTimeStyles.None).AddHours(location.AddHours).ToString(location.DateFormat);
            }
            catch (Exception ex)
            {
                return AnalyseException(ex);
            }
        }

        public static void UpdateComponentEnable(dynamic component, bool enableParameter)
        {
            component.Invoke((MethodInvoker)delegate
            {
                component.Enabled = enableParameter;
            });
        }

        public static void UpdateComponentValue(dynamic component, dynamic value)
        {
            component.Invoke((MethodInvoker)delegate
            {
                component.Value = value;
            });
        }

        public static void UpdateComponentText(dynamic component, dynamic text)
        {
            component.Invoke((MethodInvoker)delegate
            {
                component.Text = text.ToString();
            });
        }

        public static void UpdateComponentDataSource(dynamic component, dynamic dataSource)
        {
            component.Invoke((MethodInvoker)delegate
            {
                component.DataSource = dataSource;
            });
        }

        public static void UpdateComponentImage(dynamic component, dynamic image)
        {
            component.Invoke((MethodInvoker)delegate
            {
                component.Image = image;
            });
        }

        public static void ResizeDtaGrdView(DataTable dtParam, DataGridView dtaGrdViewParam)
        {
            for (int i = 0; i <= dtaGrdViewParam.Columns.Count - 1; i++)
                dtaGrdViewParam.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            for (int i = 0; i <= dtaGrdViewParam.Columns.Count - 1; i++)
            {
                int colw = dtaGrdViewParam.Columns[i].Width;
                dtaGrdViewParam.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dtaGrdViewParam.Columns[i].Width = colw;
            }
        }

        public static dynamic GetControlByName(dynamic controls, string controlName)
        {
            foreach (var item in controls)
                if (item.Name.Equals(controlName))
                    return item;

            return null;
        }

        public static string GetDateFormatFromKey(int keyParam)
        {
            return DictionaryDateFormat.Where(w => w.Key == keyParam)
                .Select(s => s.Value.DateFormat)
                .FirstOrDefault();
        }
    }


    public class LocationTimeFormat
    {
        public string DateFormat;
        public int AddHours;

        public LocationTimeFormat(string formatParam, int hoursParam)
        {
            this.DateFormat = formatParam;
            this.AddHours = hoursParam;
        }
    }
}
