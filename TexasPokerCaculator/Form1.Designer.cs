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
            this.pictureBox_PokerStack = new System.Windows.Forms.PictureBox();
            this.panel_Table = new System.Windows.Forms.Panel();
            this.pictureBox_Table = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_Calculate = new System.Windows.Forms.Button();
            this.groupBox_Dealer = new System.Windows.Forms.GroupBox();
            this.label_Best = new System.Windows.Forms.Label();
            this.label_PatternName = new System.Windows.Forms.Label();
            this.pictureBox_BestPattern = new System.Windows.Forms.PictureBox();
            this.panel_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PokerStack)).BeginInit();
            this.panel_Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Table)).BeginInit();
            this.groupBox_Dealer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BestPattern)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Control
            // 
            this.panel_Control.Controls.Add(this.groupBox_Dealer);
            this.panel_Control.Controls.Add(this.button_Calculate);
            this.panel_Control.Controls.Add(this.pictureBox_PokerStack);
            this.panel_Control.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Control.Location = new System.Drawing.Point(0, 0);
            this.panel_Control.Name = "panel_Control";
            this.panel_Control.Size = new System.Drawing.Size(255, 556);
            this.panel_Control.TabIndex = 2;
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
            this.pictureBox_Table.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Table_Paint);
            // 
            // button_Calculate
            // 
            this.button_Calculate.Location = new System.Drawing.Point(12, 165);
            this.button_Calculate.Name = "button_Calculate";
            this.button_Calculate.Size = new System.Drawing.Size(75, 23);
            this.button_Calculate.TabIndex = 5;
            this.button_Calculate.Text = "Calculate";
            this.button_Calculate.UseVisualStyleBackColor = true;
            // 
            // groupBox_Dealer
            // 
            this.groupBox_Dealer.Controls.Add(this.pictureBox_BestPattern);
            this.groupBox_Dealer.Controls.Add(this.label_PatternName);
            this.groupBox_Dealer.Controls.Add(this.label_Best);
            this.groupBox_Dealer.Location = new System.Drawing.Point(12, 204);
            this.groupBox_Dealer.Name = "groupBox_Dealer";
            this.groupBox_Dealer.Size = new System.Drawing.Size(226, 94);
            this.groupBox_Dealer.TabIndex = 6;
            this.groupBox_Dealer.TabStop = false;
            this.groupBox_Dealer.Text = "Dealer";
            // 
            // label_Best
            // 
            this.label_Best.AutoSize = true;
            this.label_Best.Location = new System.Drawing.Point(7, 20);
            this.label_Best.Name = "label_Best";
            this.label_Best.Size = new System.Drawing.Size(31, 13);
            this.label_Best.TabIndex = 0;
            this.label_Best.Text = "Best:";
            // 
            // label_PatternName
            // 
            this.label_PatternName.AutoSize = true;
            this.label_PatternName.Location = new System.Drawing.Point(39, 20);
            this.label_PatternName.Name = "label_PatternName";
            this.label_PatternName.Size = new System.Drawing.Size(0, 13);
            this.label_PatternName.TabIndex = 1;
            // 
            // pictureBox_BestPattern
            // 
            this.pictureBox_BestPattern.Location = new System.Drawing.Point(10, 37);
            this.pictureBox_BestPattern.Name = "pictureBox_BestPattern";
            this.pictureBox_BestPattern.Size = new System.Drawing.Size(186, 36);
            this.pictureBox_BestPattern.TabIndex = 2;
            this.pictureBox_BestPattern.TabStop = false;
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
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel_Control.ResumeLayout(false);
            this.panel_Control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PokerStack)).EndInit();
            this.panel_Table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Table)).EndInit();
            this.groupBox_Dealer.ResumeLayout(false);
            this.groupBox_Dealer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BestPattern)).EndInit();
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
        private System.Windows.Forms.Label label_Best;
        private System.Windows.Forms.Label label_PatternName;
        private System.Windows.Forms.PictureBox pictureBox_BestPattern;


    }
}

