
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
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.clocktimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbltempo = new System.Windows.Forms.Label();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblstatus = new System.Windows.Forms.Label();
            this.lblvstatus = new System.Windows.Forms.Label();
            this.lblvtempo = new System.Windows.Forms.Label();
            this.controllertimer = new System.Windows.Forms.Timer(this.components);
            this.statusbar1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.statusbar1.Location = new System.Drawing.Point(0, 160);
            this.statusbar1.Name = "statusbar1";
            this.statusbar1.Size = new System.Drawing.Size(401, 22);
            this.statusbar1.TabIndex = 0;
            this.statusbar1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel1.Text = "..";
            // 
            // clocktimer
            // 
            this.clocktimer.Enabled = true;
            this.clocktimer.Interval = 1000;
            this.clocktimer.Tick += new System.EventHandler(this.clocktimer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblvtempo);
            this.groupBox1.Controls.Add(this.lblvstatus);
            this.groupBox1.Controls.Add(this.lbltempo);
            this.groupBox1.Controls.Add(this.btnParar);
            this.groupBox1.Controls.Add(this.btnIniciar);
            this.groupBox1.Controls.Add(this.lblstatus);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 141);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurações :";
            // 
            // lbltempo
            // 
            this.lbltempo.AutoSize = true;
            this.lbltempo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltempo.Location = new System.Drawing.Point(6, 58);
            this.lbltempo.Name = "lbltempo";
            this.lbltempo.Size = new System.Drawing.Size(169, 25);
            this.lbltempo.TabIndex = 4;
            this.lbltempo.Text = "Tempo Rodando :";
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(205, 96);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(154, 23);
            this.btnParar.TabIndex = 3;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(25, 96);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(154, 23);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblstatus.Location = new System.Drawing.Point(6, 22);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(129, 25);
            this.lblstatus.TabIndex = 0;
            this.lblstatus.Text = "Status Atual :";
            // 
            // lblvstatus
            // 
            this.lblvstatus.AutoSize = true;
            this.lblvstatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblvstatus.ForeColor = System.Drawing.Color.Red;
            this.lblvstatus.Location = new System.Drawing.Point(141, 22);
            this.lblvstatus.Name = "lblvstatus";
            this.lblvstatus.Size = new System.Drawing.Size(89, 25);
            this.lblvstatus.TabIndex = 5;
            this.lblvstatus.Text = "PARADO";
            // 
            // lblvtempo
            // 
            this.lblvtempo.AutoSize = true;
            this.lblvtempo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblvtempo.ForeColor = System.Drawing.Color.Blue;
            this.lblvtempo.Location = new System.Drawing.Point(181, 58);
            this.lblvtempo.Name = "lblvtempo";
            this.lblvtempo.Size = new System.Drawing.Size(88, 25);
            this.lblvtempo.TabIndex = 6;
            this.lblvtempo.Text = "00:00:00";
            // 
            // controllertimer
            // 
            this.controllertimer.Interval = 500;
            this.controllertimer.Tick += new System.EventHandler(this.controllertimer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 182);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusbar1);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keep me Awake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusbar1.ResumeLayout(false);
            this.statusbar1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer automationtimer;
        private System.Windows.Forms.StatusStrip statusbar1;
        private System.Windows.Forms.Timer clocktimer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbltempo;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label lblvstatus;
        private System.Windows.Forms.Label lblvtempo;
        private System.Windows.Forms.Timer controllertimer;
    }
}

