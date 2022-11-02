namespace HomeWork7
{
    partial class NumberInput
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
            this.buttonNumberEnter = new System.Windows.Forms.Button();
            this.textBoxNumberInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNumberEnter
            // 
            this.buttonNumberEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNumberEnter.Location = new System.Drawing.Point(58, 94);
            this.buttonNumberEnter.Name = "buttonNumberEnter";
            this.buttonNumberEnter.Size = new System.Drawing.Size(148, 50);
            this.buttonNumberEnter.TabIndex = 0;
            this.buttonNumberEnter.Text = "Подтвердить ввод";
            this.buttonNumberEnter.UseVisualStyleBackColor = true;
            this.buttonNumberEnter.Click += new System.EventHandler(this.buttonNumberEnter_Click);
            // 
            // textBoxNumberInput
            // 
            this.textBoxNumberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumberInput.Location = new System.Drawing.Point(111, 54);
            this.textBoxNumberInput.Name = "textBoxNumberInput";
            this.textBoxNumberInput.Size = new System.Drawing.Size(40, 26);
            this.textBoxNumberInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите число";
            // 
            // NumberInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 161);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumberInput);
            this.Controls.Add(this.buttonNumberEnter);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(280, 200);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(280, 200);
            this.Name = "NumberInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNumberEnter;
        private System.Windows.Forms.TextBox textBoxNumberInput;
        private System.Windows.Forms.Label label1;
    }
}