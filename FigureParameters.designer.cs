namespace BaseProject
{
    partial class FigureParameters
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Draw_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.ElementsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // Draw_button
            // 
            this.Draw_button.Location = new System.Drawing.Point(258, 182);
            this.Draw_button.Margin = new System.Windows.Forms.Padding(4);
            this.Draw_button.Name = "Draw_button";
            this.Draw_button.Size = new System.Drawing.Size(100, 28);
            this.Draw_button.TabIndex = 12;
            this.Draw_button.Text = "Готово";
            this.Draw_button.UseVisualStyleBackColor = true;
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(379, 182);
            this.Cancel_button.Margin = new System.Windows.Forms.Padding(4);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(100, 28);
            this.Cancel_button.TabIndex = 13;
            this.Cancel_button.Text = "Отмена";
            this.Cancel_button.UseVisualStyleBackColor = true;
            // 
            // ElementsPanel
            // 
            this.ElementsPanel.ColumnCount = 4;
            this.ElementsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ElementsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.ElementsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ElementsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.ElementsPanel.Location = new System.Drawing.Point(6, 6);
            this.ElementsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ElementsPanel.Name = "ElementsPanel";
            this.ElementsPanel.RowCount = 4;
            this.ElementsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ElementsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ElementsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ElementsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ElementsPanel.Size = new System.Drawing.Size(729, 168);
            this.ElementsPanel.TabIndex = 18;
            // 
            // FigureParametrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 223);
            this.Controls.Add(this.ElementsPanel);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Draw_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(760, 270);
            this.Name = "FigureParametrs";
            this.Text = "Параметры объекта";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Draw_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.TableLayoutPanel ElementsPanel;
    }
}