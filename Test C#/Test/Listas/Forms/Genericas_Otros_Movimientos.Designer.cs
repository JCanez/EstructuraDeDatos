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
            this.Insertar_Ultima_Posicion_button = new System.Windows.Forms.Button();
            this.Insertar_Antepenultima_Posicion_button = new System.Windows.Forms.Button();
            this.Insertar_Segunda_Posicion_button = new System.Windows.Forms.Button();
            this.Insertar_Primera_Posicion_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Borrar_Nodo_Mayor_button = new System.Windows.Forms.Button();
            this.Borrar_Segunda_Posicion_button = new System.Windows.Forms.Button();
            this.Borrar_Primera_Posicion_button = new System.Windows.Forms.Button();
            this.Borrar_Ultima_Posicion_button = new System.Windows.Forms.Button();
            this.Cerrar_button = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Ordenar_Menor_Mayor_button = new System.Windows.Forms.Button();
            this.Ordenar_Mayor_Menor_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor";
            // 
            // Valor_textBox
            // 
            this.Valor_textBox.Location = new System.Drawing.Point(27, 34);
            this.Valor_textBox.Name = "Valor_textBox";
            this.Valor_textBox.Size = new System.Drawing.Size(100, 20);
            this.Valor_textBox.TabIndex = 1;
            this.Valor_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Valor_textBox_KeyPress);
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
            this.groupBox1.Size = new System.Drawing.Size(154, 179);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insertar";
            // 
            // Insertar_Ultima_Posicion_button
            // 
            this.Insertar_Ultima_Posicion_button.Location = new System.Drawing.Point(8, 147);
            this.Insertar_Ultima_Posicion_button.Name = "Insertar_Ultima_Posicion_button";
            this.Insertar_Ultima_Posicion_button.Size = new System.Drawing.Size(138, 23);
            this.Insertar_Ultima_Posicion_button.TabIndex = 5;
            this.Insertar_Ultima_Posicion_button.Text = "Ultima Posicion";
            this.Insertar_Ultima_Posicion_button.UseVisualStyleBackColor = true;
            this.Insertar_Ultima_Posicion_button.Click += new System.EventHandler(this.Insertar_Ultima_Posicion_button_Click);
            // 
            // Insertar_Antepenultima_Posicion_button
            // 
            this.Insertar_Antepenultima_Posicion_button.Location = new System.Drawing.Point(8, 118);
            this.Insertar_Antepenultima_Posicion_button.Name = "Insertar_Antepenultima_Posicion_button";
            this.Insertar_Antepenultima_Posicion_button.Size = new System.Drawing.Size(138, 23);
            this.Insertar_Antepenultima_Posicion_button.TabIndex = 4;
            this.Insertar_Antepenultima_Posicion_button.Text = "Antepenultima Posicion";
            this.Insertar_Antepenultima_Posicion_button.UseVisualStyleBackColor = true;
            this.Insertar_Antepenultima_Posicion_button.Click += new System.EventHandler(this.Insertar_Antepenultima_Posicion_button_Click);
            // 
            // Insertar_Segunda_Posicion_button
            // 
            this.Insertar_Segunda_Posicion_button.Location = new System.Drawing.Point(8, 89);
            this.Insertar_Segunda_Posicion_button.Name = "Insertar_Segunda_Posicion_button";
            this.Insertar_Segunda_Posicion_button.Size = new System.Drawing.Size(138, 23);
            this.Insertar_Segunda_Posicion_button.TabIndex = 3;
            this.Insertar_Segunda_Posicion_button.Text = "Segunda Posicion";
            this.Insertar_Segunda_Posicion_button.UseVisualStyleBackColor = true;
            this.Insertar_Segunda_Posicion_button.Click += new System.EventHandler(this.Insertar_Segunda_Posicion_button_Click);
            // 
            // Insertar_Primera_Posicion_button
            // 
            this.Insertar_Primera_Posicion_button.Location = new System.Drawing.Point(8, 60);
            this.Insertar_Primera_Posicion_button.Name = "Insertar_Primera_Posicion_button";
            this.Insertar_Primera_Posicion_button.Size = new System.Drawing.Size(138, 23);
            this.Insertar_Primera_Posicion_button.TabIndex = 2;
            this.Insertar_Primera_Posicion_button.Text = "Primera Posicion";
            this.Insertar_Primera_Posicion_button.UseVisualStyleBackColor = true;
            this.Insertar_Primera_Posicion_button.Click += new System.EventHandler(this.Insertar_Primera_Posicion_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Borrar_Nodo_Mayor_button);
            this.groupBox2.Controls.Add(this.Borrar_Segunda_Posicion_button);
            this.groupBox2.Controls.Add(this.Borrar_Primera_Posicion_button);
            this.groupBox2.Controls.Add(this.Borrar_Ultima_Posicion_button);
            this.groupBox2.Location = new System.Drawing.Point(12, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 136);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Borrar";
            // 
            // Borrar_Nodo_Mayor_button
            // 
            this.Borrar_Nodo_Mayor_button.Location = new System.Drawing.Point(8, 106);
            this.Borrar_Nodo_Mayor_button.Name = "Borrar_Nodo_Mayor_button";
            this.Borrar_Nodo_Mayor_button.Size = new System.Drawing.Size(138, 23);
            this.Borrar_Nodo_Mayor_button.TabIndex = 4;
            this.Borrar_Nodo_Mayor_button.Text = "Nodo Mayor";
            this.Borrar_Nodo_Mayor_button.UseVisualStyleBackColor = true;
            this.Borrar_Nodo_Mayor_button.Click += new System.EventHandler(this.Borrar_Nodo_Mayor_button_Click);
            // 
            // Borrar_Segunda_Posicion_button
            // 
            this.Borrar_Segunda_Posicion_button.Location = new System.Drawing.Point(8, 48);
            this.Borrar_Segunda_Posicion_button.Name = "Borrar_Segunda_Posicion_button";
            this.Borrar_Segunda_Posicion_button.Size = new System.Drawing.Size(138, 23);
            this.Borrar_Segunda_Posicion_button.TabIndex = 3;
            this.Borrar_Segunda_Posicion_button.Text = "Segunda Posicion";
            this.Borrar_Segunda_Posicion_button.UseVisualStyleBackColor = true;
            this.Borrar_Segunda_Posicion_button.Click += new System.EventHandler(this.Borrar_Segunda_Posicion_button_Click);
            // 
            // Borrar_Primera_Posicion_button
            // 
            this.Borrar_Primera_Posicion_button.Location = new System.Drawing.Point(8, 19);
            this.Borrar_Primera_Posicion_button.Name = "Borrar_Primera_Posicion_button";
            this.Borrar_Primera_Posicion_button.Size = new System.Drawing.Size(138, 23);
            this.Borrar_Primera_Posicion_button.TabIndex = 2;
            this.Borrar_Primera_Posicion_button.Text = "Primera Posicion";
            this.Borrar_Primera_Posicion_button.UseVisualStyleBackColor = true;
            this.Borrar_Primera_Posicion_button.Click += new System.EventHandler(this.Borrar_Primera_Posicion_button_Click);
            // 
            // Borrar_Ultima_Posicion_button
            // 
            this.Borrar_Ultima_Posicion_button.Location = new System.Drawing.Point(8, 77);
            this.Borrar_Ultima_Posicion_button.Name = "Borrar_Ultima_Posicion_button";
            this.Borrar_Ultima_Posicion_button.Size = new System.Drawing.Size(138, 23);
            this.Borrar_Ultima_Posicion_button.TabIndex = 5;
            this.Borrar_Ultima_Posicion_button.Text = "Ultima Posicion";
            this.Borrar_Ultima_Posicion_button.UseVisualStyleBackColor = true;
            this.Borrar_Ultima_Posicion_button.Click += new System.EventHandler(this.Borrar_Ultima_Posicion_button_Click);
            // 
            // Cerrar_button
            // 
            this.Cerrar_button.Location = new System.Drawing.Point(51, 427);
            this.Cerrar_button.Name = "Cerrar_button";
            this.Cerrar_button.Size = new System.Drawing.Size(75, 23);
            this.Cerrar_button.TabIndex = 7;
            this.Cerrar_button.Text = "Cerrar";
            this.Cerrar_button.UseVisualStyleBackColor = true;
            this.Cerrar_button.Click += new System.EventHandler(this.Cerrar_button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Ordenar_Menor_Mayor_button);
            this.groupBox3.Controls.Add(this.Ordenar_Mayor_Menor_button);
            this.groupBox3.Location = new System.Drawing.Point(12, 339);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(154, 82);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ordenar";
            // 
            // Ordenar_Menor_Mayor_button
            // 
            this.Ordenar_Menor_Mayor_button.Location = new System.Drawing.Point(8, 49);
            this.Ordenar_Menor_Mayor_button.Name = "Ordenar_Menor_Mayor_button";
            this.Ordenar_Menor_Mayor_button.Size = new System.Drawing.Size(138, 23);
            this.Ordenar_Menor_Mayor_button.TabIndex = 3;
            this.Ordenar_Menor_Mayor_button.Text = "Menor a Mayor";
            this.Ordenar_Menor_Mayor_button.UseVisualStyleBackColor = true;
            this.Ordenar_Menor_Mayor_button.Click += new System.EventHandler(this.Ordenar_Menor_Mayor_button_Click);
            // 
            // Ordenar_Mayor_Menor_button
            // 
            this.Ordenar_Mayor_Menor_button.Location = new System.Drawing.Point(8, 19);
            this.Ordenar_Mayor_Menor_button.Name = "Ordenar_Mayor_Menor_button";
            this.Ordenar_Mayor_Menor_button.Size = new System.Drawing.Size(138, 23);
            this.Ordenar_Mayor_Menor_button.TabIndex = 2;
            this.Ordenar_Mayor_Menor_button.Text = "Mayor a Menor";
            this.Ordenar_Mayor_Menor_button.UseVisualStyleBackColor = true;
            this.Ordenar_Mayor_Menor_button.Click += new System.EventHandler(this.Ordenar_Mayor_Menor_button_Click);
            // 
            // Genericas_Otros_Movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 456);
            this.Controls.Add(this.Cerrar_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Genericas_Otros_Movimientos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Borrar_Ultima_Posicion_button;
        private System.Windows.Forms.Button Borrar_Nodo_Mayor_button;
        private System.Windows.Forms.Button Borrar_Segunda_Posicion_button;
        private System.Windows.Forms.Button Borrar_Primera_Posicion_button;
        private System.Windows.Forms.Button Cerrar_button;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Ordenar_Menor_Mayor_button;
        private System.Windows.Forms.Button Ordenar_Mayor_Menor_button;
    }
}