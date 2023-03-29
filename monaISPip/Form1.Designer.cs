
namespace monaISPip {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing&&(components!=null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.curip = new System.Windows.Forms.Label();
            this.curreg = new System.Windows.Forms.Label();
            this.curisp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 360000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // curip
            // 
            this.curip.AutoSize = true;
            this.curip.Font = new System.Drawing.Font("Segoe UI Emoji", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.curip.ForeColor = System.Drawing.SystemColors.Highlight;
            this.curip.Location = new System.Drawing.Point(44, 9);
            this.curip.Name = "curip";
            this.curip.Size = new System.Drawing.Size(125, 37);
            this.curip.TabIndex = 0;
            this.curip.Text = "127.0.0.1";
            // 
            // curreg
            // 
            this.curreg.AutoSize = true;
            this.curreg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.curreg.Location = new System.Drawing.Point(44, 46);
            this.curreg.Name = "curreg";
            this.curreg.Size = new System.Drawing.Size(153, 28);
            this.curreg.TabIndex = 1;
            this.curreg.Text = "Current location";
            // 
            // curisp
            // 
            this.curisp.AutoSize = true;
            this.curisp.Location = new System.Drawing.Point(44, 84);
            this.curisp.Name = "curisp";
            this.curisp.Size = new System.Drawing.Size(94, 20);
            this.curisp.TabIndex = 2;
            this.curisp.Text = "Unknown ISP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 128);
            this.Controls.Add(this.curisp);
            this.Controls.Add(this.curreg);
            this.Controls.Add(this.curip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "monaISPip";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label curip;
        private System.Windows.Forms.Label curreg;
        private System.Windows.Forms.Label curisp;
    }
}

