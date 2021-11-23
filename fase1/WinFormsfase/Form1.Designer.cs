namespace WinFormsfase
{
    partial class Increment
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonIncreament = new System.Windows.Forms.Button();
            this.textBoxTeller = new System.Windows.Forms.TextBox();
            this.textBoxKiesCijfer = new System.Windows.Forms.TextBox();
            this.labelIncrement = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(124, 158);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(64, 25);
            this.labelCount.TabIndex = 0;
            this.labelCount.Text = "Count:";
            // 
            // buttonIncreament
            // 
            this.buttonIncreament.Location = new System.Drawing.Point(208, 248);
            this.buttonIncreament.Name = "buttonIncreament";
            this.buttonIncreament.Size = new System.Drawing.Size(150, 42);
            this.buttonIncreament.TabIndex = 1;
            this.buttonIncreament.Text = "Increase";
            this.buttonIncreament.UseVisualStyleBackColor = true;
            this.buttonIncreament.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonIncreament_MouseClick);
            // 
            // textBoxTeller
            // 
            this.textBoxTeller.Location = new System.Drawing.Point(208, 153);
            this.textBoxTeller.Name = "textBoxTeller";
            this.textBoxTeller.Size = new System.Drawing.Size(150, 31);
            this.textBoxTeller.TabIndex = 2;
            // 
            // textBoxKiesCijfer
            // 
            this.textBoxKiesCijfer.Location = new System.Drawing.Point(209, 76);
            this.textBoxKiesCijfer.Name = "textBoxKiesCijfer";
            this.textBoxKiesCijfer.Size = new System.Drawing.Size(150, 31);
            this.textBoxKiesCijfer.TabIndex = 3;
            // 
            // labelIncrement
            // 
            this.labelIncrement.AutoSize = true;
            this.labelIncrement.Location = new System.Drawing.Point(97, 79);
            this.labelIncrement.Name = "labelIncrement";
            this.labelIncrement.Size = new System.Drawing.Size(95, 25);
            this.labelIncrement.TabIndex = 4;
            this.labelIncrement.Text = "Increment:";
            // 
            // Increment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 436);
            this.Controls.Add(this.labelIncrement);
            this.Controls.Add(this.textBoxKiesCijfer);
            this.Controls.Add(this.textBoxTeller);
            this.Controls.Add(this.buttonIncreament);
            this.Controls.Add(this.labelCount);
            this.Name = "Increment";
            this.Text = "Increment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelCount;
        private Button buttonIncreament;
        private TextBox textBoxTeller;
        private TextBox textBoxKiesCijfer;
        private Label labelIncrement;
    }
}