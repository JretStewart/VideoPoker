namespace Azara_Video_Poker
{
    partial class frmPoker
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
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.pbCard5 = new System.Windows.Forms.PictureBox();
            this.pbCard4 = new System.Windows.Forms.PictureBox();
            this.pbCard3 = new System.Windows.Forms.PictureBox();
            this.pbCard2 = new System.Windows.Forms.PictureBox();
            this.pbCard1 = new System.Windows.Forms.PictureBox();
            this.bttnHold1 = new System.Windows.Forms.Button();
            this.bttnHold5 = new System.Windows.Forms.Button();
            this.bttnHold4 = new System.Windows.Forms.Button();
            this.bttnHold3 = new System.Windows.Forms.Button();
            this.bttnHold2 = new System.Windows.Forms.Button();
            this.bttnDeal = new System.Windows.Forms.Button();
            this.lblcredplay = new System.Windows.Forms.Label();
            this.lblBet = new System.Windows.Forms.Label();
            this.bttnMax = new System.Windows.Forms.Button();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.bttnMinus = new System.Windows.Forms.Button();
            this.lblWinningHand = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBetAmt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCredits
            // 
            this.lblCredits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCredits.AutoSize = true;
            this.lblCredits.BackColor = System.Drawing.Color.Transparent;
            this.lblCredits.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredits.Location = new System.Drawing.Point(662, 175);
            this.lblCredits.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(126, 36);
            this.lblCredits.TabIndex = 0;
            this.lblCredits.Text = "Credits:";
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(760, 175);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(31, 36);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "0";
            // 
            // pbCard5
            // 
            this.pbCard5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbCard5.Image = global::Azara_Video_Poker.Properties.Resources._150px_Card_back_Power_Core;
            this.pbCard5.Location = new System.Drawing.Point(774, 214);
            this.pbCard5.Name = "pbCard5";
            this.pbCard5.Size = new System.Drawing.Size(100, 155);
            this.pbCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCard5.TabIndex = 7;
            this.pbCard5.TabStop = false;
            this.pbCard5.Click += new System.EventHandler(this.pbCard5_Click);
            // 
            // pbCard4
            // 
            this.pbCard4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbCard4.Image = global::Azara_Video_Poker.Properties.Resources._150px_Card_back_Power_Core;
            this.pbCard4.Location = new System.Drawing.Point(638, 214);
            this.pbCard4.Name = "pbCard4";
            this.pbCard4.Size = new System.Drawing.Size(100, 155);
            this.pbCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCard4.TabIndex = 6;
            this.pbCard4.TabStop = false;
            this.pbCard4.Click += new System.EventHandler(this.pbCard4_Click);
            // 
            // pbCard3
            // 
            this.pbCard3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbCard3.Image = global::Azara_Video_Poker.Properties.Resources._150px_Card_back_Power_Core;
            this.pbCard3.Location = new System.Drawing.Point(505, 214);
            this.pbCard3.Name = "pbCard3";
            this.pbCard3.Size = new System.Drawing.Size(100, 155);
            this.pbCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCard3.TabIndex = 5;
            this.pbCard3.TabStop = false;
            this.pbCard3.Click += new System.EventHandler(this.pbCard3_Click);
            // 
            // pbCard2
            // 
            this.pbCard2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbCard2.Image = global::Azara_Video_Poker.Properties.Resources._150px_Card_back_Power_Core;
            this.pbCard2.Location = new System.Drawing.Point(372, 214);
            this.pbCard2.Name = "pbCard2";
            this.pbCard2.Size = new System.Drawing.Size(100, 155);
            this.pbCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCard2.TabIndex = 4;
            this.pbCard2.TabStop = false;
            this.pbCard2.Click += new System.EventHandler(this.pbCard2_Click_1);
            // 
            // pbCard1
            // 
            this.pbCard1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbCard1.Image = global::Azara_Video_Poker.Properties.Resources._150px_Card_back_Power_Core;
            this.pbCard1.Location = new System.Drawing.Point(241, 214);
            this.pbCard1.Name = "pbCard1";
            this.pbCard1.Size = new System.Drawing.Size(100, 155);
            this.pbCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCard1.TabIndex = 3;
            this.pbCard1.TabStop = false;
            this.pbCard1.Click += new System.EventHandler(this.pbCard1_Click_1);
            // 
            // bttnHold1
            // 
            this.bttnHold1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnHold1.BackColor = System.Drawing.Color.Transparent;
            this.bttnHold1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnHold1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnHold1.Location = new System.Drawing.Point(254, 377);
            this.bttnHold1.Name = "bttnHold1";
            this.bttnHold1.Size = new System.Drawing.Size(75, 27);
            this.bttnHold1.TabIndex = 1;
            this.bttnHold1.Text = "HOLD";
            this.bttnHold1.UseVisualStyleBackColor = false;
            this.bttnHold1.Click += new System.EventHandler(this.bttnHold1_Click);
            // 
            // bttnHold5
            // 
            this.bttnHold5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnHold5.BackColor = System.Drawing.Color.Transparent;
            this.bttnHold5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnHold5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnHold5.Location = new System.Drawing.Point(787, 377);
            this.bttnHold5.Name = "bttnHold5";
            this.bttnHold5.Size = new System.Drawing.Size(75, 27);
            this.bttnHold5.TabIndex = 5;
            this.bttnHold5.Text = "HOLD";
            this.bttnHold5.UseVisualStyleBackColor = false;
            this.bttnHold5.Click += new System.EventHandler(this.bttnHold5_Click);
            // 
            // bttnHold4
            // 
            this.bttnHold4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnHold4.BackColor = System.Drawing.Color.Transparent;
            this.bttnHold4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnHold4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnHold4.Location = new System.Drawing.Point(651, 377);
            this.bttnHold4.Name = "bttnHold4";
            this.bttnHold4.Size = new System.Drawing.Size(75, 27);
            this.bttnHold4.TabIndex = 4;
            this.bttnHold4.Text = "HOLD";
            this.bttnHold4.UseVisualStyleBackColor = false;
            this.bttnHold4.Click += new System.EventHandler(this.bttnHold4_Click);
            // 
            // bttnHold3
            // 
            this.bttnHold3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnHold3.BackColor = System.Drawing.Color.Transparent;
            this.bttnHold3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnHold3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnHold3.Location = new System.Drawing.Point(519, 377);
            this.bttnHold3.Name = "bttnHold3";
            this.bttnHold3.Size = new System.Drawing.Size(75, 27);
            this.bttnHold3.TabIndex = 3;
            this.bttnHold3.Text = "HOLD";
            this.bttnHold3.UseVisualStyleBackColor = false;
            this.bttnHold3.Click += new System.EventHandler(this.bttnHold3_Click);
            // 
            // bttnHold2
            // 
            this.bttnHold2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnHold2.BackColor = System.Drawing.Color.Transparent;
            this.bttnHold2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnHold2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnHold2.Location = new System.Drawing.Point(385, 377);
            this.bttnHold2.Name = "bttnHold2";
            this.bttnHold2.Size = new System.Drawing.Size(75, 27);
            this.bttnHold2.TabIndex = 2;
            this.bttnHold2.Text = "HOLD";
            this.bttnHold2.UseVisualStyleBackColor = false;
            this.bttnHold2.Click += new System.EventHandler(this.bttnHold2_Click);
            // 
            // bttnDeal
            // 
            this.bttnDeal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnDeal.BackColor = System.Drawing.Color.SaddleBrown;
            this.bttnDeal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnDeal.Location = new System.Drawing.Point(828, 517);
            this.bttnDeal.Name = "bttnDeal";
            this.bttnDeal.Size = new System.Drawing.Size(156, 46);
            this.bttnDeal.TabIndex = 0;
            this.bttnDeal.Text = "DEAL";
            this.bttnDeal.UseVisualStyleBackColor = false;
            this.bttnDeal.Click += new System.EventHandler(this.bttnDeal_Click);
            // 
            // lblcredplay
            // 
            this.lblcredplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblcredplay.AutoSize = true;
            this.lblcredplay.BackColor = System.Drawing.Color.Transparent;
            this.lblcredplay.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcredplay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblcredplay.Location = new System.Drawing.Point(464, 437);
            this.lblcredplay.Name = "lblcredplay";
            this.lblcredplay.Size = new System.Drawing.Size(266, 36);
            this.lblcredplay.TabIndex = 15;
            this.lblcredplay.Text = "Play 1 to 5 Credits";
            // 
            // lblBet
            // 
            this.lblBet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBet.AutoSize = true;
            this.lblBet.BackColor = System.Drawing.Color.Transparent;
            this.lblBet.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.Location = new System.Drawing.Point(899, 272);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(55, 63);
            this.lblBet.TabIndex = 18;
            this.lblBet.Text = "1";
            // 
            // bttnMax
            // 
            this.bttnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnMax.BackColor = System.Drawing.Color.SaddleBrown;
            this.bttnMax.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnMax.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnMax.Location = new System.Drawing.Point(828, 583);
            this.bttnMax.Name = "bttnMax";
            this.bttnMax.Size = new System.Drawing.Size(156, 46);
            this.bttnMax.TabIndex = 9;
            this.bttnMax.Text = "MAX BET";
            this.bttnMax.UseVisualStyleBackColor = false;
            this.bttnMax.Click += new System.EventHandler(this.bttnMax_Click);
            // 
            // bttnAdd
            // 
            this.bttnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnAdd.BackColor = System.Drawing.Color.SaddleBrown;
            this.bttnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAdd.Location = new System.Drawing.Point(990, 583);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(83, 46);
            this.bttnAdd.TabIndex = 8;
            this.bttnAdd.Text = "+ 1";
            this.bttnAdd.UseVisualStyleBackColor = false;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // bttnMinus
            // 
            this.bttnMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnMinus.BackColor = System.Drawing.Color.SaddleBrown;
            this.bttnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnMinus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnMinus.Location = new System.Drawing.Point(739, 583);
            this.bttnMinus.Name = "bttnMinus";
            this.bttnMinus.Size = new System.Drawing.Size(83, 46);
            this.bttnMinus.TabIndex = 7;
            this.bttnMinus.Text = "- 1";
            this.bttnMinus.UseVisualStyleBackColor = false;
            this.bttnMinus.Click += new System.EventHandler(this.bttnMinus_Click);
            // 
            // lblWinningHand
            // 
            this.lblWinningHand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWinningHand.AutoSize = true;
            this.lblWinningHand.BackColor = System.Drawing.Color.Transparent;
            this.lblWinningHand.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinningHand.Location = new System.Drawing.Point(318, 176);
            this.lblWinningHand.Name = "lblWinningHand";
            this.lblWinningHand.Size = new System.Drawing.Size(211, 36);
            this.lblWinningHand.TabIndex = 23;
            this.lblWinningHand.Text = "WinningHand";
            this.lblWinningHand.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1106, 33);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.saveGameToolStripMenuItem,
            this.loadGameToolStripMenuItem,
            this.exitGameToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(186, 30);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(186, 30);
            this.saveGameToolStripMenuItem.Text = "Save Game";
            this.saveGameToolStripMenuItem.Click += new System.EventHandler(this.saveGameToolStripMenuItem_Click);
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(186, 30);
            this.loadGameToolStripMenuItem.Text = "Load Game";
            this.loadGameToolStripMenuItem.Click += new System.EventHandler(this.loadGameToolStripMenuItem_Click);
            // 
            // exitGameToolStripMenuItem
            // 
            this.exitGameToolStripMenuItem.Name = "exitGameToolStripMenuItem";
            this.exitGameToolStripMenuItem.Size = new System.Drawing.Size(186, 30);
            this.exitGameToolStripMenuItem.Text = "Exit Game";
            this.exitGameToolStripMenuItem.Click += new System.EventHandler(this.exitGameToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullScreenToolStripMenuItem1,
            this.normalToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // fullScreenToolStripMenuItem1
            // 
            this.fullScreenToolStripMenuItem1.Name = "fullScreenToolStripMenuItem1";
            this.fullScreenToolStripMenuItem1.Size = new System.Drawing.Size(180, 30);
            this.fullScreenToolStripMenuItem1.Text = "Full Screen";
            this.fullScreenToolStripMenuItem1.Click += new System.EventHandler(this.fullScreenToolStripMenuItem1_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(128, 29);
            this.optionsToolStripMenuItem.Text = "Payout Menu";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Info;
            this.lblName.Location = new System.Drawing.Point(507, 566);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(109, 24);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Player";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblBetAmt
            // 
            this.lblBetAmt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBetAmt.AutoSize = true;
            this.lblBetAmt.BackColor = System.Drawing.Color.Transparent;
            this.lblBetAmt.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetAmt.Location = new System.Drawing.Point(895, 241);
            this.lblBetAmt.Name = "lblBetAmt";
            this.lblBetAmt.Size = new System.Drawing.Size(62, 36);
            this.lblBetAmt.TabIndex = 26;
            this.lblBetAmt.Text = "Bet";
            // 
            // frmPoker
            // 
            this.AcceptButton = this.bttnDeal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::Azara_Video_Poker.Properties.Resources.POKER_TABLE;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1106, 654);
            this.Controls.Add(this.lblBetAmt);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblWinningHand);
            this.Controls.Add(this.bttnMinus);
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.bttnMax);
            this.Controls.Add(this.lblBet);
            this.Controls.Add(this.lblcredplay);
            this.Controls.Add(this.bttnDeal);
            this.Controls.Add(this.bttnHold2);
            this.Controls.Add(this.bttnHold3);
            this.Controls.Add(this.bttnHold4);
            this.Controls.Add(this.bttnHold5);
            this.Controls.Add(this.bttnHold1);
            this.Controls.Add(this.pbCard5);
            this.Controls.Add(this.pbCard4);
            this.Controls.Add(this.pbCard3);
            this.Controls.Add(this.pbCard2);
            this.Controls.Add(this.pbCard1);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1014, 632);
            this.Name = "frmPoker";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Poker";
            this.Load += new System.EventHandler(this.frmPoker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.PictureBox pbCard1;
        private System.Windows.Forms.PictureBox pbCard2;
        private System.Windows.Forms.PictureBox pbCard3;
        private System.Windows.Forms.PictureBox pbCard4;
        private System.Windows.Forms.PictureBox pbCard5;
        private System.Windows.Forms.Button bttnHold1;
        private System.Windows.Forms.Button bttnHold5;
        private System.Windows.Forms.Button bttnHold4;
        private System.Windows.Forms.Button bttnHold3;
        private System.Windows.Forms.Button bttnHold2;
        private System.Windows.Forms.Button bttnDeal;
        private System.Windows.Forms.Label lblcredplay;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.Button bttnMax;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Button bttnMinus;
        private System.Windows.Forms.Label lblWinningHand;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ToolStripMenuItem exitGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.Label lblBetAmt;
    }
}

