namespace Batobato_Pick
{
    partial class Fightstage
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
            this.lblplayer1name = new System.Windows.Forms.Label();
            this.lblplayer2name = new System.Windows.Forms.Label();
            this.lblplayer1HP = new System.Windows.Forms.Label();
            this.lblplayer2HP = new System.Windows.Forms.Label();
            this.lblVS = new System.Windows.Forms.Label();
            this.picplayer1 = new System.Windows.Forms.PictureBox();
            this.picplayer2 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picplayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picplayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblplayer1name
            // 
            this.lblplayer1name.AutoSize = true;
            this.lblplayer1name.BackColor = System.Drawing.Color.Transparent;
            this.lblplayer1name.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayer1name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblplayer1name.Location = new System.Drawing.Point(91, 106);
            this.lblplayer1name.Name = "lblplayer1name";
            this.lblplayer1name.Size = new System.Drawing.Size(242, 36);
            this.lblplayer1name.TabIndex = 0;
            this.lblplayer1name.Text = "Player 1 name";
            // 
            // lblplayer2name
            // 
            this.lblplayer2name.AutoSize = true;
            this.lblplayer2name.BackColor = System.Drawing.Color.Transparent;
            this.lblplayer2name.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayer2name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblplayer2name.Location = new System.Drawing.Point(559, 106);
            this.lblplayer2name.Name = "lblplayer2name";
            this.lblplayer2name.Size = new System.Drawing.Size(242, 36);
            this.lblplayer2name.TabIndex = 1;
            this.lblplayer2name.Text = "Player 2 name";
            // 
            // lblplayer1HP
            // 
            this.lblplayer1HP.AutoSize = true;
            this.lblplayer1HP.BackColor = System.Drawing.Color.Chartreuse;
            this.lblplayer1HP.Font = new System.Drawing.Font("AngryBirds", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayer1HP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblplayer1HP.Location = new System.Drawing.Point(163, 66);
            this.lblplayer1HP.Name = "lblplayer1HP";
            this.lblplayer1HP.Size = new System.Drawing.Size(94, 31);
            this.lblplayer1HP.TabIndex = 2;
            this.lblplayer1HP.Text = "100 HP";
            // 
            // lblplayer2HP
            // 
            this.lblplayer2HP.AutoSize = true;
            this.lblplayer2HP.BackColor = System.Drawing.Color.Chartreuse;
            this.lblplayer2HP.Font = new System.Drawing.Font("AngryBirds", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayer2HP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblplayer2HP.Location = new System.Drawing.Point(634, 75);
            this.lblplayer2HP.Name = "lblplayer2HP";
            this.lblplayer2HP.Size = new System.Drawing.Size(94, 31);
            this.lblplayer2HP.TabIndex = 3;
            this.lblplayer2HP.Text = "100 HP";
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.BackColor = System.Drawing.Color.Transparent;
            this.lblVS.Font = new System.Drawing.Font("Bing Bam Boum", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVS.Location = new System.Drawing.Point(363, 42);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(176, 148);
            this.lblVS.TabIndex = 4;
            this.lblVS.Text = "VS";
            // 
            // picplayer1
            // 
            this.picplayer1.BackColor = System.Drawing.Color.Transparent;
            this.picplayer1.Image = global::Batobato_Pick.Properties.Resources.STONE;
            this.picplayer1.Location = new System.Drawing.Point(97, 160);
            this.picplayer1.Name = "picplayer1";
            this.picplayer1.Size = new System.Drawing.Size(225, 314);
            this.picplayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picplayer1.TabIndex = 5;
            this.picplayer1.TabStop = false;
            // 
            // picplayer2
            // 
            this.picplayer2.BackColor = System.Drawing.Color.Transparent;
            this.picplayer2.Image = global::Batobato_Pick.Properties.Resources.SCISSORS;
            this.picplayer2.Location = new System.Drawing.Point(565, 160);
            this.picplayer2.Name = "picplayer2";
            this.picplayer2.Size = new System.Drawing.Size(225, 314);
            this.picplayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picplayer2.TabIndex = 6;
            this.picplayer2.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStart.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStart.Location = new System.Drawing.Point(361, 478);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(178, 61);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Fightstage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Batobato_Pick.Properties.Resources.BG_2TONE;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picplayer2);
            this.Controls.Add(this.picplayer1);
            this.Controls.Add(this.lblVS);
            this.Controls.Add(this.lblplayer2HP);
            this.Controls.Add(this.lblplayer1HP);
            this.Controls.Add(this.lblplayer2name);
            this.Controls.Add(this.lblplayer1name);
            this.DoubleBuffered = true;
            this.Name = "Fightstage";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.picplayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picplayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblplayer1name;
        private System.Windows.Forms.Label lblplayer2name;
        private System.Windows.Forms.Label lblplayer1HP;
        private System.Windows.Forms.Label lblplayer2HP;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.PictureBox picplayer1;
        private System.Windows.Forms.PictureBox picplayer2;
        private System.Windows.Forms.Button btnStart;
    }
}