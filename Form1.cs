using System.Media;
using System.Windows.Forms;
namespace radio_buttons_Video7_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Name_textBox_Leave_1(object sender, System.EventArgs e)
        {
            if (Name_textBox.Text == "")
            {
                ErrorProvider.SetError(Name_textBox, "Please Enter Name.");
            }
            else
            {
                ErrorProvider.Clear();
            }
        }

        private void Password_textBox_Leave(object sender, System.EventArgs e)
        {
            if (Password_textBox.Text == "")
            {
                ErrorProvider.SetError(Password_textBox, "Please Enter Password.");
            }
            else
            {
                ErrorProvider.Clear();
            }
        }

        private void LogIn_button_Click(object sender, System.EventArgs e)
        {

            if ((!string.IsNullOrEmpty(Name_textBox.Text)) && (!string.IsNullOrEmpty(Password_textBox.Text)))
            {
                if (PlayLoginSound)
                {
                    SoundPlayer loginSuccessful = new SoundPlayer(@"D:\CSharp\WinFormsByLearningNeverEnds\ErrorProvider(Video11)\ErrorProvider(Video11)\Y2Mate.is - Windows 11 Startup sound-DxQ3DraN_Oc-128k-1654056055837.wav");
                    loginSuccessful.Play();
                }
                Name_textBox.Clear();
                Password_textBox.Clear();
                MessageBox.Show("LogIn Successful!!!");
            }
            else if (string.IsNullOrEmpty(Name_textBox.Text))
            {
                ErrorProvider.SetError(Name_textBox, "Please Enter Name.");
            }
            else if (string.IsNullOrEmpty(Password_textBox.Text))
            {
                ErrorProvider.SetError(Password_textBox, "Please Enter Password.");
            }
            else
            {
                ErrorProvider.Clear();
            }
        }

        public static bool PlayLoginSound = true;
        private void PlayLogInSound_checkBox_CheckedChanged(object sender, System.EventArgs e)
        {
            PlayLoginSound = PlayLogInSound_checkBox.Checked;
        }
    }
}


