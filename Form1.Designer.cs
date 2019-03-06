namespace 突破ゲーム
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sukima = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GameOver = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Scorerbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sukima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Orange;
            this.pictureBox1.Location = new System.Drawing.Point(-22, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(591, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // sukima
            // 
            this.sukima.BackColor = System.Drawing.SystemColors.Control;
            this.sukima.Location = new System.Drawing.Point(109, 72);
            this.sukima.Name = "sukima";
            this.sukima.Size = new System.Drawing.Size(260, 50);
            this.sukima.TabIndex = 1;
            this.sukima.TabStop = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.LimeGreen;
            this.Player.Location = new System.Drawing.Point(365, 261);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(20, 30);
            this.Player.TabIndex = 2;
            this.Player.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GameOver
            // 
            this.GameOver.AutoSize = true;
            this.GameOver.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GameOver.ForeColor = System.Drawing.Color.Red;
            this.GameOver.Location = new System.Drawing.Point(151, 158);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(244, 40);
            this.GameOver.TabIndex = 3;
            this.GameOver.Text = "GAME OVER";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(596, 12);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(177, 45);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "開　始";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "SCORE : ";
            // 
            // Scorerbl
            // 
            this.Scorerbl.AutoSize = true;
            this.Scorerbl.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Scorerbl.Location = new System.Drawing.Point(105, 28);
            this.Scorerbl.Name = "Scorerbl";
            this.Scorerbl.Size = new System.Drawing.Size(39, 20);
            this.Scorerbl.TabIndex = 6;
            this.Scorerbl.Text = "999";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 460);
            this.Controls.Add(this.Scorerbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.GameOver);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.sukima);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "突破ゲーム";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sukima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox sukima;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label GameOver;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Scorerbl;
    }
}

