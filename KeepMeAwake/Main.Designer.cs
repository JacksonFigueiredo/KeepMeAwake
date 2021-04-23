
namespace KeepMeAwake
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.automationtimer = new System.Windows.Forms.Timer(this.components);
            this.statusbar1 = new System.Windows.Forms.StatusStrip();
            this.clocktimer = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusbar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // automationtimer
            // 
            this.automationtimer.Interval = 60000;
            this.automationtimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusbar1
            // 
            this.statusbar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusbar1.Location = new System.Drawing.Point(0, 140);
            this.statusbar1.Name = "statusbar1";
            this.statusbar1.Size = new System.Drawing.Size(350, 22);
            this.statusbar1.TabIndex = 0;
            this.statusbar1.Text = "statusStrip1";
            // 
            // clocktimer
            // 
            this.clocktimer.Enabled = true;
            this.clocktimer.Interval = 1000;
            this.clocktimer.Tick += new System.EventHandler(this.clocktimer_Tick);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 162);
            this.Controls.Add(this.statusbar1);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keep me Awake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusbar1.ResumeLayout(false);
            this.statusbar1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer automationtimer;
        private System.Windows.Forms.StatusStrip statusbar1;
        private System.Windows.Forms.Timer clocktimer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

