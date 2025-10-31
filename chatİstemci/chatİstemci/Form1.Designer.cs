namespace chatİstemci
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
            txtSunucuIP = new TextBox();
            txtPort = new TextBox();
            txtChat = new RichTextBox();
            txtMesaj = new TextBox();
            btnBaglan = new Button();
            btnGonder = new Button();
            SuspendLayout();
            // 
            // txtSunucuIP
            // 
            txtSunucuIP.Location = new Point(12, 12);
            txtSunucuIP.Name = "txtSunucuIP";
            txtSunucuIP.Size = new Size(120, 23);
            txtSunucuIP.TabIndex = 0;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(138, 12);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(60, 23);
            txtPort.TabIndex = 1;
            txtPort.TextChanged += txtPort_TextChanged;
            // 
            // txtChat
            // 
            txtChat.BackColor = Color.Cornsilk;
            txtChat.BorderStyle = BorderStyle.FixedSingle;
            txtChat.Location = new Point(12, 41);
            txtChat.Name = "txtChat";
            txtChat.ReadOnly = true;
            txtChat.Size = new Size(267, 200);
            txtChat.TabIndex = 3;
            txtChat.Text = "";
            // 
            // txtMesaj
            // 
            txtMesaj.Location = new Point(12, 247);
            txtMesaj.Name = "txtMesaj";
            txtMesaj.Size = new Size(186, 23);
            txtMesaj.TabIndex = 4;
            // 
            // btnBaglan
            // 
            btnBaglan.BackColor = SystemColors.MenuBar;
            btnBaglan.FlatStyle = FlatStyle.Popup;
            btnBaglan.ForeColor = Color.DarkBlue;
            btnBaglan.Location = new Point(204, 12);
            btnBaglan.Name = "btnBaglan";
            btnBaglan.Size = new Size(75, 23);
            btnBaglan.TabIndex = 2;
            btnBaglan.Text = "Bağlan";
            btnBaglan.UseVisualStyleBackColor = false;
            btnBaglan.Click += btnBaglan_Click;
            // 
            // btnGonder
            // 
            btnGonder.BackColor = SystemColors.MenuBar;
            btnGonder.ForeColor = Color.DarkBlue;
            btnGonder.Location = new Point(204, 247);
            btnGonder.Name = "btnGonder";
            btnGonder.Size = new Size(75, 23);
            btnGonder.TabIndex = 5;
            btnGonder.Text = "Gönder";
            btnGonder.UseVisualStyleBackColor = false;
            btnGonder.Click += btnGonder_Click;
            // 
            // Form1
            // 
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(291, 282);
            Controls.Add(txtSunucuIP);
            Controls.Add(txtPort);
            Controls.Add(btnBaglan);
            Controls.Add(txtChat);
            Controls.Add(txtMesaj);
            Controls.Add(btnGonder);
            Name = "Form1";
            Text = "Chat İstemci";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtSunucuIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.RichTextBox txtChat;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.Button btnGonder;
    }
}
