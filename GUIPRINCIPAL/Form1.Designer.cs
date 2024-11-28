namespace GUIPRINCIPAL
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labeltarea = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelalarma = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelEvento = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(-7, 93);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(530, 593);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.button8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(171, 174);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(183, 55);
            this.button8.TabIndex = 8;
            this.button8.Text = "Alarmas";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.groupBox2.Controls.Add(this.labeltarea);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(44, 270);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(448, 297);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ultima tarea pendiente";
            // 
            // labeltarea
            // 
            this.labeltarea.AutoSize = true;
            this.labeltarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltarea.Location = new System.Drawing.Point(45, 42);
            this.labeltarea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltarea.Name = "labeltarea";
            this.labeltarea.Size = new System.Drawing.Size(62, 25);
            this.labeltarea.TabIndex = 9;
            this.labeltarea.Text = "Vacio";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.groupBox3.Controls.Add(this.labelalarma);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Location = new System.Drawing.Point(3, 93);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(445, 368);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Proxima Alarma";
            // 
            // labelalarma
            // 
            this.labelalarma.AutoSize = true;
            this.labelalarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelalarma.Location = new System.Drawing.Point(43, 45);
            this.labelalarma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelalarma.Name = "labelalarma";
            this.labelalarma.Size = new System.Drawing.Size(62, 25);
            this.labelalarma.TabIndex = 10;
            this.labelalarma.Text = "Vacio";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(189)))), ((int)(((byte)(227)))));
            this.groupBox4.Controls.Add(this.labelEvento);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(0, 103);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(448, 267);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Proximo Evento";
            // 
            // labelEvento
            // 
            this.labelEvento.AutoSize = true;
            this.labelEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvento.Location = new System.Drawing.Point(43, 46);
            this.labelEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEvento.Name = "labelEvento";
            this.labelEvento.Size = new System.Drawing.Size(62, 25);
            this.labelEvento.TabIndex = 11;
            this.labelEvento.Text = "Vacio";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.button6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(307, 103);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(183, 55);
            this.button6.TabIndex = 7;
            this.button6.Text = "Tareas";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(189)))), ((int)(((byte)(227)))));
            this.button1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(42, 103);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 55);
            this.button1.TabIndex = 7;
            this.button1.Text = "Eventos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUIPRINCIPAL.Properties.Resources.Imagen1;
            this.pictureBox1.Location = new System.Drawing.Point(235, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.label1.Location = new System.Drawing.Point(40, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 66);
            this.label1.TabIndex = 9;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(521, 686);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labeltarea;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelalarma;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelEvento;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

