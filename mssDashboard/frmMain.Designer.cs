
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pbADV = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lbMessage = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lbClock = new System.Windows.Forms.Label();
            this.tmClock = new System.Windows.Forms.Timer(this.components);
            this.pnCalling = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpQueue = new System.Windows.Forms.FlowLayoutPanel();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.queueDisplay1 = new mssDashboard.control.queueDisplay();
            this.queueDisplay2 = new mssDashboard.control.queueDisplay();
            this.queueDisplay3 = new mssDashboard.control.queueDisplay();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pbADV.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.pnCalling.SuspendLayout();
            this.flpQueue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.pnCalling);
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
            this.panel8.Size = new System.Drawing.Size(969, 926);
            this.panel8.TabIndex = 8;
            // 
            // pbADV
            // 
            this.pbADV.Controls.Add(this.mediaPlayer);
            this.pbADV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbADV.Location = new System.Drawing.Point(5, 105);
            this.pbADV.Name = "pbADV";
            this.pbADV.Padding = new System.Windows.Forms.Padding(10);
            this.pbADV.Size = new System.Drawing.Size(959, 716);
            this.pbADV.TabIndex = 2;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel13.Controls.Add(this.txtStatus);
            this.panel13.Controls.Add(this.label5);
            this.panel13.Controls.Add(this.label4);
            this.panel13.Controls.Add(this.label3);
            this.panel13.Controls.Add(this.label2);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(5, 821);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(959, 100);
            this.panel13.TabIndex = 1;
            // 
            // txtStatus
            // 
            this.txtStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtStatus.Location = new System.Drawing.Point(651, 0);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(308, 100);
            this.txtStatus.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(214, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 51);
            this.label5.TabIndex = 3;
            this.label5.Text = "12";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(214, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 51);
            this.label4.TabIndex = 2;
            this.label4.Text = "15";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(19, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 51);
            this.label3.TabIndex = 1;
            this.label3.Text = "คิวคงค้าง";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(19, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 51);
            this.label2.TabIndex = 0;
            this.label2.Text = "จำนวนคิวทั้งหมด";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.AliceBlue;
            this.panel12.Controls.Add(this.label1);
            this.panel12.Controls.Add(this.pictureBox1);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(5, 5);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(959, 100);
            this.panel12.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(101, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(858, 100);
            this.label1.TabIndex = 1;
            this.label1.Text = "ระบบเรียกคิว iQ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Mask_1-512.png");
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
            this.panel11.Controls.Add(this.lbMessage);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 52);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1894, 53);
            this.panel11.TabIndex = 1;
            // 
            // lbMessage
            // 
            this.lbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMessage.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.ForeColor = System.Drawing.Color.White;
            this.lbMessage.Location = new System.Drawing.Point(0, 0);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(1894, 53);
            this.lbMessage.TabIndex = 0;
            this.lbMessage.Text = "-- ยินดีต้อนรับ --";
            this.lbMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel10.Controls.Add(this.lbClock);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1894, 52);
            this.panel10.TabIndex = 0;
            // 
            // lbClock
            // 
            this.lbClock.BackColor = System.Drawing.Color.Black;
            this.lbClock.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbClock.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClock.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbClock.Location = new System.Drawing.Point(1483, 0);
            this.lbClock.Name = "lbClock";
            this.lbClock.Size = new System.Drawing.Size(411, 52);
            this.lbClock.TabIndex = 0;
            this.lbClock.Text = "00:00";
            this.lbClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmClock
            // 
            this.tmClock.Enabled = true;
            this.tmClock.Interval = 1000;
            this.tmClock.Tick += new System.EventHandler(this.tmClock_Tick);
            // 
            // pnCalling
            // 
            this.pnCalling.BackColor = System.Drawing.Color.White;
            this.pnCalling.Controls.Add(this.flpQueue);
            this.pnCalling.Controls.Add(this.panel1);
            this.pnCalling.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnCalling.Location = new System.Drawing.Point(974, 5);
            this.pnCalling.Name = "pnCalling";
            this.pnCalling.Padding = new System.Windows.Forms.Padding(10);
            this.pnCalling.Size = new System.Drawing.Size(925, 926);
            this.pnCalling.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 100);
            this.panel1.TabIndex = 0;
            // 
            // flpQueue
            // 
            this.flpQueue.AutoSize = true;
            this.flpQueue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpQueue.Controls.Add(this.queueDisplay1);
            this.flpQueue.Controls.Add(this.queueDisplay2);
            this.flpQueue.Controls.Add(this.queueDisplay3);
            this.flpQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpQueue.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpQueue.Location = new System.Drawing.Point(10, 110);
            this.flpQueue.Name = "flpQueue";
            this.flpQueue.Size = new System.Drawing.Size(905, 806);
            this.flpQueue.TabIndex = 1;
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(10, 10);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(939, 696);
            this.mediaPlayer.TabIndex = 0;
            // 
            // queueDisplay1
            // 
            this.queueDisplay1.BackColor = System.Drawing.Color.Black;
            this.queueDisplay1.Location = new System.Drawing.Point(6, 6);
            this.queueDisplay1.Margin = new System.Windows.Forms.Padding(6);
            this.queueDisplay1.Name = "queueDisplay1";
            this.queueDisplay1.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.queueDisplay1.Size = new System.Drawing.Size(900, 220);
            this.queueDisplay1.TabIndex = 0;
            // 
            // queueDisplay2
            // 
            this.queueDisplay2.BackColor = System.Drawing.Color.Black;
            this.queueDisplay2.Location = new System.Drawing.Point(6, 238);
            this.queueDisplay2.Margin = new System.Windows.Forms.Padding(6);
            this.queueDisplay2.Name = "queueDisplay2";
            this.queueDisplay2.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.queueDisplay2.Size = new System.Drawing.Size(900, 238);
            this.queueDisplay2.TabIndex = 1;
            // 
            // queueDisplay3
            // 
            this.queueDisplay3.BackColor = System.Drawing.Color.Black;
            this.queueDisplay3.Location = new System.Drawing.Point(6, 488);
            this.queueDisplay3.Margin = new System.Windows.Forms.Padding(6);
            this.queueDisplay3.Name = "queueDisplay3";
            this.queueDisplay3.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.queueDisplay3.Size = new System.Drawing.Size(900, 238);
            this.queueDisplay3.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel7);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.pbADV.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.pnCalling.ResumeLayout(false);
            this.pnCalling.PerformLayout();
            this.flpQueue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pbADV;
        private System.Windows.Forms.Panel panel13;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Label lbClock;
        private System.Windows.Forms.Timer tmClock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Panel pnCalling;
        private System.Windows.Forms.FlowLayoutPanel flpQueue;
        private System.Windows.Forms.Panel panel1;
        private control.queueDisplay queueDisplay1;
        private control.queueDisplay queueDisplay2;
        private control.queueDisplay queueDisplay3;
    }
}

