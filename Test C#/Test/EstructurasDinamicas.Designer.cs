namespace Test
{
    partial class EstructurasDinamicas
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
            this.Listas_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Listas_button
            // 
            this.Listas_button.Location = new System.Drawing.Point(12, 12);
            this.Listas_button.Name = "Listas_button";
            this.Listas_button.Size = new System.Drawing.Size(75, 23);
            this.Listas_button.TabIndex = 0;
            this.Listas_button.Text = "Listas";
            this.Listas_button.UseVisualStyleBackColor = true;
            this.Listas_button.Click += new System.EventHandler(this.Listas_button_Click);
            // 
            // EstructurasDinamicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 261);
            this.Controls.Add(this.Listas_button);
            this.Name = "EstructurasDinamicas";
            this.Text = "Estructuras Dinamicas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Listas_button;
    }
}