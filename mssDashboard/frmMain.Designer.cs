
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
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel13 = new System.Windows.Forms.Panel();
            this.lbQSkip = new System.Windows.Forms.Label();
            this.lbQCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnCalling = new System.Windows.Forms.Panel();
            this.pnMainQ = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnHis = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lbMessage = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lbClock = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tmClock = new System.Windows.Forms.Timer(this.components);
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pbADV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.panel13.SuspendLayout();
            this.pnCalling.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel10.SuspendLayout();
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
            this.panel7.Size = new System.Drawing.Size(1684, 1031);
            this.panel7.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel8.Controls.Add(this.pbADV);
            this.panel8.Controls.Add(this.panel13);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(5, 5);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(5);
            this.panel8.Size = new System.Drawing.Size(650, 916);
            this.panel8.TabIndex = 8;
            // 
            // pbADV
            // 
            this.pbADV.Controls.Add(this.mediaPlayer);
            this.pbADV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbADV.Location = new System.Drawing.Point(5, 5);
            this.pbADV.Name = "pbADV";
            this.pbADV.Padding = new System.Windows.Forms.Padding(2);
            this.pbADV.Size = new System.Drawing.Size(640, 806);
            this.pbADV.TabIndex = 2;
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(2, 2);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(636, 802);
            this.mediaPlayer.TabIndex = 0;
            this.mediaPlayer.Enter += new System.EventHandler(this.mediaPlayer_Enter);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel13.Controls.Add(this.lbQSkip);
            this.panel13.Controls.Add(this.lbQCount);
            this.panel13.Controls.Add(this.label3);
            this.panel13.Controls.Add(this.label2);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(5, 811);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(640, 100);
            this.panel13.TabIndex = 1;
            // 
            // lbQSkip
            // 
            this.lbQSkip.AutoSize = true;
            this.lbQSkip.Font = new System.Drawing.Font("DS-Digital", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQSkip.ForeColor = System.Drawing.Color.Gold;
            this.lbQSkip.Location = new System.Drawing.Point(214, 57);
            this.lbQSkip.Name = "lbQSkip";
            this.lbQSkip.Size = new System.Drawing.Size(21, 21);
            this.lbQSkip.TabIndex = 3;
            this.lbQSkip.Text = "0";
            // 
            // lbQCount
            // 
            this.lbQCount.AutoSize = true;
            this.lbQCount.Font = new System.Drawing.Font("DS-Digital", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQCount.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbQCount.Location = new System.Drawing.Point(214, 18);
            this.lbQCount.Name = "lbQCount";
            this.lbQCount.Size = new System.Drawing.Size(21, 21);
            this.lbQCount.TabIndex = 2;
            this.lbQCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(19, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
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
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "จำนวนคิวทั้งหมด";
            // 
            // pnCalling
            // 
            this.pnCalling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.pnCalling.Controls.Add(this.pnMainQ);
            this.pnCalling.Controls.Add(this.panel2);
            this.pnCalling.Controls.Add(this.panel1);
            this.pnCalling.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnCalling.Location = new System.Drawing.Point(655, 5);
            this.pnCalling.Name = "pnCalling";
            this.pnCalling.Padding = new System.Windows.Forms.Padding(10);
            this.pnCalling.Size = new System.Drawing.Size(1024, 916);
            this.pnCalling.TabIndex = 7;
            // 
            // pnMainQ
            // 
            this.pnMainQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.pnMainQ.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.pnMainQ.Location = new System.Drawing.Point(13, 137);
            this.pnMainQ.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.pnMainQ.Name = "pnMainQ";
            this.pnMainQ.Size = new System.Drawing.Size(997, 429);
            this.pnMainQ.TabIndex = 5;
            this.pnMainQ.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pnMainQ_ControlAdded);
            this.pnMainQ.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.pnMainQ_ControlRemoved);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.pnHis);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(14, 591);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(997, 308);
            this.panel2.TabIndex = 4;
            // 
            // pnHis
            // 
            this.pnHis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(8)))));
            this.pnHis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnHis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnHis.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnHis.Location = new System.Drawing.Point(10, 102);
            this.pnHis.Name = "pnHis";
            this.pnHis.Padding = new System.Windows.Forms.Padding(15, 10, 10, 10);
            this.pnHis.Size = new System.Drawing.Size(977, 196);
            this.pnHis.TabIndex = 3;
            this.pnHis.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pnHis_ControlAdded);
            this.pnHis.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.pnHis_ControlRemoved);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "คิวที่เรียกไปแล้ว";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 100);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(632, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(347, 77);
            this.label7.TabIndex = 1;
            this.label7.Text = "ช่องบริการ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(154, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(384, 77);
            this.label6.TabIndex = 0;
            this.label6.Text = "หมายเลขคิว";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.YellowGreen;
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(5, 921);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1674, 105);
            this.panel9.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.OrangeRed;
            this.panel11.Controls.Add(this.txtStatus);
            this.panel11.Controls.Add(this.pbLogo);
            this.panel11.Controls.Add(this.lbMessage);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 52);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1674, 53);
            this.panel11.TabIndex = 1;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(1768, 17);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(119, 29);
            this.txtStatus.TabIndex = 4;
            this.txtStatus.Visible = false;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImage = global::mssDashboard.Properties.Resources.ppg11168;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(85, 53);
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // lbMessage
            // 
            this.lbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMessage.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.ForeColor = System.Drawing.Color.White;
            this.lbMessage.Location = new System.Drawing.Point(0, 0);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(1674, 53);
            this.lbMessage.TabIndex = 0;
            this.lbMessage.Text = "-- ยินดีต้อนรับ --";
            this.lbMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Controls.Add(this.lbClock);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1674, 52);
            this.panel10.TabIndex = 0;
            // 
            // lbClock
            // 
            this.lbClock.BackColor = System.Drawing.Color.Black;
            this.lbClock.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbClock.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClock.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbClock.Location = new System.Drawing.Point(650, 0);
            this.lbClock.Name = "lbClock";
            this.lbClock.Size = new System.Drawing.Size(1024, 52);
            this.lbClock.TabIndex = 0;
            this.lbClock.Text = "00:00";
            this.lbClock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Mask_1-512.png");
            // 
            // tmClock
            // 
            this.tmClock.Enabled = true;
            this.tmClock.Interval = 1000;
            this.tmClock.Tick += new System.EventHandler(this.tmClock_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1684, 1031);
            this.Controls.Add(this.panel7);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "MSSQ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_LoadAsync);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.pbADV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.pnCalling.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel pbADV;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Label lbClock;
        private System.Windows.Forms.Timer tmClock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbQSkip;
        private System.Windows.Forms.Label lbQCount;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Panel pnCalling;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panel2;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnHis;
        private System.Windows.Forms.FlowLayoutPanel pnMainQ;
    }
}

