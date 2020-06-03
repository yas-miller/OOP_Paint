using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using PluginBase;

namespace BaseProject
{
    class CustomSerializer
    {
        private static string fileName = "Serialization.txt";
        private static string dirName = "SerializationDirectory";
        private static string filePath = dirName + "/" + fileName;

        private static CustomSerializer instance;

        private CustomSerializer()
        {

        }

        public static CustomSerializer GetInstance
        {
            get { return instance ?? (instance = new CustomSerializer()); }
        }

        static Dictionary<string, string> GetDictionary(object obj)
        {
            return obj.GetType().GetProperties().ToDictionary(p => p.Name, p => p.GetValue(obj)?.ToString());
        }

        public void Serialize(Collection collection)
        {
            if (!Directory.Exists(dirName))
            {
                Directory.CreateDirectory(dirName);
            }

            

            using (File.Create(filePath))
            {
            
            }

            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                foreach (var shape in collection.collection)
                {
                    streamWriter.WriteLine(shape.GetType().FullName);

                    foreach (var value in GetDictionary(shape))
                    {
                        streamWriter.WriteLine(value.Value);
                    }
                }
            }

            
        }

        public Collection Deserialize(List<AbstractPlugin> plugins)
        {
            Collection ansCollection = new Collection();

            try
            {
                using (StreamReader streamReader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        var type = Type.GetType(line);
                        if (type == null)
                        {
                            foreach (var plugin in plugins)
                            {
                                if (plugin.GetType().ToString() == line)
                                {
                                    type = plugin.GetType();
                                    break;
                                }
                            }
                        }

                        int i = 0;
                        Object[] temp = new object[10];

                        while ((line = streamReader.ReadLine()) != "System.Drawing.Drawing2D.GraphicsPath")
                        {
                            temp[i++] = int.Parse(line);
                        }

                        Object[] args = new object[i];
                        Array.Copy(temp, args, i);

                        var template = Activator.CreateInstance(type, args);
                        ansCollection.collection.Add(template);

                        streamReader.ReadLine();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show(e.Message);
            }
            
            return ansCollection;
        }
    }
}
