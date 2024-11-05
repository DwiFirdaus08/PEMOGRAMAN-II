namespace P5_1_714230065
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
            this.Outputlabel = new System.Windows.Forms.Label();
            this.Hellobutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Outputlabel
            // 
            this.Outputlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Outputlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outputlabel.Location = new System.Drawing.Point(5, 20);
            this.Outputlabel.Name = "Outputlabel";
            this.Outputlabel.Size = new System.Drawing.Size(264, 23);
            this.Outputlabel.TabIndex = 0;
            this.Outputlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Hellobutton
            // 
            this.Hellobutton.Location = new System.Drawing.Point(57, 87);
            this.Hellobutton.Name = "Hellobutton";
            this.Hellobutton.Size = new System.Drawing.Size(75, 23);
            this.Hellobutton.TabIndex = 1;
            this.Hellobutton.Text = "&sayhello";
            this.Hellobutton.UseVisualStyleBackColor = true;
            this.Hellobutton.Click += new System.EventHandler(this.Hellobutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "E&xit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(282, 128);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Hellobutton);
            this.Controls.Add(this.Outputlabel);
            this.Name = "Form1";
            this.Text = "FormHello";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Outputlabel;
        private System.Windows.Forms.Button Hellobutton;
        private System.Windows.Forms.Button button1;
    }
}

