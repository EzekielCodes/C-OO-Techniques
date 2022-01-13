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
            this.canvasMain.Location = new System.Drawing.Point(1, -1);
            this.canvasMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.canvasMain.Name = "canvasMain";
            this.canvasMain.Size = new System.Drawing.Size(379, 336);
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
            this.scorelabel.Location = new System.Drawing.Point(391, 32);
            this.scorelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(36, 15);
            this.scorelabel.TabIndex = 1;
            this.scorelabel.Text = "Score";
            // 
            // scoreCounter
            // 
            this.scoreCounter.AutoSize = true;
            this.scoreCounter.Location = new System.Drawing.Point(466, 32);
            this.scoreCounter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoreCounter.Name = "scoreCounter";
            this.scoreCounter.Size = new System.Drawing.Size(13, 15);
            this.scoreCounter.TabIndex = 2;
            this.scoreCounter.Text = "0";
            // 
            // labelHigh
            // 
            this.labelHigh.AutoSize = true;
            this.labelHigh.Location = new System.Drawing.Point(409, 224);
            this.labelHigh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHigh.Name = "labelHigh";
            this.labelHigh.Size = new System.Drawing.Size(38, 15);
            this.labelHigh.TabIndex = 3;
            this.labelHigh.Text = "label1";
            // 
            // SnakeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 336);
            this.Controls.Add(this.labelHigh);
            this.Controls.Add(this.scoreCounter);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.canvasMain);
            this.Location = new System.Drawing.Point(13, 13);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SnakeGame";
            this.Text = "SnakeGame";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
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