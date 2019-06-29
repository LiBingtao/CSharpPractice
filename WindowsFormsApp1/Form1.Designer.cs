namespace WindowsFormsApp1
{
    partial class Form1
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
            this.myAccount = new System.Windows.Forms.Label();
            this.addRecord = new System.Windows.Forms.Button();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contentBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.noteBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.incomeButton = new System.Windows.Forms.Button();
            this.revenueButton = new System.Windows.Forms.Button();
            this.expenditureButton = new System.Windows.Forms.Button();
            this.infoBox = new System.Windows.Forms.RichTextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // myAccount
            // 
            this.myAccount.AutoSize = true;
            this.myAccount.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApp1.Properties.Settings.Default, "MyAccount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.myAccount.Location = new System.Drawing.Point(370, 9);
            this.myAccount.Name = "myAccount";
            this.myAccount.Size = new System.Drawing.Size(61, 13);
            this.myAccount.TabIndex = 0;
            this.myAccount.Text = global::WindowsFormsApp1.Properties.Settings.Default.MyAccount;
            this.myAccount.Click += new System.EventHandler(this.label1_Click);
            // 
            // addRecord
            // 
            this.addRecord.Location = new System.Drawing.Point(115, 293);
            this.addRecord.Name = "addRecord";
            this.addRecord.Size = new System.Drawing.Size(75, 23);
            this.addRecord.TabIndex = 1;
            this.addRecord.Text = "AddRecord";
            this.addRecord.UseVisualStyleBackColor = true;
            this.addRecord.Click += new System.EventHandler(this.button1_Click);
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(115, 54);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(100, 20);
            this.amountBox.TabIndex = 2;
            this.amountBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(67, 57);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(42, 13);
            this.amountLabel.TabIndex = 3;
            this.amountLabel.Text = "amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "content";
            // 
            // contentBox
            // 
            this.contentBox.Location = new System.Drawing.Point(115, 99);
            this.contentBox.Name = "contentBox";
            this.contentBox.Size = new System.Drawing.Size(100, 20);
            this.contentBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "note";
            // 
            // noteBox
            // 
            this.noteBox.Location = new System.Drawing.Point(115, 150);
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(100, 20);
            this.noteBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "category";
            // 
            // categoryBox
            // 
            this.categoryBox.DisplayMember = "3";
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Items.AddRange(new object[] {
            "Spending",
            "Income"});
            this.categoryBox.Location = new System.Drawing.Point(115, 204);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(100, 21);
            this.categoryBox.TabIndex = 10;
            // 
            // incomeButton
            // 
            this.incomeButton.Location = new System.Drawing.Point(356, 70);
            this.incomeButton.Name = "incomeButton";
            this.incomeButton.Size = new System.Drawing.Size(75, 23);
            this.incomeButton.TabIndex = 11;
            this.incomeButton.Text = "Income";
            this.incomeButton.UseVisualStyleBackColor = true;
            this.incomeButton.Click += new System.EventHandler(this.incomeButton_Click);
            // 
            // revenueButton
            // 
            this.revenueButton.Location = new System.Drawing.Point(356, 207);
            this.revenueButton.Name = "revenueButton";
            this.revenueButton.Size = new System.Drawing.Size(75, 23);
            this.revenueButton.TabIndex = 12;
            this.revenueButton.Text = "Revenue";
            this.revenueButton.UseVisualStyleBackColor = true;
            this.revenueButton.Click += new System.EventHandler(this.revenueButton_Click);
            // 
            // expenditureButton
            // 
            this.expenditureButton.Location = new System.Drawing.Point(356, 143);
            this.expenditureButton.Name = "expenditureButton";
            this.expenditureButton.Size = new System.Drawing.Size(75, 23);
            this.expenditureButton.TabIndex = 13;
            this.expenditureButton.Text = "Expenditure";
            this.expenditureButton.UseVisualStyleBackColor = true;
            this.expenditureButton.Click += new System.EventHandler(this.expenditureButton_Click);
            // 
            // infoBox
            // 
            this.infoBox.Location = new System.Drawing.Point(493, 62);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(272, 163);
            this.infoBox.TabIndex = 14;
            this.infoBox.Text = "";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(67, 257);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(33, 13);
            this.nameLabel.TabIndex = 16;
            this.nameLabel.Text = "name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(115, 254);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 15;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.expenditureButton);
            this.Controls.Add(this.revenueButton);
            this.Controls.Add(this.incomeButton);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contentBox);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.addRecord);
            this.Controls.Add(this.myAccount);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label myAccount;
        private System.Windows.Forms.Button addRecord;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contentBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox noteBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Button incomeButton;
        private System.Windows.Forms.Button revenueButton;
        private System.Windows.Forms.Button expenditureButton;
        private System.Windows.Forms.RichTextBox infoBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameBox;
    }
}

