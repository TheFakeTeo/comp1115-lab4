namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        // Array of questions and answers
        string[,] questions = new string[6, 2];

        // track current question
        int CurrentQuestion = 0;

        // track correct answers
        int correct = 0;

        bool darkMode = false;

        // startup method that runs automatically when this form loads. 
        public Form1()
        {
            InitializeComponent();

            // call new LoadQuestions() method to populate quiz data
            LoadQuestions();
        }
        /// <summary>
        /// populate question / answer array
        /// </summary>
        /// <author>Matthew</author>

        private void LoadQuestions()
        {
            // populate array
            questions[0, 0] = "What's the capital of Japan?";
            questions[0, 1] = "Tokyo";
            questions[1, 0] = "What colour is the sky?";
            questions[1, 1] = "Blue";
            questions[2, 0] = "Which came first, the chicken or the egg?";
            questions[2, 1] = "Chicken";
            questions[3, 0] = "What is the largest planet in our solar system?";
            questions[3, 1] = "Jupiter";
            questions[4, 0] = "What is the biggest animal in the world?";
            questions[4, 1] = "Blue Whale";
            questions[5, 0] = "When was the first iPhone released?";
            questions[5, 1] = "2007";

            // show 1st question on question label
            lblQuestion.Text = questions[0, 0];
        }

        /// <summary>
        /// give feedback on answer
        /// </summary>
        /// <param name="text">feedback to show on label</param>
        /// <param name="colour">text color for feedback label</param>
        private void ShowFeedback(string text, Color colour)
        {
            lblMessage.Text = text;
            lblMessage.ForeColor = colour;

        }

        /// <summary>
        /// calculate the percentage score
        /// </summary>
        /// <param name="correct">number of correct answers</param>
        /// <param name="total">total number of questions</param>
        /// <returns>percentage as a whole number</returns>
        private int GetPercentScore(int correct, int total)
        {
            if (total == 0)
            {
                return 0;
            }

            return correct * 100 / total;
        }

        /// <summary>
        /// convert a percentage score into a letter grade
        /// </summary>
        /// <param name="percent">score percentage</param>
        /// <returns>letter grade A, B, C, D or F</returns>
        private string GetGrade(int percent)
        {
            if (percent >= 90)
            {
                return "A";
            }
            else if (percent >= 80)
            {
                return "B";
            }
            else if (percent >= 70)
            {
                return "C";
            }
            else if (percent >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        /// <summary>
        /// user has finished
        /// </summary>
        private void FinishQuiz()
        {
            btnSubmit.Enabled = false;

            int total = questions.GetLength(0);
            int percent = GetPercentScore(correct, total);
            string grade = GetGrade(percent);

            lblQuestion.Text = $"Score: {correct}/{total} ({percent}%) - Grade: {grade}";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Message.Box show ("You clicked me");
            // if user has entered correct answer in the textbox
            if (txtAnswer.Text == questions[CurrentQuestion, 1])
            {
                ShowFeedback("Correct", Color.Green);

                // add 1 to correct answer count
                correct++;
            }
            else
            {
                // wrong answer
                ShowFeedback("Incorrect", Color.Red);
            }

            // increment current question
            CurrentQuestion++;

            // are there more questions?
            if (CurrentQuestion < questions.GetLength(0))
            {
                // move to the next question
                lblQuestion.Text = questions[CurrentQuestion, 0];
            }
            else
            {
                // user is done - no more qustions
                FinishQuiz();
            }

            // clear last answer
            txtAnswer.Text = "";
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            CurrentQuestion = 0;
            correct = 0;
            lblMessage.Text = "Restarting the Quiz";
            lblMessage.ForeColor = Color.Black;
            lblQuestion.Text = questions[0, 0];
            btnSubmit.Enabled = true;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (darkMode == true)
            {
                this.BackColor = Color.Black;
                lblMessage.ForeColor = Color.White;
                lblQuestion.ForeColor = Color.White;
                txtAnswer.ForeColor = Color.White;
                //btnSubmit.ForeColor = Color.Black;
                //btnRestart.ForeColor = Color.Black;
                //btnToggleTheme.ForeColor = Color.Black;
                txtAnswer.BackColor = Color.Gray;
                darkMode = false;
            }
            else
            {
                {
                    this.BackColor = Color.White;
                    lblMessage.ForeColor = Color.Black;
                    lblQuestion.ForeColor = Color.Black;
                    txtAnswer.ForeColor = Color.Black;
                    //btnSubmit.ForeColor = Color.White;
                    //btnRestart.ForeColor = Color.White;
                    //btnToggleTheme.ForeColor = Color.White;
                    txtAnswer.BackColor = Color.DimGray;
                    darkMode = true;
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click1(object sender, EventArgs e)
        {
            CurrentQuestion = 0;
            correct = 0;
            lblMessage.Text = "Restarting the Quiz";
            lblMessage.ForeColor = Color.Black;
            lblQuestion.Text = questions[0, 0];
            btnSubmit.Enabled = true;
        }

        private void label1_Click_1(object sender, EventArgs e) //score percent label
        {
           
        }
    }
}