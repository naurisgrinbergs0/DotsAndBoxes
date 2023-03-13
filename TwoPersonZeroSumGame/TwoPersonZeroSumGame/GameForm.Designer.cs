
namespace TwoPersonZeroSumGame
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.gameCanvas = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPlayer1Score = new System.Windows.Forms.Label();
            this.labelPlayer2Score = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // gameCanvas
            // 
            this.gameCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gameCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameCanvas.Location = new System.Drawing.Point(31, 33);
            this.gameCanvas.Name = "gameCanvas";
            this.gameCanvas.Size = new System.Drawing.Size(541, 521);
            this.gameCanvas.TabIndex = 0;
            this.gameCanvas.TabStop = false;
            this.gameCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraphics);
            this.gameCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.gameCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            this.gameCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 40;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerTick);
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPlayer1.Location = new System.Drawing.Point(614, 83);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(52, 30);
            this.labelPlayer1.TabIndex = 1;
            this.labelPlayer1.Text = "User";
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPlayer2.Location = new System.Drawing.Point(701, 83);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(102, 30);
            this.labelPlayer2.TabIndex = 2;
            this.labelPlayer2.Text = "Computer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(656, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Score";
            // 
            // labelPlayer1Score
            // 
            this.labelPlayer1Score.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer1Score.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer1Score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPlayer1Score.Location = new System.Drawing.Point(604, 116);
            this.labelPlayer1Score.Name = "labelPlayer1Score";
            this.labelPlayer1Score.Size = new System.Drawing.Size(73, 33);
            this.labelPlayer1Score.TabIndex = 4;
            this.labelPlayer1Score.Text = "0";
            this.labelPlayer1Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPlayer2Score
            // 
            this.labelPlayer2Score.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer2Score.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer2Score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPlayer2Score.Location = new System.Drawing.Point(706, 116);
            this.labelPlayer2Score.Name = "labelPlayer2Score";
            this.labelPlayer2Score.Size = new System.Drawing.Size(97, 33);
            this.labelPlayer2Score.TabIndex = 5;
            this.labelPlayer2Score.Text = "0";
            this.labelPlayer2Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInfo
            // 
            this.labelInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelInfo.Location = new System.Drawing.Point(608, 163);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(198, 106);
            this.labelInfo.TabIndex = 6;
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRestart
            // 
            this.buttonRestart.BackColor = System.Drawing.Color.Black;
            this.buttonRestart.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonRestart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRestart.Location = new System.Drawing.Point(635, 310);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(145, 43);
            this.buttonRestart.TabIndex = 7;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = false;
            this.buttonRestart.Click += new System.EventHandler(this.OnRestartClick);
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.BackColor = System.Drawing.Color.Black;
            this.buttonMainMenu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonMainMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMainMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMainMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMainMenu.Location = new System.Drawing.Point(635, 362);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(145, 43);
            this.buttonMainMenu.TabIndex = 7;
            this.buttonMainMenu.Text = "Main Menu";
            this.buttonMainMenu.UseVisualStyleBackColor = false;
            this.buttonMainMenu.Click += new System.EventHandler(this.OnMainMenuClick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(842, 580);
            this.Controls.Add(this.buttonMainMenu);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelPlayer2Score);
            this.Controls.Add(this.labelPlayer1Score);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPlayer2);
            this.Controls.Add(this.labelPlayer1);
            this.Controls.Add(this.gameCanvas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.gameCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gameCanvas;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.Label labelPlayer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPlayer1Score;
        private System.Windows.Forms.Label labelPlayer2Score;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonMainMenu;
    }
}