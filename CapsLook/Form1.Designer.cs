namespace CapsLook
{
    partial class Form1
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
            this.numbox = new System.Windows.Forms.CheckBox();
            this.capsbox = new System.Windows.Forms.CheckBox();
            this.scrollbox = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numbox
            // 
            this.numbox.AutoSize = true;
            this.numbox.Enabled = false;
            this.numbox.Location = new System.Drawing.Point(13, 13);
            this.numbox.Name = "numbox";
            this.numbox.Size = new System.Drawing.Size(71, 17);
            this.numbox.TabIndex = 0;
            this.numbox.Text = "Num lock";
            this.numbox.UseVisualStyleBackColor = true;
            // 
            // capsbox
            // 
            this.capsbox.AutoSize = true;
            this.capsbox.Enabled = false;
            this.capsbox.Location = new System.Drawing.Point(13, 37);
            this.capsbox.Name = "capsbox";
            this.capsbox.Size = new System.Drawing.Size(73, 17);
            this.capsbox.TabIndex = 1;
            this.capsbox.Text = "Caps lock";
            this.capsbox.UseVisualStyleBackColor = true;
            // 
            // scrollbox
            // 
            this.scrollbox.AutoSize = true;
            this.scrollbox.Enabled = false;
            this.scrollbox.Location = new System.Drawing.Point(13, 61);
            this.scrollbox.Name = "scrollbox";
            this.scrollbox.Size = new System.Drawing.Size(75, 17);
            this.scrollbox.TabIndex = 2;
            this.scrollbox.Text = "Scroll lock";
            this.scrollbox.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showWindowToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 48);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // showWindowToolStripMenuItem
            // 
            this.showWindowToolStripMenuItem.Checked = true;
            this.showWindowToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showWindowToolStripMenuItem.Name = "showWindowToolStripMenuItem";
            this.showWindowToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.showWindowToolStripMenuItem.Text = "Show window";
            this.showWindowToolStripMenuItem.Click += new System.EventHandler(this.showWindowToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(124, 88);
            this.Controls.Add(this.scrollbox);
            this.Controls.Add(this.capsbox);
            this.Controls.Add(this.numbox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(140, 127);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(140, 127);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Caps Look";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox numbox;
        private System.Windows.Forms.CheckBox capsbox;
        private System.Windows.Forms.CheckBox scrollbox;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showWindowToolStripMenuItem;
    }
}

