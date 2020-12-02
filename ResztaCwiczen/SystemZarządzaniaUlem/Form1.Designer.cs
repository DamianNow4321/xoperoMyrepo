
namespace SystemZarządzaniaUlem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.report = new System.Windows.Forms.RichTextBox();
            this.assignBtn = new System.Windows.Forms.Button();
            this.shifts = new System.Windows.Forms.NumericUpDown();
            this.workBeeJob = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nxtShift = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nxtShift);
            this.groupBox1.Controls.Add(this.report);
            this.groupBox1.Controls.Add(this.assignBtn);
            this.groupBox1.Controls.Add(this.shifts);
            this.groupBox1.Controls.Add(this.workBeeJob);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Przydział prac robotnikom";
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(7, 95);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(504, 140);
            this.report.TabIndex = 4;
            this.report.Text = "";
            // 
            // assignBtn
            // 
            this.assignBtn.Location = new System.Drawing.Point(10, 65);
            this.assignBtn.Name = "assignBtn";
            this.assignBtn.Size = new System.Drawing.Size(266, 23);
            this.assignBtn.TabIndex = 3;
            this.assignBtn.Text = "Przypisz tą pracę pszczole";
            this.assignBtn.UseVisualStyleBackColor = true;
            this.assignBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(138, 37);
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(138, 20);
            this.shifts.TabIndex = 2;
            // 
            // workBeeJob
            // 
            this.workBeeJob.FormattingEnabled = true;
            this.workBeeJob.Items.AddRange(new object[] {
            "Zbieranie nektaru",
            "Wytwarzanie miodu",
            "Pielęgnacja jaj",
            "Nauczanie pszczułek",
            "Utrzymanie ula",
            "Patrol z żadłami"});
            this.workBeeJob.Location = new System.Drawing.Point(10, 37);
            this.workBeeJob.Name = "workBeeJob";
            this.workBeeJob.Size = new System.Drawing.Size(121, 21);
            this.workBeeJob.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zadanie robotnicy";
            // 
            // nxtShift
            // 
            this.nxtShift.Location = new System.Drawing.Point(309, 9);
            this.nxtShift.Name = "nxtShift";
            this.nxtShift.Size = new System.Drawing.Size(202, 79);
            this.nxtShift.TabIndex = 5;
            this.nxtShift.Text = "Przepracuj następną zmianę";
            this.nxtShift.UseVisualStyleBackColor = true;
            this.nxtShift.Click += new System.EventHandler(this.nxtShift_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 273);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button assignBtn;
        private System.Windows.Forms.NumericUpDown shifts;
        private System.Windows.Forms.ComboBox workBeeJob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox report;
        private System.Windows.Forms.Button nxtShift;
    }
}

