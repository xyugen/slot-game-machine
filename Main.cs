using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace SlotGameMachine
{
    public partial class Main : Form
    {
        Image[] imageArray;
        PictureBox[] pictureBoxes;
        int score = 0;
        int credit = 100;

        public Main()
        {
            InitializeComponent();
            btnSpin.Left = (this.ClientSize.Width - btnSpin.Width) / 2;

            imageArray = new Image[3]
            {
                Image.FromFile("assets/banana.png"),
                Image.FromFile("assets/balloon.png"),
                Image.FromFile("assets/coin.png")
            };
            pictureBoxes = new PictureBox[3] { picSlot1, picSlot2, picSlot3 };

            updateLabels();
        }

        private void setPictureBoxImage(PictureBox pictureBox)
        {
            if (pictureBox != null)
            {
                Random rand = new Random();
                int randomNumber = rand.Next(0, 3);
                pictureBox.Image = imageArray[randomNumber];
            }
        }

        private void updateLabels()
        {
            lblScoreValue.Text = score.ToString();
            lblCreditValue.Text = credit.ToString();
        }

        private int creditsWon()
        {
            if (pictureBoxes != null)
            {
                int distinctCount = pictureBoxes.Distinct(new PictureBoxImageComparer()).Count();

                switch (distinctCount)
                {
                    case 1:
                        Debug.WriteLine("1");
                        return 30;
                    case 2:
                        Debug.WriteLine("2");
                        return 10;
                }
            }
            return 0;
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            if (credit > 0)
            {
                credit -= 10;
                foreach (PictureBox pictureBox in pictureBoxes)
                {
                    setPictureBoxImage(pictureBox);
                }

                credit += creditsWon();
                score += creditsWon();

                updateLabels();
            }
            else
            {
                lblResult.Text = "You don't have enough credits!";
                centerLabel(lblResult);
            }
        }

        private void centerLabel(Label label)
        {
            label.Left = (this.ClientSize.Width - label.Width) / 2;
        }
    }

    /// <summary>
    /// Custom comparer to compare PictureBox objects based on the images they display
    /// </summary>
    public class PictureBoxImageComparer : IEqualityComparer<PictureBox>
    {
        public bool Equals(PictureBox x, PictureBox y)
        {
            // Compare images if both PictureBoxes have images
            if (x?.Image != null && y?.Image != null)
            {
                return x.Image.Equals(y.Image);
            }

            // If any PictureBox is null or doesn't have an image, consider them not equal
            return false;
        }

        public int GetHashCode(PictureBox obj)
        {
            return obj?.Image?.GetHashCode() ?? 0;
        }
    }
}