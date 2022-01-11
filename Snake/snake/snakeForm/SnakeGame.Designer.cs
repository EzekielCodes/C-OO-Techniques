namespace snakeForm
{
    partial class SnakeGame
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
            this.components = new System.ComponentModel.Container();
            this.canvasMain = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.scorelabel = new System.Windows.Forms.Label();
            this.scoreCounter = new System.Windows.Forms.Label();
            this.labelHigh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canvasMain)).BeginInit();
            this.SuspendLayout();
            // 
            // canvasMain
            // 
            this.canvasMain.BackColor = System.Drawing.Color.DarkGray;
            this.canvasMain.Location = new System.Drawing.Point(2, -1);
            this.canvasMain.Name = "canvasMain";
            this.canvasMain.Size = new System.Drawing.Size(541, 560);
            this.canvasMain.TabIndex = 0;
            this.canvasMain.TabStop = false;
            this.canvasMain.Paint += new System.Windows.Forms.PaintEventHandler(this.RefreshGraphics);
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerTick);
            // 
            // scorelabel
            // 
            this.scorelabel.AutoSize = true;
            this.scorelabel.Location = new System.Drawing.Point(559, 54);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(56, 25);
            this.scorelabel.TabIndex = 1;
            this.scorelabel.Text = "Score";
            // 
            // scoreCounter
            // 
            this.scoreCounter.AutoSize = true;
            this.scoreCounter.Location = new System.Drawing.Point(665, 54);
            this.scoreCounter.Name = "scoreCounter";
            this.scoreCounter.Size = new System.Drawing.Size(22, 25);
            this.scoreCounter.TabIndex = 2;
            this.scoreCounter.Text = "0";
            // 
            // labelHigh
            // 
            this.labelHigh.AutoSize = true;
            this.labelHigh.Location = new System.Drawing.Point(584, 373);
            this.labelHigh.Name = "labelHigh";
            this.labelHigh.Size = new System.Drawing.Size(59, 25);
            this.labelHigh.TabIndex = 3;
            this.labelHigh.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 560);
            this.Controls.Add(this.labelHigh);
            this.Controls.Add(this.scoreCounter);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.canvasMain);
            this.Location = new System.Drawing.Point(13, 13);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormKeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FormPreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.canvasMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox canvasMain;
        private System.Windows.Forms.Timer gameTimer;
        private Label scorelabel;
        private Label scoreCounter;
        private Label labelHigh;
    }
}