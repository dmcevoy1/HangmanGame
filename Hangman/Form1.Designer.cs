namespace Hangman
{
    partial class frmHangman
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeWithoutSavingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAndSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblWordGap = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shpHead = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shpBody = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shpRightLeg = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shpLeftArm = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shpRightArm = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shpLeftLeg = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lblWrongGuesses = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(290, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.closeWithoutSavingToolStripMenuItem,
            this.closeAndSaveToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // closeWithoutSavingToolStripMenuItem
            // 
            this.closeWithoutSavingToolStripMenuItem.Name = "closeWithoutSavingToolStripMenuItem";
            this.closeWithoutSavingToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.closeWithoutSavingToolStripMenuItem.Text = "Close Without Saving";
            this.closeWithoutSavingToolStripMenuItem.Click += new System.EventHandler(this.closeWithoutSavingToolStripMenuItem_Click);
            // 
            // closeAndSaveToolStripMenuItem
            // 
            this.closeAndSaveToolStripMenuItem.Name = "closeAndSaveToolStripMenuItem";
            this.closeAndSaveToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.closeAndSaveToolStripMenuItem.Text = "Close and Save";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(13, 180);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(265, 20);
            this.txtGuess.TabIndex = 1;
            this.txtGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(152, 206);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(126, 34);
            this.btnGuess.TabIndex = 2;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(13, 206);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 34);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblWordGap
            // 
            this.lblWordGap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWordGap.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblWordGap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWordGap.Location = new System.Drawing.Point(13, 148);
            this.lblWordGap.Name = "lblWordGap";
            this.lblWordGap.Size = new System.Drawing.Size(265, 25);
            this.lblWordGap.TabIndex = 4;
            this.lblWordGap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Location = new System.Drawing.Point(13, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 108);
            this.panel1.TabIndex = 5;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.shpLeftLeg,
            this.shpRightArm,
            this.shpLeftArm,
            this.shpRightLeg,
            this.shpBody,
            this.lineShape3,
            this.shpHead,
            this.lineShape2,
            this.lineShape1,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(201, 108);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.Black;
            this.rectangleShape1.Location = new System.Drawing.Point(20, 83);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(65, 18);
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 54;
            this.lineShape1.X2 = 54;
            this.lineShape1.Y1 = 10;
            this.lineShape1.Y2 = 82;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 54;
            this.lineShape2.X2 = 137;
            this.lineShape2.Y1 = 10;
            this.lineShape2.Y2 = 10;
            // 
            // shpHead
            // 
            this.shpHead.Location = new System.Drawing.Point(125, 18);
            this.shpHead.Name = "shpHead";
            this.shpHead.Size = new System.Drawing.Size(24, 23);
            this.shpHead.Visible = false;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 137;
            this.lineShape3.X2 = 137;
            this.lineShape3.Y1 = 10;
            this.lineShape3.Y2 = 18;
            // 
            // shpBody
            // 
            this.shpBody.Name = "shpBody";
            this.shpBody.Visible = false;
            this.shpBody.X1 = 138;
            this.shpBody.X2 = 138;
            this.shpBody.Y1 = 43;
            this.shpBody.Y2 = 88;
            // 
            // shpRightLeg
            // 
            this.shpRightLeg.Name = "shpRightLeg";
            this.shpRightLeg.Visible = false;
            this.shpRightLeg.X1 = 138;
            this.shpRightLeg.X2 = 177;
            this.shpRightLeg.Y1 = 88;
            this.shpRightLeg.Y2 = 99;
            // 
            // shpLeftArm
            // 
            this.shpLeftArm.Name = "shpLeftArm";
            this.shpLeftArm.Visible = false;
            this.shpLeftArm.X1 = 98;
            this.shpLeftArm.X2 = 137;
            this.shpLeftArm.Y1 = 50;
            this.shpLeftArm.Y2 = 61;
            // 
            // shpRightArm
            // 
            this.shpRightArm.Name = "shpRightArm";
            this.shpRightArm.Visible = false;
            this.shpRightArm.X1 = 137;
            this.shpRightArm.X2 = 173;
            this.shpRightArm.Y1 = 62;
            this.shpRightArm.Y2 = 53;
            // 
            // shpLeftLeg
            // 
            this.shpLeftLeg.Name = "shpLeftLeg";
            this.shpLeftLeg.Visible = false;
            this.shpLeftLeg.X1 = 101;
            this.shpLeftLeg.X2 = 137;
            this.shpLeftLeg.Y1 = 98;
            this.shpLeftLeg.Y2 = 89;
            // 
            // lblWrongGuesses
            // 
            this.lblWrongGuesses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblWrongGuesses.Location = new System.Drawing.Point(221, 28);
            this.lblWrongGuesses.Name = "lblWrongGuesses";
            this.lblWrongGuesses.Size = new System.Drawing.Size(57, 108);
            this.lblWrongGuesses.TabIndex = 6;
            // 
            // frmHangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 252);
            this.Controls.Add(this.lblWrongGuesses);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblWordGap);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHangman";
            this.Text = "Hangman Game!";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeWithoutSavingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAndSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblWordGap;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape shpLeftLeg;
        private Microsoft.VisualBasic.PowerPacks.LineShape shpRightArm;
        private Microsoft.VisualBasic.PowerPacks.LineShape shpLeftArm;
        private Microsoft.VisualBasic.PowerPacks.LineShape shpRightLeg;
        private Microsoft.VisualBasic.PowerPacks.LineShape shpBody;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.OvalShape shpHead;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label lblWrongGuesses;
    }
}

