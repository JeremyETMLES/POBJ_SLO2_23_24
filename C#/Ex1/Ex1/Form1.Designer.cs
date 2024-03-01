namespace Ex1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnConvertir = new System.Windows.Forms.Button();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.txtResultat = new System.Windows.Forms.TextBox();
            this.rbnSFR = new System.Windows.Forms.RadioButton();
            this.rbnUSD = new System.Windows.Forms.RadioButton();
            this.rbnGBP = new System.Windows.Forms.RadioButton();
            this.rbnYen = new System.Windows.Forms.RadioButton();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.picDevises = new System.Windows.Forms.PictureBox();
            this.PicDevise = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picDevises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDevise)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(186, 252);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(112, 47);
            this.btnConvertir.TabIndex = 0;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(35, 266);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(100, 20);
            this.txtMontant.TabIndex = 1;
            // 
            // txtResultat
            // 
            this.txtResultat.Location = new System.Drawing.Point(353, 266);
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.Size = new System.Drawing.Size(100, 20);
            this.txtResultat.TabIndex = 2;
            // 
            // rbnSFR
            // 
            this.rbnSFR.AutoSize = true;
            this.rbnSFR.Checked = true;
            this.rbnSFR.Location = new System.Drawing.Point(35, 44);
            this.rbnSFR.Name = "rbnSFR";
            this.rbnSFR.Size = new System.Drawing.Size(91, 17);
            this.rbnSFR.TabIndex = 3;
            this.rbnSFR.TabStop = true;
            this.rbnSFR.Text = "Francs Suisse";
            this.rbnSFR.UseVisualStyleBackColor = true;
            this.rbnSFR.CheckedChanged += new System.EventHandler(this.rbnSFR_CheckedChanged);
            // 
            // rbnUSD
            // 
            this.rbnUSD.AutoSize = true;
            this.rbnUSD.Location = new System.Drawing.Point(35, 67);
            this.rbnUSD.Name = "rbnUSD";
            this.rbnUSD.Size = new System.Drawing.Size(73, 17);
            this.rbnUSD.TabIndex = 4;
            this.rbnUSD.Text = "US dollars";
            this.rbnUSD.UseVisualStyleBackColor = true;
            this.rbnUSD.CheckedChanged += new System.EventHandler(this.rbnUSD_CheckedChanged);
            // 
            // rbnGBP
            // 
            this.rbnGBP.AutoSize = true;
            this.rbnGBP.Location = new System.Drawing.Point(35, 90);
            this.rbnGBP.Name = "rbnGBP";
            this.rbnGBP.Size = new System.Drawing.Size(96, 17);
            this.rbnGBP.TabIndex = 5;
            this.rbnGBP.Text = "Livres Sterlings";
            this.rbnGBP.UseVisualStyleBackColor = true;
            this.rbnGBP.CheckedChanged += new System.EventHandler(this.rbnGBP_CheckedChanged);
            // 
            // rbnYen
            // 
            this.rbnYen.AutoSize = true;
            this.rbnYen.Location = new System.Drawing.Point(35, 113);
            this.rbnYen.Name = "rbnYen";
            this.rbnYen.Size = new System.Drawing.Size(86, 17);
            this.rbnYen.TabIndex = 6;
            this.rbnYen.Text = "Yen japonais";
            this.rbnYen.UseVisualStyleBackColor = true;
            this.rbnYen.CheckedChanged += new System.EventHandler(this.rbnYen_CheckedChanged);
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(35, 247);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(46, 13);
            this.lblMontant.TabIndex = 8;
            this.lblMontant.Text = "Montant";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(359, 244);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(85, 13);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "Resultat en euro";
            // 
            // picDevises
            // 
            this.picDevises.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picDevises.Location = new System.Drawing.Point(203, 12);
            this.picDevises.Name = "picDevises";
            this.picDevises.Size = new System.Drawing.Size(250, 200);
            this.picDevises.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDevises.TabIndex = 7;
            this.picDevises.TabStop = false;
            this.picDevises.Click += new System.EventHandler(this.picDevises_Click);
            // 
            // PicDevise
            // 
            this.PicDevise.Location = new System.Drawing.Point(0, 0);
            this.PicDevise.Name = "PicDevise";
            this.PicDevise.Size = new System.Drawing.Size(100, 50);
            this.PicDevise.TabIndex = 0;
            this.PicDevise.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "DrapeauGB.jpg");
            this.imageList1.Images.SetKeyName(1, "DrapeauJapon.jpg");
            this.imageList1.Images.SetKeyName(2, "DrapeauSuisse.jpg");
            this.imageList1.Images.SetKeyName(3, "DrapeauUSA.jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 312);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.picDevises);
            this.Controls.Add(this.rbnYen);
            this.Controls.Add(this.rbnGBP);
            this.Controls.Add(this.rbnUSD);
            this.Controls.Add(this.rbnSFR);
            this.Controls.Add(this.txtResultat);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.btnConvertir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDevises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDevise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.TextBox txtResultat;
        private System.Windows.Forms.RadioButton rbnSFR;
        private System.Windows.Forms.RadioButton rbnUSD;
        private System.Windows.Forms.RadioButton rbnGBP;
        private System.Windows.Forms.RadioButton rbnYen;
        private System.Windows.Forms.PictureBox picDevises;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.PictureBox PicDevise;
        private System.Windows.Forms.ImageList imageList1;
    }
}

