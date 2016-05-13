namespace DirectoryCreator
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.txtParentDirectory = new System.Windows.Forms.TextBox();
            this.btnBrowseParentDirectory = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDirectoryNames = new System.Windows.Forms.TextBox();
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.parentFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkBoxSequenceNumber = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSequenceSeed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSequenceFormat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSeparator = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtParentDirectory
            // 
            this.txtParentDirectory.Location = new System.Drawing.Point(92, 12);
            this.txtParentDirectory.Name = "txtParentDirectory";
            this.txtParentDirectory.Size = new System.Drawing.Size(405, 20);
            this.txtParentDirectory.TabIndex = 1;
            this.txtParentDirectory.TextChanged += new System.EventHandler(this.txtParentDirectory_TextChanged);
            // 
            // btnBrowseParentDirectory
            // 
            this.btnBrowseParentDirectory.Location = new System.Drawing.Point(517, 10);
            this.btnBrowseParentDirectory.Name = "btnBrowseParentDirectory";
            this.btnBrowseParentDirectory.Size = new System.Drawing.Size(44, 23);
            this.btnBrowseParentDirectory.TabIndex = 2;
            this.btnBrowseParentDirectory.Text = "...";
            this.btnBrowseParentDirectory.UseVisualStyleBackColor = true;
            this.btnBrowseParentDirectory.Click += new System.EventHandler(this.btnBrowseParentDirectory_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtDirectoryNames);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtLogs);
            this.splitContainer1.Size = new System.Drawing.Size(587, 395);
            this.splitContainer1.SplitterDistance = 264;
            this.splitContainer1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSeparator);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSequenceFormat);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSequenceSeed);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.checkBoxSequenceNumber);
            this.panel1.Controls.Add(this.btnGo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBrowseParentDirectory);
            this.panel1.Controls.Add(this.txtParentDirectory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 82);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parent Directory";
            // 
            // txtDirectoryNames
            // 
            this.txtDirectoryNames.AcceptsReturn = true;
            this.txtDirectoryNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDirectoryNames.Enabled = false;
            this.txtDirectoryNames.Location = new System.Drawing.Point(0, 82);
            this.txtDirectoryNames.Multiline = true;
            this.txtDirectoryNames.Name = "txtDirectoryNames";
            this.txtDirectoryNames.Size = new System.Drawing.Size(587, 182);
            this.txtDirectoryNames.TabIndex = 1;
            // 
            // txtLogs
            // 
            this.txtLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogs.CausesValidation = false;
            this.txtLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogs.Enabled = false;
            this.txtLogs.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtLogs.Location = new System.Drawing.Point(0, 0);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLogs.Size = new System.Drawing.Size(587, 127);
            this.txtLogs.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.Enabled = false;
            this.btnGo.Location = new System.Drawing.Point(517, 35);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(44, 23);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // checkBoxSequenceNumber
            // 
            this.checkBoxSequenceNumber.AutoSize = true;
            this.checkBoxSequenceNumber.Checked = true;
            this.checkBoxSequenceNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSequenceNumber.Location = new System.Drawing.Point(6, 38);
            this.checkBoxSequenceNumber.Name = "checkBoxSequenceNumber";
            this.checkBoxSequenceNumber.Size = new System.Drawing.Size(224, 17);
            this.checkBoxSequenceNumber.TabIndex = 4;
            this.checkBoxSequenceNumber.Text = "Add sequence numbers to new directories";
            this.checkBoxSequenceNumber.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sequence initiates from";
            // 
            // txtSequenceSeed
            // 
            this.txtSequenceSeed.Location = new System.Drawing.Point(373, 35);
            this.txtSequenceSeed.Name = "txtSequenceSeed";
            this.txtSequenceSeed.Size = new System.Drawing.Size(27, 20);
            this.txtSequenceSeed.TabIndex = 6;
            this.txtSequenceSeed.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Format";
            // 
            // txtSequenceFormat
            // 
            this.txtSequenceFormat.Location = new System.Drawing.Point(465, 36);
            this.txtSequenceFormat.Name = "txtSequenceFormat";
            this.txtSequenceFormat.Size = new System.Drawing.Size(32, 20);
            this.txtSequenceFormat.TabIndex = 8;
            this.txtSequenceFormat.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Separator";
            // 
            // txtSeparator
            // 
            this.txtSeparator.Location = new System.Drawing.Point(373, 56);
            this.txtSeparator.Name = "txtSeparator";
            this.txtSeparator.Size = new System.Drawing.Size(27, 20);
            this.txtSeparator.TabIndex = 10;
            this.txtSeparator.Text = ". ";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 395);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtParentDirectory;
        private System.Windows.Forms.Button btnBrowseParentDirectory;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtDirectoryNames;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLogs;
        private System.Windows.Forms.FolderBrowserDialog parentFolderBrowserDialog;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckBox checkBoxSequenceNumber;
        private System.Windows.Forms.TextBox txtSequenceFormat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSequenceSeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSeparator;
        private System.Windows.Forms.Label label4;
    }
}