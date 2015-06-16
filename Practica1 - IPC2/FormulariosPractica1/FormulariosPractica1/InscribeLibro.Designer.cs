namespace FormulariosPractica1
{
    partial class InscribeLibro
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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBnombre = new System.Windows.Forms.TextBox();
            this.TBcantidad = new System.Windows.Forms.TextBox();
            this.TBpaginas = new System.Windows.Forms.TextBox();
            this.TBtema = new System.Windows.Forms.TextBox();
            this.TBautor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(160, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 39);
            this.label6.TabIndex = 12;
            this.label6.Text = "Registrar Libros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "No. de paginas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tema";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Autor";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TBnombre
            // 
            this.TBnombre.Location = new System.Drawing.Point(125, 122);
            this.TBnombre.Name = "TBnombre";
            this.TBnombre.Size = new System.Drawing.Size(100, 20);
            this.TBnombre.TabIndex = 18;
            // 
            // TBcantidad
            // 
            this.TBcantidad.Location = new System.Drawing.Point(125, 148);
            this.TBcantidad.Name = "TBcantidad";
            this.TBcantidad.Size = new System.Drawing.Size(100, 20);
            this.TBcantidad.TabIndex = 19;
            // 
            // TBpaginas
            // 
            this.TBpaginas.Location = new System.Drawing.Point(125, 174);
            this.TBpaginas.Name = "TBpaginas";
            this.TBpaginas.Size = new System.Drawing.Size(100, 20);
            this.TBpaginas.TabIndex = 20;
            // 
            // TBtema
            // 
            this.TBtema.Location = new System.Drawing.Point(125, 202);
            this.TBtema.Name = "TBtema";
            this.TBtema.Size = new System.Drawing.Size(100, 20);
            this.TBtema.TabIndex = 21;
            // 
            // TBautor
            // 
            this.TBautor.Location = new System.Drawing.Point(125, 231);
            this.TBautor.Name = "TBautor";
            this.TBautor.Size = new System.Drawing.Size(100, 20);
            this.TBautor.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InscribeLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 380);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TBautor);
            this.Controls.Add(this.TBtema);
            this.Controls.Add(this.TBpaginas);
            this.Controls.Add(this.TBcantidad);
            this.Controls.Add(this.TBnombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "InscribeLibro";
            this.Text = "Whizz Hard Books";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBnombre;
        private System.Windows.Forms.TextBox TBcantidad;
        private System.Windows.Forms.TextBox TBpaginas;
        private System.Windows.Forms.TextBox TBtema;
        private System.Windows.Forms.TextBox TBautor;
        private System.Windows.Forms.Button button1;
    }
}