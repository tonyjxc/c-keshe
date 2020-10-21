namespace WindowsFormsApp1
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.Butregister = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.username_txtbox = new System.Windows.Forms.TextBox();
            this.usersecret_txtbox1 = new System.Windows.Forms.TextBox();
            this.usersecret_txtbox2 = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.return_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Butregister
            // 
            this.Butregister.Font = new System.Drawing.Font("宋体", 14F);
            this.Butregister.Location = new System.Drawing.Point(178, 317);
            this.Butregister.Name = "Butregister";
            this.Butregister.Size = new System.Drawing.Size(135, 60);
            this.Butregister.TabIndex = 0;
            this.Butregister.Text = "注册";
            this.Butregister.UseVisualStyleBackColor = true;
            this.Butregister.Click += new System.EventHandler(this.button1_Click);
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("宋体", 14F);
            this.logout.Location = new System.Drawing.Point(533, 317);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(135, 60);
            this.logout.TabIndex = 1;
            this.logout.Text = "退出";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // username_txtbox
            // 
            this.username_txtbox.Font = new System.Drawing.Font("宋体", 15F);
            this.username_txtbox.Location = new System.Drawing.Point(338, 86);
            this.username_txtbox.Multiline = true;
            this.username_txtbox.Name = "username_txtbox";
            this.username_txtbox.Size = new System.Drawing.Size(218, 38);
            this.username_txtbox.TabIndex = 2;
            // 
            // usersecret_txtbox1
            // 
            this.usersecret_txtbox1.Font = new System.Drawing.Font("宋体", 15F);
            this.usersecret_txtbox1.Location = new System.Drawing.Point(338, 159);
            this.usersecret_txtbox1.Multiline = true;
            this.usersecret_txtbox1.Name = "usersecret_txtbox1";
            this.usersecret_txtbox1.PasswordChar = '*';
            this.usersecret_txtbox1.Size = new System.Drawing.Size(218, 38);
            this.usersecret_txtbox1.TabIndex = 3;
            // 
            // usersecret_txtbox2
            // 
            this.usersecret_txtbox2.Font = new System.Drawing.Font("宋体", 15F);
            this.usersecret_txtbox2.Location = new System.Drawing.Point(338, 226);
            this.usersecret_txtbox2.Multiline = true;
            this.usersecret_txtbox2.Name = "usersecret_txtbox2";
            this.usersecret_txtbox2.PasswordChar = '*';
            this.usersecret_txtbox2.Size = new System.Drawing.Size(218, 38);
            this.usersecret_txtbox2.TabIndex = 4;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("宋体", 15F);
            this.name.Location = new System.Drawing.Point(244, 104);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(69, 20);
            this.name.TabIndex = 5;
            this.name.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(244, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(243, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "确认密码";
            // 
            // return_but
            // 
            this.return_but.Font = new System.Drawing.Font("宋体", 14F);
            this.return_but.Location = new System.Drawing.Point(349, 317);
            this.return_but.Name = "return_but";
            this.return_but.Size = new System.Drawing.Size(134, 60);
            this.return_but.TabIndex = 8;
            this.return_but.Text = "返回";
            this.return_but.UseVisualStyleBackColor = true;
            this.return_but.Click += new System.EventHandler(this.return_but_Click);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.return_but);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.usersecret_txtbox2);
            this.Controls.Add(this.usersecret_txtbox1);
            this.Controls.Add(this.username_txtbox);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.Butregister);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 200);
            this.Name = "register";
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Butregister;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.TextBox username_txtbox;
        private System.Windows.Forms.TextBox usersecret_txtbox1;
        private System.Windows.Forms.TextBox usersecret_txtbox2;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button return_but;
    }
}