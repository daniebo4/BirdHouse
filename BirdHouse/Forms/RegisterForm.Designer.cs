namespace BirdHouse
{
    partial class RegisterForm
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
            label2 = new Label();
            label1 = new Label();
            userNameBox = new TextBox();
            passwordBox = new TextBox();
            label3 = new Label();
            idBox = new TextBox();
            label4 = new Label();
            confirm = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 63);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 8;
            label2.Text = "Password : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 41);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 7;
            label1.Text = "User Name :";
            // 
            // userNameBox
            // 
            userNameBox.Location = new Point(85, 37);
            userNameBox.Margin = new Padding(2, 2, 2, 2);
            userNameBox.Name = "userNameBox";
            userNameBox.Size = new Size(166, 23);
            userNameBox.TabIndex = 6;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(85, 60);
            passwordBox.Margin = new Padding(2, 2, 2, 2);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(166, 23);
            passwordBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 87);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 10;
            label3.Text = "ID : ";
            // 
            // idBox
            // 
            idBox.Location = new Point(85, 84);
            idBox.Margin = new Padding(2, 2, 2, 2);
            idBox.Name = "idBox";
            idBox.Size = new Size(166, 23);
            idBox.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(126, 14);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 11;
            label4.Text = "Register";
            // 
            // confirm
            // 
            confirm.Location = new Point(85, 106);
            confirm.Margin = new Padding(2, 2, 2, 2);
            confirm.Name = "confirm";
            confirm.Size = new Size(78, 20);
            confirm.TabIndex = 12;
            confirm.Text = "Confirm";
            confirm.UseVisualStyleBackColor = true;
            confirm.Click += confirm_Click;
            // 
            // button2
            // 
            button2.Location = new Point(172, 106);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(78, 20);
            button2.TabIndex = 13;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 144);
            Controls.Add(button2);
            Controls.Add(confirm);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(idBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(userNameBox);
            Controls.Add(passwordBox);
            Margin = new Padding(2, 2, 2, 2);
            Name = "RegisterForm";
            Text = "Register";
            Load += RegisterForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox userNameBox;
        private TextBox passwordBox;
        private Label label3;
        private TextBox idBox;
        private Label label4;
        private Button confirm;
        private Button button2;
    }
}