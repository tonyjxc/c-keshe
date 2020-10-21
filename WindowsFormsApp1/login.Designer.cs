namespace WindowsFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.register = new System.Windows.Forms.Button();
            this.Butlogin = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.username_txtbox = new System.Windows.Forms.TextBox();
            this.userid_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // register
            // 
            this.register.Font = new System.Drawing.Font("宋体", 14F);
            this.register.Location = new System.Drawing.Point(144, 307);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(140, 65);
            this.register.TabIndex = 0;
            this.register.Text = "注册";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.button1_Click);
            // 
            // Butlogin
            // 
            this.Butlogin.Font = new System.Drawing.Font("宋体", 14F);
            this.Butlogin.Location = new System.Drawing.Point(326, 307);
            this.Butlogin.Name = "Butlogin";
            this.Butlogin.Size = new System.Drawing.Size(140, 65);
            this.Butlogin.TabIndex = 1;
            this.Butlogin.Text = "登陆";
            this.Butlogin.UseVisualStyleBackColor = true;
            this.Butlogin.Click += new System.EventHandler(this.button2_Click);
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("宋体", 14F);
            this.logout.Location = new System.Drawing.Point(508, 307);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(140, 65);
            this.logout.TabIndex = 2;
            this.logout.Text = "退出";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // username_txtbox
            // 
            this.username_txtbox.Font = new System.Drawing.Font("宋体", 20F);
            this.username_txtbox.Location = new System.Drawing.Point(268, 112);
            this.username_txtbox.Multiline = true;
            this.username_txtbox.Name = "username_txtbox";
            this.username_txtbox.Size = new System.Drawing.Size(272, 50);
            this.username_txtbox.TabIndex = 3;
            // 
            // userid_txtbox
            // 
            this.userid_txtbox.Font = new System.Drawing.Font("宋体", 20F);
            this.userid_txtbox.Location = new System.Drawing.Point(268, 202);
            this.userid_txtbox.Multiline = true;
            this.userid_txtbox.Name = "userid_txtbox";
            this.userid_txtbox.PasswordChar = '*';
            this.userid_txtbox.Size = new System.Drawing.Size(272, 50);
            this.userid_txtbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F);
            this.label1.Location = new System.Drawing.Point(169, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 18F);
            this.label2.Location = new System.Drawing.Point(169, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "密码";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userid_txtbox);
            this.Controls.Add(this.username_txtbox);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.Butlogin);
            this.Controls.Add(this.register);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 200);
            this.Name = "Login";
            this.Text = "登陆";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Button Butlogin;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.TextBox username_txtbox;
        private System.Windows.Forms.TextBox userid_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

