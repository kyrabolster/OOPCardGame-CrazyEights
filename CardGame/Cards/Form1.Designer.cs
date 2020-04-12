namespace Cards
{
    partial class Form1
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
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PanelPick = new System.Windows.Forms.Panel();
            this.PanelDiscard = new System.Windows.Forms.Panel();
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.grpCrazyEight = new System.Windows.Forms.GroupBox();
            this.rdoSpades = new System.Windows.Forms.RadioButton();
            this.rdoClubs = new System.Windows.Forms.RadioButton();
            this.rdoDiamonds = new System.Windows.Forms.RadioButton();
            this.rdoHearts = new System.Windows.Forms.RadioButton();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblSuit = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpCrazyEight.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel2
            // 
            this.Panel2.AutoScroll = true;
            this.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Panel2.Location = new System.Drawing.Point(70, 388);
            this.Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1303, 150);
            this.Panel2.TabIndex = 10;
            this.Panel2.Click += new System.EventHandler(this.Hand_Click);
            // 
            // Panel1
            // 
            this.Panel1.AutoScroll = true;
            this.Panel1.Location = new System.Drawing.Point(70, 25);
            this.Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1292, 150);
            this.Panel1.TabIndex = 8;
            this.Panel1.Click += new System.EventHandler(this.Hand_Click);
            // 
            // PanelPick
            // 
            this.PanelPick.Location = new System.Drawing.Point(472, 229);
            this.PanelPick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelPick.Name = "PanelPick";
            this.PanelPick.Size = new System.Drawing.Size(205, 126);
            this.PanelPick.TabIndex = 11;
            // 
            // PanelDiscard
            // 
            this.PanelDiscard.Location = new System.Drawing.Point(736, 229);
            this.PanelDiscard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelDiscard.Name = "PanelDiscard";
            this.PanelDiscard.Size = new System.Drawing.Size(205, 126);
            this.PanelDiscard.TabIndex = 12;
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEndTurn.Location = new System.Drawing.Point(974, 246);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(106, 41);
            this.btnEndTurn.TabIndex = 13;
            this.btnEndTurn.Text = "End Turn";
            this.btnEndTurn.UseVisualStyleBackColor = false;
            this.btnEndTurn.Click += new System.EventHandler(this.btnEndTurn_Click);
            // 
            // grpCrazyEight
            // 
            this.grpCrazyEight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpCrazyEight.Controls.Add(this.rdoSpades);
            this.grpCrazyEight.Controls.Add(this.rdoClubs);
            this.grpCrazyEight.Controls.Add(this.rdoDiamonds);
            this.grpCrazyEight.Controls.Add(this.rdoHearts);
            this.grpCrazyEight.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.grpCrazyEight.ForeColor = System.Drawing.Color.Black;
            this.grpCrazyEight.Location = new System.Drawing.Point(70, 213);
            this.grpCrazyEight.Name = "grpCrazyEight";
            this.grpCrazyEight.Size = new System.Drawing.Size(320, 142);
            this.grpCrazyEight.TabIndex = 14;
            this.grpCrazyEight.TabStop = false;
            this.grpCrazyEight.Text = "Crazy Eight - Pick your suit!";
            // 
            // rdoSpades
            // 
            this.rdoSpades.AutoSize = true;
            this.rdoSpades.ForeColor = System.Drawing.Color.Black;
            this.rdoSpades.Location = new System.Drawing.Point(191, 84);
            this.rdoSpades.Name = "rdoSpades";
            this.rdoSpades.Size = new System.Drawing.Size(81, 20);
            this.rdoSpades.TabIndex = 3;
            this.rdoSpades.TabStop = true;
            this.rdoSpades.Text = "Spades";
            this.rdoSpades.UseVisualStyleBackColor = true;
            this.rdoSpades.Click += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdoClubs
            // 
            this.rdoClubs.AutoSize = true;
            this.rdoClubs.ForeColor = System.Drawing.Color.Black;
            this.rdoClubs.Location = new System.Drawing.Point(191, 43);
            this.rdoClubs.Name = "rdoClubs";
            this.rdoClubs.Size = new System.Drawing.Size(69, 20);
            this.rdoClubs.TabIndex = 2;
            this.rdoClubs.TabStop = true;
            this.rdoClubs.Text = "Clubs";
            this.rdoClubs.UseVisualStyleBackColor = true;
            this.rdoClubs.Click += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdoDiamonds
            // 
            this.rdoDiamonds.AutoSize = true;
            this.rdoDiamonds.ForeColor = System.Drawing.Color.Black;
            this.rdoDiamonds.Location = new System.Drawing.Point(38, 84);
            this.rdoDiamonds.Name = "rdoDiamonds";
            this.rdoDiamonds.Size = new System.Drawing.Size(98, 20);
            this.rdoDiamonds.TabIndex = 1;
            this.rdoDiamonds.TabStop = true;
            this.rdoDiamonds.Text = "Diamonds";
            this.rdoDiamonds.UseVisualStyleBackColor = true;
            this.rdoDiamonds.Click += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdoHearts
            // 
            this.rdoHearts.AutoSize = true;
            this.rdoHearts.ForeColor = System.Drawing.Color.Black;
            this.rdoHearts.Location = new System.Drawing.Point(38, 43);
            this.rdoHearts.Name = "rdoHearts";
            this.rdoHearts.Size = new System.Drawing.Size(75, 20);
            this.rdoHearts.TabIndex = 0;
            this.rdoHearts.TabStop = true;
            this.rdoHearts.Text = "Hearts";
            this.rdoHearts.UseVisualStyleBackColor = true;
            this.rdoHearts.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTurn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTurn.Location = new System.Drawing.Point(970, 210);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(65, 24);
            this.lblTurn.TabIndex = 15;
            this.lblTurn.Text = "label1";
            // 
            // lblSuit
            // 
            this.lblSuit.AutoSize = true;
            this.lblSuit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblSuit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSuit.Location = new System.Drawing.Point(677, 193);
            this.lblSuit.Name = "lblSuit";
            this.lblSuit.Size = new System.Drawing.Size(54, 19);
            this.lblSuit.TabIndex = 16;
            this.lblSuit.Text = "label1";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold);
            this.lblWinner.ForeColor = System.Drawing.Color.White;
            this.lblWinner.Location = new System.Drawing.Point(567, 550);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(0, 51);
            this.lblWinner.TabIndex = 17;
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewGame.Location = new System.Drawing.Point(974, 314);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(106, 41);
            this.btnNewGame.TabIndex = 19;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "P1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "P2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(1212, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "8 : wild cards";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(1212, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "2 : pick up two";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(1212, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "J : skip your turn";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(1200, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "** Special cards **";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1402, 603);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblSuit);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.grpCrazyEight);
            this.Controls.Add(this.btnEndTurn);
            this.Controls.Add(this.PanelDiscard);
            this.Controls.Add(this.PanelPick);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Crazy Eights";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpCrazyEight.ResumeLayout(false);
            this.grpCrazyEight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Panel PanelPick;
        internal System.Windows.Forms.Panel PanelDiscard;
        private System.Windows.Forms.Button btnEndTurn;
        private System.Windows.Forms.GroupBox grpCrazyEight;
        private System.Windows.Forms.RadioButton rdoHearts;
        private System.Windows.Forms.RadioButton rdoSpades;
        private System.Windows.Forms.RadioButton rdoClubs;
        private System.Windows.Forms.RadioButton rdoDiamonds;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblSuit;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
    }
}