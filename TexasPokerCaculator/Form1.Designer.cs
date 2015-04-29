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
            this.label_PokerName = new System.Windows.Forms.Label();
            this.pictureBox_PokerStack = new System.Windows.Forms.PictureBox();
            this.panel_Table = new System.Windows.Forms.Panel();
            this.pictureBox_Table = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PokerStack)).BeginInit();
            this.panel_Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Control
            // 
            this.panel_Control.Controls.Add(this.label_PokerName);
            this.panel_Control.Controls.Add(this.pictureBox_PokerStack);
            this.panel_Control.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Control.Location = new System.Drawing.Point(0, 0);
            this.panel_Control.Name = "panel_Control";
            this.panel_Control.Size = new System.Drawing.Size(255, 440);
            this.panel_Control.TabIndex = 2;
            // 
            // label_PokerName
            // 
            this.label_PokerName.AutoSize = true;
            this.label_PokerName.Location = new System.Drawing.Point(12, 167);
            this.label_PokerName.Name = "label_PokerName";
            this.label_PokerName.Size = new System.Drawing.Size(35, 13);
            this.label_PokerName.TabIndex = 5;
            this.label_PokerName.Text = "label1";
            // 
            // pictureBox_PokerStack
            // 
            this.pictureBox_PokerStack.Image = global::TexasPokerCaculator.Properties.Resources.SmallPokers;
            this.pictureBox_PokerStack.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_PokerStack.Name = "pictureBox_PokerStack";
            this.pictureBox_PokerStack.Size = new System.Drawing.Size(252, 150);
            this.pictureBox_PokerStack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_PokerStack.TabIndex = 4;
            this.pictureBox_PokerStack.TabStop = false;
            this.pictureBox_PokerStack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_PokerStack_MouseMove);
            // 
            // panel_Table
            // 
            this.panel_Table.Controls.Add(this.pictureBox_Table);
            this.panel_Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Table.Location = new System.Drawing.Point(255, 0);
            this.panel_Table.Name = "panel_Table";
            this.panel_Table.Size = new System.Drawing.Size(677, 440);
            this.panel_Table.TabIndex = 3;
            // 
            // pictureBox_Table
            // 
            this.pictureBox_Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Table.Image = global::TexasPokerCaculator.Properties.Resources.PokerTable;
            this.pictureBox_Table.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Table.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox_Table.Name = "pictureBox_Table";
            this.pictureBox_Table.Size = new System.Drawing.Size(677, 440);
            this.pictureBox_Table.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Table.TabIndex = 2;
            this.pictureBox_Table.TabStop = false;
            this.pictureBox_Table.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Table_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 440);
            this.Controls.Add(this.panel_Table);
            this.Controls.Add(this.panel_Control);
            this.Name = "Form1";
            this.Text = "TexasPoker Caculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel_Control.ResumeLayout(false);
            this.panel_Control.PerformLayout();
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
        private System.Windows.Forms.Label label_PokerName;
        private System.Windows.Forms.ToolTip toolTip1;


    }
}

