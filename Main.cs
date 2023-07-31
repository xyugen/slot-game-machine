using System.Diagnostics;

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
                int randomNumber = rand.Next(0, imageArray!.Length);
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
            if (lblStart.Visible)
            {
                lblStart.Visible = false;
            }

            if (credit >= creditAmount)
            {
                lblCost.Text = $"-{creditAmount} Credits";
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
            Spin(1, 10);
        }

        private void BtnSpin5x_Click(object sender, EventArgs e)
        {
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

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            txtName.Text = txtName.Text.Trim();
            if (!ValidateName())
            {
                return;
            }

            btnExit.Text = "Save";
            txtName.Enabled = false;
            btnSubmit.Enabled = false;
            Debug.WriteLine(this.ClientSize.Width.ToString());
        }

        private bool ValidateName()
        {
            epName.Clear();

            if (string.IsNullOrEmpty(txtName.Text))
            {
                epName.SetError(txtName, "Name is required.");
                return false;
            }

            if (txtName.Text.Length <= 3)
            {
                epName.SetError(txtName, "Name must be more than 3 characters.");
                return false;
            }

            return true;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (!btnSubmit.Enabled)
            {
                SaveScore();
            }
            Close();
        }

        private void SaveScore()
        {
            string folderPath = "output";
            string filePath = Path.Combine(folderPath, "scores.txt");

            if (!File.Exists(filePath))
            {
                CreateScoresFile(folderPath, filePath);
            }

            try
            {
                File.AppendAllText(filePath, $"{txtName.Text}: {score}\n");
                MessageBox.Show("Your score is added to the file!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding a new line to the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void CreateScoresFile(string folderPath, string filePath)
        {
            try
            {
                if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);
                using (FileStream fileStream = File.Create(filePath))
                {
                    fileStream.Close();
                }
                MessageBox.Show("File created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowScores_Click(object sender, EventArgs e)
        {
            string filePath = "output/scores.txt";
            if (File.Exists(filePath))
            {
                string text = File.ReadAllText(filePath);
                MessageBox.Show($"{text}", "Scores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There are no scores yet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    /// <summary>
    /// Custom comparer to compare PictureBox objects based on the images they display
    /// </summary>
    public class PictureBoxImageComparer : IEqualityComparer<PictureBox>
    {
        public bool Equals(PictureBox? x, PictureBox? y)
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