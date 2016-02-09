namespace Thumbnail
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.destinationDir = new System.Windows.Forms.TextBox();
            this.txtboxScale = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoWidth = new System.Windows.Forms.RadioButton();
            this.txtboxWidth = new System.Windows.Forms.TextBox();
            this.rdoHeight = new System.Windows.Forms.RadioButton();
            this.txtboxHegiht = new System.Windows.Forms.TextBox();
            this.rdoScale = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.selectDir = new System.Windows.Forms.TextBox();
            this.messageList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(474, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "轉換";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 24);
            this.button2.TabIndex = 1;
            this.button2.Text = "儲存資料夾路徑";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // destinationDir
            // 
            this.destinationDir.Location = new System.Drawing.Point(145, 13);
            this.destinationDir.Name = "destinationDir";
            this.destinationDir.Size = new System.Drawing.Size(394, 22);
            this.destinationDir.TabIndex = 2;
            // 
            // txtboxScale
            // 
            this.txtboxScale.Location = new System.Drawing.Point(87, 10);
            this.txtboxScale.Name = "txtboxScale";
            this.txtboxScale.Size = new System.Drawing.Size(57, 22);
            this.txtboxScale.TabIndex = 4;
            this.txtboxScale.Text = "0.73";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rdoWidth);
            this.panel1.Controls.Add(this.txtboxWidth);
            this.panel1.Controls.Add(this.rdoHeight);
            this.panel1.Controls.Add(this.txtboxHegiht);
            this.panel1.Controls.Add(this.rdoScale);
            this.panel1.Controls.Add(this.txtboxScale);
            this.panel1.Location = new System.Drawing.Point(22, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 43);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "(Pixel)";
            // 
            // rdoWidth
            // 
            this.rdoWidth.AutoSize = true;
            this.rdoWidth.Location = new System.Drawing.Point(156, 12);
            this.rdoWidth.Name = "rdoWidth";
            this.rdoWidth.Size = new System.Drawing.Size(95, 16);
            this.rdoWidth.TabIndex = 7;
            this.rdoWidth.Text = "限制最大寬度";
            this.rdoWidth.UseVisualStyleBackColor = true;
            // 
            // txtboxWidth
            // 
            this.txtboxWidth.Location = new System.Drawing.Point(251, 10);
            this.txtboxWidth.Name = "txtboxWidth";
            this.txtboxWidth.Size = new System.Drawing.Size(57, 22);
            this.txtboxWidth.TabIndex = 8;
            this.txtboxWidth.Text = "500";
            // 
            // rdoHeight
            // 
            this.rdoHeight.AutoSize = true;
            this.rdoHeight.Location = new System.Drawing.Point(314, 12);
            this.rdoHeight.Name = "rdoHeight";
            this.rdoHeight.Size = new System.Drawing.Size(98, 16);
            this.rdoHeight.TabIndex = 5;
            this.rdoHeight.Text = "限制最大高度:";
            this.rdoHeight.UseVisualStyleBackColor = true;
            // 
            // txtboxHegiht
            // 
            this.txtboxHegiht.Location = new System.Drawing.Point(411, 10);
            this.txtboxHegiht.Name = "txtboxHegiht";
            this.txtboxHegiht.Size = new System.Drawing.Size(57, 22);
            this.txtboxHegiht.TabIndex = 6;
            this.txtboxHegiht.Text = "500";
            // 
            // rdoScale
            // 
            this.rdoScale.AutoSize = true;
            this.rdoScale.Checked = true;
            this.rdoScale.Location = new System.Drawing.Point(12, 13);
            this.rdoScale.Name = "rdoScale";
            this.rdoScale.Size = new System.Drawing.Size(74, 16);
            this.rdoScale.TabIndex = 0;
            this.rdoScale.TabStop = true;
            this.rdoScale.Text = "縮放倍率:";
            this.rdoScale.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(242, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "來源檔案夾(會讀取該目錄下所有圖片檔案)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureListView
            // 
            this.pictureListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.pictureListView.Location = new System.Drawing.Point(145, 114);
            this.pictureListView.Name = "pictureListView";
            this.pictureListView.Size = new System.Drawing.Size(394, 124);
            this.pictureListView.TabIndex = 7;
            this.pictureListView.UseCompatibleStateImageBehavior = false;
            this.pictureListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "檔案名稱(Name)";
            this.columnHeader1.Width = 234;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "圖片類型(Type)";
            this.columnHeader2.Width = 111;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(21, 243);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(518, 19);
            this.progressBar1.TabIndex = 8;
            // 
            // selectDir
            // 
            this.selectDir.Location = new System.Drawing.Point(269, 84);
            this.selectDir.Name = "selectDir";
            this.selectDir.Size = new System.Drawing.Size(270, 22);
            this.selectDir.TabIndex = 9;
            this.selectDir.Leave += new System.EventHandler(this.selectDir_Leave);
            // 
            // messageList
            // 
            this.messageList.FormattingEnabled = true;
            this.messageList.ItemHeight = 12;
            this.messageList.Location = new System.Drawing.Point(21, 114);
            this.messageList.Name = "messageList";
            this.messageList.Size = new System.Drawing.Size(118, 124);
            this.messageList.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 48);
            this.label1.TabIndex = 11;
            this.label1.Text = "Usage:\r\n1.選擇[儲存資料夾的路徑]\r\n2.選擇[來源資料夾的路徑]\r\n3.點下轉換\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "※若轉換失敗會在 [儲存資料夾路徑] 下建立[轉換失敗清單.txt]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "[註]無論長高皆為等比例轉換";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(468, 319);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(83, 12);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Powered By UM";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 338);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageList);
            this.Controls.Add(this.selectDir);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureListView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.destinationDir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " Thumbnail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox destinationDir;
        private System.Windows.Forms.TextBox txtboxScale;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoWidth;
        private System.Windows.Forms.TextBox txtboxWidth;
        private System.Windows.Forms.RadioButton rdoHeight;
        private System.Windows.Forms.TextBox txtboxHegiht;
        private System.Windows.Forms.RadioButton rdoScale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView pictureListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox selectDir;
        private System.Windows.Forms.ListBox messageList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

