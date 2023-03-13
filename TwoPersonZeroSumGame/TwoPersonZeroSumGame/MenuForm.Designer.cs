
namespace TwoPersonZeroSumGame
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.startGameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.smallSizeButton = new System.Windows.Forms.Button();
            this.mediumSizeButton = new System.Windows.Forms.Button();
            this.bigSizeButton = new System.Windows.Forms.Button();
            this.checkboxPlayer1 = new System.Windows.Forms.RadioButton();
            this.checkboxPlayer2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startGameButton
            // 
            this.startGameButton.BackColor = System.Drawing.Color.Transparent;
            this.startGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startGameButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.startGameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startGameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.startGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startGameButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameButton.ForeColor = System.Drawing.Color.White;
            this.startGameButton.Location = new System.Drawing.Point(382, 271);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(168, 57);
            this.startGameButton.TabIndex = 0;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseVisualStyleBackColor = false;
            this.startGameButton.Click += new System.EventHandler(this.StartButtonClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(27, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(875, 135);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(171, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(579, 105);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dots and Boxes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // smallSizeButton
            // 
            this.smallSizeButton.BackColor = System.Drawing.Color.Black;
            this.smallSizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smallSizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.smallSizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.smallSizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smallSizeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallSizeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.smallSizeButton.Location = new System.Drawing.Point(293, 207);
            this.smallSizeButton.Name = "smallSizeButton";
            this.smallSizeButton.Size = new System.Drawing.Size(86, 36);
            this.smallSizeButton.TabIndex = 2;
            this.smallSizeButton.Text = "Small";
            this.smallSizeButton.UseVisualStyleBackColor = false;
            this.smallSizeButton.Click += new System.EventHandler(this.SmallGameButtonPress);
            // 
            // mediumSizeButton
            // 
            this.mediumSizeButton.BackColor = System.Drawing.Color.Black;
            this.mediumSizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mediumSizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.mediumSizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mediumSizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediumSizeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumSizeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mediumSizeButton.Location = new System.Drawing.Point(423, 207);
            this.mediumSizeButton.Name = "mediumSizeButton";
            this.mediumSizeButton.Size = new System.Drawing.Size(86, 36);
            this.mediumSizeButton.TabIndex = 3;
            this.mediumSizeButton.Text = "Medium";
            this.mediumSizeButton.UseVisualStyleBackColor = false;
            this.mediumSizeButton.Click += new System.EventHandler(this.MediumGameButtonPress);
            // 
            // bigSizeButton
            // 
            this.bigSizeButton.BackColor = System.Drawing.Color.Black;
            this.bigSizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bigSizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bigSizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bigSizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bigSizeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigSizeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bigSizeButton.Location = new System.Drawing.Point(549, 207);
            this.bigSizeButton.Name = "bigSizeButton";
            this.bigSizeButton.Size = new System.Drawing.Size(86, 36);
            this.bigSizeButton.TabIndex = 4;
            this.bigSizeButton.Text = "Big";
            this.bigSizeButton.UseVisualStyleBackColor = false;
            this.bigSizeButton.Click += new System.EventHandler(this.BigGameButtonPress);
            // 
            // checkboxPlayer1
            // 
            this.checkboxPlayer1.AutoSize = true;
            this.checkboxPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.checkboxPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkboxPlayer1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxPlayer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkboxPlayer1.Location = new System.Drawing.Point(128, 34);
            this.checkboxPlayer1.Name = "checkboxPlayer1";
            this.checkboxPlayer1.Size = new System.Drawing.Size(13, 12);
            this.checkboxPlayer1.TabIndex = 5;
            this.checkboxPlayer1.TabStop = true;
            this.checkboxPlayer1.UseVisualStyleBackColor = false;
            this.checkboxPlayer1.CheckedChanged += new System.EventHandler(this.Player1RadioChecked);
            // 
            // checkboxPlayer2
            // 
            this.checkboxPlayer2.AutoSize = true;
            this.checkboxPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.checkboxPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkboxPlayer2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxPlayer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkboxPlayer2.Location = new System.Drawing.Point(205, 34);
            this.checkboxPlayer2.Name = "checkboxPlayer2";
            this.checkboxPlayer2.Size = new System.Drawing.Size(13, 12);
            this.checkboxPlayer2.TabIndex = 6;
            this.checkboxPlayer2.TabStop = true;
            this.checkboxPlayer2.UseVisualStyleBackColor = false;
            this.checkboxPlayer2.CheckedChanged += new System.EventHandler(this.Player2RadioChecked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "First move:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.checkboxPlayer1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.checkboxPlayer2);
            this.panel1.Location = new System.Drawing.Point(342, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 56);
            this.panel1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(172, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Computer";
            this.label5.Click += new System.EventHandler(this.Player2LabelClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(111, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "User";
            this.label4.Click += new System.EventHandler(this.Player1LabelClick);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bigSizeButton);
            this.Controls.Add(this.mediumSizeButton);
            this.Controls.Add(this.smallSizeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startGameButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.Text = "Dots and Boxes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button smallSizeButton;
        private System.Windows.Forms.Button mediumSizeButton;
        private System.Windows.Forms.Button bigSizeButton;
        private System.Windows.Forms.RadioButton checkboxPlayer1;
        private System.Windows.Forms.RadioButton checkboxPlayer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

