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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // btnAtaque
            // 
            this.btnAtaque.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtaque.Location = new System.Drawing.Point(626, 24);
            this.btnAtaque.Name = "btnAtaque";
            this.btnAtaque.Size = new System.Drawing.Size(107, 45);
            this.btnAtaque.TabIndex = 1;
            this.btnAtaque.Text = "Ataque";
            this.btnAtaque.UseVisualStyleBackColor = true;
            this.btnAtaque.Click += new System.EventHandler(this.btnAtaque_Click);
            // 
            // listBoxReco
            // 
            this.listBoxReco.FormattingEnabled = true;
            this.listBoxReco.Location = new System.Drawing.Point(626, 100);
            this.listBoxReco.Name = "listBoxReco";
            this.listBoxReco.Size = new System.Drawing.Size(266, 251);
            this.listBoxReco.TabIndex = 2;
            this.listBoxReco.SelectedIndexChanged += new System.EventHandler(this.listBoxReco_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 524);
            this.Controls.Add(this.listBoxReco);
            this.Controls.Add(this.btnAtaque);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAtaque;
        private System.Windows.Forms.ListBox listBoxReco;
    }
}

