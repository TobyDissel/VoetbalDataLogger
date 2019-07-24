namespace VoetbalDataLogger
{

    partial class VoetbalDataLogger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.HomeScore = new System.Windows.Forms.NumericUpDown();
            this.AwayScore = new System.Windows.Forms.NumericUpDown();
            this.Name = new System.Windows.Forms.TextBox();
            this.CompList = new System.Windows.Forms.ComboBox();
            this.Team1 = new System.Windows.Forms.ComboBox();
            this.Team2 = new System.Windows.Forms.ComboBox();
            this.CompConfirm = new System.Windows.Forms.Button();
            this.GameButton = new System.Windows.Forms.Button();
            this.TeamButton = new System.Windows.Forms.Button();
            this.CompButton = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LatestMatchLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HomeScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AwayScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeScore
            // 
            this.HomeScore.Location = new System.Drawing.Point(118, 14);
            this.HomeScore.Name = "HomeScore";
            this.HomeScore.Size = new System.Drawing.Size(28, 20);
            this.HomeScore.TabIndex = 0;
            // 
            // AwayScore
            // 
            this.AwayScore.Location = new System.Drawing.Point(118, 40);
            this.AwayScore.Name = "AwayScore";
            this.AwayScore.Size = new System.Drawing.Size(28, 20);
            this.AwayScore.TabIndex = 1;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(152, 122);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(134, 20);
            this.Name.TabIndex = 7;
            // 
            // CompList
            // 
            this.CompList.FormattingEnabled = true;
            this.CompList.Location = new System.Drawing.Point(12, 66);
            this.CompList.Name = "CompList";
            this.CompList.Size = new System.Drawing.Size(134, 21);
            this.CompList.TabIndex = 8;
            this.CompList.Text = "Competition";
            // 
            // Team1
            // 
            this.Team1.FormattingEnabled = true;
            this.Team1.Location = new System.Drawing.Point(12, 12);
            this.Team1.Name = "Team1";
            this.Team1.Size = new System.Drawing.Size(100, 21);
            this.Team1.TabIndex = 9;
            this.Team1.Text = "HomeTeam";
            // 
            // Team2
            // 
            this.Team2.FormattingEnabled = true;
            this.Team2.Location = new System.Drawing.Point(12, 39);
            this.Team2.Name = "Team2";
            this.Team2.Size = new System.Drawing.Size(100, 21);
            this.Team2.TabIndex = 10;
            this.Team2.Text = "AwayTeam";
            // 
            // CompConfirm
            // 
            this.CompConfirm.Location = new System.Drawing.Point(12, 93);
            this.CompConfirm.Name = "CompConfirm";
            this.CompConfirm.Size = new System.Drawing.Size(134, 23);
            this.CompConfirm.TabIndex = 11;
            this.CompConfirm.Text = "Set Competion";
            this.CompConfirm.UseVisualStyleBackColor = true;
            this.CompConfirm.Click += new System.EventHandler(this.CompConfirm_Click);
            // 
            // GameButton
            // 
            this.GameButton.Location = new System.Drawing.Point(152, 12);
            this.GameButton.Name = "GameButton";
            this.GameButton.Size = new System.Drawing.Size(134, 46);
            this.GameButton.TabIndex = 13;
            this.GameButton.Text = "Add Game";
            this.GameButton.UseVisualStyleBackColor = true;
            this.GameButton.Click += new System.EventHandler(this.GameButton_Click);
            // 
            // TeamButton
            // 
            this.TeamButton.Location = new System.Drawing.Point(152, 64);
            this.TeamButton.Name = "TeamButton";
            this.TeamButton.Size = new System.Drawing.Size(134, 23);
            this.TeamButton.TabIndex = 14;
            this.TeamButton.Text = "Add Team";
            this.TeamButton.UseVisualStyleBackColor = true;
            this.TeamButton.Click += new System.EventHandler(this.TeamButton_Click);
            // 
            // CompButton
            // 
            this.CompButton.Location = new System.Drawing.Point(150, 93);
            this.CompButton.Name = "CompButton";
            this.CompButton.Size = new System.Drawing.Size(134, 23);
            this.CompButton.TabIndex = 15;
            this.CompButton.Text = "Add Competition";
            this.CompButton.UseVisualStyleBackColor = true;
            this.CompButton.Click += new System.EventHandler(this.CompButton_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(12, 122);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(66, 23);
            this.Save.TabIndex = 16;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(84, 122);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(62, 23);
            this.Load.TabIndex = 17;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // LatestMatchLabel
            // 
            this.LatestMatchLabel.AutoSize = true;
            this.LatestMatchLabel.Location = new System.Drawing.Point(86, 148);
            this.LatestMatchLabel.Name = "LatestMatchLabel";
            this.LatestMatchLabel.Size = new System.Drawing.Size(0, 13);
            this.LatestMatchLabel.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Latest match:";
            // 
            // VoetbalDataLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 238);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LatestMatchLabel);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.CompButton);
            this.Controls.Add(this.TeamButton);
            this.Controls.Add(this.GameButton);
            this.Controls.Add(this.CompConfirm);
            this.Controls.Add(this.Team2);
            this.Controls.Add(this.Team1);
            this.Controls.Add(this.CompList);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.AwayScore);
            this.Controls.Add(this.HomeScore);
            this.Text = "Voetbal Data logger";
            ((System.ComponentModel.ISupportInitialize)(this.HomeScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AwayScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown HomeScore;
        private System.Windows.Forms.NumericUpDown AwayScore;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.ComboBox CompList;
        private System.Windows.Forms.ComboBox Team1;
        private System.Windows.Forms.ComboBox Team2;
        private System.Windows.Forms.Button CompConfirm;
        private System.Windows.Forms.Button GameButton;
        private System.Windows.Forms.Button TeamButton;
        private System.Windows.Forms.Button CompButton;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.BindingSource teamBindingSource;
        private System.Windows.Forms.Label LatestMatchLabel;
        private System.Windows.Forms.Label label1;
    }
}

