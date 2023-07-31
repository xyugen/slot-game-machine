using System.Diagnostics;

namespace SlotGameMachine
{
    /// <summary>
    /// The main form of the Slot Game Machine application.
    /// </summary>
    public partial class Main : Form
    {
        private Image[]? imageArray;
        private readonly PictureBox[] pictureBoxes;
        private static readonly System.Windows.Forms.Timer costTimer = new();
        private int score = 0;
        private int credit = 100;

        private const string SCORES_FILENAME = "scores.txt";

        /// <summary>
        /// Initializes a new instance of the <see cref="Main"/> class.
        /// </summary>
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

        /// <summary>
        /// Loads images from the "assets/slot_machine_items/" folder.
        /// </summary>
        private void LoadImages()
        {
            string[] imagePaths = GetImagesFromFolder("assets/slot_machine_items/");
            List<Image> imageList = new List<Image>();

            foreach (string imagePath in imagePaths)
            {
                imageList.Add(Image.FromFile(imagePath));
            }

            imageArray = imageList.ToArray();
        }

        /// <summary>
        /// Retrieves image file paths from the specified folder path.
        /// </summary>
        private static string[] GetImagesFromFolder(string folderPath)
        {
            string[] imageFiles = Directory.GetFiles(folderPath, "*.*", SearchOption.TopDirectoryOnly)
                .Where(file => file.EndsWith(".png", StringComparison.OrdinalIgnoreCase))
                .ToArray();

            return imageFiles;
        }

        /// <summary>
        /// Sets the image for the specified PictureBox.
        /// </summary>
        private void SetPictureBoxImage(PictureBox pictureBox)
        {
            if (pictureBox != null)
            {
                Random rand = new Random();
                int randomNumber = rand.Next(0, imageArray!.Length);
                pictureBox.Image = imageArray[randomNumber];
            }
        }

        /// <summary>
        /// Updates the text of score and credit labels.
        /// </summary>
        private void UpdateLabels()
        {
            lblScoreValue.Text = score.ToString();
            lblCreditValue.Text = credit.ToString();
        }

        /// <summary>
        /// Updates the credit and score values.
        /// </summary>
        private void UpdateValues()
        {
            credit += CreditsWon();
            score += CreditsWon();
        }

        /// <summary>
        /// Updates the result label based on the amount and credit cost.
        /// </summary>
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

        /// <summary>
        /// Calculates the number of credits won based on the unique images in the PictureBoxes.
        /// </summary>
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

        /// <summary>
        /// Performs a single spin with the specified number of spins and credit amount.
        /// </summary>
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

        /// <summary>
        /// Handles the "Spin" button click event for a single spin.
        /// </summary>
        private void BtnSpin_Click(object sender, EventArgs e)
        {
            Spin(1, 10);
        }

        /// <summary>
        /// Handles the "Spin 5x" button click event for spinning five times.
        /// </summary>
        private void BtnSpin5x_Click(object sender, EventArgs e)
        {
            Spin(5, 40);
        }

        /// <summary>
        /// Handles the <see cref="System.Windows.Forms.Timer.Tick"/> event for the cost timer.
        /// </summary>
        private void CostTimer_Tick(object? sender, EventArgs e)
        {
            costTimer.Stop();
            if (!costTimer.Enabled)
            {
                lblCost.Visible = false;
            }
        }

        /// <summary>
        /// Centers the specified label on the form.
        /// </summary>
        private void CenterLabel(Label label)
        {
            label.Left = (this.ClientSize.Width - label.Width) / 2;
        }

        /// <summary>
        /// Handles the "Submit" button click event to validate and disable name input.
        /// </summary>
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

        /// <summary>
        /// Validates the input name and displays error provider messages if necessary.
        /// </summary>
        /// <returns><c>true</c> if the name is valid; otherwise, <c>false</c>.</returns>
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

        /// <summary>
        /// Handles the "Exit" button click event to save the score and close the form.
        /// </summary>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (!btnSubmit.Enabled)
            {
                SaveScore();
            }
            Close();
        }

        /// <summary>
        /// Saves the player's score to the scores file.
        /// </summary>
        private void SaveScore()
        {
            string folderPath = "output";
            string filePath = Path.Combine(folderPath, SCORES_FILENAME);

            if (!File.Exists(filePath))
            {
                CreateScoresFile(folderPath, filePath);
            }

            try
            {
                File.AppendAllText(filePath, $"{txtName.Text}: {score}\n");
                MessageBox.Show("Your score has been saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding a new line to the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Creates the scores file in the specified folder path.
        /// </summary>
        private static void CreateScoresFile(string folderPath, string filePath)
        {
            try
            {
                if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);
                using (FileStream fileStream = File.Create(filePath))
                {
                    fileStream.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the "Show Scores" button click event to display the scores to the user.
        /// </summary>
        private void btnShowScores_Click(object sender, EventArgs e)
        {
            string filePath = $"output/{SCORES_FILENAME}";
            if (File.Exists(filePath))
            {
                string text = File.ReadAllText(filePath);
                if (text.Trim().Length <= 0)
                    MessageBox.Show("There are no scores yet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show($"{text}", "Scores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There are no scores yet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Handles the "Show Author" button click event to display the author information.
        /// </summary>
        private void btnShowAuthor(object sender, EventArgs e)
        {
            cMessBox authorMessageBox = new();
            authorMessageBox.ShowDialog("Developer", SystemIcons.Information);
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