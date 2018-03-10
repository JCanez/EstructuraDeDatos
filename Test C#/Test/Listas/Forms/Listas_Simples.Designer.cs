namespace Test.Listas.Forms
{
    partial class Listas_Simples
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
            this.Pila_groupBox = new System.Windows.Forms.GroupBox();
            this.Vaciar_button = new System.Windows.Forms.Button();
            this.Imprimir_button = new System.Windows.Forms.Button();
            this.Extraer_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nuevo_Valor_Pila_textBox = new System.Windows.Forms.TextBox();
            this.Agregar_Valor_Lista_button = new System.Windows.Forms.Button();
            this.Pila_button = new System.Windows.Forms.Button();
            this.Cola_button = new System.Windows.Forms.Button();
            this.Cola_groupBox = new System.Windows.Forms.GroupBox();
            this.Vaciar_Cola_button = new System.Windows.Forms.Button();
            this.Imprimir_Cola_button = new System.Windows.Forms.Button();
            this.Extraer_Cola_button = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Nuevo_Valor_Cola_textBox = new System.Windows.Forms.TextBox();
            this.Agregar_Valor_Cola_button = new System.Windows.Forms.Button();
            this.Genericas_groupBox = new System.Windows.Forms.GroupBox();
            this.Intercambiar_Generica_button = new System.Windows.Forms.Button();
            this.Existe_Generico_button = new System.Windows.Forms.Button();
            this.Ordenada_Generico_button = new System.Windows.Forms.Button();
            this.Posicion_Mayor_Generico_button = new System.Windows.Forms.Button();
            this.Mayor_Valor_Generico_button = new System.Windows.Forms.Button();
            this.Borrar_Generico_button = new System.Windows.Forms.Button();
            this.Vacia_Generico_button = new System.Windows.Forms.Button();
            this.Imprimir_Generico_button = new System.Windows.Forms.Button();
            this.Extraer_Generico_button = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Posicion_Generica_label = new System.Windows.Forms.Label();
            this.Posicion_Generico_textBox = new System.Windows.Forms.TextBox();
            this.Valor_Generica_label = new System.Windows.Forms.Label();
            this.Valor_Generico_textBox = new System.Windows.Forms.TextBox();
            this.Agregar_Valor_Generico_button = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Genericas_button = new System.Windows.Forms.Button();
            this.Movimientos_Extras_button = new System.Windows.Forms.Button();
            this.Pila_groupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Cola_groupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Genericas_groupBox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pila_groupBox
            // 
            this.Pila_groupBox.Controls.Add(this.Vaciar_button);
            this.Pila_groupBox.Controls.Add(this.Imprimir_button);
            this.Pila_groupBox.Controls.Add(this.Extraer_button);
            this.Pila_groupBox.Controls.Add(this.groupBox2);
            this.Pila_groupBox.Enabled = false;
            this.Pila_groupBox.Location = new System.Drawing.Point(12, 83);
            this.Pila_groupBox.Name = "Pila_groupBox";
            this.Pila_groupBox.Size = new System.Drawing.Size(354, 121);
            this.Pila_groupBox.TabIndex = 0;
            this.Pila_groupBox.TabStop = false;
            this.Pila_groupBox.Text = "Pila";
            // 
            // Vaciar_button
            // 
            this.Vaciar_button.Location = new System.Drawing.Point(251, 82);
            this.Vaciar_button.Name = "Vaciar_button";
            this.Vaciar_button.Size = new System.Drawing.Size(86, 23);
            this.Vaciar_button.TabIndex = 5;
            this.Vaciar_button.Text = "Vaciar";
            this.Vaciar_button.UseVisualStyleBackColor = true;
            // 
            // Imprimir_button
            // 
            this.Imprimir_button.Location = new System.Drawing.Point(134, 82);
            this.Imprimir_button.Name = "Imprimir_button";
            this.Imprimir_button.Size = new System.Drawing.Size(87, 23);
            this.Imprimir_button.TabIndex = 4;
            this.Imprimir_button.Text = "Imprimir";
            this.Imprimir_button.UseVisualStyleBackColor = true;
            this.Imprimir_button.Click += new System.EventHandler(this.Imprimir_button_Click);
            // 
            // Extraer_button
            // 
            this.Extraer_button.Location = new System.Drawing.Point(14, 82);
            this.Extraer_button.Name = "Extraer_button";
            this.Extraer_button.Size = new System.Drawing.Size(87, 23);
            this.Extraer_button.TabIndex = 3;
            this.Extraer_button.Text = "Extraer";
            this.Extraer_button.UseVisualStyleBackColor = true;
            this.Extraer_button.Click += new System.EventHandler(this.Extraer_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Nuevo_Valor_Pila_textBox);
            this.groupBox2.Controls.Add(this.Agregar_Valor_Lista_button);
            this.groupBox2.Location = new System.Drawing.Point(37, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 57);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nuevo Valor";
            // 
            // Nuevo_Valor_Pila_textBox
            // 
            this.Nuevo_Valor_Pila_textBox.Location = new System.Drawing.Point(86, 21);
            this.Nuevo_Valor_Pila_textBox.Name = "Nuevo_Valor_Pila_textBox";
            this.Nuevo_Valor_Pila_textBox.Size = new System.Drawing.Size(100, 20);
            this.Nuevo_Valor_Pila_textBox.TabIndex = 1;
            this.Nuevo_Valor_Pila_textBox.Tag = "";
            // 
            // Agregar_Valor_Lista_button
            // 
            this.Agregar_Valor_Lista_button.Location = new System.Drawing.Point(192, 20);
            this.Agregar_Valor_Lista_button.Name = "Agregar_Valor_Lista_button";
            this.Agregar_Valor_Lista_button.Size = new System.Drawing.Size(75, 23);
            this.Agregar_Valor_Lista_button.TabIndex = 0;
            this.Agregar_Valor_Lista_button.Text = "Agregar";
            this.Agregar_Valor_Lista_button.UseVisualStyleBackColor = true;
            this.Agregar_Valor_Lista_button.Click += new System.EventHandler(this.Agregar_Valor_Lista_button_Click);
            // 
            // Pila_button
            // 
            this.Pila_button.Location = new System.Drawing.Point(15, 25);
            this.Pila_button.Name = "Pila_button";
            this.Pila_button.Size = new System.Drawing.Size(86, 23);
            this.Pila_button.TabIndex = 0;
            this.Pila_button.Text = "Pila";
            this.Pila_button.UseVisualStyleBackColor = true;
            this.Pila_button.Click += new System.EventHandler(this.Pila_button_Click);
            // 
            // Cola_button
            // 
            this.Cola_button.Location = new System.Drawing.Point(134, 25);
            this.Cola_button.Name = "Cola_button";
            this.Cola_button.Size = new System.Drawing.Size(87, 23);
            this.Cola_button.TabIndex = 2;
            this.Cola_button.Text = "Cola";
            this.Cola_button.UseVisualStyleBackColor = true;
            this.Cola_button.Click += new System.EventHandler(this.Cola_button_Click);
            // 
            // Cola_groupBox
            // 
            this.Cola_groupBox.Controls.Add(this.Vaciar_Cola_button);
            this.Cola_groupBox.Controls.Add(this.Imprimir_Cola_button);
            this.Cola_groupBox.Controls.Add(this.Extraer_Cola_button);
            this.Cola_groupBox.Controls.Add(this.groupBox3);
            this.Cola_groupBox.Enabled = false;
            this.Cola_groupBox.Location = new System.Drawing.Point(11, 210);
            this.Cola_groupBox.Name = "Cola_groupBox";
            this.Cola_groupBox.Size = new System.Drawing.Size(355, 121);
            this.Cola_groupBox.TabIndex = 6;
            this.Cola_groupBox.TabStop = false;
            this.Cola_groupBox.Text = "Cola";
            // 
            // Vaciar_Cola_button
            // 
            this.Vaciar_Cola_button.Location = new System.Drawing.Point(251, 82);
            this.Vaciar_Cola_button.Name = "Vaciar_Cola_button";
            this.Vaciar_Cola_button.Size = new System.Drawing.Size(87, 23);
            this.Vaciar_Cola_button.TabIndex = 5;
            this.Vaciar_Cola_button.Text = "¿Vacia?";
            this.Vaciar_Cola_button.UseVisualStyleBackColor = true;
            this.Vaciar_Cola_button.Click += new System.EventHandler(this.Vaciar_Cola_button_Click);
            // 
            // Imprimir_Cola_button
            // 
            this.Imprimir_Cola_button.Location = new System.Drawing.Point(136, 82);
            this.Imprimir_Cola_button.Name = "Imprimir_Cola_button";
            this.Imprimir_Cola_button.Size = new System.Drawing.Size(87, 23);
            this.Imprimir_Cola_button.TabIndex = 4;
            this.Imprimir_Cola_button.Text = "Imprimir";
            this.Imprimir_Cola_button.UseVisualStyleBackColor = true;
            this.Imprimir_Cola_button.Click += new System.EventHandler(this.Imprimir_Cola_button_Click);
            // 
            // Extraer_Cola_button
            // 
            this.Extraer_Cola_button.Location = new System.Drawing.Point(15, 82);
            this.Extraer_Cola_button.Name = "Extraer_Cola_button";
            this.Extraer_Cola_button.Size = new System.Drawing.Size(87, 23);
            this.Extraer_Cola_button.TabIndex = 3;
            this.Extraer_Cola_button.Text = "Extraer";
            this.Extraer_Cola_button.UseVisualStyleBackColor = true;
            this.Extraer_Cola_button.Click += new System.EventHandler(this.Extraer_Cola_button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.Nuevo_Valor_Cola_textBox);
            this.groupBox3.Controls.Add(this.Agregar_Valor_Cola_button);
            this.groupBox3.Location = new System.Drawing.Point(38, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 57);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Agregar Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nuevo Valor";
            // 
            // Nuevo_Valor_Cola_textBox
            // 
            this.Nuevo_Valor_Cola_textBox.Location = new System.Drawing.Point(86, 21);
            this.Nuevo_Valor_Cola_textBox.Name = "Nuevo_Valor_Cola_textBox";
            this.Nuevo_Valor_Cola_textBox.Size = new System.Drawing.Size(100, 20);
            this.Nuevo_Valor_Cola_textBox.TabIndex = 1;
            // 
            // Agregar_Valor_Cola_button
            // 
            this.Agregar_Valor_Cola_button.Location = new System.Drawing.Point(192, 20);
            this.Agregar_Valor_Cola_button.Name = "Agregar_Valor_Cola_button";
            this.Agregar_Valor_Cola_button.Size = new System.Drawing.Size(75, 23);
            this.Agregar_Valor_Cola_button.TabIndex = 0;
            this.Agregar_Valor_Cola_button.Text = "Agregar";
            this.Agregar_Valor_Cola_button.UseVisualStyleBackColor = true;
            this.Agregar_Valor_Cola_button.Click += new System.EventHandler(this.Agregar_Valor_Cola_button_Click);
            // 
            // Genericas_groupBox
            // 
            this.Genericas_groupBox.Controls.Add(this.Intercambiar_Generica_button);
            this.Genericas_groupBox.Controls.Add(this.Existe_Generico_button);
            this.Genericas_groupBox.Controls.Add(this.Ordenada_Generico_button);
            this.Genericas_groupBox.Controls.Add(this.Posicion_Mayor_Generico_button);
            this.Genericas_groupBox.Controls.Add(this.Mayor_Valor_Generico_button);
            this.Genericas_groupBox.Controls.Add(this.Borrar_Generico_button);
            this.Genericas_groupBox.Controls.Add(this.Vacia_Generico_button);
            this.Genericas_groupBox.Controls.Add(this.Imprimir_Generico_button);
            this.Genericas_groupBox.Controls.Add(this.Extraer_Generico_button);
            this.Genericas_groupBox.Controls.Add(this.groupBox4);
            this.Genericas_groupBox.Enabled = false;
            this.Genericas_groupBox.Location = new System.Drawing.Point(11, 337);
            this.Genericas_groupBox.Name = "Genericas_groupBox";
            this.Genericas_groupBox.Size = new System.Drawing.Size(355, 170);
            this.Genericas_groupBox.TabIndex = 7;
            this.Genericas_groupBox.TabStop = false;
            this.Genericas_groupBox.Text = "Genericas";
            // 
            // Intercambiar_Generica_button
            // 
            this.Intercambiar_Generica_button.Location = new System.Drawing.Point(252, 140);
            this.Intercambiar_Generica_button.Name = "Intercambiar_Generica_button";
            this.Intercambiar_Generica_button.Size = new System.Drawing.Size(86, 23);
            this.Intercambiar_Generica_button.TabIndex = 11;
            this.Intercambiar_Generica_button.Text = "¿Intercambiar?";
            this.Intercambiar_Generica_button.UseVisualStyleBackColor = true;
            this.Intercambiar_Generica_button.Click += new System.EventHandler(this.Intercambiar_Generica_button_Click);
            // 
            // Existe_Generico_button
            // 
            this.Existe_Generico_button.Location = new System.Drawing.Point(135, 141);
            this.Existe_Generico_button.Name = "Existe_Generico_button";
            this.Existe_Generico_button.Size = new System.Drawing.Size(87, 23);
            this.Existe_Generico_button.TabIndex = 10;
            this.Existe_Generico_button.Text = "Existe";
            this.Existe_Generico_button.UseVisualStyleBackColor = true;
            this.Existe_Generico_button.Click += new System.EventHandler(this.Existe_Generico_button_Click);
            // 
            // Ordenada_Generico_button
            // 
            this.Ordenada_Generico_button.Location = new System.Drawing.Point(15, 141);
            this.Ordenada_Generico_button.Name = "Ordenada_Generico_button";
            this.Ordenada_Generico_button.Size = new System.Drawing.Size(87, 23);
            this.Ordenada_Generico_button.TabIndex = 9;
            this.Ordenada_Generico_button.Text = "¿Ordenada?";
            this.Ordenada_Generico_button.UseVisualStyleBackColor = true;
            this.Ordenada_Generico_button.Click += new System.EventHandler(this.Ordenada_Generico_button_Click);
            // 
            // Posicion_Mayor_Generico_button
            // 
            this.Posicion_Mayor_Generico_button.Location = new System.Drawing.Point(252, 111);
            this.Posicion_Mayor_Generico_button.Name = "Posicion_Mayor_Generico_button";
            this.Posicion_Mayor_Generico_button.Size = new System.Drawing.Size(86, 23);
            this.Posicion_Mayor_Generico_button.TabIndex = 8;
            this.Posicion_Mayor_Generico_button.Text = "Posicion Mayor";
            this.Posicion_Mayor_Generico_button.UseVisualStyleBackColor = true;
            this.Posicion_Mayor_Generico_button.Click += new System.EventHandler(this.Posicion_Mayor_Generico_button_Click);
            // 
            // Mayor_Valor_Generico_button
            // 
            this.Mayor_Valor_Generico_button.Location = new System.Drawing.Point(135, 111);
            this.Mayor_Valor_Generico_button.Name = "Mayor_Valor_Generico_button";
            this.Mayor_Valor_Generico_button.Size = new System.Drawing.Size(87, 23);
            this.Mayor_Valor_Generico_button.TabIndex = 7;
            this.Mayor_Valor_Generico_button.Text = "Mayor Valor";
            this.Mayor_Valor_Generico_button.UseVisualStyleBackColor = true;
            this.Mayor_Valor_Generico_button.Click += new System.EventHandler(this.Mayor_Valor_Generico_button_Click);
            // 
            // Borrar_Generico_button
            // 
            this.Borrar_Generico_button.Location = new System.Drawing.Point(15, 111);
            this.Borrar_Generico_button.Name = "Borrar_Generico_button";
            this.Borrar_Generico_button.Size = new System.Drawing.Size(87, 23);
            this.Borrar_Generico_button.TabIndex = 6;
            this.Borrar_Generico_button.Text = "Borrar";
            this.Borrar_Generico_button.UseVisualStyleBackColor = true;
            this.Borrar_Generico_button.Click += new System.EventHandler(this.Borrar_Generico_button_Click);
            // 
            // Vacia_Generico_button
            // 
            this.Vacia_Generico_button.Location = new System.Drawing.Point(252, 82);
            this.Vacia_Generico_button.Name = "Vacia_Generico_button";
            this.Vacia_Generico_button.Size = new System.Drawing.Size(86, 23);
            this.Vacia_Generico_button.TabIndex = 5;
            this.Vacia_Generico_button.Text = "¿Vacia?";
            this.Vacia_Generico_button.UseVisualStyleBackColor = true;
            this.Vacia_Generico_button.Click += new System.EventHandler(this.Vacia_Generico_button_Click);
            // 
            // Imprimir_Generico_button
            // 
            this.Imprimir_Generico_button.Location = new System.Drawing.Point(135, 82);
            this.Imprimir_Generico_button.Name = "Imprimir_Generico_button";
            this.Imprimir_Generico_button.Size = new System.Drawing.Size(87, 23);
            this.Imprimir_Generico_button.TabIndex = 4;
            this.Imprimir_Generico_button.Text = "Imprimir";
            this.Imprimir_Generico_button.UseVisualStyleBackColor = true;
            this.Imprimir_Generico_button.Click += new System.EventHandler(this.Imprimir_Generico_button_Click);
            // 
            // Extraer_Generico_button
            // 
            this.Extraer_Generico_button.Location = new System.Drawing.Point(15, 82);
            this.Extraer_Generico_button.Name = "Extraer_Generico_button";
            this.Extraer_Generico_button.Size = new System.Drawing.Size(87, 23);
            this.Extraer_Generico_button.TabIndex = 3;
            this.Extraer_Generico_button.Text = "Extraer";
            this.Extraer_Generico_button.UseVisualStyleBackColor = true;
            this.Extraer_Generico_button.Click += new System.EventHandler(this.Extraer_Generico_button_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Movimientos_Extras_button);
            this.groupBox4.Controls.Add(this.Posicion_Generica_label);
            this.groupBox4.Controls.Add(this.Posicion_Generico_textBox);
            this.groupBox4.Controls.Add(this.Valor_Generica_label);
            this.groupBox4.Controls.Add(this.Valor_Generico_textBox);
            this.groupBox4.Controls.Add(this.Agregar_Valor_Generico_button);
            this.groupBox4.Location = new System.Drawing.Point(16, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(322, 57);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Agregar Valor";
            // 
            // Posicion_Generica_label
            // 
            this.Posicion_Generica_label.AutoSize = true;
            this.Posicion_Generica_label.Location = new System.Drawing.Point(100, 25);
            this.Posicion_Generica_label.Name = "Posicion_Generica_label";
            this.Posicion_Generica_label.Size = new System.Drawing.Size(47, 13);
            this.Posicion_Generica_label.TabIndex = 4;
            this.Posicion_Generica_label.Text = "Posicion";
            // 
            // Posicion_Generico_textBox
            // 
            this.Posicion_Generico_textBox.Location = new System.Drawing.Point(147, 21);
            this.Posicion_Generico_textBox.Name = "Posicion_Generico_textBox";
            this.Posicion_Generico_textBox.Size = new System.Drawing.Size(35, 20);
            this.Posicion_Generico_textBox.TabIndex = 3;
            // 
            // Valor_Generica_label
            // 
            this.Valor_Generica_label.AutoSize = true;
            this.Valor_Generica_label.Location = new System.Drawing.Point(7, 25);
            this.Valor_Generica_label.Name = "Valor_Generica_label";
            this.Valor_Generica_label.Size = new System.Drawing.Size(31, 13);
            this.Valor_Generica_label.TabIndex = 2;
            this.Valor_Generica_label.Text = "Valor";
            // 
            // Valor_Generico_textBox
            // 
            this.Valor_Generico_textBox.Location = new System.Drawing.Point(48, 21);
            this.Valor_Generico_textBox.Name = "Valor_Generico_textBox";
            this.Valor_Generico_textBox.Size = new System.Drawing.Size(45, 20);
            this.Valor_Generico_textBox.TabIndex = 1;
            // 
            // Agregar_Valor_Generico_button
            // 
            this.Agregar_Valor_Generico_button.Location = new System.Drawing.Point(193, 20);
            this.Agregar_Valor_Generico_button.Name = "Agregar_Valor_Generico_button";
            this.Agregar_Valor_Generico_button.Size = new System.Drawing.Size(75, 23);
            this.Agregar_Valor_Generico_button.TabIndex = 0;
            this.Agregar_Valor_Generico_button.Text = "Agregar";
            this.Agregar_Valor_Generico_button.UseVisualStyleBackColor = true;
            this.Agregar_Valor_Generico_button.Click += new System.EventHandler(this.Agregar_Valor_Generico_button_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Genericas_button);
            this.groupBox5.Controls.Add(this.Pila_button);
            this.groupBox5.Controls.Add(this.Cola_button);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(354, 65);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tipos";
            // 
            // Genericas_button
            // 
            this.Genericas_button.Location = new System.Drawing.Point(251, 25);
            this.Genericas_button.Name = "Genericas_button";
            this.Genericas_button.Size = new System.Drawing.Size(86, 23);
            this.Genericas_button.TabIndex = 3;
            this.Genericas_button.Text = "Genericas";
            this.Genericas_button.UseVisualStyleBackColor = true;
            this.Genericas_button.Click += new System.EventHandler(this.Genericas_button_Click);
            // 
            // Movimientos_Extras_button
            // 
            this.Movimientos_Extras_button.Location = new System.Drawing.Point(280, 21);
            this.Movimientos_Extras_button.Name = "Movimientos_Extras_button";
            this.Movimientos_Extras_button.Size = new System.Drawing.Size(28, 23);
            this.Movimientos_Extras_button.TabIndex = 5;
            this.Movimientos_Extras_button.Text = "E";
            this.Movimientos_Extras_button.UseVisualStyleBackColor = true;
            this.Movimientos_Extras_button.Click += new System.EventHandler(this.Movimientos_Extras_button_Click);
            // 
            // Listas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 519);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.Genericas_groupBox);
            this.Controls.Add(this.Cola_groupBox);
            this.Controls.Add(this.Pila_groupBox);
            this.Name = "Listas";
            this.Text = "Listas Simples";
            this.Pila_groupBox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Cola_groupBox.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Genericas_groupBox.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Pila_groupBox;
        private System.Windows.Forms.Button Vaciar_button;
        private System.Windows.Forms.Button Imprimir_button;
        private System.Windows.Forms.Button Extraer_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nuevo_Valor_Pila_textBox;
        private System.Windows.Forms.Button Agregar_Valor_Lista_button;
        private System.Windows.Forms.Button Pila_button;
        private System.Windows.Forms.Button Cola_button;
        private System.Windows.Forms.GroupBox Cola_groupBox;
        private System.Windows.Forms.Button Vaciar_Cola_button;
        private System.Windows.Forms.Button Imprimir_Cola_button;
        private System.Windows.Forms.Button Extraer_Cola_button;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nuevo_Valor_Cola_textBox;
        private System.Windows.Forms.Button Agregar_Valor_Cola_button;
        private System.Windows.Forms.GroupBox Genericas_groupBox;
        private System.Windows.Forms.Button Vacia_Generico_button;
        private System.Windows.Forms.Button Imprimir_Generico_button;
        private System.Windows.Forms.Button Extraer_Generico_button;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label Valor_Generica_label;
        private System.Windows.Forms.TextBox Valor_Generico_textBox;
        private System.Windows.Forms.Button Agregar_Valor_Generico_button;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Genericas_button;
        private System.Windows.Forms.Label Posicion_Generica_label;
        private System.Windows.Forms.TextBox Posicion_Generico_textBox;
        private System.Windows.Forms.Button Intercambiar_Generica_button;
        private System.Windows.Forms.Button Existe_Generico_button;
        private System.Windows.Forms.Button Ordenada_Generico_button;
        private System.Windows.Forms.Button Posicion_Mayor_Generico_button;
        private System.Windows.Forms.Button Mayor_Valor_Generico_button;
        private System.Windows.Forms.Button Borrar_Generico_button;
        private System.Windows.Forms.Button Movimientos_Extras_button;
    }
}