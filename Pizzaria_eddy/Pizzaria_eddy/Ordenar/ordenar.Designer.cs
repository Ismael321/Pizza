﻿namespace Pizzaria_eddy.Ordenar
{
    partial class ordenar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ordenar));
            this.L_tamano = new System.Windows.Forms.Label();
            this.Box_tamano = new System.Windows.Forms.ComboBox();
            this.CBIngredientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.L_ingrediente_1 = new System.Windows.Forms.Label();
            this.L_Ingrediente_2 = new System.Windows.Forms.Label();
            this.L_Ingrediente_3 = new System.Windows.Forms.Label();
            this.B_ingrediente_1 = new System.Windows.Forms.ComboBox();
            this.B_ingrediente_2 = new System.Windows.Forms.ComboBox();
            this.B_Ingrediente_3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBSabor = new System.Windows.Forms.ComboBox();
            this.CBTamano = new System.Windows.Forms.ComboBox();
            this.CBCantidad = new System.Windows.Forms.ComboBox();
            this.TB_total = new System.Windows.Forms.TextBox();
            this.Lb_Total = new System.Windows.Forms.Label();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonRegresar = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
=======
            this.radioButtonSi = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
>>>>>>> c508d6ca23886589d81186637845dfdea1be46dc
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // L_tamano
            // 
            this.L_tamano.AutoSize = true;
            this.L_tamano.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_tamano.Location = new System.Drawing.Point(425, 68);
            this.L_tamano.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_tamano.Name = "L_tamano";
            this.L_tamano.Size = new System.Drawing.Size(154, 19);
            this.L_tamano.TabIndex = 0;
            this.L_tamano.Text = "Seleccione el Tamaño";
            // 
            // Box_tamano
            // 
            this.Box_tamano.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_tamano.FormattingEnabled = true;
            this.Box_tamano.Items.AddRange(new object[] {
            "Chica",
            "Mediana ",
            "Grande ",
            "Familiar"});
            this.Box_tamano.Location = new System.Drawing.Point(424, 103);
            this.Box_tamano.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Box_tamano.Name = "Box_tamano";
            this.Box_tamano.Size = new System.Drawing.Size(171, 27);
            this.Box_tamano.TabIndex = 1;
            this.Box_tamano.Text = "     Seleccione Una Opcion";
            // 
            // CBIngredientes
            // 
            this.CBIngredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBIngredientes.FormattingEnabled = true;
            this.CBIngredientes.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
<<<<<<< HEAD
            this.comboBox1.Location = new System.Drawing.Point(329, 218);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(91, 23);
            this.comboBox1.TabIndex = 2;
=======
            this.CBIngredientes.Location = new System.Drawing.Point(148, 178);
            this.CBIngredientes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CBIngredientes.Name = "CBIngredientes";
            this.CBIngredientes.Size = new System.Drawing.Size(48, 23);
            this.CBIngredientes.TabIndex = 2;
            this.CBIngredientes.SelectedIndexChanged += new System.EventHandler(this.CBIngredientes_SelectedIndexChanged);
>>>>>>> c508d6ca23886589d81186637845dfdea1be46dc
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingredientes";
            // 
            // L_ingrediente_1
            // 
            this.L_ingrediente_1.AutoSize = true;
            this.L_ingrediente_1.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_ingrediente_1.Location = new System.Drawing.Point(259, 270);
            this.L_ingrediente_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_ingrediente_1.Name = "L_ingrediente_1";
            this.L_ingrediente_1.Size = new System.Drawing.Size(93, 18);
            this.L_ingrediente_1.TabIndex = 4;
            this.L_ingrediente_1.Text = "Ingrediente 1";
            // 
            // L_Ingrediente_2
            // 
            this.L_Ingrediente_2.AutoSize = true;
            this.L_Ingrediente_2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Ingrediente_2.Location = new System.Drawing.Point(464, 269);
            this.L_Ingrediente_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_Ingrediente_2.Name = "L_Ingrediente_2";
            this.L_Ingrediente_2.Size = new System.Drawing.Size(98, 19);
            this.L_Ingrediente_2.TabIndex = 5;
            this.L_Ingrediente_2.Text = "Ingrediente 2";
            // 
            // L_Ingrediente_3
            // 
            this.L_Ingrediente_3.AutoSize = true;
            this.L_Ingrediente_3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Ingrediente_3.Location = new System.Drawing.Point(656, 269);
            this.L_Ingrediente_3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_Ingrediente_3.Name = "L_Ingrediente_3";
            this.L_Ingrediente_3.Size = new System.Drawing.Size(98, 19);
            this.L_Ingrediente_3.TabIndex = 6;
            this.L_Ingrediente_3.Text = "Ingrediente 3";
            // 
            // B_ingrediente_1
            // 
            this.B_ingrediente_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_ingrediente_1.FormattingEnabled = true;
            this.B_ingrediente_1.Location = new System.Drawing.Point(240, 295);
            this.B_ingrediente_1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.B_ingrediente_1.Name = "B_ingrediente_1";
            this.B_ingrediente_1.Size = new System.Drawing.Size(120, 23);
            this.B_ingrediente_1.TabIndex = 7;
            // 
            // B_ingrediente_2
            // 
            this.B_ingrediente_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_ingrediente_2.FormattingEnabled = true;
            this.B_ingrediente_2.Location = new System.Drawing.Point(448, 295);
            this.B_ingrediente_2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.B_ingrediente_2.Name = "B_ingrediente_2";
            this.B_ingrediente_2.Size = new System.Drawing.Size(114, 23);
            this.B_ingrediente_2.TabIndex = 8;
            // 
            // B_Ingrediente_3
            // 
            this.B_Ingrediente_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Ingrediente_3.FormattingEnabled = true;
            this.B_Ingrediente_3.Location = new System.Drawing.Point(647, 295);
            this.B_Ingrediente_3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.B_Ingrediente_3.Name = "B_Ingrediente_3";
            this.B_Ingrediente_3.Size = new System.Drawing.Size(117, 23);
            this.B_Ingrediente_3.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 349);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Refresco";
            // 
            // CBSabor
            // 
            this.CBSabor.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBSabor.FormattingEnabled = true;
            this.CBSabor.Items.AddRange(new object[] {
            "Coca-Cola",
            "Manzanita",
            "7Seven",
            "Fanta"});
<<<<<<< HEAD
            this.B_refresco.Location = new System.Drawing.Point(262, 410);
            this.B_refresco.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.B_refresco.Name = "B_refresco";
            this.B_refresco.Size = new System.Drawing.Size(70, 23);
            this.B_refresco.TabIndex = 11;
            this.B_refresco.Text = "Sabor";
            // 
            // CB_refrescoS
            // 
            this.CB_refrescoS.AutoSize = true;
            this.CB_refrescoS.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_refrescoS.Location = new System.Drawing.Point(264, 371);
            this.CB_refrescoS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CB_refrescoS.Name = "CB_refrescoS";
            this.CB_refrescoS.Size = new System.Drawing.Size(42, 23);
            this.CB_refrescoS.TabIndex = 12;
            this.CB_refrescoS.Text = "Si";
            this.CB_refrescoS.UseVisualStyleBackColor = true;
            // 
            // CB_refrescoN
            // 
            this.CB_refrescoN.AutoSize = true;
            this.CB_refrescoN.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_refrescoN.Location = new System.Drawing.Point(329, 371);
            this.CB_refrescoN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CB_refrescoN.Name = "CB_refrescoN";
            this.CB_refrescoN.Size = new System.Drawing.Size(48, 23);
            this.CB_refrescoN.TabIndex = 13;
            this.CB_refrescoN.Text = "No";
            this.CB_refrescoN.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(397, 410);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(114, 23);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.Text = "Tamaño";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(573, 410);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(117, 23);
            this.comboBox3.TabIndex = 15;
            this.comboBox3.Text = "Cantidad";
=======
            this.CBSabor.Location = new System.Drawing.Point(146, 363);
            this.CBSabor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CBSabor.Name = "CBSabor";
            this.CBSabor.Size = new System.Drawing.Size(124, 23);
            this.CBSabor.TabIndex = 11;
            this.CBSabor.Text = "Sabor";
            // 
            // CBTamano
            // 
            this.CBTamano.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBTamano.FormattingEnabled = true;
            this.CBTamano.Location = new System.Drawing.Point(348, 363);
            this.CBTamano.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CBTamano.Name = "CBTamano";
            this.CBTamano.Size = new System.Drawing.Size(114, 23);
            this.CBTamano.TabIndex = 14;
            this.CBTamano.Text = "Tamaño";
            // 
            // CBCantidad
            // 
            this.CBCantidad.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCantidad.FormattingEnabled = true;
            this.CBCantidad.Location = new System.Drawing.Point(519, 363);
            this.CBCantidad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CBCantidad.Name = "CBCantidad";
            this.CBCantidad.Size = new System.Drawing.Size(117, 23);
            this.CBCantidad.TabIndex = 15;
            this.CBCantidad.Text = "Cantidad";
>>>>>>> c508d6ca23886589d81186637845dfdea1be46dc
            // 
            // TB_total
            // 
            this.TB_total.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_total.Location = new System.Drawing.Point(573, 508);
            this.TB_total.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_total.Name = "TB_total";
            this.TB_total.Size = new System.Drawing.Size(68, 26);
            this.TB_total.TabIndex = 16;
            // 
            // Lb_Total
            // 
            this.Lb_Total.AutoSize = true;
            this.Lb_Total.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Total.Location = new System.Drawing.Point(518, 476);
            this.Lb_Total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_Total.Name = "Lb_Total";
            this.Lb_Total.Size = new System.Drawing.Size(44, 19);
            this.Lb_Total.TabIndex = 17;
            this.Lb_Total.Text = "Total";
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmar.Location = new System.Drawing.Point(740, 507);
            this.buttonConfirmar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(94, 23);
            this.buttonConfirmar.TabIndex = 18;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 476);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "A Nombre:";
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Nombre.Location = new System.Drawing.Point(240, 508);
            this.TB_Nombre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(179, 22);
            this.TB_Nombre.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pizzaria_eddy.Properties.Resources.pizza;
            this.pictureBox1.Location = new System.Drawing.Point(914, 68);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(414, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(881, 507);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 23;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegresar.Location = new System.Drawing.Point(1008, 507);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(75, 23);
            this.buttonRegresar.TabIndex = 24;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
<<<<<<< HEAD
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(289, 161);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
=======
            // radioButtonSi
            // 
            this.radioButtonSi.AutoSize = true;
            this.radioButtonSi.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.radioButtonSi.Location = new System.Drawing.Point(229, 319);
            this.radioButtonSi.Name = "radioButtonSi";
            this.radioButtonSi.Size = new System.Drawing.Size(41, 23);
            this.radioButtonSi.TabIndex = 25;
            this.radioButtonSi.TabStop = true;
            this.radioButtonSi.Text = "Si";
            this.radioButtonSi.UseVisualStyleBackColor = true;
            this.radioButtonSi.CheckedChanged += new System.EventHandler(this.radioButtonSi_CheckedChanged);
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.radioButtonNo.Location = new System.Drawing.Point(287, 322);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(47, 23);
            this.radioButtonNo.TabIndex = 26;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            this.radioButtonNo.CheckedChanged += new System.EventHandler(this.radioButtonNo_CheckedChanged);
>>>>>>> c508d6ca23886589d81186637845dfdea1be46dc
            // 
            // ordenar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 632);
<<<<<<< HEAD
            this.Controls.Add(this.pictureBox2);
=======
            this.Controls.Add(this.radioButtonNo);
            this.Controls.Add(this.radioButtonSi);
>>>>>>> c508d6ca23886589d81186637845dfdea1be46dc
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TB_Nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.Lb_Total);
            this.Controls.Add(this.TB_total);
            this.Controls.Add(this.CBCantidad);
            this.Controls.Add(this.CBTamano);
            this.Controls.Add(this.CBSabor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.B_Ingrediente_3);
            this.Controls.Add(this.B_ingrediente_2);
            this.Controls.Add(this.B_ingrediente_1);
            this.Controls.Add(this.L_Ingrediente_3);
            this.Controls.Add(this.L_Ingrediente_2);
            this.Controls.Add(this.L_ingrediente_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBIngredientes);
            this.Controls.Add(this.Box_tamano);
            this.Controls.Add(this.L_tamano);
            this.Font = new System.Drawing.Font("Mistral", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ordenar";
            this.Text = "Pizza Eddy\'s";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ordenar_FormClosing);
            this.Load += new System.EventHandler(this.ordenar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_tamano;
        private System.Windows.Forms.ComboBox Box_tamano;
        private System.Windows.Forms.ComboBox CBIngredientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label L_ingrediente_1;
        private System.Windows.Forms.Label L_Ingrediente_2;
        private System.Windows.Forms.Label L_Ingrediente_3;
        private System.Windows.Forms.ComboBox B_ingrediente_1;
        private System.Windows.Forms.ComboBox B_ingrediente_2;
        private System.Windows.Forms.ComboBox B_Ingrediente_3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBSabor;
        private System.Windows.Forms.ComboBox CBTamano;
        private System.Windows.Forms.ComboBox CBCantidad;
        private System.Windows.Forms.TextBox TB_total;
        private System.Windows.Forms.Label Lb_Total;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonRegresar;
<<<<<<< HEAD
        private System.Windows.Forms.PictureBox pictureBox2;
=======
        private System.Windows.Forms.RadioButton radioButtonSi;
        private System.Windows.Forms.RadioButton radioButtonNo;
>>>>>>> c508d6ca23886589d81186637845dfdea1be46dc
    }
}