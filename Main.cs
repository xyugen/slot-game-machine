using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace SlotGameMachine
{
    public partial class Main : Form
    {
        Image[] imageArray;
        PictureBox[] pictureBoxes;

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

        private int creditsWon()
        {
            if (pictureBoxes != null)
            {
                int distinctCount = pictureBoxes.Distinct().Count();

                switch (distinctCount)
                {
                    case 1:
                        return 30;
                    case 2:
                        return 10;
                }
            }

            return 0;
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                setPictureBoxImage(pictureBox);
            }
        }
    }
}