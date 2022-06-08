namespace CuteCat
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
            this.CatScreen = new System.Windows.Forms.Label();
            this.Play = new System.Windows.Forms.Button();
            this.Feed = new System.Windows.Forms.Button();
            this.CatTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CatScreen
            // 
            this.CatScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CatScreen.Location = new System.Drawing.Point(25, 24);
            this.CatScreen.Name = "CatScreen";
            this.CatScreen.Size = new System.Drawing.Size(388, 61);
            this.CatScreen.TabIndex = 0;
            this.CatScreen.Text = "Click Here";
            this.CatScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CatScreen.Click += new System.EventHandler(this.CatScreen_Click);
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(25, 106);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 31);
            this.Play.TabIndex = 1;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Feed
            // 
            this.Feed.Location = new System.Drawing.Point(129, 106);
            this.Feed.Name = "Feed";
            this.Feed.Size = new System.Drawing.Size(75, 31);
            this.Feed.TabIndex = 2;
            this.Feed.Text = "Feed";
            this.Feed.UseVisualStyleBackColor = true;
            this.Feed.Click += new System.EventHandler(this.Feed_Click);
            // 
            // CatTimer
            // 
            this.CatTimer.Enabled = true;
            this.CatTimer.Interval = 5000;
            this.CatTimer.Tick += new System.EventHandler(this.CatTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 260);
            this.Controls.Add(this.Feed);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.CatScreen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Label CatScreen;
        private Button Play;
        private Button Feed;
        private System.Windows.Forms.Timer CatTimer;
    }
}