namespace PivotAnimator0._1._2._5._0
{
    partial class PivotScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PivotScreen));
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.optionsMenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.fpsTextBox = new System.Windows.Forms.TextBox();
            this.optionsMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // animationTimer
            // 
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "pivot";
            this.openFileDialog.InitialDirectory = "@\"C:\\Users\"";
            this.openFileDialog.RestoreDirectory = true;
            this.openFileDialog.Title = "Open Animation";
            // 
            // optionsMenuStrip
            // 
            this.optionsMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.optionsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.optionsMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.optionsMenuStrip.Name = "optionsMenuStrip";
            this.optionsMenuStrip.Size = new System.Drawing.Size(1144, 40);
            this.optionsMenuStrip.TabIndex = 0;
            this.optionsMenuStrip.Text = "menuStrip1";
            this.optionsMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fileMenuStrip_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(194, 36);
            this.toolStripMenuItem1.Text = "Save Animation";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(203, 36);
            this.toolStripMenuItem2.Text = "Open Animation";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(141, 36);
            this.toolStripMenuItem3.Text = "Add Scene";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(186, 36);
            this.toolStripMenuItem4.Text = "Run Animation";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(293, 36);
            this.toolStripMenuItem5.Text = "Open Background Image";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "pivot";
            this.saveFileDialog.InitialDirectory = "@\"C\\Users\"";
            this.saveFileDialog.RestoreDirectory = true;
            // 
            // fpsTextBox
            // 
            this.fpsTextBox.Location = new System.Drawing.Point(12, 150);
            this.fpsTextBox.Name = "fpsTextBox";
            this.fpsTextBox.Size = new System.Drawing.Size(100, 31);
            this.fpsTextBox.TabIndex = 1;
            this.fpsTextBox.Text = "FPS";
            this.fpsTextBox.TextChanged += new System.EventHandler(this.fpsTextBox_TextChanged);
            // 
            // PivotScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 840);
            this.Controls.Add(this.fpsTextBox);
            this.Controls.Add(this.optionsMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.optionsMenuStrip;
            this.Name = "PivotScreen";
            this.Text = "Pivot Animator Demo 0.9";
            this.optionsMenuStrip.ResumeLayout(false);
            this.optionsMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.MenuStrip optionsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.TextBox fpsTextBox;
    }
}