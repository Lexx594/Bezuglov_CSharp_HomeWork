namespace HomeWork7
{
    partial class Menu
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
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelGameSelection = new System.Windows.Forms.Label();
            this.buttonPlayMulti = new System.Windows.Forms.Button();
            this.buttonPlayNumber = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(151, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(186, 18);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Домашняя работа № 7";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelGameSelection
            // 
            this.labelGameSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGameSelection.AutoSize = true;
            this.labelGameSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGameSelection.Location = new System.Drawing.Point(89, 89);
            this.labelGameSelection.Name = "labelGameSelection";
            this.labelGameSelection.Size = new System.Drawing.Size(299, 20);
            this.labelGameSelection.TabIndex = 1;
            this.labelGameSelection.Text = "В какую игру вы хотите поиграть?";
            // 
            // buttonPlayMulti
            // 
            this.buttonPlayMulti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonPlayMulti.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlayMulti.Location = new System.Drawing.Point(23, 149);
            this.buttonPlayMulti.Name = "buttonPlayMulti";
            this.buttonPlayMulti.Size = new System.Drawing.Size(175, 112);
            this.buttonPlayMulti.TabIndex = 2;
            this.buttonPlayMulti.Text = "Удвоитель";
            this.buttonPlayMulti.UseVisualStyleBackColor = false;
            this.buttonPlayMulti.Click += new System.EventHandler(this.buttonPlayMulti_Click);
            // 
            // buttonPlayNumber
            // 
            this.buttonPlayNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonPlayNumber.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlayNumber.Location = new System.Drawing.Point(284, 149);
            this.buttonPlayNumber.Name = "buttonPlayNumber";
            this.buttonPlayNumber.Size = new System.Drawing.Size(175, 112);
            this.buttonPlayNumber.TabIndex = 3;
            this.buttonPlayNumber.Text = "Угадай число";
            this.buttonPlayNumber.UseVisualStyleBackColor = false;
            this.buttonPlayNumber.Click += new System.EventHandler(this.buttonPlayNumber_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(0, 267);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(484, 44);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPlayNumber);
            this.Controls.Add(this.buttonPlayMulti);
            this.Controls.Add(this.labelGameSelection);
            this.Controls.Add(this.labelInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню игр";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelGameSelection;
        private System.Windows.Forms.Button buttonPlayMulti;
        private System.Windows.Forms.Button buttonPlayNumber;
        private System.Windows.Forms.Button buttonExit;
    }
}