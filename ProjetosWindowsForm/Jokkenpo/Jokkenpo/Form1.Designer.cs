namespace Jokkenpo
{
    partial class Jokkepon
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lalTitle = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblPC = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnStone = new System.Windows.Forms.Button();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.picturePlayer2 = new System.Windows.Forms.PictureBox();
            this.picturePlayer1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPC1 = new System.Windows.Forms.Label();
            this.lblResult1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // lalTitle
            // 
            this.lalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalTitle.Location = new System.Drawing.Point(13, 9);
            this.lalTitle.Name = "lalTitle";
            this.lalTitle.Size = new System.Drawing.Size(777, 56);
            this.lalTitle.TabIndex = 0;
            this.lalTitle.Text = "Escolha: Pedra, Papel ou Tesoura...";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPlayer.Location = new System.Drawing.Point(94, 138);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(65, 25);
            this.lblPlayer.TabIndex = 4;
            this.lblPlayer.Text = "Você";
            // 
            // lblPC
            // 
            this.lblPC.AutoSize = true;
            this.lblPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPC.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPC.Location = new System.Drawing.Point(337, 138);
            this.lblPC.Name = "lblPC";
            this.lblPC.Size = new System.Drawing.Size(139, 25);
            this.lblPC.TabIndex = 5;
            this.lblPC.Text = "Computador";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblResult.Location = new System.Drawing.Point(660, 138);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(25, 25);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(246, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "VS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(528, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "=";
            // 
            // btnScissors
            // 
            this.btnScissors.BackgroundImage = global::Jokkenpo.Properties.Resources.Tesoura;
            this.btnScissors.Location = new System.Drawing.Point(573, 280);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(200, 157);
            this.btnScissors.TabIndex = 11;
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackgroundImage = global::Jokkenpo.Properties.Resources.Papel;
            this.btnPaper.Location = new System.Drawing.Point(306, 280);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(200, 157);
            this.btnPaper.TabIndex = 10;
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnStone
            // 
            this.btnStone.BackgroundImage = global::Jokkenpo.Properties.Resources.Pedra;
            this.btnStone.Location = new System.Drawing.Point(29, 280);
            this.btnStone.Name = "btnStone";
            this.btnStone.Size = new System.Drawing.Size(200, 157);
            this.btnStone.TabIndex = 9;
            this.btnStone.UseVisualStyleBackColor = true;
            this.btnStone.Click += new System.EventHandler(this.btnStone_Click);
            // 
            // picResult
            // 
            this.picResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picResult.Location = new System.Drawing.Point(573, 82);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(200, 157);
            this.picResult.TabIndex = 3;
            this.picResult.TabStop = false;
            // 
            // picturePlayer2
            // 
            this.picturePlayer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturePlayer2.Location = new System.Drawing.Point(306, 82);
            this.picturePlayer2.Name = "picturePlayer2";
            this.picturePlayer2.Size = new System.Drawing.Size(200, 157);
            this.picturePlayer2.TabIndex = 2;
            this.picturePlayer2.TabStop = false;
            this.picturePlayer2.Click += new System.EventHandler(this.picturePlayer2_Click);
            // 
            // picturePlayer1
            // 
            this.picturePlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturePlayer1.Location = new System.Drawing.Point(29, 82);
            this.picturePlayer1.Name = "picturePlayer1";
            this.picturePlayer1.Size = new System.Drawing.Size(200, 157);
            this.picturePlayer1.TabIndex = 1;
            this.picturePlayer1.TabStop = false;
            this.picturePlayer1.Click += new System.EventHandler(this.picturePlayer1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(94, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pedra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(376, 457);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Papel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(630, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tesoura";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPlayer1.Location = new System.Drawing.Point(94, 54);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(65, 25);
            this.lblPlayer1.TabIndex = 15;
            this.lblPlayer1.Text = "Você";
            this.lblPlayer1.Visible = false;
            // 
            // lblPC1
            // 
            this.lblPC1.AutoSize = true;
            this.lblPC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPC1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPC1.Location = new System.Drawing.Point(337, 54);
            this.lblPC1.Name = "lblPC1";
            this.lblPC1.Size = new System.Drawing.Size(139, 25);
            this.lblPC1.TabIndex = 16;
            this.lblPC1.Text = "Computador";
            this.lblPC1.Visible = false;
            // 
            // lblResult1
            // 
            this.lblResult1.AutoSize = true;
            this.lblResult1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblResult1.Location = new System.Drawing.Point(620, 54);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Size = new System.Drawing.Size(118, 25);
            this.lblResult1.TabIndex = 17;
            this.lblResult1.Text = "Resultado";
            this.lblResult1.Visible = false;
            // 
            // Jokkepon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 548);
            this.Controls.Add(this.lblResult1);
            this.Controls.Add(this.lblPC1);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnStone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblPC);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.picResult);
            this.Controls.Add(this.picturePlayer2);
            this.Controls.Add(this.picturePlayer1);
            this.Controls.Add(this.lalTitle);
            this.Name = "Jokkepon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jokkepon";
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lalTitle;
        private System.Windows.Forms.PictureBox picturePlayer1;
        private System.Windows.Forms.PictureBox picturePlayer2;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblPC;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStone;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPC1;
        private System.Windows.Forms.Label lblResult1;
    }
}

