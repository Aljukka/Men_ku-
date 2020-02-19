namespace _19
{
    partial class Form2
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
            this.Drehen = new System.Windows.Forms.Button();
            this.Imja1 = new System.Windows.Forms.Label();
            this.Geld1 = new System.Windows.Forms.Label();
            this.Geld2 = new System.Windows.Forms.Label();
            this.Imja2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BewertenTextBox = new System.Windows.Forms.TextBox();
            this.Bewerten1 = new System.Windows.Forms.Label();
            this.Zahl1 = new System.Windows.Forms.PictureBox();
            this.Zahl2 = new System.Windows.Forms.PictureBox();
            this.Zahl3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Zahl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zahl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zahl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Drehen
            // 
            this.Drehen.Location = new System.Drawing.Point(284, 336);
            this.Drehen.Name = "Drehen";
            this.Drehen.Size = new System.Drawing.Size(235, 87);
            this.Drehen.TabIndex = 0;
            this.Drehen.Text = "Крутить";
            this.Drehen.UseVisualStyleBackColor = true;
            this.Drehen.Click += new System.EventHandler(this.Drehen_Click);
            // 
            // Imja1
            // 
            this.Imja1.AutoSize = true;
            this.Imja1.Location = new System.Drawing.Point(64, 122);
            this.Imja1.Name = "Imja1";
            this.Imja1.Size = new System.Drawing.Size(57, 13);
            this.Imja1.TabIndex = 1;
            this.Imja1.Text = "Ваше имя";
            // 
            // Geld1
            // 
            this.Geld1.AutoSize = true;
            this.Geld1.Location = new System.Drawing.Point(64, 148);
            this.Geld1.Name = "Geld1";
            this.Geld1.Size = new System.Drawing.Size(67, 13);
            this.Geld1.TabIndex = 2;
            this.Geld1.Text = "Ваша казна";
            // 
            // Geld2
            // 
            this.Geld2.AutoSize = true;
            this.Geld2.Location = new System.Drawing.Point(192, 148);
            this.Geld2.Name = "Geld2";
            this.Geld2.Size = new System.Drawing.Size(13, 13);
            this.Geld2.TabIndex = 5;
            this.Geld2.Text = "0";
            // 
            // Imja2
            // 
            this.Imja2.AutoSize = true;
            this.Imja2.Location = new System.Drawing.Point(192, 122);
            this.Imja2.Name = "Imja2";
            this.Imja2.Size = new System.Drawing.Size(13, 13);
            this.Imja2.TabIndex = 4;
            this.Imja2.Text = "0";
            this.Imja2.Click += new System.EventHandler(this.Imja2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 10;
            // 
            // BewertenTextBox
            // 
            this.BewertenTextBox.Location = new System.Drawing.Point(195, 171);
            this.BewertenTextBox.Name = "BewertenTextBox";
            this.BewertenTextBox.Size = new System.Drawing.Size(100, 20);
            this.BewertenTextBox.TabIndex = 11;
            // 
            // Bewerten1
            // 
            this.Bewerten1.AutoSize = true;
            this.Bewerten1.Location = new System.Drawing.Point(64, 174);
            this.Bewerten1.Name = "Bewerten1";
            this.Bewerten1.Size = new System.Drawing.Size(43, 13);
            this.Bewerten1.TabIndex = 3;
            this.Bewerten1.Text = "Ставка";
            // 
            // Zahl1
            // 
            this.Zahl1.Location = new System.Drawing.Point(321, 262);
            this.Zahl1.Name = "Zahl1";
            this.Zahl1.Size = new System.Drawing.Size(50, 58);
            this.Zahl1.TabIndex = 12;
            this.Zahl1.TabStop = false;
            // 
            // Zahl2
            // 
            this.Zahl2.Location = new System.Drawing.Point(377, 262);
            this.Zahl2.Name = "Zahl2";
            this.Zahl2.Size = new System.Drawing.Size(50, 58);
            this.Zahl2.TabIndex = 13;
            this.Zahl2.TabStop = false;
            // 
            // Zahl3
            // 
            this.Zahl3.Location = new System.Drawing.Point(433, 262);
            this.Zahl3.Name = "Zahl3";
            this.Zahl3.Size = new System.Drawing.Size(50, 58);
            this.Zahl3.TabIndex = 14;
            this.Zahl3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(67, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(683, 91);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Zahl3);
            this.Controls.Add(this.Zahl2);
            this.Controls.Add(this.Zahl1);
            this.Controls.Add(this.BewertenTextBox);
            this.Controls.Add(this.Geld2);
            this.Controls.Add(this.Imja2);
            this.Controls.Add(this.Bewerten1);
            this.Controls.Add(this.Geld1);
            this.Controls.Add(this.Imja1);
            this.Controls.Add(this.Drehen);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.Zahl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zahl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zahl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Drehen;
        private System.Windows.Forms.Label Imja1;
        private System.Windows.Forms.Label Geld1;
        private System.Windows.Forms.Label Geld2;
        private System.Windows.Forms.Label Imja2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BewertenTextBox;
        private System.Windows.Forms.Label Bewerten1;
        private System.Windows.Forms.PictureBox Zahl1;
        private System.Windows.Forms.PictureBox Zahl2;
        private System.Windows.Forms.PictureBox Zahl3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}