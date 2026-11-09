namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        // Array of questions and answers
        string[,] questions = new string[4, 2];

        // track current question
        int CurrentQuestion = 0;

        // track correct answers
        int correct = 0;

        // track whether dark mode is on or off
        bool darkMode = false;


        // startup method that runs automatically when this form loads. 
        public Form1()
        {
            InitializeComponent();

            // populate array
            questions[0, 0] = "What's the capital of Japan?";
            questions[0, 1] = "Tokyo";
            questions[1, 0] = "What colour is the sky?";
            questions[1, 1] = "Blue";
            questions[2, 0] = "Which came first, the chicken or the egg?";
            questions[2, 1] = "Chicken";
            questions[3, 0] = "What is the largest planet in our solar system?";
            questions[3, 1] = "Jupiter";

            ResetQuiz();

            // show 1st question on question label
            lblQuestion.Text = questions[0, 0];
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Message.Box show ("You clicked me");
            // if user has entered correct answer in the textbox
            if (txtAnswer.Text == questions[CurrentQuestion, 1])
            {
                lblMessage.Text = "Correct!";
                lblMessage.ForeColor = Color.Green;
                txtAnswer.Clear();

                // add 1 correct answer count
                correct++;
            }
            else
            {
                lblMessage.Text = "Incorrect. Please try again.";
                lblMessage.ForeColor = Color.Red;
                txtAnswer.Clear();
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
                btnSubmit.Enabled = false;
                lblQuestion.Text = $"You got {correct} out of {questions.GetLength(0)} correct!";
            }
        }

        private void ResetQuiz()
        {
            CurrentQuestion = 0;
            correct = 0;
            lblMessage.Text = "Enter your answer below";
            lblMessage.ForeColor = Color.Black;
            txtAnswer.Clear();
            btnSubmit.Enabled = true;
            lblQuestion.Text = questions[CurrentQuestion, 0];
        }

        
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetQuiz();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click1(object sender, EventArgs e)
        {
            ResetQuiz();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
                // flip between dark and light
                darkMode = !darkMode;

                // pick the colours based on the mode
                Color back = darkMode ? Color.FromArgb(30, 30, 30) : SystemColors.Control;
                Color fore = darkMode ? Color.White : SystemColors.ControlText;
                Color boxBack = darkMode ? Color.FromArgb(60, 60, 60) : SystemColors.Window;

                // the form itself
                this.BackColor = back;

               
                }

                // update the toggle button's text
                //btnDarkMode.Text = darkMode ? "Light Mode" : "Dark Mode";

            }
    }
//}