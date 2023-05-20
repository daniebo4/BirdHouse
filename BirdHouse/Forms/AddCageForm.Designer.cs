
namespace BirdHouse.Forms
{
    partial class AddCageForm
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            LengthTextBox = new TextBox();
            SerialNumberTextBox = new TextBox();
            WidthTextBox = new TextBox();
            HeightTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            AddCageButtonClick = new Button();
            MaterialComboBox = new ComboBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 56);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 17;
            label3.Text = "Material:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 100);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 16;
            label2.Text = "Size:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 15;
            label1.Text = "Serial number:";
            // 
            // LengthTextBox
            // 
            LengthTextBox.Location = new Point(55, 97);
            LengthTextBox.Margin = new Padding(2);
            LengthTextBox.Name = "LengthTextBox";
            LengthTextBox.Size = new Size(70, 23);
            LengthTextBox.TabIndex = 13;
            // 
            // SerialNumberTextBox
            // 
            SerialNumberTextBox.Location = new Point(93, 12);
            SerialNumberTextBox.Margin = new Padding(2);
            SerialNumberTextBox.Name = "SerialNumberTextBox";
            SerialNumberTextBox.Size = new Size(104, 23);
            SerialNumberTextBox.TabIndex = 12;
            SerialNumberTextBox.TextChanged += SerialNumberTextBox_TextChanged;
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(127, 97);
            WidthTextBox.Margin = new Padding(2);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(70, 23);
            WidthTextBox.TabIndex = 18;
            // 
            // HeightTextBox
            // 
            HeightTextBox.Location = new Point(199, 97);
            HeightTextBox.Margin = new Padding(2);
            HeightTextBox.Name = "HeightTextBox";
            HeightTextBox.Size = new Size(70, 23);
            HeightTextBox.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(72, 116);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(36, 12);
            label4.TabIndex = 20;
            label4.Text = "Length";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(143, 116);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(31, 12);
            label5.TabIndex = 21;
            label5.Text = "Width";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(215, 116);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(34, 12);
            label6.TabIndex = 22;
            label6.Text = "Height";
            // 
            // AddCageButtonClick
            // 
            AddCageButtonClick.Location = new Point(122, 169);
            AddCageButtonClick.Name = "AddCageButtonClick";
            AddCageButtonClick.Size = new Size(75, 23);
            AddCageButtonClick.TabIndex = 23;
            AddCageButtonClick.Text = "Add Cage";
            AddCageButtonClick.UseVisualStyleBackColor = true;
            AddCageButtonClick.Click += button1_Click;
            // 
            // MaterialComboBox
            // 
            MaterialComboBox.FormattingEnabled = true;
            MaterialComboBox.Location = new Point(93, 53);
            MaterialComboBox.Name = "MaterialComboBox";
            MaterialComboBox.Size = new Size(121, 23);
            MaterialComboBox.TabIndex = 24;
            // 
            // AddCageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 225);
            Controls.Add(MaterialComboBox);
            Controls.Add(AddCageButtonClick);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(HeightTextBox);
            Controls.Add(WidthTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LengthTextBox);
            Controls.Add(SerialNumberTextBox);
            Margin = new Padding(2);
            Name = "AddCageForm";
            Text = "AddCageForm";
            Load += AddCageForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox LengthTextBox;
        private TextBox SerialNumberTextBox;
        private TextBox WidthTextBox;
        private TextBox HeightTextBox;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button AddCageButtonClick;
        private ComboBox MaterialComboBox;
    }
}