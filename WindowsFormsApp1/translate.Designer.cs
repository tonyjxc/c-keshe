namespace WindowsFormsApp1
{
    partial class translate
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
            this.question_text = new System.Windows.Forms.TextBox();
            this.question_lab = new System.Windows.Forms.Label();
            this.translate_lab = new System.Windows.Forms.Label();
            this.translate_but = new System.Windows.Forms.Button();
            this.back_but = new System.Windows.Forms.Button();
            this.exit_but = new System.Windows.Forms.Button();
            this.answer_txtbox = new System.Windows.Forms.TextBox();
            this.sayhello = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // question_text
            // 
            this.question_text.Font = new System.Drawing.Font("宋体", 15F);
            this.question_text.Location = new System.Drawing.Point(324, 124);
            this.question_text.Multiline = true;
            this.question_text.Name = "question_text";
            this.question_text.Size = new System.Drawing.Size(308, 60);
            this.question_text.TabIndex = 0;
            this.question_text.Text = "请输入要翻译的话";
            this.question_text.TextChanged += new System.EventHandler(this.question_text_TextChanged);
            // 
            // question_lab
            // 
            this.question_lab.AutoSize = true;
            this.question_lab.Font = new System.Drawing.Font("宋体", 12F);
            this.question_lab.Location = new System.Drawing.Point(205, 147);
            this.question_lab.Name = "question_lab";
            this.question_lab.Size = new System.Drawing.Size(88, 16);
            this.question_lab.TabIndex = 1;
            this.question_lab.Text = "请输入问题";
            // 
            // translate_lab
            // 
            this.translate_lab.AutoSize = true;
            this.translate_lab.Font = new System.Drawing.Font("宋体", 12F);
            this.translate_lab.Location = new System.Drawing.Point(231, 226);
            this.translate_lab.Name = "translate_lab";
            this.translate_lab.Size = new System.Drawing.Size(40, 16);
            this.translate_lab.TabIndex = 2;
            this.translate_lab.Text = "翻译";
            // 
            // translate_but
            // 
            this.translate_but.Font = new System.Drawing.Font("宋体", 12F);
            this.translate_but.Location = new System.Drawing.Point(173, 326);
            this.translate_but.Name = "translate_but";
            this.translate_but.Size = new System.Drawing.Size(130, 51);
            this.translate_but.TabIndex = 4;
            this.translate_but.Text = "翻译";
            this.translate_but.UseVisualStyleBackColor = true;
            this.translate_but.Click += new System.EventHandler(this.translate_but_Click);
            // 
            // back_but
            // 
            this.back_but.Font = new System.Drawing.Font("宋体", 15F);
            this.back_but.Location = new System.Drawing.Point(364, 326);
            this.back_but.Name = "back_but";
            this.back_but.Size = new System.Drawing.Size(130, 51);
            this.back_but.TabIndex = 5;
            this.back_but.Text = "返回";
            this.back_but.UseVisualStyleBackColor = true;
            this.back_but.Click += new System.EventHandler(this.back_but_Click);
            // 
            // exit_but
            // 
            this.exit_but.Font = new System.Drawing.Font("宋体", 15F);
            this.exit_but.Location = new System.Drawing.Point(550, 326);
            this.exit_but.Name = "exit_but";
            this.exit_but.Size = new System.Drawing.Size(130, 51);
            this.exit_but.TabIndex = 6;
            this.exit_but.Text = "退出";
            this.exit_but.UseVisualStyleBackColor = true;
            this.exit_but.Click += new System.EventHandler(this.exit_but_Click);
            // 
            // answer_txtbox
            // 
            this.answer_txtbox.Font = new System.Drawing.Font("宋体", 15F);
            this.answer_txtbox.Location = new System.Drawing.Point(324, 209);
            this.answer_txtbox.Multiline = true;
            this.answer_txtbox.Name = "answer_txtbox";
            this.answer_txtbox.Size = new System.Drawing.Size(308, 60);
            this.answer_txtbox.TabIndex = 7;
            this.answer_txtbox.Text = "结果待展示";
            // 
            // sayhello
            // 
            this.sayhello.AutoSize = true;
            this.sayhello.Font = new System.Drawing.Font("宋体", 15F);
            this.sayhello.Location = new System.Drawing.Point(186, 40);
            this.sayhello.Name = "sayhello";
            this.sayhello.Size = new System.Drawing.Size(19, 20);
            this.sayhello.TabIndex = 8;
            this.sayhello.Text = " ";
            // 
            // translate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sayhello);
            this.Controls.Add(this.answer_txtbox);
            this.Controls.Add(this.exit_but);
            this.Controls.Add(this.back_but);
            this.Controls.Add(this.translate_but);
            this.Controls.Add(this.translate_lab);
            this.Controls.Add(this.question_lab);
            this.Controls.Add(this.question_text);
            this.Name = "translate";
            this.Text = "翻译";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox question_text;
        private System.Windows.Forms.Label question_lab;
        private System.Windows.Forms.Label translate_lab;
        private System.Windows.Forms.Button translate_but;
        private System.Windows.Forms.Button back_but;
        private System.Windows.Forms.Button exit_but;
        private System.Windows.Forms.TextBox answer_txtbox;
        private System.Windows.Forms.Label sayhello;
    }
}