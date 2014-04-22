namespace RFIDThing
{
    partial class RacerForm
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
            this.laps = new System.Windows.Forms.Label();
            this.comBox = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // laps
            // 
            this.laps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laps.AutoSize = true;
            this.laps.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laps.ForeColor = System.Drawing.Color.Purple;
            this.laps.Location = new System.Drawing.Point(243, 135);
            this.laps.Name = "laps";
            this.laps.Size = new System.Drawing.Size(68, 73);
            this.laps.TabIndex = 0;
            this.laps.Text = "0";
            // 
            // comBox
            // 
            this.comBox.Location = new System.Drawing.Point(13, 13);
            this.comBox.Name = "comBox";
            this.comBox.Size = new System.Drawing.Size(100, 20);
            this.comBox.TabIndex = 1;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(119, 10);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 2;
            this.start.Text = "GO GO GO";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 362);
            this.Controls.Add(this.start);
            this.Controls.Add(this.comBox);
            this.Controls.Add(this.laps);
            this.Name = "Form1";
            this.Text = "Racecar is a palindrome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laps;
        private System.Windows.Forms.TextBox comBox;
        private System.Windows.Forms.Button start;
    }
}

