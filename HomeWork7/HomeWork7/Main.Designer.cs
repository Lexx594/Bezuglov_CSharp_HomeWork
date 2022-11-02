namespace HomeWork7
{
    partial class Main
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
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonResetGame = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMulti = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelComputerNumber = new System.Windows.Forms.Label();
            this.labelUserNumber = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelTimerMin = new System.Windows.Forms.Label();
            this.labelTimerSec = new System.Windows.Forms.Label();
            this.labelTimerPoint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNewGame.Location = new System.Drawing.Point(337, 10);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(135, 54);
            this.buttonNewGame.TabIndex = 0;
            this.buttonNewGame.Text = "Новая игра";
            this.buttonNewGame.UseVisualStyleBackColor = false;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonResetGame
            // 
            this.buttonResetGame.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonResetGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonResetGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResetGame.Location = new System.Drawing.Point(337, 70);
            this.buttonResetGame.Name = "buttonResetGame";
            this.buttonResetGame.Size = new System.Drawing.Size(135, 54);
            this.buttonResetGame.TabIndex = 1;
            this.buttonResetGame.Text = "Сброс текущей игры";
            this.buttonResetGame.UseVisualStyleBackColor = false;
            this.buttonResetGame.Click += new System.EventHandler(this.buttonResetGame_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPlus.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.Location = new System.Drawing.Point(2, 232);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(125, 76);
            this.buttonPlus.TabIndex = 2;
            this.buttonPlus.Text = "+1";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMulti
            // 
            this.buttonMulti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMulti.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMulti.Location = new System.Drawing.Point(357, 232);
            this.buttonMulti.Name = "buttonMulti";
            this.buttonMulti.Size = new System.Drawing.Size(125, 76);
            this.buttonMulti.TabIndex = 3;
            this.buttonMulti.Text = "x2";
            this.buttonMulti.UseVisualStyleBackColor = false;
            this.buttonMulti.Click += new System.EventHandler(this.buttonMulti_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(143, 248);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(198, 43);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "отмена хода";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelComputerNumber
            // 
            this.labelComputerNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelComputerNumber.AutoSize = true;
            this.labelComputerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelComputerNumber.Location = new System.Drawing.Point(41, 125);
            this.labelComputerNumber.Name = "labelComputerNumber";
            this.labelComputerNumber.Size = new System.Drawing.Size(178, 24);
            this.labelComputerNumber.TabIndex = 5;
            this.labelComputerNumber.Text = "Получите число: ";
            // 
            // labelUserNumber
            // 
            this.labelUserNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelUserNumber.AutoSize = true;
            this.labelUserNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserNumber.Location = new System.Drawing.Point(44, 173);
            this.labelUserNumber.Name = "labelUserNumber";
            this.labelUserNumber.Size = new System.Drawing.Size(168, 24);
            this.labelUserNumber.TabIndex = 6;
            this.labelUserNumber.Text = "Текущее число: ";
            // 
            // labelTimer
            // 
            this.labelTimer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimer.Location = new System.Drawing.Point(42, 9);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(66, 18);
            this.labelTimer.TabIndex = 7;
            this.labelTimer.Text = "Таймер";
            // 
            // labelCount
            // 
            this.labelCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(41, 51);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(129, 18);
            this.labelCount.TabIndex = 8;
            this.labelCount.Text = "Сделано ходов";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTimerMin
            // 
            this.labelTimerMin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTimerMin.AutoSize = true;
            this.labelTimerMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimerMin.Location = new System.Drawing.Point(108, 9);
            this.labelTimerMin.Name = "labelTimerMin";
            this.labelTimerMin.Size = new System.Drawing.Size(26, 18);
            this.labelTimerMin.TabIndex = 9;
            this.labelTimerMin.Text = "00";
            // 
            // labelTimerSec
            // 
            this.labelTimerSec.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTimerSec.AutoSize = true;
            this.labelTimerSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimerSec.Location = new System.Drawing.Point(140, 9);
            this.labelTimerSec.Name = "labelTimerSec";
            this.labelTimerSec.Size = new System.Drawing.Size(26, 18);
            this.labelTimerSec.TabIndex = 10;
            this.labelTimerSec.Text = "00";
            // 
            // labelTimerPoint
            // 
            this.labelTimerPoint.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTimerPoint.AutoSize = true;
            this.labelTimerPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimerPoint.Location = new System.Drawing.Point(130, 9);
            this.labelTimerPoint.Name = "labelTimerPoint";
            this.labelTimerPoint.Size = new System.Drawing.Size(13, 18);
            this.labelTimerPoint.TabIndex = 11;
            this.labelTimerPoint.Text = ":";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.labelTimerPoint);
            this.Controls.Add(this.labelTimerSec);
            this.Controls.Add(this.labelTimerMin);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.labelUserNumber);
            this.Controls.Add(this.labelComputerNumber);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonMulti);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonResetGame);
            this.Controls.Add(this.buttonNewGame);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Удвоитель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonResetGame;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMulti;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelComputerNumber;
        private System.Windows.Forms.Label labelUserNumber;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelTimerMin;
        private System.Windows.Forms.Label labelTimerSec;
        private System.Windows.Forms.Label labelTimerPoint;
    }
}