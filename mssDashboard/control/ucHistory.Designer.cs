
namespace mssDashboard.control
{
    partial class ucHistory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnQ1 = new System.Windows.Forms.Panel();
            this.lbCounter = new System.Windows.Forms.Label();
            this.lbTimeleft = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbQ = new System.Windows.Forms.Label();
            this.pnQ1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnQ1
            // 
            this.pnQ1.AllowDrop = true;
            this.pnQ1.BackColor = System.Drawing.Color.DarkGray;
            this.pnQ1.Controls.Add(this.lbCounter);
            this.pnQ1.Controls.Add(this.lbTimeleft);
            this.pnQ1.Controls.Add(this.lbTitle);
            this.pnQ1.Controls.Add(this.lbQ);
            this.pnQ1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnQ1.Location = new System.Drawing.Point(1, 1);
            this.pnQ1.Name = "pnQ1";
            this.pnQ1.Size = new System.Drawing.Size(127, 168);
            this.pnQ1.TabIndex = 1;
            // 
            // lbCounter
            // 
            this.lbCounter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            this.lbCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCounter.Font = new System.Drawing.Font("Gas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCounter.ForeColor = System.Drawing.Color.White;
            this.lbCounter.Location = new System.Drawing.Point(0, 94);
            this.lbCounter.Name = "lbCounter";
            this.lbCounter.Size = new System.Drawing.Size(127, 47);
            this.lbCounter.TabIndex = 3;
            this.lbCounter.Text = "1";
            this.lbCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTimeleft
            // 
            this.lbTimeleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbTimeleft.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbTimeleft.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeleft.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbTimeleft.Location = new System.Drawing.Point(0, 141);
            this.lbTimeleft.Name = "lbTimeleft";
            this.lbTimeleft.Size = new System.Drawing.Size(127, 27);
            this.lbTimeleft.TabIndex = 4;
            this.lbTimeleft.Text = "0 นาที";
            this.lbTimeleft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(0, 60);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(127, 34);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "ช่องบริการ";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbQ
            // 
            this.lbQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(84)))));
            this.lbQ.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbQ.Font = new System.Drawing.Font("Gas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQ.ForeColor = System.Drawing.Color.White;
            this.lbQ.Location = new System.Drawing.Point(0, 0);
            this.lbQ.Name = "lbQ";
            this.lbQ.Size = new System.Drawing.Size(127, 60);
            this.lbQ.TabIndex = 0;
            this.lbQ.Text = "A999";
            this.lbQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnQ1);
            this.Name = "ucHistory";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(128, 170);
            this.pnQ1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnQ1;
        internal System.Windows.Forms.Label lbQ;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbCounter;
        private System.Windows.Forms.Label lbTimeleft;
    }
}
