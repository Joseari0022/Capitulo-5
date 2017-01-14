namespace Cadena
{
    partial class Form1
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
            this.PalabratextBox = new System.Windows.Forms.TextBox();
            this.RegresaPalabraLabel1 = new System.Windows.Forms.Label();
            this.ClickButton = new System.Windows.Forms.Button();
            this.NumerotextBox = new System.Windows.Forms.TextBox();
            this.DigiteNumeroLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PalabratextBox
            // 
            this.PalabratextBox.Location = new System.Drawing.Point(13, 104);
            this.PalabratextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PalabratextBox.Name = "PalabratextBox";
            this.PalabratextBox.Size = new System.Drawing.Size(272, 22);
            this.PalabratextBox.TabIndex = 9;
            // 
            // RegresaPalabraLabel1
            // 
            this.RegresaPalabraLabel1.AutoSize = true;
            this.RegresaPalabraLabel1.Location = new System.Drawing.Point(13, 83);
            this.RegresaPalabraLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegresaPalabraLabel1.Name = "RegresaPalabraLabel1";
            this.RegresaPalabraLabel1.Size = new System.Drawing.Size(61, 17);
            this.RegresaPalabraLabel1.TabIndex = 8;
            this.RegresaPalabraLabel1.Text = "Palabra ";
            // 
            // ClickButton
            // 
            this.ClickButton.Location = new System.Drawing.Point(13, 150);
            this.ClickButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClickButton.Name = "ClickButton";
            this.ClickButton.Size = new System.Drawing.Size(100, 28);
            this.ClickButton.TabIndex = 7;
            this.ClickButton.Text = "Precionar";
            this.ClickButton.UseVisualStyleBackColor = true;
            this.ClickButton.Click += new System.EventHandler(this.ClickButton_Click);
            // 
            // NumerotextBox
            // 
            this.NumerotextBox.Location = new System.Drawing.Point(16, 44);
            this.NumerotextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NumerotextBox.Name = "NumerotextBox";
            this.NumerotextBox.Size = new System.Drawing.Size(132, 22);
            this.NumerotextBox.TabIndex = 6;
            // 
            // DigiteNumeroLabel1
            // 
            this.DigiteNumeroLabel1.AutoSize = true;
            this.DigiteNumeroLabel1.Location = new System.Drawing.Point(13, 23);
            this.DigiteNumeroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DigiteNumeroLabel1.Name = "DigiteNumeroLabel1";
            this.DigiteNumeroLabel1.Size = new System.Drawing.Size(120, 17);
            this.DigiteNumeroLabel1.TabIndex = 5;
            this.DigiteNumeroLabel1.Text = "Digites el Numero";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 306);
            this.Controls.Add(this.PalabratextBox);
            this.Controls.Add(this.RegresaPalabraLabel1);
            this.Controls.Add(this.ClickButton);
            this.Controls.Add(this.NumerotextBox);
            this.Controls.Add(this.DigiteNumeroLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PalabratextBox;
        private System.Windows.Forms.Label RegresaPalabraLabel1;
        private System.Windows.Forms.Button ClickButton;
        private System.Windows.Forms.TextBox NumerotextBox;
        private System.Windows.Forms.Label DigiteNumeroLabel1;
    }
}

