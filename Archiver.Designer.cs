namespace BaseProject
{
    partial class Archiver
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
            this.button_de = new System.Windows.Forms.Button();
            this.button_arch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_de
            // 
            this.button_de.Location = new System.Drawing.Point(27, 51);
            this.button_de.Name = "button_de";
            this.button_de.Size = new System.Drawing.Size(127, 33);
            this.button_de.TabIndex = 0;
            this.button_de.Text = "Разархивировать";
            this.button_de.UseVisualStyleBackColor = true;
            this.button_de.Click += new System.EventHandler(this.button_de_Click);
            // 
            // button_arch
            // 
            this.button_arch.Location = new System.Drawing.Point(27, 12);
            this.button_arch.Name = "button_arch";
            this.button_arch.Size = new System.Drawing.Size(127, 33);
            this.button_arch.TabIndex = 1;
            this.button_arch.Text = "Архивировать";
            this.button_arch.UseVisualStyleBackColor = true;
            this.button_arch.Click += new System.EventHandler(this.button_arch_Click);
            // 
            // Archiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 106);
            this.Controls.Add(this.button_arch);
            this.Controls.Add(this.button_de);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(195, 145);
            this.Name = "Archiver";
            this.Text = "Архиватор";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_de;
        private System.Windows.Forms.Button button_arch;
    }
}