namespace GameManager {
    partial class CustomMessageBox {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.messagePanel = new System.Windows.Forms.Panel();
            this.message = new System.Windows.Forms.Label();
            this.noButton = new System.Windows.Forms.Button();
            this.yesButton = new System.Windows.Forms.Button();
            this.dontAskAgainCheckbox = new System.Windows.Forms.CheckBox();
            this.messagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // messagePanel
            // 
            this.messagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.messagePanel.Controls.Add(this.message);
            this.messagePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.messagePanel.Location = new System.Drawing.Point(0, 0);
            this.messagePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(461, 123);
            this.messagePanel.TabIndex = 0;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.ForeColor = System.Drawing.SystemColors.Control;
            this.message.Location = new System.Drawing.Point(15, 46);
            this.message.MaximumSize = new System.Drawing.Size(500, 0);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(78, 16);
            this.message.TabIndex = 0;
            this.message.Text = "<message>";
            // 
            // noButton
            // 
            this.noButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.noButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.noButton.ForeColor = System.Drawing.SystemColors.Control;
            this.noButton.Location = new System.Drawing.Point(351, 135);
            this.noButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(99, 32);
            this.noButton.TabIndex = 3;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = false;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // yesButton
            // 
            this.yesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.yesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.yesButton.ForeColor = System.Drawing.SystemColors.Control;
            this.yesButton.Location = new System.Drawing.Point(244, 135);
            this.yesButton.Margin = new System.Windows.Forms.Padding(3, 2, 5, 2);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(99, 32);
            this.yesButton.TabIndex = 1;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = false;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // dontAskAgainCheckbox
            // 
            this.dontAskAgainCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dontAskAgainCheckbox.AutoSize = true;
            this.dontAskAgainCheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dontAskAgainCheckbox.ForeColor = System.Drawing.SystemColors.Control;
            this.dontAskAgainCheckbox.Location = new System.Drawing.Point(12, 144);
            this.dontAskAgainCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dontAskAgainCheckbox.Name = "dontAskAgainCheckbox";
            this.dontAskAgainCheckbox.Size = new System.Drawing.Size(122, 20);
            this.dontAskAgainCheckbox.TabIndex = 0;
            this.dontAskAgainCheckbox.Text = "Don\'t ask again";
            this.dontAskAgainCheckbox.UseVisualStyleBackColor = false;
            this.dontAskAgainCheckbox.CheckedChanged += new System.EventHandler(this.dontAskAgainCheckbox_CheckedChanged);
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(461, 180);
            this.Controls.Add(this.dontAskAgainCheckbox);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.messagePanel);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomMessageBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "<title>";
            this.TopMost = true;
            this.messagePanel.ResumeLayout(false);
            this.messagePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel messagePanel;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.CheckBox dontAskAgainCheckbox;
    }
}
