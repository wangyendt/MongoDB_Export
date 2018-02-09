namespace MongoDB_Export
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tbDataBaseAddr = new System.Windows.Forms.TextBox();
            this.tbLibName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSetName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbExportDir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbExportFileName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(73, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据库地址:";
            // 
            // tbDataBaseAddr
            // 
            this.tbDataBaseAddr.Location = new System.Drawing.Point(192, 31);
            this.tbDataBaseAddr.Name = "tbDataBaseAddr";
            this.tbDataBaseAddr.Size = new System.Drawing.Size(371, 25);
            this.tbDataBaseAddr.TabIndex = 1;
            this.tbDataBaseAddr.Text = "localhost:27017";
            this.tbDataBaseAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbLibName
            // 
            this.tbLibName.Location = new System.Drawing.Point(192, 79);
            this.tbLibName.Name = "tbLibName";
            this.tbLibName.Size = new System.Drawing.Size(371, 25);
            this.tbLibName.TabIndex = 3;
            this.tbLibName.Text = "default";
            this.tbLibName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(118, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "库名:";
            // 
            // tbSetName
            // 
            this.tbSetName.Location = new System.Drawing.Point(192, 127);
            this.tbSetName.Name = "tbSetName";
            this.tbSetName.Size = new System.Drawing.Size(371, 25);
            this.tbSetName.TabIndex = 5;
            this.tbSetName.Text = "default";
            this.tbSetName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(58, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "数据库集合名:";
            // 
            // tbExportDir
            // 
            this.tbExportDir.Location = new System.Drawing.Point(192, 175);
            this.tbExportDir.Name = "tbExportDir";
            this.tbExportDir.Size = new System.Drawing.Size(371, 25);
            this.tbExportDir.TabIndex = 7;
            this.tbExportDir.Text = "E:/Programmes/MongoDB/data/export_files/";
            this.tbExportDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(88, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "导出目录:";
            // 
            // tbExportFileName
            // 
            this.tbExportFileName.Location = new System.Drawing.Point(192, 223);
            this.tbExportFileName.Name = "tbExportFileName";
            this.tbExportFileName.Size = new System.Drawing.Size(371, 25);
            this.tbExportFileName.TabIndex = 9;
            this.tbExportFileName.Text = "My_export_file.xls";
            this.tbExportFileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(88, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "导出文件:";
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExport.BackgroundImage")));
            this.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExport.Font = new System.Drawing.Font("幼圆", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExport.Location = new System.Drawing.Point(214, 283);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(212, 74);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "导出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(618, 384);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.tbExportFileName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbExportDir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSetName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLibName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDataBaseAddr);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(636, 431);
            this.MinimumSize = new System.Drawing.Size(636, 431);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MongoDB Export, y.wang@newdegreetech.com";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDataBaseAddr;
        private System.Windows.Forms.TextBox tbLibName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSetName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbExportDir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbExportFileName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExport;
    }
}

