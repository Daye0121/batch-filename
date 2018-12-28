namespace BatchFilename
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_SelectPath = new System.Windows.Forms.TextBox();
            this.btn_SelectPath = new System.Windows.Forms.Button();
            this.lbl_Format = new System.Windows.Forms.Label();
            this.txt_Format = new System.Windows.Forms.TextBox();
            this.lbl_SelectPath = new System.Windows.Forms.Label();
            this.btn_Rename = new System.Windows.Forms.Button();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_FormatView = new System.Windows.Forms.Label();
            this.lbl_Remark = new System.Windows.Forms.Label();
            this.ck_ParentPath = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_FormatView_Final = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_SelectPath
            // 
            this.txt_SelectPath.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_SelectPath.Location = new System.Drawing.Point(111, 40);
            this.txt_SelectPath.Name = "txt_SelectPath";
            this.txt_SelectPath.ReadOnly = true;
            this.txt_SelectPath.Size = new System.Drawing.Size(303, 27);
            this.txt_SelectPath.TabIndex = 0;
            // 
            // btn_SelectPath
            // 
            this.btn_SelectPath.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_SelectPath.Location = new System.Drawing.Point(420, 40);
            this.btn_SelectPath.Name = "btn_SelectPath";
            this.btn_SelectPath.Size = new System.Drawing.Size(87, 27);
            this.btn_SelectPath.TabIndex = 0;
            this.btn_SelectPath.Text = "選擇路徑";
            this.btn_SelectPath.UseVisualStyleBackColor = true;
            this.btn_SelectPath.Click += new System.EventHandler(this.btn_SelectPath_Click);
            // 
            // lbl_Format
            // 
            this.lbl_Format.AutoSize = true;
            this.lbl_Format.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Format.Location = new System.Drawing.Point(12, 84);
            this.lbl_Format.Name = "lbl_Format";
            this.lbl_Format.Size = new System.Drawing.Size(93, 16);
            this.lbl_Format.TabIndex = 2;
            this.lbl_Format.Text = "命名格式：";
            // 
            // txt_Format
            // 
            this.txt_Format.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Format.Location = new System.Drawing.Point(111, 81);
            this.txt_Format.Name = "txt_Format";
            this.txt_Format.Size = new System.Drawing.Size(303, 27);
            this.txt_Format.TabIndex = 3;
            this.txt_Format.TextChanged += new System.EventHandler(this.txt_Format_TextChanged);
            // 
            // lbl_SelectPath
            // 
            this.lbl_SelectPath.AutoSize = true;
            this.lbl_SelectPath.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_SelectPath.Location = new System.Drawing.Point(12, 43);
            this.lbl_SelectPath.Name = "lbl_SelectPath";
            this.lbl_SelectPath.Size = new System.Drawing.Size(59, 16);
            this.lbl_SelectPath.TabIndex = 4;
            this.lbl_SelectPath.Text = "路徑：";
            // 
            // btn_Rename
            // 
            this.btn_Rename.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Rename.Location = new System.Drawing.Point(420, 412);
            this.btn_Rename.Name = "btn_Rename";
            this.btn_Rename.Size = new System.Drawing.Size(87, 27);
            this.btn_Rename.TabIndex = 6;
            this.btn_Rename.Text = "重新命名";
            this.btn_Rename.UseVisualStyleBackColor = true;
            this.btn_Rename.Click += new System.EventHandler(this.btn_Rename_Click);
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Total.ForeColor = System.Drawing.Color.Brown;
            this.lbl_Total.Location = new System.Drawing.Point(395, 373);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(112, 16);
            this.lbl_Total.TabIndex = 7;
            this.lbl_Total.Text = "總共有0個檔案";
            // 
            // lbl_FormatView
            // 
            this.lbl_FormatView.AutoSize = true;
            this.lbl_FormatView.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_FormatView.Location = new System.Drawing.Point(138, 163);
            this.lbl_FormatView.Name = "lbl_FormatView";
            this.lbl_FormatView.Size = new System.Drawing.Size(24, 16);
            this.lbl_FormatView.TabIndex = 11;
            this.lbl_FormatView.Text = "　";
            // 
            // lbl_Remark
            // 
            this.lbl_Remark.AutoSize = true;
            this.lbl_Remark.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Remark.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Remark.Location = new System.Drawing.Point(299, 133);
            this.lbl_Remark.Name = "lbl_Remark";
            this.lbl_Remark.Size = new System.Drawing.Size(208, 30);
            this.lbl_Remark.TabIndex = 12;
            this.lbl_Remark.Text = "例如:File1, File2...，就輸入File*\r\n預設為1, 2, 3...\r\n";
            // 
            // ck_ParentPath
            // 
            this.ck_ParentPath.AutoSize = true;
            this.ck_ParentPath.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ck_ParentPath.Location = new System.Drawing.Point(15, 140);
            this.ck_ParentPath.Name = "ck_ParentPath";
            this.ck_ParentPath.Size = new System.Drawing.Size(162, 20);
            this.ck_ParentPath.TabIndex = 13;
            this.ck_ParentPath.Text = "需要上層目錄名嗎?";
            this.ck_ParentPath.UseVisualStyleBackColor = true;
            this.ck_ParentPath.CheckedChanged += new System.EventHandler(this.ck_ParentPath_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 14;
            // 
            // lbl_FormatView_Final
            // 
            this.lbl_FormatView_Final.AutoSize = true;
            this.lbl_FormatView_Final.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_FormatView_Final.ForeColor = System.Drawing.Color.Brown;
            this.lbl_FormatView_Final.Location = new System.Drawing.Point(15, 244);
            this.lbl_FormatView_Final.Name = "lbl_FormatView_Final";
            this.lbl_FormatView_Final.Size = new System.Drawing.Size(88, 16);
            this.lbl_FormatView_Final.TabIndex = 15;
            this.lbl_FormatView_Final.Text = "輸出格式：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 451);
            this.Controls.Add(this.lbl_FormatView_Final);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ck_ParentPath);
            this.Controls.Add(this.lbl_Remark);
            this.Controls.Add(this.lbl_FormatView);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.btn_Rename);
            this.Controls.Add(this.lbl_SelectPath);
            this.Controls.Add(this.txt_Format);
            this.Controls.Add(this.lbl_Format);
            this.Controls.Add(this.btn_SelectPath);
            this.Controls.Add(this.txt_SelectPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_SelectPath;
        private System.Windows.Forms.Button btn_SelectPath;
        private System.Windows.Forms.Label lbl_Format;
        private System.Windows.Forms.TextBox txt_Format;
        private System.Windows.Forms.Label lbl_SelectPath;
        private System.Windows.Forms.Button btn_Rename;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_FormatView;
        private System.Windows.Forms.Label lbl_Remark;
        private System.Windows.Forms.CheckBox ck_ParentPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_FormatView_Final;
    }
}

