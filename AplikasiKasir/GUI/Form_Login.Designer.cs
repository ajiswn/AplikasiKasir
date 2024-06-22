namespace AplikasiKasir.GUI
{
    partial class Form_Login
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
            label1 = new Label();
            label2 = new Label();
            textBox_username = new TextBox();
            textBox_password = new TextBox();
            buttonLogin = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 72);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 122);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // textBox_username
            // 
            textBox_username.Location = new Point(148, 65);
            textBox_username.Name = "textBox_username";
            textBox_username.PlaceholderText = "Your Username";
            textBox_username.Size = new Size(234, 27);
            textBox_username.TabIndex = 2;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(148, 119);
            textBox_password.Name = "textBox_password";
            textBox_password.PasswordChar = '#';
            textBox_password.PlaceholderText = "Your Password";
            textBox_password.Size = new Size(234, 27);
            textBox_password.TabIndex = 3;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.YellowGreen;
            buttonLogin.Location = new Point(124, 205);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(94, 29);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(251, 205);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 303);
            Controls.Add(buttonCancel);
            Controls.Add(buttonLogin);
            Controls.Add(textBox_password);
            Controls.Add(textBox_username);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form_Login";
            StartPosition = FormStartPosition.CenterParent;
            Text = ":: LOGIN ::";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox_username;
        private TextBox textBox_password;
        private Button buttonLogin;
        private Button buttonCancel;
    }
}