namespace Battlestar
{
    partial class Replay
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
            this.btnQuitGame = new System.Windows.Forms.Button();
            this.btnBackMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuitGame
            // 
            this.btnQuitGame.Location = new System.Drawing.Point(245, 157);
            this.btnQuitGame.Name = "btnQuitGame";
            this.btnQuitGame.Size = new System.Drawing.Size(117, 58);
            this.btnQuitGame.TabIndex = 0;
            this.btnQuitGame.Text = "Quit Game";
            this.btnQuitGame.UseVisualStyleBackColor = true;
            this.btnQuitGame.Click += new System.EventHandler(this.btnQuitGame_Click);
            // 
            // btnBackMenu
            // 
            this.btnBackMenu.Location = new System.Drawing.Point(54, 157);
            this.btnBackMenu.Name = "btnBackMenu";
            this.btnBackMenu.Size = new System.Drawing.Size(117, 58);
            this.btnBackMenu.TabIndex = 1;
            this.btnBackMenu.Text = "Back to menu";
            this.btnBackMenu.UseVisualStyleBackColor = true;
            this.btnBackMenu.Click += new System.EventHandler(this.btnBackMenu_Click);
            // 
            // Replay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Battlestar.Properties.Resources.sky2;
            this.ClientSize = new System.Drawing.Size(386, 299);
            this.Controls.Add(this.btnBackMenu);
            this.Controls.Add(this.btnQuitGame);
            this.Name = "Replay";
            this.Text = "Replay";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuitGame;
        private System.Windows.Forms.Button btnBackMenu;
    }
}