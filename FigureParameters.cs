using System;
using System.Reflection;
using System.Windows.Forms;
using PluginBase;

namespace BaseProject
{
    public partial class FigureParameters : Form
    {
        private const string LabelPostfix = "Label";
        private const string NumericUpDownPostfix = "NumericUpDown";

        private FigureParameters()
        {
            InitializeComponent();
            Cancel_button.Click += CancelButtonOnClick;
        }

        private void CancelButtonOnClick(object o, EventArgs eventArgs)
        {
            this.Close();
        }

        private void AddNumericUpDown(string name, int value)
        {
            NumericUpDown numericUpDown = new NumericUpDown
            {
                Name = name + NumericUpDownPostfix,
                Minimum = 0,
                Maximum = 500,
                Value = value
            };

            this.ElementsPanel.Controls.Add(numericUpDown);
        }

        private void AddLabel(string name)
        {
            Label label = new Label
            {
                Name = name + LabelPostfix,
                Text = name + ':'
            };

            this.ElementsPanel.Controls.Add(label);
        }

        public FigureParameters(AbstractPlugin figure) : this()
        {
            Type figureType = figure.GetType();

            foreach (PropertyInfo pi in figureType.GetProperties())
            {
                if (pi.Name != "GraphicsPath" && pi.Name != "Pen")
                {
                    this.AddLabel(pi.Name);
                    this.AddNumericUpDown(pi.Name, (int) pi.GetValue(figure));
                }
            }

            this.Draw_button.Click += (sender, args) =>
            {
                foreach (PropertyInfo pi in figureType.GetProperties())
                {
                    if (pi.Name != "GraphicsPath" && pi.Name != "Pen")
                    {
                        pi.SetValue(figure,
                            (int) (this.ElementsPanel.Controls[pi.Name + NumericUpDownPostfix] as NumericUpDown).Value);
                    }
                }

                this.DialogResult = DialogResult.OK;
            };
        }
    }
}
