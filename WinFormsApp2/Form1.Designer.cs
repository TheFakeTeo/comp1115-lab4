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
            lblTimeLimit = new Label();
            txtTimeLimit = new TextBox();
            btnSetTimeLimit = new Button();
            txtQuestionCount = new TextBox();
            lblQuestionCount = new Label();
            btnQuestions = new Button();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(287, 279);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 4;
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
            lblQuestion.Location = new Point(225, 171);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(187, 20);
            lblQuestion.TabIndex = 2;
            lblQuestion.Text = "What's the capital of Japan";
            lblQuestion.Click += lblQuestion_Click;
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(225, 206);
            txtAnswer.MaxLength = 11;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(308, 27);
            txtAnswer.TabIndex = 0;
            txtAnswer.TextChanged += txtAnswer_TextChanged;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(387, 279);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 0;
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
            // lblTimeLimit
            // 
            lblTimeLimit.AutoSize = true;
            lblTimeLimit.Location = new Point(229, 39);
            lblTimeLimit.Name = "lblTimeLimit";
            lblTimeLimit.Size = new Size(79, 20);
            lblTimeLimit.TabIndex = 6;
            lblTimeLimit.Text = "Time Limit";
            lblTimeLimit.Click += label1_Click_2;
            // 
            // txtTimeLimit
            // 
            txtTimeLimit.Location = new Point(314, 35);
            txtTimeLimit.Name = "txtTimeLimit";
            txtTimeLimit.Size = new Size(125, 27);
            txtTimeLimit.TabIndex = 7;
            txtTimeLimit.TextChanged += textBox1_TextChanged;
            // 
            // btnSetTimeLimit
            // 
            btnSetTimeLimit.Location = new Point(445, 35);
            btnSetTimeLimit.Name = "btnSetTimeLimit";
            btnSetTimeLimit.Size = new Size(94, 29);
            btnSetTimeLimit.TabIndex = 8;
            btnSetTimeLimit.Text = "Set";
            btnSetTimeLimit.UseVisualStyleBackColor = true;
            btnSetTimeLimit.Click += btnSetTimeLimit_Click;
            // 
            // txtQuestionCount
            // 
            txtQuestionCount.Location = new Point(314, 68);
            txtQuestionCount.Name = "txtQuestionCount";
            txtQuestionCount.Size = new Size(125, 27);
            txtQuestionCount.TabIndex = 10;
            txtQuestionCount.TextChanged += txtQuestionCount_TextChanged;
            // 
            // lblQuestionCount
            // 
            lblQuestionCount.AutoSize = true;
            lblQuestionCount.Location = new Point(224, 71);
            lblQuestionCount.Name = "lblQuestionCount";
            lblQuestionCount.Size = new Size(84, 20);
            lblQuestionCount.TabIndex = 11;
            lblQuestionCount.Text = "Test Length";
            lblQuestionCount.Click += lblQuestionCount_Click;
            // 
            // btnQuestions
            // 
            btnQuestions.Location = new Point(448, 71);
            btnQuestions.Name = "btnQuestions";
            btnQuestions.Size = new Size(94, 29);
            btnQuestions.TabIndex = 12;
            btnQuestions.Text = "Questions";
            btnQuestions.UseVisualStyleBackColor = true;
            btnQuestions.Click += btnQuestions_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnQuestions);
            Controls.Add(lblQuestionCount);
            Controls.Add(txtQuestionCount);
            Controls.Add(btnSetTimeLimit);
            Controls.Add(txtTimeLimit);
            Controls.Add(lblTimeLimit);
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
        private Label lblTimeLimit;
        private TextBox txtTimeLimit;
        private Button btnSetTimeLimit;
        private TextBox txtQuestionCount;
        private Label lblQuestionCount;
        private Button btnQuestions;
    }
}
