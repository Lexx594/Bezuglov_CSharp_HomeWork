namespace HomeWork7
{
    partial class Number
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
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.labelInputNumber = new System.Windows.Forms.Label();
            this.buttonToInputForm = new System.Windows.Forms.Button();
            this.labelAllNumbers = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelTimerPoint = new System.Windows.Forms.Label();
            this.labelTimerSec = new System.Windows.Forms.Label();
            this.labelTimerMin = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonStartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartGame.Location = new System.Drawing.Point(170, 255);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(145, 44);
            this.buttonStartGame.TabIndex = 14;
            this.buttonStartGame.Text = "Начать игру";
            this.buttonStartGame.UseVisualStyleBackColor = false;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // labelInputNumber
            // 
            this.labelInputNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelInputNumber.AutoSize = true;
            this.labelInputNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInputNumber.Location = new System.Drawing.Point(270, 108);
            this.labelInputNumber.Name = "labelInputNumber";
            this.labelInputNumber.Size = new System.Drawing.Size(0, 20);
            this.labelInputNumber.TabIndex = 15;
            this.labelInputNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonToInputForm
            // 
            this.buttonToInputForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonToInputForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonToInputForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToInputForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonToInputForm.Location = new System.Drawing.Point(145, 161);
            this.buttonToInputForm.Name = "buttonToInputForm";
            this.buttonToInputForm.Size = new System.Drawing.Size(205, 61);
            this.buttonToInputForm.TabIndex = 16;
            this.buttonToInputForm.Text = "Ввести число";
            this.buttonToInputForm.UseVisualStyleBackColor = false;
            this.buttonToInputForm.Click += new System.EventHandler(this.buttonToInputForm_Click);
            // 
            // labelAllNumbers
            // 
            this.labelAllNumbers.AutoSize = true;
            this.labelAllNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAllNumbers.Location = new System.Drawing.Point(13, 13);
            this.labelAllNumbers.Name = "labelAllNumbers";
            this.labelAllNumbers.Size = new System.Drawing.Size(105, 20);
            this.labelAllNumbers.TabIndex = 17;
            this.labelAllNumbers.Text = "Вы вводили:";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(13, 39);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(70, 18);
            this.labelCount.TabIndex = 18;
            this.labelCount.Text = "Попытка";
            // 
            // labelTimerPoint
            // 
            this.labelTimerPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTimerPoint.AutoSize = true;
            this.labelTimerPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimerPoint.Location = new System.Drawing.Point(100, 284);
            this.labelTimerPoint.Name = "labelTimerPoint";
            this.labelTimerPoint.Size = new System.Drawing.Size(13, 18);
            this.labelTimerPoint.TabIndex = 22;
            this.labelTimerPoint.Text = ":";
            // 
            // labelTimerSec
            // 
            this.labelTimerSec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTimerSec.AutoSize = true;
            this.labelTimerSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimerSec.Location = new System.Drawing.Point(110, 284);
            this.labelTimerSec.Name = "labelTimerSec";
            this.labelTimerSec.Size = new System.Drawing.Size(26, 18);
            this.labelTimerSec.TabIndex = 21;
            this.labelTimerSec.Text = "00";
            // 
            // labelTimerMin
            // 
            this.labelTimerMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTimerMin.AutoSize = true;
            this.labelTimerMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimerMin.Location = new System.Drawing.Point(78, 284);
            this.labelTimerMin.Name = "labelTimerMin";
            this.labelTimerMin.Size = new System.Drawing.Size(26, 18);
            this.labelTimerMin.TabIndex = 20;
            this.labelTimerMin.Text = "00";
            // 
            // labelTimer
            // 
            this.labelTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimer.Location = new System.Drawing.Point(12, 284);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(66, 18);
            this.labelTimer.TabIndex = 19;
            this.labelTimer.Text = "Таймер";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(176, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Вы ввели ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Number
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTimerPoint);
            this.Controls.Add(this.labelTimerSec);
            this.Controls.Add(this.labelTimerMin);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelAllNumbers);
            this.Controls.Add(this.buttonToInputForm);
            this.Controls.Add(this.labelInputNumber);
            this.Controls.Add(this.buttonStartGame);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "Number";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Угадай число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Label labelInputNumber;
        private System.Windows.Forms.Button buttonToInputForm;
        private System.Windows.Forms.Label labelAllNumbers;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelTimerPoint;
        private System.Windows.Forms.Label labelTimerSec;
        private System.Windows.Forms.Label labelTimerMin;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
    }
}