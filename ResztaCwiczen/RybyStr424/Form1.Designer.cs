
namespace RybyStr424
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listHand = new System.Windows.Forms.ListBox();
            this.buttonAsk = new System.Windows.Forms.Button();
            this.textProgress = new System.Windows.Forms.TextBox();
            this.textBooks = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Imię";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Postępy gry";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Grupy";
            // 
            // listHand
            // 
            this.listHand.FormattingEnabled = true;
            this.listHand.Location = new System.Drawing.Point(443, 73);
            this.listHand.Name = "listHand";
            this.listHand.Size = new System.Drawing.Size(120, 303);
            this.listHand.TabIndex = 7;
            // 
            // buttonAsk
            // 
            this.buttonAsk.Location = new System.Drawing.Point(443, 377);
            this.buttonAsk.Name = "buttonAsk";
            this.buttonAsk.Size = new System.Drawing.Size(120, 23);
            this.buttonAsk.TabIndex = 8;
            this.buttonAsk.Text = "Zażądaj karty";
            this.buttonAsk.UseVisualStyleBackColor = true;
            this.buttonAsk.Click += new System.EventHandler(this.buttonAsk_Click);
            // 
            // textProgress
            // 
            this.textProgress.Location = new System.Drawing.Point(12, 74);
            this.textProgress.Multiline = true;
            this.textProgress.Name = "textProgress";
            this.textProgress.ReadOnly = true;
            this.textProgress.Size = new System.Drawing.Size(404, 206);
            this.textProgress.TabIndex = 9;
            // 
            // textBooks
            // 
            this.textBooks.Location = new System.Drawing.Point(15, 300);
            this.textBooks.Multiline = true;
            this.textBooks.Name = "textBooks";
            this.textBooks.ReadOnly = true;
            this.textBooks.Size = new System.Drawing.Size(401, 100);
            this.textBooks.TabIndex = 10;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(293, 27);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(123, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Rozpocznij grę";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(12, 27);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(275, 20);
            this.textName.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 412);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textBooks);
            this.Controls.Add(this.textProgress);
            this.Controls.Add(this.buttonAsk);
            this.Controls.Add(this.listHand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listHand;
        private System.Windows.Forms.Button buttonAsk;
        private System.Windows.Forms.TextBox textProgress;
        private System.Windows.Forms.TextBox textBooks;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textName;
    }
}

