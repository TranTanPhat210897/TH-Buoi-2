namespace TH_Buoi_2_Client
{
    partial class Client
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
            this.BtnSendClient = new System.Windows.Forms.Button();
            this.txtboxMessageClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Listbox = new System.Windows.Forms.ListBox();
            this.txtboxIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnConn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSendClient
            // 
            this.BtnSendClient.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSendClient.Location = new System.Drawing.Point(602, 390);
            this.BtnSendClient.Name = "BtnSendClient";
            this.BtnSendClient.Size = new System.Drawing.Size(80, 72);
            this.BtnSendClient.TabIndex = 17;
            this.BtnSendClient.Text = "Send";
            this.BtnSendClient.UseVisualStyleBackColor = true;
            this.BtnSendClient.Click += new System.EventHandler(this.BtnSendClient_Click);
            // 
            // txtboxMessageClient
            // 
            this.txtboxMessageClient.Location = new System.Drawing.Point(36, 390);
            this.txtboxMessageClient.Multiline = true;
            this.txtboxMessageClient.Name = "txtboxMessageClient";
            this.txtboxMessageClient.Size = new System.Drawing.Size(544, 95);
            this.txtboxMessageClient.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(33, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Message";
            // 
            // Listbox
            // 
            this.Listbox.FormattingEnabled = true;
            this.Listbox.ItemHeight = 16;
            this.Listbox.Location = new System.Drawing.Point(36, 79);
            this.Listbox.Name = "Listbox";
            this.Listbox.Size = new System.Drawing.Size(544, 260);
            this.Listbox.TabIndex = 11;
            // 
            // txtboxIP
            // 
            this.txtboxIP.Location = new System.Drawing.Point(108, 21);
            this.txtboxIP.Multiline = true;
            this.txtboxIP.Name = "txtboxIP";
            this.txtboxIP.Size = new System.Drawing.Size(267, 30);
            this.txtboxIP.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Server";
            // 
            // BtnConn
            // 
            this.BtnConn.Location = new System.Drawing.Point(401, 12);
            this.BtnConn.Name = "BtnConn";
            this.BtnConn.Size = new System.Drawing.Size(106, 52);
            this.BtnConn.TabIndex = 18;
            this.BtnConn.Text = "Connect";
            this.BtnConn.UseVisualStyleBackColor = true;
            this.BtnConn.Click += new System.EventHandler(this.BtnConn_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 497);
            this.Controls.Add(this.BtnConn);
            this.Controls.Add(this.BtnSendClient);
            this.Controls.Add(this.txtboxMessageClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Listbox);
            this.Controls.Add(this.txtboxIP);
            this.Controls.Add(this.label1);
            this.Name = "Client";
            this.Text = "Chat Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSendClient;
        private System.Windows.Forms.TextBox txtboxMessageClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Listbox;
        private System.Windows.Forms.TextBox txtboxIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConn;
    }
}

