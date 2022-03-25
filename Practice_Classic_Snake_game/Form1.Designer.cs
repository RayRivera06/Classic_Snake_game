
namespace Practice_Classic_Snake_game
{
    partial class snake_Form1
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.graphicGame = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.txt_Score = new System.Windows.Forms.Label();
            this.txt_HighScore = new System.Windows.Forms.Label();
            this.difficultySelection = new System.Windows.Forms.ComboBox();
            this.restartCurrentGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graphicGame)).BeginInit();
            this.SuspendLayout();
            // 
            // graphicGame
            // 
            this.graphicGame.BackColor = System.Drawing.Color.Silver;
            this.graphicGame.Location = new System.Drawing.Point(12, 12);
            this.graphicGame.Name = "graphicGame";
            this.graphicGame.Size = new System.Drawing.Size(514, 552);
            this.graphicGame.TabIndex = 0;
            this.graphicGame.TabStop = false;
            this.graphicGame.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxAndGraphics);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(555, 47);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(133, 71);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButtonOnClick);
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 40;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // txt_Score
            // 
            this.txt_Score.AutoSize = true;
            this.txt_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Score.Location = new System.Drawing.Point(549, 288);
            this.txt_Score.Name = "txt_Score";
            this.txt_Score.Size = new System.Drawing.Size(110, 29);
            this.txt_Score.TabIndex = 2;
            this.txt_Score.Text = "Score: 0";
            // 
            // txt_HighScore
            // 
            this.txt_HighScore.AutoSize = true;
            this.txt_HighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HighScore.Location = new System.Drawing.Point(549, 337);
            this.txt_HighScore.Name = "txt_HighScore";
            this.txt_HighScore.Size = new System.Drawing.Size(139, 29);
            this.txt_HighScore.TabIndex = 3;
            this.txt_HighScore.Text = "High score";
            // 
            // difficultySelection
            // 
            this.difficultySelection.FormattingEnabled = true;
            this.difficultySelection.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard",
            "Expert"});
            this.difficultySelection.Location = new System.Drawing.Point(555, 233);
            this.difficultySelection.Name = "difficultySelection";
            this.difficultySelection.Size = new System.Drawing.Size(121, 24);
            this.difficultySelection.TabIndex = 4;
            // 
            // restartCurrentGame
            // 
            this.restartCurrentGame.BackColor = System.Drawing.Color.LightSkyBlue;
            this.restartCurrentGame.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.restartCurrentGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartCurrentGame.Location = new System.Drawing.Point(554, 124);
            this.restartCurrentGame.Name = "restartCurrentGame";
            this.restartCurrentGame.Size = new System.Drawing.Size(134, 71);
            this.restartCurrentGame.TabIndex = 5;
            this.restartCurrentGame.Text = "Restart";
            this.restartCurrentGame.UseVisualStyleBackColor = false;
            this.restartCurrentGame.Click += new System.EventHandler(this.RestartStartedGame);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(560, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Press r to enable";
            // 
            // snake_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 576);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.restartCurrentGame);
            this.Controls.Add(this.difficultySelection);
            this.Controls.Add(this.txt_HighScore);
            this.Controls.Add(this.txt_Score);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.graphicGame);
            this.Name = "snake_Form1";
            this.Text = "Snake Game";
            this.Load += new System.EventHandler(this.snake_Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.graphicGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox graphicGame;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label txt_Score;
        private System.Windows.Forms.Label txt_HighScore;
        private System.Windows.Forms.ComboBox difficultySelection;
        private System.Windows.Forms.Button restartCurrentGame;
        private System.Windows.Forms.Label label1;
    }
}

