namespace frmWin.ClassInfo
{
    partial class NoClassStuFrm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.changebtn = new System.Windows.Forms.Button();
            this.NoclassStu = new System.Windows.Forms.DataGridView();
            this.ClassType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NoclassStu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("宋体", 12F);
            this.btnExit.Location = new System.Drawing.Point(694, 363);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(59, 26);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // changebtn
            // 
            this.changebtn.Font = new System.Drawing.Font("宋体", 12F);
            this.changebtn.Location = new System.Drawing.Point(589, 363);
            this.changebtn.Margin = new System.Windows.Forms.Padding(2);
            this.changebtn.Name = "changebtn";
            this.changebtn.Size = new System.Drawing.Size(59, 26);
            this.changebtn.TabIndex = 17;
            this.changebtn.Text = "修改";
            this.changebtn.UseVisualStyleBackColor = true;
            this.changebtn.Click += new System.EventHandler(this.changebtn_Click);
            // 
            // NoclassStu
            // 
            this.NoclassStu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NoclassStu.Location = new System.Drawing.Point(336, 62);
            this.NoclassStu.Margin = new System.Windows.Forms.Padding(2);
            this.NoclassStu.Name = "NoclassStu";
            this.NoclassStu.RowHeadersWidth = 51;
            this.NoclassStu.RowTemplate.Height = 27;
            this.NoclassStu.Size = new System.Drawing.Size(416, 270);
            this.NoclassStu.TabIndex = 16;
            // 
            // ClassType
            // 
            this.ClassType.Font = new System.Drawing.Font("宋体", 15F);
            this.ClassType.FormattingEnabled = true;
            this.ClassType.Location = new System.Drawing.Point(141, 177);
            this.ClassType.Margin = new System.Windows.Forms.Padding(2);
            this.ClassType.Name = "ClassType";
            this.ClassType.Size = new System.Drawing.Size(180, 28);
            this.ClassType.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(35, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "修改班级";
            // 
            // NoClassStuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.changebtn);
            this.Controls.Add(this.NoclassStu);
            this.Controls.Add(this.ClassType);
            this.Controls.Add(this.label2);
            this.Name = "NoClassStuFrm";
            this.Text = "NoClassStuFrm";
            ((System.ComponentModel.ISupportInitialize)(this.NoclassStu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button changebtn;
        private System.Windows.Forms.DataGridView NoclassStu;
        private System.Windows.Forms.ComboBox ClassType;
        private System.Windows.Forms.Label label2;
    }
}