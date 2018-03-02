namespace Test.Listas.Forms
{
    partial class Genericas_Otros_Movimientos
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
            this.label1 = new System.Windows.Forms.Label();
            this.Valor_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Insertar_Primera_Posicion_button = new System.Windows.Forms.Button();
            this.Insertar_Segunda_Posicion_button = new System.Windows.Forms.Button();
            this.Insertar_Antepenultima_Posicion_button = new System.Windows.Forms.Button();
            this.Insertar_Ultima_Posicion_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Valor_textBox
            // 
            this.Valor_textBox.Location = new System.Drawing.Point(19, 34);
            this.Valor_textBox.Name = "Valor_textBox";
            this.Valor_textBox.Size = new System.Drawing.Size(100, 20);
            this.Valor_textBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Insertar_Ultima_Posicion_button);
            this.groupBox1.Controls.Add(this.Insertar_Antepenultima_Posicion_button);
            this.groupBox1.Controls.Add(this.Insertar_Segunda_Posicion_button);
            this.groupBox1.Controls.Add(this.Insertar_Primera_Posicion_button);
            this.groupBox1.Controls.Add(this.Valor_textBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 192);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insertar";
            // 
            // Insertar_Primera_Posicion_button
            // 
            this.Insertar_Primera_Posicion_button.Location = new System.Drawing.Point(32, 60);
            this.Insertar_Primera_Posicion_button.Name = "Insertar_Primera_Posicion_button";
            this.Insertar_Primera_Posicion_button.Size = new System.Drawing.Size(138, 23);
            this.Insertar_Primera_Posicion_button.TabIndex = 2;
            this.Insertar_Primera_Posicion_button.Text = "Primera Posicion";
            this.Insertar_Primera_Posicion_button.UseVisualStyleBackColor = true;
            // 
            // Insertar_Segunda_Posicion_button
            // 
            this.Insertar_Segunda_Posicion_button.Location = new System.Drawing.Point(32, 89);
            this.Insertar_Segunda_Posicion_button.Name = "Insertar_Segunda_Posicion_button";
            this.Insertar_Segunda_Posicion_button.Size = new System.Drawing.Size(138, 23);
            this.Insertar_Segunda_Posicion_button.TabIndex = 3;
            this.Insertar_Segunda_Posicion_button.Text = "Segunda Posicion";
            this.Insertar_Segunda_Posicion_button.UseVisualStyleBackColor = true;
            // 
            // Insertar_Antepenultima_Posicion_button
            // 
            this.Insertar_Antepenultima_Posicion_button.Location = new System.Drawing.Point(32, 118);
            this.Insertar_Antepenultima_Posicion_button.Name = "Insertar_Antepenultima_Posicion_button";
            this.Insertar_Antepenultima_Posicion_button.Size = new System.Drawing.Size(138, 23);
            this.Insertar_Antepenultima_Posicion_button.TabIndex = 4;
            this.Insertar_Antepenultima_Posicion_button.Text = "Antepenultima Posicion";
            this.Insertar_Antepenultima_Posicion_button.UseVisualStyleBackColor = true;
            // 
            // Insertar_Ultima_Posicion_button
            // 
            this.Insertar_Ultima_Posicion_button.Location = new System.Drawing.Point(32, 147);
            this.Insertar_Ultima_Posicion_button.Name = "Insertar_Ultima_Posicion_button";
            this.Insertar_Ultima_Posicion_button.Size = new System.Drawing.Size(138, 23);
            this.Insertar_Ultima_Posicion_button.TabIndex = 5;
            this.Insertar_Ultima_Posicion_button.Text = "Ultima Posicion";
            this.Insertar_Ultima_Posicion_button.UseVisualStyleBackColor = true;
            // 
            // Genericas_Otros_Movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 387);
            this.Controls.Add(this.groupBox1);
            this.Name = "Genericas_Otros_Movimientos";
            this.Text = "Ultima Posicion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Valor_textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Insertar_Ultima_Posicion_button;
        private System.Windows.Forms.Button Insertar_Antepenultima_Posicion_button;
        private System.Windows.Forms.Button Insertar_Segunda_Posicion_button;
        private System.Windows.Forms.Button Insertar_Primera_Posicion_button;
    }
}