
namespace ZbudujmyDom
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
            this.Description = new System.Windows.Forms.RichTextBox();
            this.ex = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.hide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(13, 12);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(253, 168);
            this.Description.TabIndex = 0;
            this.Description.Text = "";
            // 
            // ex
            // 
            this.ex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ex.FormattingEnabled = true;
            this.ex.Location = new System.Drawing.Point(94, 186);
            this.ex.Name = "ex";
            this.ex.Size = new System.Drawing.Size(172, 21);
            this.ex.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Idź tutaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Przejdź przez drzwi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(13, 211);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(253, 23);
            this.check.TabIndex = 4;
            this.check.Text = "Sprawdź";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // hide
            // 
            this.hide.Location = new System.Drawing.Point(13, 241);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(253, 23);
            this.hide.TabIndex = 5;
            this.hide.Text = "Ukryj się";
            this.hide.UseVisualStyleBackColor = true;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 301);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.check);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ex);
            this.Controls.Add(this.Description);
            this.Name = "Form1";
            this.Text = "Dom";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.ComboBox ex;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button hide;
    }
}

