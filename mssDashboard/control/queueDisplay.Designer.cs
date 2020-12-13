
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbPerson = new System.Windows.Forms.PictureBox();
            this.lbNum = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbGate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbNum);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pbPerson);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 200);
            this.panel1.TabIndex = 0;
            // 
            // pbPerson
            // 
            this.pbPerson.BackgroundImage = global::mssDashboard.Properties.Resources.Mask_1_512;
            this.pbPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPerson.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbPerson.Location = new System.Drawing.Point(0, 0);
            this.pbPerson.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pbPerson.Name = "pbPerson";
            this.pbPerson.Size = new System.Drawing.Size(228, 198);
            this.pbPerson.TabIndex = 1;
            this.pbPerson.TabStop = false;
            // 
            // lbNum
            // 
            this.lbNum.BackColor = System.Drawing.Color.Teal;
            this.lbNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 55.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNum.ForeColor = System.Drawing.Color.White;
            this.lbNum.Location = new System.Drawing.Point(228, 0);
            this.lbNum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(432, 198);
            this.lbNum.TabIndex = 2;
            this.lbNum.Text = "A999";
            this.lbNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.lbGate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(660, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 198);
            this.panel2.TabIndex = 3;
            // 
            // lbGate
            // 
            this.lbGate.BackColor = System.Drawing.Color.Transparent;
            this.lbGate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbGate.Font = new System.Drawing.Font("Microsoft Sans Serif", 55.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGate.ForeColor = System.Drawing.Color.White;
            this.lbGate.Location = new System.Drawing.Point(0, 0);
            this.lbGate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbGate.Name = "lbGate";
            this.lbGate.Size = new System.Drawing.Size(218, 198);
            this.lbGate.TabIndex = 3;
            this.lbGate.Text = "1";
            this.lbGate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // queueDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "queueDisplay";
            this.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.Size = new System.Drawing.Size(900, 220);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbPerson;
        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbGate;
    }
}
