using System;
using System.Reflection;
using System.Windows.Forms;

namespace BaseProject
{
    public partial class Archiver : Form
    {
        Object[] str = new Object[1];
        Object o;
        public Archiver(Object obj)
        {
            o = obj;
            InitializeComponent();
        }

        private void button_arch_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog openFolderDialog = new FolderBrowserDialog();
                openFolderDialog.SelectedPath = AppDomain.CurrentDomain.BaseDirectory;
                if (openFolderDialog.ShowDialog() == DialogResult.OK)
                {
                    var args = new Type[1];
                    args[0] = Type.GetType("System.String");
                    MethodInfo Create = o.GetType().GetMethod("Create", args);
                    str[0] = openFolderDialog.SelectedPath;
                    Create.Invoke(o, str);
                }    
            }
            catch
            {

            }
            this.Close();
        }

        private void button_de_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog()
                {
                    Filter = "ZIP Файл|*.zip"
                };
                openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var args = new Type[1];
                    args[0] = Type.GetType("System.String");
                    MethodInfo Read = o.GetType().GetMethod("Read", args);
                    str[0] = openFileDialog.FileName;
                    Read.Invoke(o, str);
                }   
            }
            catch
            {

            }
            this.Close();
        }
    }
}
