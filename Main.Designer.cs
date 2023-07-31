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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
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
            this.btnShowScores = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.epName = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblStart = new System.Windows.Forms.Label();
            this.ttHelp = new System.Windows.Forms.ToolTip(this.components);
            this.btnAttributions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSlot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSlot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSlot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epName)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpin
            // 
            resources.ApplyResources(this.btnSpin, "btnSpin");
            this.btnSpin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(172)))), ((int)(((byte)(61)))));
            this.btnSpin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpin.FlatAppearance.BorderSize = 0;
            this.btnSpin.ForeColor = System.Drawing.Color.Yellow;
            this.btnSpin.Name = "btnSpin";
            this.ttSpin.SetToolTip(this.btnSpin, resources.GetString("btnSpin.ToolTip"));
            this.btnSpin.UseVisualStyleBackColor = false;
            this.btnSpin.Click += new System.EventHandler(this.BtnSpin_Click);
            // 
            // lblScore
            // 
            resources.ApplyResources(this.lblScore, "lblScore");
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(168)))), ((int)(((byte)(19)))));
            this.lblScore.Name = "lblScore";
            // 
            // lblScoreValue
            // 
            resources.ApplyResources(this.lblScoreValue, "lblScoreValue");
            this.lblScoreValue.Name = "lblScoreValue";
            // 
            // lblCredit
            // 
            resources.ApplyResources(this.lblCredit, "lblCredit");
            this.lblCredit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(168)))));
            this.lblCredit.Name = "lblCredit";
            // 
            // lblCreditValue
            // 
            resources.ApplyResources(this.lblCreditValue, "lblCreditValue");
            this.lblCreditValue.Name = "lblCreditValue";
            // 
            // picSlot1
            // 
            resources.ApplyResources(this.picSlot1, "picSlot1");
            this.picSlot1.Name = "picSlot1";
            this.picSlot1.TabStop = false;
            // 
            // picSlot2
            // 
            resources.ApplyResources(this.picSlot2, "picSlot2");
            this.picSlot2.Name = "picSlot2";
            this.picSlot2.TabStop = false;
            // 
            // picSlot3
            // 
            resources.ApplyResources(this.picSlot3, "picSlot3");
            this.picSlot3.Name = "picSlot3";
            this.picSlot3.TabStop = false;
            // 
            // lblResult
            // 
            resources.ApplyResources(this.lblResult, "lblResult");
            this.lblResult.Name = "lblResult";
            // 
            // lblCost
            // 
            resources.ApplyResources(this.lblCost, "lblCost");
            this.lblCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblCost.Name = "lblCost";
            // 
            // btnSpin5x
            // 
            resources.ApplyResources(this.btnSpin5x, "btnSpin5x");
            this.btnSpin5x.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(172)))), ((int)(((byte)(61)))));
            this.btnSpin5x.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpin5x.FlatAppearance.BorderSize = 0;
            this.btnSpin5x.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSpin5x.Name = "btnSpin5x";
            this.ttSpin.SetToolTip(this.btnSpin5x, resources.GetString("btnSpin5x.ToolTip"));
            this.btnSpin5x.UseVisualStyleBackColor = false;
            this.btnSpin5x.Click += new System.EventHandler(this.BtnSpin5x_Click);
            // 
            // ttSpin
            // 
            this.ttSpin.ToolTipTitle = "Cost";
            // 
            // btnShowScores
            // 
            resources.ApplyResources(this.btnShowScores, "btnShowScores");
            this.btnShowScores.Name = "btnShowScores";
            this.ttHelp.SetToolTip(this.btnShowScores, resources.GetString("btnShowScores.ToolTip"));
            this.btnShowScores.UseVisualStyleBackColor = true;
            this.btnShowScores.Click += new System.EventHandler(this.btnShowScores_Click);
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            // 
            // btnSubmit
            // 
            resources.ApplyResources(this.btnSubmit, "btnSubmit");
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // epName
            // 
            this.epName.ContainerControl = this;
            // 
            // lblStart
            // 
            resources.ApplyResources(this.lblStart, "lblStart");
            this.lblStart.Name = "lblStart";
            // 
            // ttHelp
            // 
            this.ttHelp.AutomaticDelay = 300;
            // 
            // btnAttributions
            // 
            resources.ApplyResources(this.btnAttributions, "btnAttributions");
            this.btnAttributions.Name = "btnAttributions";
            this.ttHelp.SetToolTip(this.btnAttributions, resources.GetString("btnAttributions.ToolTip"));
            this.btnAttributions.UseVisualStyleBackColor = true;
            this.btnAttributions.Click += new System.EventHandler(this.btnShowAuthor);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.btnAttributions);
            this.Controls.Add(this.btnShowScores);
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
            this.MaximizeBox = false;
            this.Name = "Main";
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
        private Button btnShowScores;
        private Label lblStart;
        private ToolTip ttHelp;
        private Button btnAttributions;
    }
}