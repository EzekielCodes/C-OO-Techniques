namespace snakeForm
{
    partial class Form1
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
            ((System.ComponentModel.ISupportInitialize)(this.canvasMain)).BeginInit();
            this.SuspendLayout();
            // 
            // canvasMain
            // 
            this.canvasMain.BackColor = System.Drawing.Color.DarkGray;
            this.canvasMain.Location = new System.Drawing.Point(70, 12);
            this.canvasMain.Name = "canvasMain";
            this.canvasMain.Size = new System.Drawing.Size(541, 560);
            this.canvasMain.TabIndex = 0;
            this.canvasMain.TabStop = false;
            this.canvasMain.Paint += new System.Windows.Forms.PaintEventHandler(this.RefreshGraphics);
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 625);
            this.Controls.Add(this.canvasMain);
            this.Location = new System.Drawing.Point(13, 13);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.canvasMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox canvasMain;
        private System.Windows.Forms.Timer gameTimer;
    }
}