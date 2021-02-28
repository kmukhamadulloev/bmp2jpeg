namespace BMP2JPEG
{
    partial class appForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appForm));
            this.dropPanel = new System.Windows.Forms.Panel();
            this.labelDescription = new System.Windows.Forms.Label();
            this.visitMyWebSite = new System.Windows.Forms.LinkLabel();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.checkFolder = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // dropPanel
            // 
            this.dropPanel.AllowDrop = true;
            this.dropPanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dropPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dropPanel.BackgroundImage")));
            this.dropPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dropPanel.Location = new System.Drawing.Point(0, 0);
            this.dropPanel.Name = "dropPanel";
            this.dropPanel.Size = new System.Drawing.Size(453, 344);
            this.dropPanel.TabIndex = 0;
            this.dropPanel.Click += new System.EventHandler(this.dropPanel_Click);
            this.dropPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.dropPanel_DragDrop);
            this.dropPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.dropPanel_DragEnter);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(3, 347);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(79, 13);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "AppDescription";
            // 
            // visitMyWebSite
            // 
            this.visitMyWebSite.AutoSize = true;
            this.visitMyWebSite.Location = new System.Drawing.Point(373, 359);
            this.visitMyWebSite.Name = "visitMyWebSite";
            this.visitMyWebSite.Size = new System.Drawing.Size(80, 13);
            this.visitMyWebSite.TabIndex = 2;
            this.visitMyWebSite.TabStop = true;
            this.visitMyWebSite.Text = "visit my website";
            this.visitMyWebSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.visitMyWebSite_LinkClicked);
            // 
            // openFile
            // 
            this.openFile.Multiselect = true;
            // 
            // bw
            // 
            this.bw.WorkerReportsProgress = true;
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
            this.bw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw_ProgressChanged);
            this.bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_RunWorkerCompleted);
            // 
            // checkFolder
            // 
            this.checkFolder.AutoSize = true;
            this.checkFolder.Location = new System.Drawing.Point(301, 359);
            this.checkFolder.Name = "checkFolder";
            this.checkFolder.Size = new System.Drawing.Size(66, 13);
            this.checkFolder.TabIndex = 3;
            this.checkFolder.TabStop = true;
            this.checkFolder.Text = "check folder";
            this.checkFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.checkFolder_LinkClicked);
            // 
            // appForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 381);
            this.Controls.Add(this.checkFolder);
            this.Controls.Add(this.visitMyWebSite);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.dropPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "appForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMP2JPEG";
            this.Load += new System.EventHandler(this.appForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel dropPanel;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.LinkLabel visitMyWebSite;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.ComponentModel.BackgroundWorker bw;
        private System.Windows.Forms.LinkLabel checkFolder;
    }
}

