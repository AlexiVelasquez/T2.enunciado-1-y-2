﻿namespace T2.enunciado1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textTelef = new System.Windows.Forms.TextBox();
            this.textDirec = new System.Windows.Forms.TextBox();
            this.textNomb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.txtrazMasc = new System.Windows.Forms.TextBox();
            this.txtedMas = new System.Windows.Forms.TextBox();
            this.txtnmasc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboboxdueños = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelInfoMascota = new System.Windows.Forms.Label();
            this.botonbuscarmascota = new System.Windows.Forms.Button();
            this.txtBuscarMascota = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(32, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(503, 340);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textTelef);
            this.tabPage1.Controls.Add(this.textDirec);
            this.tabPage1.Controls.Add(this.textNomb);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(495, 314);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro Dueño:";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OliveDrab;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(118, 223);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 72);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textTelef
            // 
            this.textTelef.Location = new System.Drawing.Point(118, 162);
            this.textTelef.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textTelef.Name = "textTelef";
            this.textTelef.Size = new System.Drawing.Size(116, 20);
            this.textTelef.TabIndex = 6;
            // 
            // textDirec
            // 
            this.textDirec.Location = new System.Drawing.Point(118, 104);
            this.textDirec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textDirec.Name = "textDirec";
            this.textDirec.Size = new System.Drawing.Size(116, 20);
            this.textDirec.TabIndex = 5;
            // 
            // textNomb
            // 
            this.textNomb.Location = new System.Drawing.Point(118, 57);
            this.textNomb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textNomb.Name = "textNomb";
            this.textNomb.Size = new System.Drawing.Size(116, 20);
            this.textNomb.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingrese datos Solicitados:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Direccion:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.txtrazMasc);
            this.tabPage2.Controls.Add(this.txtedMas);
            this.tabPage2.Controls.Add(this.txtnmasc);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.comboboxdueños);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(495, 314);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registro Mascotas:";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Brown;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(146, 234);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 63);
            this.button2.TabIndex = 9;
            this.button2.Text = "Registrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtrazMasc
            // 
            this.txtrazMasc.Location = new System.Drawing.Point(120, 150);
            this.txtrazMasc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtrazMasc.Name = "txtrazMasc";
            this.txtrazMasc.Size = new System.Drawing.Size(118, 20);
            this.txtrazMasc.TabIndex = 8;
            // 
            // txtedMas
            // 
            this.txtedMas.Location = new System.Drawing.Point(120, 99);
            this.txtedMas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtedMas.Name = "txtedMas";
            this.txtedMas.Size = new System.Drawing.Size(118, 20);
            this.txtedMas.TabIndex = 7;
            // 
            // txtnmasc
            // 
            this.txtnmasc.Location = new System.Drawing.Point(120, 51);
            this.txtnmasc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnmasc.Name = "txtnmasc";
            this.txtnmasc.Size = new System.Drawing.Size(118, 20);
            this.txtnmasc.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 197);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Dueño:";
            // 
            // comboboxdueños
            // 
            this.comboboxdueños.FormattingEnabled = true;
            this.comboboxdueños.Location = new System.Drawing.Point(120, 197);
            this.comboboxdueños.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboboxdueños.Name = "comboboxdueños";
            this.comboboxdueños.Size = new System.Drawing.Size(118, 21);
            this.comboboxdueños.TabIndex = 4;
            this.comboboxdueños.Text = "Escoger dueño";
            this.comboboxdueños.SelectedIndexChanged += new System.EventHandler(this.Listadueños_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 150);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Raza:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 104);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Edad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ingrese datos de su mascota:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.labelInfoMascota);
            this.tabPage3.Controls.Add(this.botonbuscarmascota);
            this.tabPage3.Controls.Add(this.txtBuscarMascota);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(495, 314);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Buscar Mascota:";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelInfoMascota
            // 
            this.labelInfoMascota.Font = new System.Drawing.Font("Eras Medium ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoMascota.Location = new System.Drawing.Point(38, 95);
            this.labelInfoMascota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfoMascota.Name = "labelInfoMascota";
            this.labelInfoMascota.Size = new System.Drawing.Size(426, 168);
            this.labelInfoMascota.TabIndex = 3;
            // 
            // botonbuscarmascota
            // 
            this.botonbuscarmascota.Location = new System.Drawing.Point(278, 39);
            this.botonbuscarmascota.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonbuscarmascota.Name = "botonbuscarmascota";
            this.botonbuscarmascota.Size = new System.Drawing.Size(74, 37);
            this.botonbuscarmascota.TabIndex = 2;
            this.botonbuscarmascota.Text = "Buscar";
            this.botonbuscarmascota.UseVisualStyleBackColor = true;
            this.botonbuscarmascota.Click += new System.EventHandler(this.botonbuscarmascota_Click);
            // 
            // txtBuscarMascota
            // 
            this.txtBuscarMascota.Location = new System.Drawing.Point(122, 48);
            this.txtBuscarMascota.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscarMascota.Name = "txtBuscarMascota";
            this.txtBuscarMascota.Size = new System.Drawing.Size(142, 20);
            this.txtBuscarMascota.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 19);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 48);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ingrese el nombre la Mascota:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textTelef;
        private System.Windows.Forms.TextBox textDirec;
        private System.Windows.Forms.TextBox textNomb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtrazMasc;
        private System.Windows.Forms.TextBox txtedMas;
        private System.Windows.Forms.TextBox txtnmasc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboboxdueños;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button botonbuscarmascota;
        private System.Windows.Forms.TextBox txtBuscarMascota;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelInfoMascota;
    }
}

