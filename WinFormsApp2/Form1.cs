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

        // Number of questions user wants 
        int questionCount;


        // startup method that runs automatically when this form loads. 
        public Form1()
        {
            InitializeComponent();

            // call new LoadQuestions() method to populate quiz data
            LoadQuestions();

            ShowSetupState();
        }
        /// <summary>
        /// populate question / answer array
        /// </summary>
        /// <author>Matthew</author>

        private void LoadQuestions()
        {
            // populate array
            questions[0, 0] = "What's 1 + 1?";
            questions[0, 1] = "2";
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
        /// setup the quiz
        /// </summary>



        private void ShowSetupState()
        {
            questionCount = 0;
            CurrentQuestion = 0;
            correct = 0;

            txtQuestionCount.Text = "";
            txtQuestionCount.Enabled = true;
            btnQuestions.Enabled = true;

            txtAnswer.Text = "";
            txtAnswer.Enabled = false;
            btnSubmit.Enabled = false;

            lblQuestion.Text = "Choose how many questions youd like to answer , the click start!";
            ShowFeedback($"Enter a whole number from 1 to {questions.GetLength(0)}", Color.Black);
            txtQuestionCount.Focus();
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
            txtAnswer.Enabled = false;


            int percent = GetPercentScore(correct, questionCount);
            string grade = GetGrade(percent);

            lblQuestion.Text = $"Score: {correct}/{questionCount} ({percent}%) - Grade: {grade}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // testig 1st question only - convert answer to an int
                //int answer = int.Parse(txtAnswer.Text);

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
                if (CurrentQuestion < questionCount)
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
            catch (FormatException)
            {
                // user did not enter a number
                ShowFeedback("Please enter a whole number", Color.Red);
                txtAnswer.Focus();
                txtAnswer.Text = "";
            }
            catch (OverflowException)
            {
                ShowFeedback("That number be way to big!!!", Color.Red);
                txtAnswer.Focus();
                txtAnswer.Text = "";
            }

            return; // stop here


        }


        private void btnRestart_Click(object sender, EventArgs e)
        {
            ShowSetupState();
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
            ShowSetupState();
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

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnSetTimeLimit_Click(object sender, EventArgs e)
        {
            // use int TryParse to TRY converting value to an into without crashing
            // if text input is a valid numer, store it in the timeLimit var
            if (int.TryParse(txtTimeLimit.Text, out int timeLimit) == true)
            {
                lblTimeLimit.Text = $"Time Limit: {timeLimit}";
                // remove any error message
                ShowFeedback("", Color.Black);
            }
            else
            {
                ShowFeedback("Please enter a valid number", Color.Red);
                txtTimeLimit.Focus();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void lblQuestionCount_Click(object sender, EventArgs e)
        {

        }

        private void txtQuestionCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuestions_Click(object sender, EventArgs e)
        {

        }

        private void btnQuestions_Click_1(object sender, EventArgs e)
        {
            int maxQuestions = questions.GetLength(0);
            //TryParse returns false for blanks, text, decimals, or numbers that are too big
            if (int.TryParse(txtQuestionCount.Text, out int requested) == false)
            {
                ShowFeedback($"Please enter a whole number from 1 to {maxQuestions}", Color.Red);
                txtQuestionCount.Focus();
                txtQuestionCount.SelectAll();
                return;
            }
            if (requested < 1)
            {
                ShowFeedback($"You gotta at least answer 1 question...", Color.Red);
                txtQuestionCount.Focus();
                txtQuestionCount.SelectAll();
                return;
            }
            if (requested > questions.GetLength(0))
            {
                ShowFeedback($"Not that many questions, theres only {maxQuestions}", Color.Red);
                txtQuestionCount.Focus();
                txtQuestionCount.SelectAll();
                return;
            }
            // if all inputs are valid start the quiz
            questionCount = requested;
            CurrentQuestion = 0;
            correct = 0;

            ShowFeedback("", Color.Black);
            lblQuestion.Text = questions[0, 0];

            //lock the setup stuff while unlocking the quiz stuff
            ShowFeedback($"You gotta at least answer 1 question..", Color.Red);
            txtQuestionCount.Focus();
            txtQuestionCount.SelectAll();
            return;

        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}