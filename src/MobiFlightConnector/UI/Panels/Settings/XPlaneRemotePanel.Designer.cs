namespace MobiFlight.UI.Panels.Settings
{
    partial class XPlaneRemotePanel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.XPlaneRemote = new System.Windows.Forms.CheckBox();
            this.XPlaneIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.XPlaneRemote);
            this.groupBox1.Controls.Add(this.XPlaneIP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "X-Plane Remote Settings";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // XPlaneRemote
            // 
            this.XPlaneRemote.AutoSize = true;
            this.XPlaneRemote.Location = new System.Drawing.Point(9, 19);
            this.XPlaneRemote.Name = "XPlaneRemote";
            this.XPlaneRemote.Size = new System.Drawing.Size(196, 17);
            this.XPlaneRemote.TabIndex = 5;
            this.XPlaneRemote.Text = "Enable X-Plane Remote Connection";
            this.XPlaneRemote.UseVisualStyleBackColor = true;
            this.XPlaneRemote.CheckedChanged += new System.EventHandler(this.XPlaneRemoteEnable_CheckedChanged);
            // 
            // XPlaneIP
            // 
            this.XPlaneIP.Location = new System.Drawing.Point(49, 40);
            this.XPlaneIP.Name = "XPlaneIP";
            this.XPlaneIP.Size = new System.Drawing.Size(154, 20);
            this.XPlaneIP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // XPlaneRemotePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "XPlaneRemotePanel";
            this.Size = new System.Drawing.Size(558, 524);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox XPlaneRemote;
        private System.Windows.Forms.TextBox XPlaneIP;
        private System.Windows.Forms.Label label1;
    }
}
