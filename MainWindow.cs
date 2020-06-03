using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using PluginBase;
using static BaseProject.Verification;

namespace BaseProject
{
    public partial class Paint : Form
    {
        Collection collection = new Collection();
        List<AbstractPlugin> plugins;
        Object archiver; // Archiver
        private readonly CustomSerializer formatter = CustomSerializer.GetInstance;
        
        private void LoadPlugins(string path)
        {
            string[] pluginFiles = Directory.GetFiles(path, "*.dll");
            plugins = new List<AbstractPlugin>();

            foreach (string pluginPath in pluginFiles)
            {       
                try
                {
                    Assembly assembly = Assembly.LoadFrom(pluginPath);
                    Type[] objType = assembly.GetTypes();

                    foreach (var type in objType)
                    {
                        if (type.IsSubclassOf(typeof(AbstractPlugin)))
                        {
                            if (type.FullName == "PluginArchiver.Archiver")
                            {
                                if (archiver == null)
                                {
                                    archiver = assembly.CreateInstance("PluginArchiver.Archiver");
                                    pluginsList.Items.Add("Archiver").SubItems.Add(isSignedPlugin(assembly).ToString());
                                    continue;
                                }
                            }
                            if (type.FullName == "PartnerArchiver.PartnerAdapter")
                            {
                                if (archiver == null)
                                {
                                    archiver = assembly.CreateInstance("PartnerArchiver.Archiver");
                                    pluginsList.Items.Add("Archiver").SubItems.Add(isSignedPlugin(assembly).ToString());
                                    continue;
                                }
                            }
                            if (type.FullName == "PartnerArchiver.Archiver")
                            {
                                continue;
                            }
                            else
                            {
                                var plugin = (AbstractPlugin)Activator.CreateInstance(type);
                                plugins.Add(plugin);
                                pluginsList.Items.Add(plugin.ToString()).SubItems.Add(isSignedPlugin(assembly).ToString());
                            }
                        }
                    }
                }
                catch
                {
                    continue;
                }
            }
        }

        private void button_Reload_Click(object sender, EventArgs e)
        {
            plugins.Clear();
            pluginsList.Items.Clear();
            archiver = null;
            LoadPlugins(Application.StartupPath);
        }

        public Paint()
        {
            InitializeComponent();
            ThisAppStrongName = GetStrongName(Assembly.GetExecutingAssembly());
            this.LoadPlugins(Application.StartupPath);
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void button_Draw_Click(object sender, EventArgs e)
        {
            collection.DrawAll(pictureBox1);
        }

        private void button_clear_list_Click(object sender, EventArgs e)
        {
            collection.collection.Clear();
            FiguresList.Items.Clear();
        }

        private void FiguresList_DoubleClick(object sender, EventArgs e)
        {
            if (FiguresList.SelectedIndex >= 0)
            {
                dynamic figure = FiguresList.SelectedItem;
                FigureParameters form = new FigureParameters(figure);
                form.ShowDialog();
                FiguresList.Refresh();
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (FiguresList.SelectedIndex >= 0)
            {
                collection.collection.RemoveAt(FiguresList.SelectedIndex);
                FiguresList.Items.RemoveAt(FiguresList.SelectedIndex);
            }
        }

        private void pluginsList_DoubleClick_1(object sender, EventArgs e)
        {
            if (pluginsList.SelectedIndices.Count > 0)
            {
                foreach (var plugin in plugins)
                {
                    if (plugin.ToString() == pluginsList.SelectedItems[0].Text)
                    {
                        dynamic figure = plugin.Clone();
                        FigureParameters form = new FigureParameters(figure);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            collection.collection.Add(figure);
                            FiguresList.Items.Add(figure);
                        }
                        break;
                    }

                    if (pluginsList.SelectedItems[0].Text == "Archiver")
                    {
                        Archiver form = new Archiver(archiver);
                        form.Show();
                        break;
                    }
                }
            }
        }

        private void button_archive_Click(object sender, EventArgs e)
        {
            if (archiver == null)
            {
                try
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog()
                    {
                        Filter = "DLL Файл|*.dll"
                    };
                    openFileDialog.ShowDialog();
                    Assembly assembly = Assembly.LoadFrom(openFileDialog.FileName);
                    Type[] objType = assembly.GetTypes();

                    foreach (var type in objType)
                    {
                        if (type.FullName == "PartnerArchiver.PartnerAdapter")
                        {
                            archiver = assembly.CreateInstance("PartnerArchiver.PartnerAdapter");
                            pluginsList.Items.Add("Archiver").SubItems.Add(isSignedPlugin(assembly).ToString());
                            break;
                        }
                        if (type.FullName == "PluginArchiver.Archiver")
                        {
                            archiver = assembly.CreateInstance("PluginArchiver.Archiver");
                            pluginsList.Items.Add("Archiver").SubItems.Add(isSignedPlugin(assembly).ToString());
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                catch
                {
                    archiver = null;
                }
            }
            else
            {
                MessageBox.Show("Архиватор уже был загружен!");
            }
        }

        private void button_serialize_Click(object sender, EventArgs e)
        {
            formatter.Serialize(collection);
        }

        private void button_deserialize_Click(object sender, EventArgs e)
        {
            FiguresList.Items.Clear();
            collection.collection.Clear();

            collection = formatter.Deserialize(plugins);
            foreach (var name in collection.collection)
            {
                FiguresList.Items.Add(name);
            }
        }

        private void button_adapter_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "DLL Файл|*.dll"
                };
                openFileDialog.ShowDialog();
                Assembly assembly = Assembly.LoadFrom(openFileDialog.FileName);
                Type[] types = assembly.GetTypes();

                foreach (var type in types)
                {
                    if (type.Name == "PartnerAdapter")
                    {
                        var plugin = Activator.CreateInstance(type);
                        pluginsList.Items.Add(plugin.ToString()).SubItems.Add(isSignedPlugin(assembly).ToString());
                    }
                    else
                    {
                        continue;
                    } 
                }
            }
            catch
            {
            
            }
        }
    }
}
