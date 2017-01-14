namespace PerimetroPoligono
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
            this.BorrarBotton = new System.Windows.Forms.Button();
            this.PerimetroPoligonoLabel1 = new System.Windows.Forms.Label();
            this.PerimetroPoligonotextBox3 = new System.Windows.Forms.TextBox();
            this.DimecionPoligonotextBox2 = new System.Windows.Forms.TextBox();
            this.DimencionPoligonoLabel2 = new System.Windows.Forms.Label();
            this.NumeroLadotextBox1 = new System.Windows.Forms.TextBox();
            this.NumeroLadoLabel = new System.Windows.Forms.Label();
            this.CacularButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BorrarBotton
            // 
            this.BorrarBotton.Location = new System.Drawing.Point(233, 138);
            this.BorrarBotton.Margin = new System.Windows.Forms.Padding(4);
            this.BorrarBotton.Name = "BorrarBotton";
            this.BorrarBotton.Size = new System.Drawing.Size(100, 28);
            this.BorrarBotton.TabIndex = 15;
            this.BorrarBotton.Text = "Borrar";
            this.BorrarBotton.UseVisualStyleBackColor = true;
            this.BorrarBotton.Click += new System.EventHandler(this.BorrarBotton_Click);
            // 
            // PerimetroPoligonoLabel1
            // 
            this.PerimetroPoligonoLabel1.AutoSize = true;
            this.PerimetroPoligonoLabel1.Location = new System.Drawing.Point(4, 149);
            this.PerimetroPoligonoLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PerimetroPoligonoLabel1.Name = "PerimetroPoligonoLabel1";
            this.PerimetroPoligonoLabel1.Size = new System.Drawing.Size(72, 17);
            this.PerimetroPoligonoLabel1.TabIndex = 14;
            this.PerimetroPoligonoLabel1.Text = "Resultado";
            // 
            // PerimetroPoligonotextBox3
            // 
            this.PerimetroPoligonotextBox3.Location = new System.Drawing.Point(7, 170);
            this.PerimetroPoligonotextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.PerimetroPoligonotextBox3.Name = "PerimetroPoligonotextBox3";
            this.PerimetroPoligonotextBox3.Size = new System.Drawing.Size(132, 22);
            this.PerimetroPoligonotextBox3.TabIndex = 13;
            // 
            // DimecionPoligonotextBox2
            // 
            this.DimecionPoligonotextBox2.Location = new System.Drawing.Point(7, 115);
            this.DimecionPoligonotextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.DimecionPoligonotextBox2.Name = "DimecionPoligonotextBox2";
            this.DimecionPoligonotextBox2.Size = new System.Drawing.Size(132, 22);
            this.DimecionPoligonotextBox2.TabIndex = 12;
            // 
            // DimencionPoligonoLabel2
            // 
            this.DimencionPoligonoLabel2.AutoSize = true;
            this.DimencionPoligonoLabel2.Location = new System.Drawing.Point(4, 94);
            this.DimencionPoligonoLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DimencionPoligonoLabel2.Name = "DimencionPoligonoLabel2";
            this.DimencionPoligonoLabel2.Size = new System.Drawing.Size(157, 17);
            this.DimencionPoligonoLabel2.TabIndex = 11;
            this.DimencionPoligonoLabel2.Text = "Dimencion de Poligono ";
            // 
            // NumeroLadotextBox1
            // 
            this.NumeroLadotextBox1.Location = new System.Drawing.Point(7, 64);
            this.NumeroLadotextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.NumeroLadotextBox1.Name = "NumeroLadotextBox1";
            this.NumeroLadotextBox1.Size = new System.Drawing.Size(132, 22);
            this.NumeroLadotextBox1.TabIndex = 10;
            // 
            // NumeroLadoLabel
            // 
            this.NumeroLadoLabel.AutoSize = true;
            this.NumeroLadoLabel.Location = new System.Drawing.Point(4, 43);
            this.NumeroLadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumeroLadoLabel.Name = "NumeroLadoLabel";
            this.NumeroLadoLabel.Size = new System.Drawing.Size(121, 17);
            this.NumeroLadoLabel.TabIndex = 9;
            this.NumeroLadoLabel.Text = "Numero de Lados";
            // 
            // CacularButton
            // 
            this.CacularButton.Location = new System.Drawing.Point(233, 58);
            this.CacularButton.Margin = new System.Windows.Forms.Padding(4);
            this.CacularButton.Name = "CacularButton";
            this.CacularButton.Size = new System.Drawing.Size(100, 28);
            this.CacularButton.TabIndex = 8;
            this.CacularButton.Text = "Calcular";
            this.CacularButton.UseVisualStyleBackColor = true;
            this.CacularButton.Click += new System.EventHandler(this.CacularButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 231);
            this.Controls.Add(this.BorrarBotton);
            this.Controls.Add(this.PerimetroPoligonoLabel1);
            this.Controls.Add(this.PerimetroPoligonotextBox3);
            this.Controls.Add(this.DimecionPoligonotextBox2);
            this.Controls.Add(this.DimencionPoligonoLabel2);
            this.Controls.Add(this.NumeroLadotextBox1);
            this.Controls.Add(this.NumeroLadoLabel);
            this.Controls.Add(this.CacularButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BorrarBotton;
        private System.Windows.Forms.Label PerimetroPoligonoLabel1;
        private System.Windows.Forms.TextBox PerimetroPoligonotextBox3;
        private System.Windows.Forms.TextBox DimecionPoligonotextBox2;
        private System.Windows.Forms.Label DimencionPoligonoLabel2;
        private System.Windows.Forms.TextBox NumeroLadotextBox1;
        private System.Windows.Forms.Label NumeroLadoLabel;
        private System.Windows.Forms.Button CacularButton;
    }
}

