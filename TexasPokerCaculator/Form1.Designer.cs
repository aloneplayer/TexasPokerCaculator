namespace TexasPokerCaculator
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
            this.components = new System.ComponentModel.Container();
            this.panel_Control = new System.Windows.Forms.Panel();
            this.textBox_PotOdds = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this._PotChips = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_Dealer = new System.Windows.Forms.GroupBox();
            this.pictureBox_BestPattern = new System.Windows.Forms.PictureBox();
            this.label_PatternName = new System.Windows.Forms.Label();
            this.label_CurrentBest = new System.Windows.Forms.Label();
            this.button_Calculate = new System.Windows.Forms.Button();
            this.pictureBox_PokerStack = new System.Windows.Forms.PictureBox();
            this.panel_Table = new System.Windows.Forms.Panel();
            this.pictureBox_Table = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PotChips)).BeginInit();
            this.groupBox_Dealer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BestPattern)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PokerStack)).BeginInit();
            this.panel_Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Control
            // 
            this.panel_Control.Controls.Add(this.textBox_PotOdds);
            this.panel_Control.Controls.Add(this.label3);
            this.panel_Control.Controls.Add(this.numericUpDown1);
            this.panel_Control.Controls.Add(this.label2);
            this.panel_Control.Controls.Add(this._PotChips);
            this.panel_Control.Controls.Add(this.label1);
            this.panel_Control.Controls.Add(this.groupBox1);
            this.panel_Control.Controls.Add(this.groupBox_Dealer);
            this.panel_Control.Controls.Add(this.button_Calculate);
            this.panel_Control.Controls.Add(this.pictureBox_PokerStack);
            this.panel_Control.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Control.Location = new System.Drawing.Point(0, 0);
            this.panel_Control.Name = "panel_Control";
            this.panel_Control.Size = new System.Drawing.Size(255, 556);
            this.panel_Control.TabIndex = 2;
            // 
            // textBox_PotOdds
            // 
            this.textBox_PotOdds.Location = new System.Drawing.Point(100, 247);
            this.textBox_PotOdds.Name = "textBox_PotOdds";
            this.textBox_PotOdds.ReadOnly = true;
            this.textBox_PotOdds.Size = new System.Drawing.Size(100, 20);
            this.textBox_PotOdds.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pot Odds";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(100, 182);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Chips Follow";
            // 
            // _PotChips
            // 
            this._PotChips.Location = new System.Drawing.Point(100, 156);
            this._PotChips.Name = "_PotChips";
            this._PotChips.Size = new System.Drawing.Size(120, 20);
            this._PotChips.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chips In Pot";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(13, 434);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 110);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Others";
            // 
            // groupBox_Dealer
            // 
            this.groupBox_Dealer.Controls.Add(this.pictureBox_BestPattern);
            this.groupBox_Dealer.Controls.Add(this.label_PatternName);
            this.groupBox_Dealer.Controls.Add(this.label_CurrentBest);
            this.groupBox_Dealer.Location = new System.Drawing.Point(15, 273);
            this.groupBox_Dealer.Name = "groupBox_Dealer";
            this.groupBox_Dealer.Size = new System.Drawing.Size(226, 155);
            this.groupBox_Dealer.TabIndex = 6;
            this.groupBox_Dealer.TabStop = false;
            this.groupBox_Dealer.Text = "Dealer";
            // 
            // pictureBox_BestPattern
            // 
            this.pictureBox_BestPattern.Location = new System.Drawing.Point(10, 37);
            this.pictureBox_BestPattern.Name = "pictureBox_BestPattern";
            this.pictureBox_BestPattern.Size = new System.Drawing.Size(186, 36);
            this.pictureBox_BestPattern.TabIndex = 2;
            this.pictureBox_BestPattern.TabStop = false;
            // 
            // label_PatternName
            // 
            this.label_PatternName.AutoSize = true;
            this.label_PatternName.Location = new System.Drawing.Point(39, 20);
            this.label_PatternName.Name = "label_PatternName";
            this.label_PatternName.Size = new System.Drawing.Size(0, 13);
            this.label_PatternName.TabIndex = 1;
            // 
            // label_CurrentBest
            // 
            this.label_CurrentBest.AutoSize = true;
            this.label_CurrentBest.Location = new System.Drawing.Point(7, 20);
            this.label_CurrentBest.Name = "label_CurrentBest";
            this.label_CurrentBest.Size = new System.Drawing.Size(75, 13);
            this.label_CurrentBest.TabIndex = 0;
            this.label_CurrentBest.Text = "Currently Best:";
            // 
            // button_Calculate
            // 
            this.button_Calculate.Location = new System.Drawing.Point(12, 215);
            this.button_Calculate.Name = "button_Calculate";
            this.button_Calculate.Size = new System.Drawing.Size(75, 23);
            this.button_Calculate.TabIndex = 5;
            this.button_Calculate.Text = "Calculate";
            this.button_Calculate.UseVisualStyleBackColor = true;
            this.button_Calculate.Click += new System.EventHandler(this.button_Calculate_Click);
            // 
            // pictureBox_PokerStack
            // 
            this.pictureBox_PokerStack.BackgroundImage = global::TexasPokerCaculator.Properties.Resources.SmallPokers;
            this.pictureBox_PokerStack.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_PokerStack.Name = "pictureBox_PokerStack";
            this.pictureBox_PokerStack.Size = new System.Drawing.Size(252, 150);
            this.pictureBox_PokerStack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_PokerStack.TabIndex = 4;
            this.pictureBox_PokerStack.TabStop = false;
            this.pictureBox_PokerStack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_PokerStack_MouseClick);
            this.pictureBox_PokerStack.MouseLeave += new System.EventHandler(this.pictureBox_PokerStack_MouseLeave);
            this.pictureBox_PokerStack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_PokerStack_MouseMove);
            // 
            // panel_Table
            // 
            this.panel_Table.Controls.Add(this.pictureBox_Table);
            this.panel_Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Table.Location = new System.Drawing.Point(255, 0);
            this.panel_Table.Name = "panel_Table";
            this.panel_Table.Size = new System.Drawing.Size(677, 556);
            this.panel_Table.TabIndex = 3;
            // 
            // pictureBox_Table
            // 
            this.pictureBox_Table.BackgroundImage = global::TexasPokerCaculator.Properties.Resources.PokerTable;
            this.pictureBox_Table.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Table.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Table.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox_Table.Name = "pictureBox_Table";
            this.pictureBox_Table.Size = new System.Drawing.Size(677, 556);
            this.pictureBox_Table.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Table.TabIndex = 2;
            this.pictureBox_Table.TabStop = false;
            this.pictureBox_Table.SizeChanged += new System.EventHandler(this.pictureBox_Table_SizeChanged);
            this.pictureBox_Table.Click += new System.EventHandler(this.pictureBox_Table_Click);
            this.pictureBox_Table.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Table_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 556);
            this.Controls.Add(this.panel_Table);
            this.Controls.Add(this.panel_Control);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "TexasPoker Caculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Control.ResumeLayout(false);
            this.panel_Control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PotChips)).EndInit();
            this.groupBox_Dealer.ResumeLayout(false);
            this.groupBox_Dealer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BestPattern)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PokerStack)).EndInit();
            this.panel_Table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Control;
        private System.Windows.Forms.PictureBox pictureBox_PokerStack;
        private System.Windows.Forms.Panel panel_Table;
        private System.Windows.Forms.PictureBox pictureBox_Table;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button_Calculate;
        private System.Windows.Forms.GroupBox groupBox_Dealer;
        private System.Windows.Forms.Label label_CurrentBest;
        private System.Windows.Forms.Label label_PatternName;
        private System.Windows.Forms.PictureBox pictureBox_BestPattern;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown _PotChips;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_PotOdds;


    }
}

