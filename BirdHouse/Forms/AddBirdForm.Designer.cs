
namespace BirdHouse.Forms
{
    partial class AddBirdForm
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
            serialNumberBoxTextBox = new TextBox();
            cageNumberTextBox = new TextBox();
            dadSerialTextBox = new TextBox();
            momSerialTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            AddBirdButton = new Button();
            hatchDateTimePicker = new DateTimePicker();
            kindComboBox = new ComboBox();
            subKindComboBox = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            SuspendLayout();
            // 
            // serialNumberBoxTextBox
            // 
            serialNumberBoxTextBox.Location = new Point(221, 33);
            serialNumberBoxTextBox.Name = "serialNumberBoxTextBox";
            serialNumberBoxTextBox.Size = new Size(189, 39);
            serialNumberBoxTextBox.TabIndex = 0;
            serialNumberBoxTextBox.TextChanged += serialNumberBoxTextBox_TextChanged;
            // 
            // cageNumberTextBox
            // 
            cageNumberTextBox.Location = new Point(221, 164);
            cageNumberTextBox.Name = "cageNumberTextBox";
            cageNumberTextBox.Size = new Size(189, 39);
            cageNumberTextBox.TabIndex = 3;
            // 
            // dadSerialTextBox
            // 
            dadSerialTextBox.Location = new Point(221, 208);
            dadSerialTextBox.Name = "dadSerialTextBox";
            dadSerialTextBox.Size = new Size(189, 39);
            dadSerialTextBox.TabIndex = 4;
            // 
            // momSerialTextBox
            // 
            momSerialTextBox.Location = new Point(221, 252);
            momSerialTextBox.Name = "momSerialTextBox";
            momSerialTextBox.Size = new Size(189, 39);
            momSerialTextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 38);
            label1.Name = "label1";
            label1.Size = new Size(168, 32);
            label1.TabIndex = 8;
            label1.Text = "Serial number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 82);
            label2.Name = "label2";
            label2.Size = new Size(74, 32);
            label2.TabIndex = 9;
            label2.Text = "Kind: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 126);
            label3.Name = "label3";
            label3.Size = new Size(113, 32);
            label3.TabIndex = 11;
            label3.Text = "Sub kind:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 170);
            label4.Name = "label4";
            label4.Size = new Size(164, 32);
            label4.TabIndex = 10;
            label4.Text = "Cage number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 213);
            label5.Name = "label5";
            label5.Size = new Size(215, 32);
            label5.TabIndex = 15;
            label5.Text = "Dad serial number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 257);
            label6.Name = "label6";
            label6.Size = new Size(228, 32);
            label6.TabIndex = 14;
            label6.Text = "mom serial number:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(78, 301);
            label7.Name = "label7";
            label7.Size = new Size(138, 32);
            label7.TabIndex = 13;
            label7.Text = "Hatch Date:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(151, 345);
            label8.Name = "label8";
            label8.Size = new Size(63, 32);
            label8.TabIndex = 12;
            label8.Text = "Sex :";
            // 
            // AddBirdButton
            // 
            AddBirdButton.Location = new Point(221, 383);
            AddBirdButton.Name = "AddBirdButton";
            AddBirdButton.Size = new Size(142, 43);
            AddBirdButton.TabIndex = 16;
            AddBirdButton.Text = "AddBird";
            AddBirdButton.TextAlign = ContentAlignment.BottomCenter;
            AddBirdButton.UseVisualStyleBackColor = true;
            AddBirdButton.Click += AddBirdButton_Click;
            // 
            // hatchDateTimePicker
            // 
            hatchDateTimePicker.Format = DateTimePickerFormat.Short;
            hatchDateTimePicker.Location = new Point(218, 295);
            hatchDateTimePicker.Name = "hatchDateTimePicker";
            hatchDateTimePicker.Size = new Size(192, 39);
            hatchDateTimePicker.TabIndex = 17;
            hatchDateTimePicker.ValueChanged += hatchDateTimePicker_ValueChanged;
            // 
            // kindComboBox
            // 
            kindComboBox.FormattingEnabled = true;
            kindComboBox.Location = new Point(221, 77);
            kindComboBox.Name = "kindComboBox";
            kindComboBox.Size = new Size(189, 40);
            kindComboBox.TabIndex = 18;
            kindComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // subKindComboBox
            // 
            subKindComboBox.FormattingEnabled = true;
            subKindComboBox.Location = new Point(221, 123);
            subKindComboBox.Name = "subKindComboBox";
            subKindComboBox.Size = new Size(189, 40);
            subKindComboBox.TabIndex = 19;
            subKindComboBox.SelectedIndexChanged += subKindComboBox_SelectedIndexChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(325, 340);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(122, 36);
            radioButton1.TabIndex = 20;
            radioButton1.TabStop = true;
            radioButton1.Text = "Female";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(221, 340);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(98, 36);
            radioButton2.TabIndex = 21;
            radioButton2.TabStop = true;
            radioButton2.Text = "Male";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // AddBirdForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 464);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(subKindComboBox);
            Controls.Add(kindComboBox);
            Controls.Add(hatchDateTimePicker);
            Controls.Add(AddBirdButton);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(momSerialTextBox);
            Controls.Add(dadSerialTextBox);
            Controls.Add(cageNumberTextBox);
            Controls.Add(serialNumberBoxTextBox);
            Name = "AddBirdForm";
            Text = "AddBirdForm";
            Load += AddBirdForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox serialNumberBoxTextBox;
        private TextBox cageNumberTextBox;
        private TextBox dadSerialTextBox;
        private TextBox momSerialTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button AddBirdButton;
        private DateTimePicker hatchDateTimePicker;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox kindComboBox;
        private ComboBox subKindComboBox;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}