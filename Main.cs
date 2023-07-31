namespace SlotGameMachine
{
    public partial class Main : Form
    {
        // Fields
        private Image[]? imageArray;
        private readonly PictureBox[] pictureBoxes;
        private static System.Windows.Forms.Timer costTimer = new();
        private int score = 0;
        private int credit = 100;

        public Main()
        {
            InitializeComponent();
            btnSpin.Left = (this.ClientSize.Width - btnSpin.Width) / 2;

            LoadImages();
            pictureBoxes = new PictureBox[] { picSlot1, picSlot2, picSlot3 };

            // Timer
            costTimer.Interval = 500;
            costTimer.Tick += new EventHandler(CostTimer_Tick);

            UpdateLabels();
        }

        // Helper methods
        private void LoadImages()
        {
            string[] imagePaths = GetImagesFromFolder("assets/");
            List<Image> imageList = new List<Image>();

            foreach (string imagePath in imagePaths)
            {
                imageList.Add(Image.FromFile(imagePath));
            }

            imageArray = imageList.ToArray();
        }

        private static string[] GetImagesFromFolder(string folderPath)
        {
            string[] imageFiles = Directory.GetFiles(folderPath, "*.*", SearchOption.TopDirectoryOnly)
                .Where(file => file.EndsWith(".png", StringComparison.OrdinalIgnoreCase))
                .ToArray();

            return imageFiles;
        }

        private void SetPictureBoxImage(PictureBox pictureBox)
        {
            if (pictureBox != null)
            {
                Random rand = new Random();
                int randomNumber = rand.Next(0, imageArray.Length);
                pictureBox.Image = imageArray[randomNumber];
            }
        }

        private void UpdateLabels()
        {
            lblScoreValue.Text = score.ToString();
            lblCreditValue.Text = credit.ToString();
        }

        private void UpdateValues()
        {
            credit += CreditsWon();
            score += CreditsWon();
        }

        private void UpdateResult(int amount, int creditCost)
        {
            if (amount > 0)
            {
                lblResult.Text = $"You won {amount} credits!";
            }
            else
            {
                lblResult.Text = $"You lost {creditCost} credits.";
            }
            CenterLabel(lblResult);
        }

        private int CreditsWon()
        {
            if (pictureBoxes != null)
            {
                int distinctCount = pictureBoxes.Distinct(new PictureBoxImageComparer()).Count();

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

        private void Spin(int spins, int creditAmount)
        {
            if (credit >= creditAmount)
            {
                credit -= creditAmount;
                int amountWon = 0;
                for (int i = 0; i < spins; i++)
                {
                    foreach (PictureBox pictureBox in pictureBoxes)
                    {
                        SetPictureBoxImage(pictureBox);
                    }
                    amountWon += CreditsWon();

                    UpdateValues();
                    UpdateResult(amountWon, creditAmount);
                    UpdateLabels();
                }
                lblCost.Visible = true;
                costTimer.Start();
            }
            else
            {
                lblResult.Text = "You don't have enough credits!";
                CenterLabel(lblResult);
            }
        }

        private void BtnSpin_Click(object sender, EventArgs e)
        {
            lblCost.Text = "-10 Credits";
            Spin(1, 10);
        }

        private void BtnSpin5x_Click(object sender, EventArgs e)
        {
            lblCost.Text = "-40 Credits";
            Spin(5, 40);
        }

        private void CostTimer_Tick(object? sender, EventArgs e)
        {
            costTimer.Stop();
            if (!costTimer.Enabled)
            {
                lblCost.Visible = false;
            }
        }

        private void CenterLabel(Label label)
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