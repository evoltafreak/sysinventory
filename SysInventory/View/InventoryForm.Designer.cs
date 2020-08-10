namespace SysInventory
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmdScan = new System.Windows.Forms.Button();
            this.CmdCompare = new System.Windows.Forms.Button();
            this.CmdUploadFileOne = new System.Windows.Forms.Button();
            this.LblScanOpenPath = new System.Windows.Forms.Label();
            this.Lbox1 = new System.Windows.Forms.ListBox();
            this.Lbox2 = new System.Windows.Forms.ListBox();
            this.LblListBox1 = new System.Windows.Forms.Label();
            this.LblListBox2 = new System.Windows.Forms.Label();
            this.LBoxScanList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmdFilter = new System.Windows.Forms.Button();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.LBoxFilteredScanList = new System.Windows.Forms.ListBox();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.CmdRemove = new System.Windows.Forms.Button();
            this.LblScanSavePath = new System.Windows.Forms.Label();
            this.CmdShow = new System.Windows.Forms.Button();
            this.CmdHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdScan
            // 
            this.CmdScan.Location = new System.Drawing.Point(28, 23);
            this.CmdScan.Margin = new System.Windows.Forms.Padding(4);
            this.CmdScan.Name = "CmdScan";
            this.CmdScan.Size = new System.Drawing.Size(250, 46);
            this.CmdScan.TabIndex = 0;
            this.CmdScan.Text = "Scan";
            this.CmdScan.UseVisualStyleBackColor = true;
            this.CmdScan.Click += new System.EventHandler(this.CmdScan_Click);
            // 
            // CmdCompare
            // 
            this.CmdCompare.Enabled = false;
            this.CmdCompare.Location = new System.Drawing.Point(34, 579);
            this.CmdCompare.Margin = new System.Windows.Forms.Padding(4);
            this.CmdCompare.Name = "CmdCompare";
            this.CmdCompare.Size = new System.Drawing.Size(250, 46);
            this.CmdCompare.TabIndex = 1;
            this.CmdCompare.Text = "Vergleichen";
            this.CmdCompare.UseVisualStyleBackColor = true;
            this.CmdCompare.Click += new System.EventHandler(this.CmdCompare_Click);
            // 
            // CmdUploadFileOne
            // 
            this.CmdUploadFileOne.Location = new System.Drawing.Point(28, 87);
            this.CmdUploadFileOne.Margin = new System.Windows.Forms.Padding(4);
            this.CmdUploadFileOne.Name = "CmdUploadFileOne";
            this.CmdUploadFileOne.Size = new System.Drawing.Size(250, 46);
            this.CmdUploadFileOne.TabIndex = 3;
            this.CmdUploadFileOne.Text = "Durchsuchen...";
            this.CmdUploadFileOne.UseVisualStyleBackColor = true;
            this.CmdUploadFileOne.Click += new System.EventHandler(this.CmdUploadFile_Click);
            // 
            // LblScanOpenPath
            // 
            this.LblScanOpenPath.AutoSize = true;
            this.LblScanOpenPath.Location = new System.Drawing.Point(296, 98);
            this.LblScanOpenPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblScanOpenPath.Name = "LblScanOpenPath";
            this.LblScanOpenPath.Size = new System.Drawing.Size(68, 25);
            this.LblScanOpenPath.TabIndex = 5;
            this.LblScanOpenPath.Text = "Pfad: ";
            // 
            // Lbox1
            // 
            this.Lbox1.FormattingEnabled = true;
            this.Lbox1.ItemHeight = 25;
            this.Lbox1.Location = new System.Drawing.Point(28, 694);
            this.Lbox1.Margin = new System.Windows.Forms.Padding(4);
            this.Lbox1.Name = "Lbox1";
            this.Lbox1.Size = new System.Drawing.Size(540, 279);
            this.Lbox1.TabIndex = 7;
            // 
            // Lbox2
            // 
            this.Lbox2.FormattingEnabled = true;
            this.Lbox2.ItemHeight = 25;
            this.Lbox2.Location = new System.Drawing.Point(616, 694);
            this.Lbox2.Margin = new System.Windows.Forms.Padding(4);
            this.Lbox2.Name = "Lbox2";
            this.Lbox2.Size = new System.Drawing.Size(540, 279);
            this.Lbox2.TabIndex = 8;
            // 
            // LblListBox1
            // 
            this.LblListBox1.AutoSize = true;
            this.LblListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.LblListBox1.Location = new System.Drawing.Point(24, 654);
            this.LblListBox1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblListBox1.Name = "LblListBox1";
            this.LblListBox1.Size = new System.Drawing.Size(175, 31);
            this.LblListBox1.TabIndex = 9;
            this.LblListBox1.Text = "Erster Scan ";
            // 
            // LblListBox2
            // 
            this.LblListBox2.AutoSize = true;
            this.LblListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.LblListBox2.Location = new System.Drawing.Point(610, 654);
            this.LblListBox2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblListBox2.Name = "LblListBox2";
            this.LblListBox2.Size = new System.Drawing.Size(193, 31);
            this.LblListBox2.TabIndex = 10;
            this.LblListBox2.Text = "Zweiter Scan ";
            // 
            // LBoxScanList
            // 
            this.LBoxScanList.FormattingEnabled = true;
            this.LBoxScanList.ItemHeight = 25;
            this.LBoxScanList.Location = new System.Drawing.Point(28, 262);
            this.LBoxScanList.Margin = new System.Windows.Forms.Padding(4);
            this.LBoxScanList.Name = "LBoxScanList";
            this.LBoxScanList.Size = new System.Drawing.Size(718, 279);
            this.LBoxScanList.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(24, 221);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Scanliste";
            // 
            // CmdFilter
            // 
            this.CmdFilter.Enabled = false;
            this.CmdFilter.Location = new System.Drawing.Point(28, 154);
            this.CmdFilter.Margin = new System.Windows.Forms.Padding(4);
            this.CmdFilter.Name = "CmdFilter";
            this.CmdFilter.Size = new System.Drawing.Size(250, 46);
            this.CmdFilter.TabIndex = 14;
            this.CmdFilter.Text = "Filtern";
            this.CmdFilter.UseVisualStyleBackColor = true;
            this.CmdFilter.Click += new System.EventHandler(this.CmdFilter_Click);
            // 
            // DatePicker
            // 
            this.DatePicker.Enabled = false;
            this.DatePicker.Location = new System.Drawing.Point(300, 160);
            this.DatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(392, 31);
            this.DatePicker.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(1040, 221);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "Auswahl";
            // 
            // LBoxFilteredScanList
            // 
            this.LBoxFilteredScanList.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.LBoxFilteredScanList.FormattingEnabled = true;
            this.LBoxFilteredScanList.ItemHeight = 25;
            this.LBoxFilteredScanList.Location = new System.Drawing.Point(1046, 262);
            this.LBoxFilteredScanList.Margin = new System.Windows.Forms.Padding(4);
            this.LBoxFilteredScanList.Name = "LBoxFilteredScanList";
            this.LBoxFilteredScanList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LBoxFilteredScanList.Size = new System.Drawing.Size(718, 279);
            this.LBoxFilteredScanList.TabIndex = 16;
            // 
            // CmdAdd
            // 
            this.CmdAdd.Enabled = false;
            this.CmdAdd.Location = new System.Drawing.Point(772, 273);
            this.CmdAdd.Margin = new System.Windows.Forms.Padding(4);
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.Size = new System.Drawing.Size(250, 46);
            this.CmdAdd.TabIndex = 18;
            this.CmdAdd.Text = "Hinzufügen >>";
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // CmdRemove
            // 
            this.CmdRemove.Enabled = false;
            this.CmdRemove.Location = new System.Drawing.Point(772, 344);
            this.CmdRemove.Margin = new System.Windows.Forms.Padding(4);
            this.CmdRemove.Name = "CmdRemove";
            this.CmdRemove.Size = new System.Drawing.Size(250, 46);
            this.CmdRemove.TabIndex = 19;
            this.CmdRemove.Text = "Entfernen";
            this.CmdRemove.UseVisualStyleBackColor = true;
            this.CmdRemove.Click += new System.EventHandler(this.CmdRemove_Click);
            // 
            // LblScanSavePath
            // 
            this.LblScanSavePath.AutoSize = true;
            this.LblScanSavePath.Location = new System.Drawing.Point(296, 35);
            this.LblScanSavePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblScanSavePath.Name = "LblScanSavePath";
            this.LblScanSavePath.Size = new System.Drawing.Size(68, 25);
            this.LblScanSavePath.TabIndex = 20;
            this.LblScanSavePath.Text = "Pfad: ";
            // 
            // CmdShow
            // 
            this.CmdShow.Enabled = false;
            this.CmdShow.Location = new System.Drawing.Point(772, 415);
            this.CmdShow.Margin = new System.Windows.Forms.Padding(4);
            this.CmdShow.Name = "CmdShow";
            this.CmdShow.Size = new System.Drawing.Size(250, 46);
            this.CmdShow.TabIndex = 21;
            this.CmdShow.Text = "Anzeigen";
            this.CmdShow.UseVisualStyleBackColor = true;
            this.CmdShow.Click += new System.EventHandler(this.CmdShow_Click);
            // 
            // CmdHistory
            // 
            this.CmdHistory.Enabled = false;
            this.CmdHistory.Location = new System.Drawing.Point(772, 483);
            this.CmdHistory.Margin = new System.Windows.Forms.Padding(4);
            this.CmdHistory.Name = "CmdHistory";
            this.CmdHistory.Size = new System.Drawing.Size(250, 46);
            this.CmdHistory.TabIndex = 22;
            this.CmdHistory.Text = "History";
            this.CmdHistory.UseVisualStyleBackColor = true;
            this.CmdHistory.Click += new System.EventHandler(this.CmdHistory_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1836, 1012);
            this.Controls.Add(this.CmdHistory);
            this.Controls.Add(this.CmdShow);
            this.Controls.Add(this.LblScanSavePath);
            this.Controls.Add(this.CmdRemove);
            this.Controls.Add(this.CmdAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBoxFilteredScanList);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.CmdFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBoxScanList);
            this.Controls.Add(this.LblListBox2);
            this.Controls.Add(this.LblListBox1);
            this.Controls.Add(this.Lbox2);
            this.Controls.Add(this.Lbox1);
            this.Controls.Add(this.LblScanOpenPath);
            this.Controls.Add(this.CmdUploadFileOne);
            this.Controls.Add(this.CmdCompare);
            this.Controls.Add(this.CmdScan);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "SysInventory";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button CmdAdd;
        private System.Windows.Forms.Button CmdCompare;
        private System.Windows.Forms.Button CmdFilter;
        private System.Windows.Forms.Button CmdHistory;
        private System.Windows.Forms.Button CmdRemove;
        private System.Windows.Forms.Button CmdScan;
        private System.Windows.Forms.Button CmdShow;
        private System.Windows.Forms.Button CmdUploadFileOne;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblListBox1;
        private System.Windows.Forms.Label LblListBox2;
        private System.Windows.Forms.Label LblScanOpenPath;
        private System.Windows.Forms.Label LblScanSavePath;
        private System.Windows.Forms.ListBox Lbox1;
        private System.Windows.Forms.ListBox Lbox2;
        private System.Windows.Forms.ListBox LBoxFilteredScanList;
        private System.Windows.Forms.ListBox LBoxScanList;

        #endregion
    }
}

