
namespace klasaGuy
{
    partial class Form1
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
            this.joelabel = new System.Windows.Forms.Label();
            this.boblabel = new System.Windows.Forms.Label();
            this.banklabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // joelabel
            // 
            this.joelabel.AutoSize = true;
            this.joelabel.Location = new System.Drawing.Point(13, 37);
            this.joelabel.Name = "joelabel";
            this.joelabel.Size = new System.Drawing.Size(68, 13);
            this.joelabel.TabIndex = 0;
            this.joelabel.Text = "Joe ma 50 zł";
            // 
            // boblabel
            // 
            this.boblabel.AutoSize = true;
            this.boblabel.Location = new System.Drawing.Point(13, 74);
            this.boblabel.Name = "boblabel";
            this.boblabel.Size = new System.Drawing.Size(76, 13);
            this.boblabel.TabIndex = 1;
            this.boblabel.Text = "Bob ma 100 zł";
            // 
            // banklabel
            // 
            this.banklabel.AutoSize = true;
            this.banklabel.Location = new System.Drawing.Point(13, 115);
            this.banklabel.Name = "banklabel";
            this.banklabel.Size = new System.Drawing.Size(82, 13);
            this.banklabel.TabIndex = 2;
            this.banklabel.Text = "Bank ma 100 zł";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Daj 10 zł Joemu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Weż 5 zł od Boba";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Joe daje 10 zł Bobowi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(140, 177);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Bob daje 5 zł Joemu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.banklabel);
            this.Controls.Add(this.boblabel);
            this.Controls.Add(this.joelabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label joelabel;
        private System.Windows.Forms.Label boblabel;
        private System.Windows.Forms.Label banklabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

