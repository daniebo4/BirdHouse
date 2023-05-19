
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
            this.serialNumberBoxTextBox = new System.Windows.Forms.TextBox();
            this.cageNumberTextBox = new System.Windows.Forms.TextBox();
            this.dadSerialTextBox = new System.Windows.Forms.TextBox();
            this.momSerialTextBox = new System.Windows.Forms.TextBox();
            this.sexTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AddBirdButton = new System.Windows.Forms.Button();
            this.hatchDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.kindComboBox = new System.Windows.Forms.ComboBox();
            this.subKindComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // serialNumberBoxTextBox
            // 
            this.serialNumberBoxTextBox.Location = new System.Drawing.Point(204, 31);
            this.serialNumberBoxTextBox.Name = "serialNumberBoxTextBox";
            this.serialNumberBoxTextBox.Size = new System.Drawing.Size(175, 35);
            this.serialNumberBoxTextBox.TabIndex = 0;
            // 
            // cageNumberTextBox
            // 
            this.cageNumberTextBox.Location = new System.Drawing.Point(204, 154);
            this.cageNumberTextBox.Name = "cageNumberTextBox";
            this.cageNumberTextBox.Size = new System.Drawing.Size(175, 35);
            this.cageNumberTextBox.TabIndex = 3;
            // 
            // dadSerialTextBox
            // 
            this.dadSerialTextBox.Location = new System.Drawing.Point(204, 195);
            this.dadSerialTextBox.Name = "dadSerialTextBox";
            this.dadSerialTextBox.Size = new System.Drawing.Size(175, 35);
            this.dadSerialTextBox.TabIndex = 4;
            // 
            // momSerialTextBox
            // 
            this.momSerialTextBox.Location = new System.Drawing.Point(204, 236);
            this.momSerialTextBox.Name = "momSerialTextBox";
            this.momSerialTextBox.Size = new System.Drawing.Size(175, 35);
            this.momSerialTextBox.TabIndex = 5;
            // 
            // sexTextBox
            // 
            this.sexTextBox.Location = new System.Drawing.Point(204, 318);
            this.sexTextBox.Name = "sexTextBox";
            this.sexTextBox.Size = new System.Drawing.Size(175, 35);
            this.sexTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Serial number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kind: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sub kind:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cage number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 30);
            this.label5.TabIndex = 15;
            this.label5.Text = "Dad serial number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "mom serial number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 30);
            this.label7.TabIndex = 13;
            this.label7.Text = "Hatch Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 30);
            this.label8.TabIndex = 12;
            this.label8.Text = "Sex :";
            // 
            // AddBirdButton
            // 
            this.AddBirdButton.Location = new System.Drawing.Point(204, 359);
            this.AddBirdButton.Name = "AddBirdButton";
            this.AddBirdButton.Size = new System.Drawing.Size(131, 40);
            this.AddBirdButton.TabIndex = 16;
            this.AddBirdButton.Text = "AddBird";
            this.AddBirdButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddBirdButton.UseVisualStyleBackColor = true;
            this.AddBirdButton.Click += new System.EventHandler(this.AddBirdButton_Click);
            // 
            // hatchDateTimePicker
            // 
            this.hatchDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hatchDateTimePicker.Location = new System.Drawing.Point(201, 277);
            this.hatchDateTimePicker.Name = "hatchDateTimePicker";
            this.hatchDateTimePicker.Size = new System.Drawing.Size(178, 35);
            this.hatchDateTimePicker.TabIndex = 17;
            // 
            // kindComboBox
            // 
            this.kindComboBox.FormattingEnabled = true;
            this.kindComboBox.Location = new System.Drawing.Point(204, 72);
            this.kindComboBox.Name = "kindComboBox";
            this.kindComboBox.Size = new System.Drawing.Size(175, 38);
            this.kindComboBox.TabIndex = 18;
            this.kindComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // subKindComboBox
            // 
            this.subKindComboBox.FormattingEnabled = true;
            this.subKindComboBox.Location = new System.Drawing.Point(204, 115);
            this.subKindComboBox.Name = "subKindComboBox";
            this.subKindComboBox.Size = new System.Drawing.Size(175, 38);
            this.subKindComboBox.TabIndex = 19;
            // 
            // AddBirdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 435);
            this.Controls.Add(this.subKindComboBox);
            this.Controls.Add(this.kindComboBox);
            this.Controls.Add(this.hatchDateTimePicker);
            this.Controls.Add(this.AddBirdButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sexTextBox);
            this.Controls.Add(this.momSerialTextBox);
            this.Controls.Add(this.dadSerialTextBox);
            this.Controls.Add(this.cageNumberTextBox);
            this.Controls.Add(this.serialNumberBoxTextBox);
            this.Name = "AddBirdForm";
            this.Text = "AddBirdForm";
            this.Load += new System.EventHandler(this.AddBirdForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox serialNumberBoxTextBox;
        private TextBox cageNumberTextBox;
        private TextBox dadSerialTextBox;
        private TextBox momSerialTextBox;
        private TextBox sexTextBox;
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
    }
}