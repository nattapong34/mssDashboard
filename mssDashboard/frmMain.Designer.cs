
namespace mssDashboard
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pbADV = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbRoom1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbRoom2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbRoom3 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.queueDisplay1 = new mssDashboard.control.queueDisplay();
            this.queueDisplay2 = new mssDashboard.control.queueDisplay();
            this.queueDisplay3 = new mssDashboard.control.queueDisplay();
            this.queueDisplay4 = new mssDashboard.control.queueDisplay();
            this.queueDisplay5 = new mssDashboard.control.queueDisplay();
            this.queueDisplay6 = new mssDashboard.control.queueDisplay();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pbADV.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(5);
            this.panel7.Size = new System.Drawing.Size(1904, 1041);
            this.panel7.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.pbADV);
            this.panel8.Controls.Add(this.panel13);
            this.panel8.Controls.Add(this.panel12);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(5, 5);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(5);
            this.panel8.Size = new System.Drawing.Size(661, 926);
            this.panel8.TabIndex = 8;
            // 
            // pbADV
            // 
            this.pbADV.Controls.Add(this.mediaPlayer);
            this.pbADV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbADV.Location = new System.Drawing.Point(5, 105);
            this.pbADV.Name = "pbADV";
            this.pbADV.Padding = new System.Windows.Forms.Padding(10);
            this.pbADV.Size = new System.Drawing.Size(651, 716);
            this.pbADV.TabIndex = 2;
            // 
            // panel13
            // 
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(5, 821);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(651, 100);
            this.panel13.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.AliceBlue;
            this.panel12.Controls.Add(this.label1);
            this.panel12.Controls.Add(this.pictureBox1);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(5, 5);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(651, 100);
            this.panel12.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(101, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 100);
            this.label1.TabIndex = 1;
            this.label1.Text = "ระบบเรียกคิว iQ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.flowLayoutPanel3);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(666, 5);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(411, 926);
            this.panel4.TabIndex = 7;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Azure;
            this.flowLayoutPanel3.Controls.Add(this.queueDisplay1);
            this.flowLayoutPanel3.Controls.Add(this.queueDisplay4);
            this.flowLayoutPanel3.Controls.Add(this.queueDisplay5);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(5, 105);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(401, 816);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.lbRoom1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 100);
            this.panel1.TabIndex = 0;
            // 
            // lbRoom1
            // 
            this.lbRoom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRoom1.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoom1.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbRoom1.Location = new System.Drawing.Point(0, 0);
            this.lbRoom1.Name = "lbRoom1";
            this.lbRoom1.Size = new System.Drawing.Size(401, 100);
            this.lbRoom1.TabIndex = 0;
            this.lbRoom1.Text = "แผนกที่ 1";
            this.lbRoom1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1077, 5);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(411, 926);
            this.panel2.TabIndex = 6;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.PowderBlue;
            this.flowLayoutPanel2.Controls.Add(this.queueDisplay2);
            this.flowLayoutPanel2.Controls.Add(this.queueDisplay6);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(5, 105);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(401, 816);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel6.Controls.Add(this.lbRoom2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(5, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(401, 100);
            this.panel6.TabIndex = 2;
            // 
            // lbRoom2
            // 
            this.lbRoom2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRoom2.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoom2.ForeColor = System.Drawing.Color.White;
            this.lbRoom2.Location = new System.Drawing.Point(0, 0);
            this.lbRoom2.Name = "lbRoom2";
            this.lbRoom2.Size = new System.Drawing.Size(401, 100);
            this.lbRoom2.TabIndex = 1;
            this.lbRoom2.Text = "แผนกที่ 2";
            this.lbRoom2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1488, 5);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(411, 926);
            this.panel3.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.CadetBlue;
            this.flowLayoutPanel1.Controls.Add(this.queueDisplay3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 105);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(401, 816);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Controls.Add(this.lbRoom3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(5, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(401, 100);
            this.panel5.TabIndex = 2;
            // 
            // lbRoom3
            // 
            this.lbRoom3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRoom3.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoom3.ForeColor = System.Drawing.Color.White;
            this.lbRoom3.Location = new System.Drawing.Point(0, 0);
            this.lbRoom3.Name = "lbRoom3";
            this.lbRoom3.Size = new System.Drawing.Size(401, 100);
            this.lbRoom3.TabIndex = 1;
            this.lbRoom3.Text = "แผนกที่ 3";
            this.lbRoom3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.YellowGreen;
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(5, 931);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1894, 105);
            this.panel9.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.OrangeRed;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 52);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1894, 53);
            this.panel11.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1894, 52);
            this.panel10.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::mssDashboard.Properties.Resources.ppg11168;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(10, 10);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(631, 696);
            this.mediaPlayer.TabIndex = 0;
            // 
            // queueDisplay1
            // 
            this.queueDisplay1.BackColor = System.Drawing.Color.Black;
            this.queueDisplay1.Location = new System.Drawing.Point(4, 4);
            this.queueDisplay1.Name = "queueDisplay1";
            this.queueDisplay1.Padding = new System.Windows.Forms.Padding(5);
            this.queueDisplay1.Size = new System.Drawing.Size(390, 153);
            this.queueDisplay1.TabIndex = 0;
            // 
            // queueDisplay2
            // 
            this.queueDisplay2.BackColor = System.Drawing.Color.Black;
            this.queueDisplay2.Location = new System.Drawing.Point(4, 4);
            this.queueDisplay2.Name = "queueDisplay2";
            this.queueDisplay2.Padding = new System.Windows.Forms.Padding(5);
            this.queueDisplay2.Size = new System.Drawing.Size(390, 153);
            this.queueDisplay2.TabIndex = 1;
            // 
            // queueDisplay3
            // 
            this.queueDisplay3.BackColor = System.Drawing.Color.Black;
            this.queueDisplay3.Location = new System.Drawing.Point(4, 4);
            this.queueDisplay3.Name = "queueDisplay3";
            this.queueDisplay3.Padding = new System.Windows.Forms.Padding(5);
            this.queueDisplay3.Size = new System.Drawing.Size(390, 153);
            this.queueDisplay3.TabIndex = 1;
            // 
            // queueDisplay4
            // 
            this.queueDisplay4.BackColor = System.Drawing.Color.Black;
            this.queueDisplay4.Location = new System.Drawing.Point(4, 163);
            this.queueDisplay4.Name = "queueDisplay4";
            this.queueDisplay4.Padding = new System.Windows.Forms.Padding(5);
            this.queueDisplay4.Size = new System.Drawing.Size(390, 153);
            this.queueDisplay4.TabIndex = 1;
            // 
            // queueDisplay5
            // 
            this.queueDisplay5.BackColor = System.Drawing.Color.Black;
            this.queueDisplay5.Location = new System.Drawing.Point(4, 322);
            this.queueDisplay5.Name = "queueDisplay5";
            this.queueDisplay5.Padding = new System.Windows.Forms.Padding(5);
            this.queueDisplay5.Size = new System.Drawing.Size(390, 153);
            this.queueDisplay5.TabIndex = 2;
            // 
            // queueDisplay6
            // 
            this.queueDisplay6.BackColor = System.Drawing.Color.Black;
            this.queueDisplay6.Location = new System.Drawing.Point(4, 163);
            this.queueDisplay6.Name = "queueDisplay6";
            this.queueDisplay6.Padding = new System.Windows.Forms.Padding(5);
            this.queueDisplay6.Size = new System.Drawing.Size(390, 153);
            this.queueDisplay6.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel7);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.pbADV.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lbRoom1;
        private System.Windows.Forms.Label lbRoom2;
        private System.Windows.Forms.Label lbRoom3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pbADV;
        private System.Windows.Forms.Panel panel13;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private control.queueDisplay queueDisplay1;
        private control.queueDisplay queueDisplay4;
        private control.queueDisplay queueDisplay5;
        private control.queueDisplay queueDisplay2;
        private control.queueDisplay queueDisplay6;
        private control.queueDisplay queueDisplay3;
    }
}

