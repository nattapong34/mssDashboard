
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
            this.lbNum = new System.Windows.Forms.Label();
            this.lbGate = new System.Windows.Forms.Label();
            this.pbPerson = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbGate);
            this.panel1.Controls.Add(this.lbNum);
            this.panel1.Controls.Add(this.pbPerson);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 120);
            this.panel1.TabIndex = 0;
            // 
            // lbNum
            // 
            this.lbNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(84)))));
            this.lbNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbNum.Font = new System.Drawing.Font("DS-Digital", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNum.ForeColor = System.Drawing.Color.Gold;
            this.lbNum.Location = new System.Drawing.Point(120, 4);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(350, 110);
            this.lbNum.TabIndex = 2;
            this.lbNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbGate
            // 
            this.lbGate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(84)))));
            this.lbGate.Font = new System.Drawing.Font("DS-Digital", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGate.ForeColor = System.Drawing.Color.Gold;
            this.lbGate.Location = new System.Drawing.Point(604, 4);
            this.lbGate.Name = "lbGate";
            this.lbGate.Size = new System.Drawing.Size(350, 110);
            this.lbGate.TabIndex = 3;
            this.lbGate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbPerson
            // 
            this.pbPerson.BackgroundImage = global::mssDashboard.Properties.Resources.Mask_1_512;
            this.pbPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPerson.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbPerson.Location = new System.Drawing.Point(0, 0);
            this.pbPerson.Name = "pbPerson";
            this.pbPerson.Size = new System.Drawing.Size(114, 120);
            this.pbPerson.TabIndex = 1;
            this.pbPerson.TabStop = false;
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
        internal System.Windows.Forms.Label lbNum;
        internal System.Windows.Forms.Label lbGate;
    }
}
