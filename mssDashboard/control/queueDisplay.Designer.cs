
namespace mssDashboard.control
{
    partial class queueDisplay
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCounter = new System.Windows.Forms.Label();
            this.lbQ = new System.Windows.Forms.Label();
            this.pbPerson = new System.Windows.Forms.PictureBox();
            this.tmTick = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbCounter);
            this.panel1.Controls.Add(this.lbQ);
            this.panel1.Controls.Add(this.pbPerson);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 120);
            this.panel1.TabIndex = 0;
            // 
            // lbCounter
            // 
            this.lbCounter.BackColor = System.Drawing.Color.Black;
            this.lbCounter.Font = new System.Drawing.Font("Gas", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCounter.ForeColor = System.Drawing.Color.Gold;
            this.lbCounter.Location = new System.Drawing.Point(597, 0);
            this.lbCounter.Name = "lbCounter";
            this.lbCounter.Size = new System.Drawing.Size(364, 120);
            this.lbCounter.TabIndex = 3;
            this.lbCounter.Text = "1";
            this.lbCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbQ
            // 
            this.lbQ.BackColor = System.Drawing.Color.Black;
            this.lbQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbQ.Font = new System.Drawing.Font("Gas", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQ.ForeColor = System.Drawing.Color.Gold;
            this.lbQ.Location = new System.Drawing.Point(159, 0);
            this.lbQ.Name = "lbQ";
            this.lbQ.Size = new System.Drawing.Size(364, 120);
            this.lbQ.TabIndex = 2;
            this.lbQ.Text = "C1";
            this.lbQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbPerson
            // 
            this.pbPerson.BackgroundImage = global::mssDashboard.Properties.Resources.human_mask;
            this.pbPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPerson.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbPerson.Location = new System.Drawing.Point(0, 0);
            this.pbPerson.Name = "pbPerson";
            this.pbPerson.Size = new System.Drawing.Size(153, 120);
            this.pbPerson.TabIndex = 1;
            this.pbPerson.TabStop = false;
            // 
            // tmTick
            // 
            this.tmTick.Interval = 200;
            this.tmTick.Tick += new System.EventHandler(this.tmTick_Tick);
            // 
            // queueDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "queueDisplay";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1000, 130);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.PictureBox pbPerson;
        internal System.Windows.Forms.Label lbQ;
        internal System.Windows.Forms.Label lbCounter;
        private System.Windows.Forms.Timer tmTick;
    }
}
