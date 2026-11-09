namespace WinFormsApp2
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
            btnSubmit = new Button();
            lblMessage = new Label();
            lblQuestion = new Label();
            txtAnswer = new TextBox();
            btnReset = new Button();
            btnDarkMode = new Button();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(287, 279);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += button1_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(287, 97);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(171, 20);
            lblMessage.TabIndex = 1;
            lblMessage.Text = "Enter your answer below";
            lblMessage.Click += label1_Click;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(287, 174);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(187, 20);
            lblQuestion.TabIndex = 2;
            lblQuestion.Text = "What's the capital of Japan";
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(225, 206);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(308, 27);
            txtAnswer.TabIndex = 3;
            txtAnswer.TextChanged += txtAnswer_TextChanged;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(387, 279);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += button1_Click1;
            // 
            // btnDarkMode
            // 
            btnDarkMode.Location = new Point(689, 421);
            btnDarkMode.Name = "btnDarkMode";
            btnDarkMode.Size = new Size(112, 29);
            btnDarkMode.TabIndex = 5;
            btnDarkMode.Text = "Theme Toggle";
            btnDarkMode.UseVisualStyleBackColor = true;
            btnDarkMode.Click += button1_Click_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDarkMode);
            Controls.Add(btnReset);
            Controls.Add(txtAnswer);
            Controls.Add(lblQuestion);
            Controls.Add(lblMessage);
            Controls.Add(btnSubmit);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Label lblMessage;
        private Label lblQuestion;
        private TextBox txtAnswer;
        private Button btnReset;
        private Button btnDarkMode;
    }
}
