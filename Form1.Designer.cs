namespace Bellum_non_deficient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAtaque = new System.Windows.Forms.Button();
            this.listBoxReco = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDESTRUIDAS = new System.Windows.Forms.Label();
            this.labelAFLOTE = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(55, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // btnAtaque
            // 
            this.btnAtaque.BackgroundImage = global::Bellum_non_deficient.Properties.Resources.fondo1;
            this.btnAtaque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtaque.Enabled = false;
            this.btnAtaque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtaque.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtaque.Location = new System.Drawing.Point(570, 169);
            this.btnAtaque.Name = "btnAtaque";
            this.btnAtaque.Size = new System.Drawing.Size(107, 45);
            this.btnAtaque.TabIndex = 1;
            this.btnAtaque.Text = "Ataque";
            this.btnAtaque.UseVisualStyleBackColor = true;
            this.btnAtaque.Click += new System.EventHandler(this.btnAtaque_Click);
            // 
            // listBoxReco
            // 
            this.listBoxReco.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxReco.FormattingEnabled = true;
            this.listBoxReco.ItemHeight = 20;
            this.listBoxReco.Location = new System.Drawing.Point(647, 378);
            this.listBoxReco.Name = "listBoxReco";
            this.listBoxReco.Size = new System.Drawing.Size(262, 124);
            this.listBoxReco.TabIndex = 2;
            this.listBoxReco.SelectedIndexChanged += new System.EventHandler(this.listBoxReco_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(647, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Comandos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 12F);
            this.label2.Location = new System.Drawing.Point(90, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Golpes ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnIniciar.BackgroundImage = global::Bellum_non_deficient.Properties.Resources.fondo1;
            this.btnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(615, 2);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(188, 45);
            this.btnIniciar.TabIndex = 6;
            this.btnIniciar.Text = "Iniciar Guerra";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 12F);
            this.label3.Location = new System.Drawing.Point(63, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Golpes a naves";
            // 
            // labelDESTRUIDAS
            // 
            this.labelDESTRUIDAS.AutoSize = true;
            this.labelDESTRUIDAS.BackColor = System.Drawing.Color.Transparent;
            this.labelDESTRUIDAS.Font = new System.Drawing.Font("Impact", 12F);
            this.labelDESTRUIDAS.Location = new System.Drawing.Point(39, 55);
            this.labelDESTRUIDAS.Name = "labelDESTRUIDAS";
            this.labelDESTRUIDAS.Size = new System.Drawing.Size(18, 20);
            this.labelDESTRUIDAS.TabIndex = 8;
            this.labelDESTRUIDAS.Text = "0";
            // 
            // labelAFLOTE
            // 
            this.labelAFLOTE.AutoSize = true;
            this.labelAFLOTE.BackColor = System.Drawing.Color.Transparent;
            this.labelAFLOTE.Font = new System.Drawing.Font("Impact", 12F);
            this.labelAFLOTE.Location = new System.Drawing.Point(30, 12);
            this.labelAFLOTE.Name = "labelAFLOTE";
            this.labelAFLOTE.Size = new System.Drawing.Size(18, 20);
            this.labelAFLOTE.TabIndex = 9;
            this.labelAFLOTE.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Bellum_non_deficient.Properties.Resources.fondo1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.labelAFLOTE);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelDESTRUIDAS);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(700, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 93);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(65, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 30);
            this.panel2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 12F);
            this.label4.Location = new System.Drawing.Point(26, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "01";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(165, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(80, 30);
            this.panel3.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Impact", 12F);
            this.label5.Location = new System.Drawing.Point(26, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "02";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(265, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(80, 30);
            this.panel4.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Impact", 12F);
            this.label6.Location = new System.Drawing.Point(26, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "03";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(365, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(80, 30);
            this.panel5.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Impact", 12F);
            this.label7.Location = new System.Drawing.Point(26, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "04";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(465, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(80, 30);
            this.panel6.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Impact", 12F);
            this.label8.Location = new System.Drawing.Point(26, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "05";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Green;
            this.panel7.Location = new System.Drawing.Point(19, 251);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(30, 80);
            this.panel7.TabIndex = 14;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Window;
            this.panel8.Location = new System.Drawing.Point(19, 351);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(30, 80);
            this.panel8.TabIndex = 15;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Yellow;
            this.panel9.Location = new System.Drawing.Point(19, 451);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(30, 80);
            this.panel9.TabIndex = 16;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Blue;
            this.panel10.Location = new System.Drawing.Point(19, 151);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(30, 80);
            this.panel10.TabIndex = 17;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Red;
            this.panel11.Location = new System.Drawing.Point(19, 51);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(30, 80);
            this.panel11.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Impact", 12F);
            this.label9.Location = new System.Drawing.Point(54, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "/15";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bellum_non_deficient.Properties.Resources.fondo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(945, 553);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxReco);
            this.Controls.Add(this.btnAtaque);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAtaque;
        private System.Windows.Forms.ListBox listBoxReco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDESTRUIDAS;
        private System.Windows.Forms.Label labelAFLOTE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label9;
    }
}

