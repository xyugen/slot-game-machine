namespace SlotGameMachine
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.btnSpin = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreValue = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.lblCreditValue = new System.Windows.Forms.Label();
            this.picSlot1 = new System.Windows.Forms.PictureBox();
            this.picSlot2 = new System.Windows.Forms.PictureBox();
            this.picSlot3 = new System.Windows.Forms.PictureBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.btnSpin5x = new System.Windows.Forms.Button();
            this.ttSpin = new System.Windows.Forms.ToolTip(this.components);
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.epName = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picSlot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSlot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSlot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epName)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpin
            // 
            this.btnSpin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSpin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(172)))), ((int)(((byte)(61)))));
            this.btnSpin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSpin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpin.FlatAppearance.BorderSize = 0;
            this.btnSpin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpin.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSpin.ForeColor = System.Drawing.Color.Yellow;
            this.btnSpin.Location = new System.Drawing.Point(340, 259);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(115, 45);
            this.btnSpin.TabIndex = 0;
            this.btnSpin.Text = "Spin";
            this.ttSpin.SetToolTip(this.btnSpin, "10 Credits");
            this.btnSpin.UseVisualStyleBackColor = false;
            this.btnSpin.Click += new System.EventHandler(this.BtnSpin_Click);
            // 
            // lblScore
            // 
            this.lblScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(168)))), ((int)(((byte)(19)))));
            this.lblScore.Location = new System.Drawing.Point(86, 232);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(89, 33);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score";
            // 
            // lblScoreValue
            // 
            this.lblScoreValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblScoreValue.AutoSize = true;
            this.lblScoreValue.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScoreValue.Location = new System.Drawing.Point(113, 271);
            this.lblScoreValue.Name = "lblScoreValue";
            this.lblScoreValue.Size = new System.Drawing.Size(31, 33);
            this.lblScoreValue.TabIndex = 2;
            this.lblScoreValue.Text = "0";
            // 
            // lblCredit
            // 
            this.lblCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCredit.AutoSize = true;
            this.lblCredit.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCredit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(168)))));
            this.lblCredit.Location = new System.Drawing.Point(614, 232);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(96, 33);
            this.lblCredit.TabIndex = 3;
            this.lblCredit.Text = "Credit";
            // 
            // lblCreditValue
            // 
            this.lblCreditValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreditValue.AutoSize = true;
            this.lblCreditValue.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreditValue.Location = new System.Drawing.Point(645, 271);
            this.lblCreditValue.Name = "lblCreditValue";
            this.lblCreditValue.Size = new System.Drawing.Size(31, 33);
            this.lblCreditValue.TabIndex = 2;
            this.lblCreditValue.Text = "0";
            // 
            // picSlot1
            // 
            this.picSlot1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picSlot1.Location = new System.Drawing.Point(189, 77);
            this.picSlot1.Name = "picSlot1";
            this.picSlot1.Size = new System.Drawing.Size(100, 100);
            this.picSlot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSlot1.TabIndex = 4;
            this.picSlot1.TabStop = false;
            // 
            // picSlot2
            // 
            this.picSlot2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picSlot2.Location = new System.Drawing.Point(348, 77);
            this.picSlot2.Name = "picSlot2";
            this.picSlot2.Size = new System.Drawing.Size(100, 100);
            this.picSlot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSlot2.TabIndex = 4;
            this.picSlot2.TabStop = false;
            // 
            // picSlot3
            // 
            this.picSlot3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picSlot3.Location = new System.Drawing.Point(503, 77);
            this.picSlot3.Name = "picSlot3";
            this.picSlot3.Size = new System.Drawing.Size(100, 100);
            this.picSlot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSlot3.TabIndex = 4;
            this.picSlot3.TabStop = false;
            // 
            // lblResult
            // 
            this.lblResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(398, 21);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 37);
            this.lblResult.TabIndex = 5;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCost
            // 
            this.lblCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblCost.Location = new System.Drawing.Point(350, 307);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(94, 22);
            this.lblCost.TabIndex = 6;
            this.lblCost.Text = "-10 Credits";
            this.lblCost.Visible = false;
            // 
            // btnSpin5x
            // 
            this.btnSpin5x.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSpin5x.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(172)))), ((int)(((byte)(61)))));
            this.btnSpin5x.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSpin5x.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpin5x.FlatAppearance.BorderSize = 0;
            this.btnSpin5x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpin5x.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSpin5x.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSpin5x.Location = new System.Drawing.Point(461, 259);
            this.btnSpin5x.Name = "btnSpin5x";
            this.btnSpin5x.Size = new System.Drawing.Size(50, 45);
            this.btnSpin5x.TabIndex = 0;
            this.btnSpin5x.Text = "5x";
            this.ttSpin.SetToolTip(this.btnSpin5x, "40 Credits");
            this.btnSpin5x.UseVisualStyleBackColor = false;
            this.btnSpin5x.Click += new System.EventHandler(this.BtnSpin5x_Click);
            // 
            // ttSpin
            // 
            this.ttSpin.ToolTipTitle = "Cost";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtName.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(284, 359);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "GUEST";
            this.txtName.Size = new System.Drawing.Size(248, 33);
            this.txtName.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSubmit.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(538, 359);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(97, 33);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Montserrat Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(196, 362);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 29);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(362, 410);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 28);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // epName
            // 
            this.epName.ContainerControl = this;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.picSlot3);
            this.Controls.Add(this.picSlot2);
            this.Controls.Add(this.picSlot1);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.lblCreditValue);
            this.Controls.Add(this.lblScoreValue);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnSpin5x);
            this.Controls.Add(this.btnSpin);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(530, 430);
            this.Name = "Main";
            this.Text = "Slot Game Machine";
            ((System.ComponentModel.ISupportInitialize)(this.picSlot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSlot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSlot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSpin;
        private Label lblScore;
        private Label lblScoreValue;
        private Label lblCredit;
        private Label lblCreditValue;
        private PictureBox picSlot1;
        private PictureBox picSlot2;
        private PictureBox picSlot3;
        private Label lblResult;
        private Label lblCost;
        private Button btnSpin5x;
        private ToolTip ttSpin;
        private TextBox txtName;
        private Button btnSubmit;
        private Label lblName;
        private Button btnExit;
        private ErrorProvider epName;
    }
}