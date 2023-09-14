namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            stunoLabel = new Label();
            progLabel = new Label();
            stunotextBox = new TextBox();
            lastnametextBox = new TextBox();
            programcomboBox = new ComboBox();
            lastnameLabel = new Label();
            firstnameLabel = new Label();
            firstnametextBox = new TextBox();
            middlenametextBox = new TextBox();
            middlenameLabel = new Label();
            ageLabel = new Label();
            agetextBox = new TextBox();
            contactLabel = new Label();
            contacttextBox = new TextBox();
            adressLabel = new Label();
            adresstextBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // stunoLabel
            // 
            stunoLabel.AutoSize = true;
            stunoLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            stunoLabel.Location = new Point(12, 9);
            stunoLabel.Name = "stunoLabel";
            stunoLabel.Size = new Size(79, 17);
            stunoLabel.TabIndex = 0;
            stunoLabel.Text = "Studen No*";
            // 
            // progLabel
            // 
            progLabel.AutoSize = true;
            progLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            progLabel.Location = new Point(222, 9);
            progLabel.Name = "progLabel";
            progLabel.Size = new Size(67, 17);
            progLabel.TabIndex = 1;
            progLabel.Text = "Program*";
            // 
            // stunotextBox
            // 
            stunotextBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            stunotextBox.ForeColor = SystemColors.WindowFrame;
            stunotextBox.Location = new Point(12, 29);
            stunotextBox.Name = "stunotextBox";
            stunotextBox.Size = new Size(204, 25);
            stunotextBox.TabIndex = 2;
            // 
            // lastnametextBox
            // 
            lastnametextBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lastnametextBox.ForeColor = SystemColors.WindowFrame;
            lastnametextBox.Location = new Point(12, 75);
            lastnametextBox.Name = "lastnametextBox";
            lastnametextBox.Size = new Size(204, 25);
            lastnametextBox.TabIndex = 3;
            // 
            // programcomboBox
            // 
            programcomboBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            programcomboBox.ForeColor = SystemColors.WindowFrame;
            programcomboBox.FormattingEnabled = true;
            programcomboBox.Items.AddRange(new object[] { "BS Information Technology", "BS Computer Science", "BS Computer Engineeering", "BS Information System", "BS Business Administration", "BS Multi-media Arts" });
            programcomboBox.Location = new Point(222, 30);
            programcomboBox.Name = "programcomboBox";
            programcomboBox.Size = new Size(235, 25);
            programcomboBox.TabIndex = 4;
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lastnameLabel.Location = new Point(12, 55);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new Size(79, 17);
            lastnameLabel.TabIndex = 5;
            lastnameLabel.Text = "Last Name*";
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            firstnameLabel.Location = new Point(222, 58);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new Size(81, 17);
            firstnameLabel.TabIndex = 6;
            firstnameLabel.Text = "First Name*";
            // 
            // firstnametextBox
            // 
            firstnametextBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            firstnametextBox.ForeColor = SystemColors.WindowFrame;
            firstnametextBox.Location = new Point(222, 75);
            firstnametextBox.Name = "firstnametextBox";
            firstnametextBox.Size = new Size(204, 25);
            firstnametextBox.TabIndex = 7;
            // 
            // middlenametextBox
            // 
            middlenametextBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            middlenametextBox.ForeColor = SystemColors.WindowFrame;
            middlenametextBox.Location = new Point(432, 75);
            middlenametextBox.Name = "middlenametextBox";
            middlenametextBox.Size = new Size(204, 25);
            middlenametextBox.TabIndex = 9;
            // 
            // middlenameLabel
            // 
            middlenameLabel.AutoSize = true;
            middlenameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            middlenameLabel.Location = new Point(432, 58);
            middlenameLabel.Name = "middlenameLabel";
            middlenameLabel.Size = new Size(97, 17);
            middlenameLabel.TabIndex = 8;
            middlenameLabel.Text = "Middle Name*";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ageLabel.Location = new Point(12, 106);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(38, 17);
            ageLabel.TabIndex = 11;
            ageLabel.Text = "Age*";
            // 
            // agetextBox
            // 
            agetextBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            agetextBox.ForeColor = SystemColors.WindowFrame;
            agetextBox.Location = new Point(12, 126);
            agetextBox.Name = "agetextBox";
            agetextBox.Size = new Size(204, 25);
            agetextBox.TabIndex = 10;
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            contactLabel.Location = new Point(222, 106);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new Size(91, 17);
            contactLabel.TabIndex = 13;
            contactLabel.Text = "Contact No. *";
            // 
            // contacttextBox
            // 
            contacttextBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            contacttextBox.ForeColor = SystemColors.WindowFrame;
            contacttextBox.Location = new Point(222, 126);
            contacttextBox.Name = "contacttextBox";
            contacttextBox.Size = new Size(204, 25);
            contacttextBox.TabIndex = 12;
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            adressLabel.Location = new Point(12, 156);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new Size(59, 17);
            adressLabel.TabIndex = 15;
            adressLabel.Text = "Adress *";
            // 
            // adresstextBox
            // 
            adresstextBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            adresstextBox.ForeColor = SystemColors.WindowFrame;
            adresstextBox.Location = new Point(12, 176);
            adresstextBox.Name = "adresstextBox";
            adresstextBox.Size = new Size(624, 25);
            adresstextBox.TabIndex = 14;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(277, 213);
            button1.Name = "button1";
            button1.Size = new Size(75, 29);
            button1.TabIndex = 16;
            button1.Text = "NEXT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(648, 251);
            Controls.Add(button1);
            Controls.Add(adressLabel);
            Controls.Add(adresstextBox);
            Controls.Add(contactLabel);
            Controls.Add(contacttextBox);
            Controls.Add(ageLabel);
            Controls.Add(agetextBox);
            Controls.Add(middlenametextBox);
            Controls.Add(middlenameLabel);
            Controls.Add(firstnametextBox);
            Controls.Add(firstnameLabel);
            Controls.Add(lastnameLabel);
            Controls.Add(programcomboBox);
            Controls.Add(lastnametextBox);
            Controls.Add(stunotextBox);
            Controls.Add(progLabel);
            Controls.Add(stunoLabel);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "FrmRegistration";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label stunoLabel;
        private Label progLabel;
        private TextBox stunotextBox;
        private TextBox lastnametextBox;
        private ComboBox programcomboBox;
        private Label lastnameLabel;
        private Label firstnameLabel;
        private TextBox firstnametextBox;
        private TextBox middlenametextBox;
        private Label middlenameLabel;
        private Label ageLabel;
        private TextBox agetextBox;
        private Label contactLabel;
        private TextBox contacttextBox;
        private Label adressLabel;
        private TextBox adresstextBox;
        private Button button1;
    }
}