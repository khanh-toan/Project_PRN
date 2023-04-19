namespace PhoneManagerFormApp
{
    partial class PhoneDetail
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            txtId = new TextBox();
            txtName = new TextBox();
            txtDescription = new TextBox();
            numericUpDown1 = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            label8 = new Label();
            txtManufacturer = new TextBox();
            label9 = new Label();
            txtPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 35);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 77);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(410, 142);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 2;
            label3.Text = "Release Year";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(410, 38);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 3;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(410, 75);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 4;
            label5.Text = "Manufacturer Id";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(388, 118);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 122);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 6;
            label7.Text = "Description";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(192, 232);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 20);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(447, 232);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 20);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(129, 35);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(180, 23);
            txtId.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Location = new Point(129, 75);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(180, 23);
            txtName.TabIndex = 10;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(129, 116);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(237, 95);
            txtDescription.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(551, 38);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(146, 23);
            numericUpDown1.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(551, 142);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(147, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(550, 73);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(148, 23);
            comboBox1.TabIndex = 14;
            comboBox1.TextChanged += comboBox1_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(410, 109);
            label8.Name = "label8";
            label8.Size = new Size(114, 15);
            label8.TabIndex = 15;
            label8.Text = "Manufacturer Name";
            // 
            // txtManufacturer
            // 
            txtManufacturer.Enabled = false;
            txtManufacturer.Location = new Point(550, 106);
            txtManufacturer.Margin = new Padding(3, 2, 3, 2);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(148, 23);
            txtManufacturer.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(410, 182);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 17;
            label9.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(550, 177);
            txtPrice.Margin = new Padding(3, 2, 3, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(148, 23);
            txtPrice.TabIndex = 18;
            // 
            // PhoneDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 272);
            Controls.Add(txtPrice);
            Controls.Add(label9);
            Controls.Add(txtManufacturer);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(numericUpDown1);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PhoneDetail";
            Text = "Form2";
            Load += PhoneDetail_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtDescription;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label8;
        private TextBox txtManufacturer;
        private Label label9;
        private TextBox txtPrice;
    }
}