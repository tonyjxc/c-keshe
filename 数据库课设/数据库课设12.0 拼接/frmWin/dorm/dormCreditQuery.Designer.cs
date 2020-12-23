namespace frmWin.dorm
{
    partial class dormCreditQuery
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
            this.dgvDormCredit = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtclass = new System.Windows.Forms.TextBox();
            this.btnclass = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btncredit = new System.Windows.Forms.Button();
            this.btnavgclss = new System.Windows.Forms.Button();
            this.btnavgall = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtall = new System.Windows.Forms.TextBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnmess = new System.Windows.Forms.Button();
            this.buildName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dormNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dormCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDormCredit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDormCredit
            // 
            this.dgvDormCredit.AllowUserToOrderColumns = true;
            this.dgvDormCredit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDormCredit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buildName,
            this.dormNum,
            this.dormCredit,
            this.classname,
            this.Column4});
            this.dgvDormCredit.Location = new System.Drawing.Point(33, 136);
            this.dgvDormCredit.Name = "dgvDormCredit";
            this.dgvDormCredit.RowHeadersWidth = 51;
            this.dgvDormCredit.RowTemplate.Height = 27;
            this.dgvDormCredit.Size = new System.Drawing.Size(831, 274);
            this.dgvDormCredit.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(774, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "注：1为警告";
            // 
            // txtclass
            // 
            this.txtclass.Location = new System.Drawing.Point(187, 467);
            this.txtclass.Name = "txtclass";
            this.txtclass.Size = new System.Drawing.Size(131, 25);
            this.txtclass.TabIndex = 2;
            // 
            // btnclass
            // 
            this.btnclass.Location = new System.Drawing.Point(279, 52);
            this.btnclass.Name = "btnclass";
            this.btnclass.Size = new System.Drawing.Size(198, 56);
            this.btnclass.TabIndex = 3;
            this.btnclass.Text = "按照班级查询卫生";
            this.btnclass.UseVisualStyleBackColor = true;
            this.btnclass.Click += new System.EventHandler(this.btnclass_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "分数显示";
            // 
            // btncredit
            // 
            this.btncredit.Location = new System.Drawing.Point(41, 52);
            this.btncredit.Name = "btncredit";
            this.btncredit.Size = new System.Drawing.Size(198, 56);
            this.btncredit.TabIndex = 5;
            this.btncredit.Text = "按照分数查询卫生";
            this.btncredit.UseVisualStyleBackColor = true;
            this.btncredit.Click += new System.EventHandler(this.btncredit_Click);
            // 
            // btnavgclss
            // 
            this.btnavgclss.Location = new System.Drawing.Point(333, 449);
            this.btnavgclss.Name = "btnavgclss";
            this.btnavgclss.Size = new System.Drawing.Size(170, 56);
            this.btnavgclss.TabIndex = 6;
            this.btnavgclss.Text = "统计班级卫生平均分";
            this.btnavgclss.UseVisualStyleBackColor = true;
            this.btnavgclss.Click += new System.EventHandler(this.btnavgclss_Click);
            // 
            // btnavgall
            // 
            this.btnavgall.Location = new System.Drawing.Point(333, 513);
            this.btnavgall.Name = "btnavgall";
            this.btnavgall.Size = new System.Drawing.Size(170, 56);
            this.btnavgall.TabIndex = 7;
            this.btnavgall.Text = "统计整体卫生平均分";
            this.btnavgall.UseVisualStyleBackColor = true;
            this.btnavgall.Click += new System.EventHandler(this.btnavgall_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 541);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "整体分数显示";
            // 
            // txtall
            // 
            this.txtall.Location = new System.Drawing.Point(187, 531);
            this.txtall.Name = "txtall";
            this.txtall.Size = new System.Drawing.Size(131, 25);
            this.txtall.TabIndex = 8;
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(36, 469);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(121, 23);
            this.cmbClass.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "所查班级";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(748, 531);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 39);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnmess
            // 
            this.btnmess.Location = new System.Drawing.Point(502, 52);
            this.btnmess.Name = "btnmess";
            this.btnmess.Size = new System.Drawing.Size(135, 56);
            this.btnmess.TabIndex = 13;
            this.btnmess.Text = "通知辅导员";
            this.btnmess.UseVisualStyleBackColor = true;
            this.btnmess.Click += new System.EventHandler(this.btnmess_Click);
            // 
            // buildName
            // 
            this.buildName.DataPropertyName = "fk_buildid";
            this.buildName.HeaderText = "楼号";
            this.buildName.MinimumWidth = 6;
            this.buildName.Name = "buildName";
            this.buildName.Width = 125;
            // 
            // dormNum
            // 
            this.dormNum.DataPropertyName = "dormNum";
            this.dormNum.HeaderText = "寝室号";
            this.dormNum.MinimumWidth = 6;
            this.dormNum.Name = "dormNum";
            this.dormNum.Width = 125;
            // 
            // dormCredit
            // 
            this.dormCredit.DataPropertyName = "dorm_grade";
            this.dormCredit.HeaderText = "卫生分";
            this.dormCredit.MinimumWidth = 6;
            this.dormCredit.Name = "dormCredit";
            this.dormCredit.Width = 125;
            // 
            // classname
            // 
            this.classname.DataPropertyName = "name";
            this.classname.HeaderText = "班级";
            this.classname.MinimumWidth = 6;
            this.classname.Name = "classname";
            this.classname.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "warnflag";
            this.Column4.HeaderText = "是否警告";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // dormCreditQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 651);
            this.Controls.Add(this.btnmess);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtall);
            this.Controls.Add(this.btnavgall);
            this.Controls.Add(this.btnavgclss);
            this.Controls.Add(this.btncredit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnclass);
            this.Controls.Add(this.txtclass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDormCredit);
            this.Name = "dormCreditQuery";
            this.Text = "dormCreditQuery";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dormCreditQuery_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDormCredit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDormCredit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtclass;
        private System.Windows.Forms.Button btnclass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncredit;
        private System.Windows.Forms.Button btnavgclss;
        private System.Windows.Forms.Button btnavgall;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtall;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnmess;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dormNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dormCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn classname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}