namespace drawSquaresAndRectangles
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
            this.dotCtrl4 = new drawSquaresAndRectangles.dotCtrl();
            this.dotCtrl3 = new drawSquaresAndRectangles.dotCtrl();
            this.dotCtrl2 = new drawSquaresAndRectangles.dotCtrl();
            this.dotCtrl1 = new drawSquaresAndRectangles.dotCtrl();
            this.SuspendLayout();
            // 
            // dotCtrl4
            // 
            this.dotCtrl4.BackColor = System.Drawing.Color.Red;
            this.dotCtrl4.Location = new System.Drawing.Point(288, 309);
            this.dotCtrl4.Name = "dotCtrl4";
            this.dotCtrl4.Size = new System.Drawing.Size(7, 7);
            this.dotCtrl4.TabIndex = 3;
            // 
            // dotCtrl3
            // 
            this.dotCtrl3.BackColor = System.Drawing.Color.Red;
            this.dotCtrl3.Location = new System.Drawing.Point(145, 197);
            this.dotCtrl3.Name = "dotCtrl3";
            this.dotCtrl3.Size = new System.Drawing.Size(7, 7);
            this.dotCtrl3.TabIndex = 2;
            // 
            // dotCtrl2
            // 
            this.dotCtrl2.BackColor = System.Drawing.Color.Red;
            this.dotCtrl2.Location = new System.Drawing.Point(288, 139);
            this.dotCtrl2.Name = "dotCtrl2";
            this.dotCtrl2.Size = new System.Drawing.Size(7, 7);
            this.dotCtrl2.TabIndex = 1;
            // 
            // dotCtrl1
            // 
            this.dotCtrl1.BackColor = System.Drawing.Color.Red;
            this.dotCtrl1.Location = new System.Drawing.Point(145, 67);
            this.dotCtrl1.Name = "dotCtrl1";
            this.dotCtrl1.Size = new System.Drawing.Size(7, 7);
            this.dotCtrl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 418);
            this.Controls.Add(this.dotCtrl4);
            this.Controls.Add(this.dotCtrl3);
            this.Controls.Add(this.dotCtrl2);
            this.Controls.Add(this.dotCtrl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private dotCtrl dotCtrl1;
        private dotCtrl dotCtrl2;
        private dotCtrl dotCtrl3;
        private dotCtrl dotCtrl4;
    }
}

