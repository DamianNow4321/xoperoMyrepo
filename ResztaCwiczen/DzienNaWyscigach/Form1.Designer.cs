
namespace DzienNaWyscigach
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.janekBtn = new System.Windows.Forms.RadioButton();
            this.bartekBtn = new System.Windows.Forms.RadioButton();
            this.arekBtn = new System.Windows.Forms.RadioButton();
            this.minimumBet = new System.Windows.Forms.Label();
            this.bettorName = new System.Windows.Forms.Label();
            this.betBtn = new System.Windows.Forms.Button();
            this.betAmount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.raceBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dogNr = new System.Windows.Forms.NumericUpDown();
            this.janekBet = new System.Windows.Forms.Label();
            this.bartekBet = new System.Windows.Forms.Label();
            this.arekBet = new System.Windows.Forms.Label();
            this.dog4 = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.race = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogNr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.race)).BeginInit();
            this.SuspendLayout();
            // 
            // janekBtn
            // 
            this.janekBtn.AutoSize = true;
            this.janekBtn.Location = new System.Drawing.Point(34, 327);
            this.janekBtn.Name = "janekBtn";
            this.janekBtn.Size = new System.Drawing.Size(54, 17);
            this.janekBtn.TabIndex = 0;
            this.janekBtn.TabStop = true;
            this.janekBtn.Text = "Janek";
            this.janekBtn.UseVisualStyleBackColor = true;
            this.janekBtn.CheckedChanged += new System.EventHandler(this.janekBtn_CheckedChanged);
            // 
            // bartekBtn
            // 
            this.bartekBtn.AutoSize = true;
            this.bartekBtn.Location = new System.Drawing.Point(34, 350);
            this.bartekBtn.Name = "bartekBtn";
            this.bartekBtn.Size = new System.Drawing.Size(56, 17);
            this.bartekBtn.TabIndex = 1;
            this.bartekBtn.TabStop = true;
            this.bartekBtn.Text = "Bartek";
            this.bartekBtn.UseVisualStyleBackColor = true;
            this.bartekBtn.CheckedChanged += new System.EventHandler(this.bartekBtn_CheckedChanged);
            // 
            // arekBtn
            // 
            this.arekBtn.AutoSize = true;
            this.arekBtn.Location = new System.Drawing.Point(34, 373);
            this.arekBtn.Name = "arekBtn";
            this.arekBtn.Size = new System.Drawing.Size(47, 17);
            this.arekBtn.TabIndex = 2;
            this.arekBtn.TabStop = true;
            this.arekBtn.Text = "Arek";
            this.arekBtn.UseVisualStyleBackColor = true;
            this.arekBtn.CheckedChanged += new System.EventHandler(this.arekBtn_CheckedChanged);
            // 
            // minimumBet
            // 
            this.minimumBet.AutoSize = true;
            this.minimumBet.Location = new System.Drawing.Point(34, 308);
            this.minimumBet.Name = "minimumBet";
            this.minimumBet.Size = new System.Drawing.Size(84, 13);
            this.minimumBet.TabIndex = 3;
            this.minimumBet.Text = "Minimalna liczba";
            // 
            // bettorName
            // 
            this.bettorName.AutoSize = true;
            this.bettorName.Location = new System.Drawing.Point(34, 416);
            this.bettorName.Name = "bettorName";
            this.bettorName.Size = new System.Drawing.Size(35, 13);
            this.bettorName.TabIndex = 4;
            this.bettorName.Text = "label2";
            // 
            // betBtn
            // 
            this.betBtn.Location = new System.Drawing.Point(75, 411);
            this.betBtn.Name = "betBtn";
            this.betBtn.Size = new System.Drawing.Size(75, 23);
            this.betBtn.TabIndex = 5;
            this.betBtn.Text = "stawia";
            this.betBtn.UseVisualStyleBackColor = true;
            this.betBtn.Click += new System.EventHandler(this.betBtn_Click);
            // 
            // betAmount
            // 
            this.betAmount.Location = new System.Drawing.Point(165, 414);
            this.betAmount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.betAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betAmount.Name = "betAmount";
            this.betAmount.Size = new System.Drawing.Size(36, 20);
            this.betAmount.TabIndex = 6;
            this.betAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "zł na charta nr";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // raceBtn
            // 
            this.raceBtn.Location = new System.Drawing.Point(487, 314);
            this.raceBtn.Name = "raceBtn";
            this.raceBtn.Size = new System.Drawing.Size(150, 88);
            this.raceBtn.TabIndex = 12;
            this.raceBtn.Text = "Start";
            this.raceBtn.UseVisualStyleBackColor = true;
            this.raceBtn.Click += new System.EventHandler(this.raceBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Zakłady";
            // 
            // dogNr
            // 
            this.dogNr.Location = new System.Drawing.Point(289, 414);
            this.dogNr.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogNr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNr.Name = "dogNr";
            this.dogNr.Size = new System.Drawing.Size(36, 20);
            this.dogNr.TabIndex = 14;
            this.dogNr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // janekBet
            // 
            this.janekBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.janekBet.Location = new System.Drawing.Point(238, 327);
            this.janekBet.Name = "janekBet";
            this.janekBet.Size = new System.Drawing.Size(207, 17);
            this.janekBet.TabIndex = 15;
            this.janekBet.Text = "label5";
            // 
            // bartekBet
            // 
            this.bartekBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bartekBet.Location = new System.Drawing.Point(238, 351);
            this.bartekBet.Name = "bartekBet";
            this.bartekBet.Size = new System.Drawing.Size(207, 17);
            this.bartekBet.TabIndex = 16;
            this.bartekBet.Text = "label6";
            // 
            // arekBet
            // 
            this.arekBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arekBet.Location = new System.Drawing.Point(238, 378);
            this.arekBet.Name = "arekBet";
            this.arekBet.Size = new System.Drawing.Size(207, 17);
            this.arekBet.TabIndex = 17;
            this.arekBet.Text = "label7";
            // 
            // dog4
            // 
            this.dog4.Image = global::DzienNaWyscigach.Properties.Resources.dog;
            this.dog4.Location = new System.Drawing.Point(34, 180);
            this.dog4.Name = "dog4";
            this.dog4.Size = new System.Drawing.Size(79, 19);
            this.dog4.TabIndex = 11;
            this.dog4.TabStop = false;
            // 
            // dog3
            // 
            this.dog3.Image = global::DzienNaWyscigach.Properties.Resources.dog;
            this.dog3.Location = new System.Drawing.Point(37, 120);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(76, 22);
            this.dog3.TabIndex = 10;
            this.dog3.TabStop = false;
            // 
            // dog2
            // 
            this.dog2.Image = global::DzienNaWyscigach.Properties.Resources.dog;
            this.dog2.Location = new System.Drawing.Point(34, 66);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(79, 21);
            this.dog2.TabIndex = 9;
            this.dog2.TabStop = false;
            // 
            // dog1
            // 
            this.dog1.Image = global::DzienNaWyscigach.Properties.Resources.dog;
            this.dog1.Location = new System.Drawing.Point(34, 22);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(79, 21);
            this.dog1.TabIndex = 8;
            this.dog1.TabStop = false;
            // 
            // race
            // 
            this.race.Image = global::DzienNaWyscigach.Properties.Resources.racetrack;
            this.race.Location = new System.Drawing.Point(34, 12);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(603, 205);
            this.race.TabIndex = 18;
            this.race.TabStop = false;
            this.race.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(34, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 152);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dom bukmacherski";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 453);
            this.Controls.Add(this.arekBet);
            this.Controls.Add(this.bartekBet);
            this.Controls.Add(this.janekBet);
            this.Controls.Add(this.dogNr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.raceBtn);
            this.Controls.Add(this.dog4);
            this.Controls.Add(this.dog3);
            this.Controls.Add(this.dog2);
            this.Controls.Add(this.dog1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.betAmount);
            this.Controls.Add(this.betBtn);
            this.Controls.Add(this.bettorName);
            this.Controls.Add(this.minimumBet);
            this.Controls.Add(this.arekBtn);
            this.Controls.Add(this.bartekBtn);
            this.Controls.Add(this.janekBtn);
            this.Controls.Add(this.race);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogNr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.race)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton janekBtn;
        private System.Windows.Forms.RadioButton bartekBtn;
        private System.Windows.Forms.RadioButton arekBtn;
        private System.Windows.Forms.Label minimumBet;
        private System.Windows.Forms.Label bettorName;
        private System.Windows.Forms.Button betBtn;
        private System.Windows.Forms.NumericUpDown betAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.PictureBox dog4;
        private System.Windows.Forms.Button raceBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown dogNr;
        private System.Windows.Forms.Label janekBet;
        private System.Windows.Forms.Label bartekBet;
        private System.Windows.Forms.Label arekBet;
        private System.Windows.Forms.PictureBox race;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

