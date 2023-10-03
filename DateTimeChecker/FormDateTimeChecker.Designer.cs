namespace DateTimeChecker
{
    partial class FormDateTimeChecker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDateTimeChecker));
            btnCheck = new Button();
            txtDay = new MaskedTextBox();
            txtMonth = new MaskedTextBox();
            txtYear = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnClear = new Button();
            btnTest = new Button();
            pictureBox1 = new PictureBox();
            title = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCheck
            // 
            btnCheck.BackColor = Color.FromArgb(192, 255, 192);
            btnCheck.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCheck.Location = new Point(414, 221);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(75, 38);
            btnCheck.TabIndex = 0;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // txtDay
            // 
            txtDay.Location = new Point(51, 142);
            txtDay.Name = "txtDay";
            txtDay.Size = new Size(117, 23);
            txtDay.TabIndex = 1;
            txtDay.ValidatingType = typeof(int);
            // 
            // txtMonth
            // 
            txtMonth.Location = new Point(207, 142);
            txtMonth.Name = "txtMonth";
            txtMonth.Size = new Size(117, 23);
            txtMonth.TabIndex = 2;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(372, 142);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(117, 23);
            txtYear.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(86, 109);
            label1.Name = "label1";
            label1.Size = new Size(50, 30);
            label1.TabIndex = 4;
            label1.Text = "Day";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(231, 109);
            label2.Name = "label2";
            label2.Size = new Size(77, 30);
            label2.TabIndex = 5;
            label2.Text = "Month";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(405, 109);
            label3.Name = "label3";
            label3.Size = new Size(54, 30);
            label3.TabIndex = 6;
            label3.Text = "Year";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 192, 192);
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(303, 221);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 38);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnTest
            // 
            btnTest.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTest.Location = new Point(51, 221);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(132, 38);
            btnTest.TabIndex = 8;
            btnTest.Text = "Generate";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // title
            // 
            title.BackColor = SystemColors.Control;
            title.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            title.ForeColor = SystemColors.MenuHighlight;
            title.Location = new Point(330, 3);
            title.Name = "title";
            title.Size = new Size(201, 85);
            title.TabIndex = 6;
            title.Text = "Date Time Checker";
            title.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(49, 199);
            label4.Name = "label4";
            label4.Size = new Size(148, 17);
            label4.TabIndex = 4;
            label4.Text = "Generate Random Date:";
            // 
            // FormDateTimeChecker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(543, 282);
            Controls.Add(pictureBox1);
            Controls.Add(btnTest);
            Controls.Add(btnClear);
            Controls.Add(title);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtYear);
            Controls.Add(txtMonth);
            Controls.Add(txtDay);
            Controls.Add(btnCheck);
            Name = "FormDateTimeChecker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Date Time Checker";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCheck;
        private MaskedTextBox txtDay;
        private MaskedTextBox txtMonth;
        private MaskedTextBox txtYear;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnClear;
        private Button btnTest;
        private PictureBox pictureBox1;
        private Label title;
        private Label label4;
    }
}