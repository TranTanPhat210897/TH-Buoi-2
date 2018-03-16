namespace TH_Buoi_2
{
    partial class Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxIP = new System.Windows.Forms.TextBox();
            this.Listbox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxMessage = new System.Windows.Forms.TextBox();
            this.BtnFiles = new System.Windows.Forms.Button();
            this.BtnMusics = new System.Windows.Forms.Button();
            this.BtnImages = new System.Windows.Forms.Button();
            this.BtnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtboxIP
            // 
            resources.ApplyResources(this.txtboxIP, "txtboxIP");
            this.txtboxIP.Name = "txtboxIP";
            // 
            // Listbox
            // 
            this.Listbox.FormattingEnabled = true;
            resources.ApplyResources(this.Listbox, "Listbox");
            this.Listbox.Name = "Listbox";
            this.Listbox.SelectedIndexChanged += new System.EventHandler(this.Listbox_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtboxMessage
            // 
            resources.ApplyResources(this.txtboxMessage, "txtboxMessage");
            this.txtboxMessage.Name = "txtboxMessage";
            this.txtboxMessage.TextChanged += new System.EventHandler(this.txtboxMessage_TextChanged);
            // 
            // BtnFiles
            // 
            resources.ApplyResources(this.BtnFiles, "BtnFiles");
            this.BtnFiles.Name = "BtnFiles";
            this.BtnFiles.UseVisualStyleBackColor = true;
            // 
            // BtnMusics
            // 
            resources.ApplyResources(this.BtnMusics, "BtnMusics");
            this.BtnMusics.Name = "BtnMusics";
            this.BtnMusics.UseVisualStyleBackColor = true;
            // 
            // BtnImages
            // 
            resources.ApplyResources(this.BtnImages, "BtnImages");
            this.BtnImages.Name = "BtnImages";
            this.BtnImages.UseVisualStyleBackColor = true;
            // 
            // BtnSend
            // 
            resources.ApplyResources(this.BtnSend, "BtnSend");
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // Server
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.BtnImages);
            this.Controls.Add(this.BtnMusics);
            this.Controls.Add(this.BtnFiles);
            this.Controls.Add(this.txtboxMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Listbox);
            this.Controls.Add(this.txtboxIP);
            this.Controls.Add(this.label1);
            this.Name = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxIP;
        private System.Windows.Forms.ListBox Listbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxMessage;
        private System.Windows.Forms.Button BtnFiles;
        private System.Windows.Forms.Button BtnMusics;
        private System.Windows.Forms.Button BtnImages;
        private System.Windows.Forms.Button BtnSend;
    }
}

