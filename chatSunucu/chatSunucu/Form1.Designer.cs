namespace chatSunucu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            btnBaslat = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(360, 334);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnBaslat
            // 
            btnBaslat.BackColor = Color.Coral;
            btnBaslat.FlatStyle = FlatStyle.System;
            btnBaslat.Location = new Point(92, 352);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(183, 54);
            btnBaslat.TabIndex = 1;
            btnBaslat.Text = "Çalıştır";
            btnBaslat.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBaslat.UseVisualStyleBackColor = false;
            btnBaslat.Click += btnBaslat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 450);
            Controls.Add(btnBaslat);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnBaslat;
    }
}
