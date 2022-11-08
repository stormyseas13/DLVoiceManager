namespace GameManager {
    partial class GamePropertiesForm {
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
            this.useAgth = new System.Windows.Forms.CheckBox();
            this.autoCopy = new System.Windows.Forms.CheckBox();
            this.removeRepSymbols = new System.Windows.Forms.CheckBox();
            this.suppressRepPhrases = new System.Windows.Forms.CheckBox();
            this.alwaysOnTop = new System.Windows.Forms.CheckBox();
            this.autoCopyLabel = new System.Windows.Forms.Label();
            this.removeRepsLabel = new System.Windows.Forms.Label();
            this.xLabel1 = new System.Windows.Forms.Label();
            this.xLabel2 = new System.Windows.Forms.Label();
            this.xLabel3 = new System.Windows.Forms.Label();
            this.splitParamsLabel = new System.Windows.Forms.Label();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.agthTab = new System.Windows.Forms.TabPage();
            this.useChiiTrans = new System.Windows.Forms.CheckBox();
            this.suppressRepPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.traceParam1 = new GameManager.TweakedTextBox();
            this.traceParam2 = new GameManager.TweakedTextBox();
            this.autoCopyPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.autoCopyDelay = new GameManager.TweakedTextBox();
            this.removeRepsCount = new GameManager.TweakedTextBox();
            this.splitParam3 = new GameManager.TweakedTextBox();
            this.options = new GameManager.TweakedTextBox();
            this.splitParam2 = new GameManager.TweakedTextBox();
            this.splitParam1 = new GameManager.TweakedTextBox();
            this.resolutionTab = new System.Windows.Forms.TabPage();
            this.resolutionGroup = new System.Windows.Forms.GroupBox();
            this.resolutionList = new System.Windows.Forms.ComboBox();
            this.restoreButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.agthTab.SuspendLayout();
            this.suppressRepPanel.SuspendLayout();
            this.autoCopyPanel.SuspendLayout();
            this.resolutionTab.SuspendLayout();
            this.resolutionGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // useAgth
            // 
            this.useAgth.AutoSize = true;
            this.useAgth.Location = new System.Drawing.Point(8, 8);
            this.useAgth.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.useAgth.Name = "useAgth";
            this.useAgth.Size = new System.Drawing.Size(157, 20);
            this.useAgth.TabIndex = 0;
            this.useAgth.Text = "Run game with AGTH";
            this.useAgth.UseVisualStyleBackColor = true;
            this.useAgth.CheckedChanged += new System.EventHandler(this.useAgth_CheckedChanged);
            // 
            // autoCopy
            // 
            this.autoCopy.AutoSize = true;
            this.autoCopy.Location = new System.Drawing.Point(0, 1);
            this.autoCopy.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.autoCopy.Name = "autoCopy";
            this.autoCopy.Size = new System.Drawing.Size(192, 20);
            this.autoCopy.TabIndex = 1;
            this.autoCopy.Text = "Auto copy to clipboard after";
            this.autoCopy.UseVisualStyleBackColor = true;
            this.autoCopy.CheckedChanged += new System.EventHandler(this.autoCopy_CheckedChanged);
            // 
            // removeRepSymbols
            // 
            this.removeRepSymbols.AutoSize = true;
            this.removeRepSymbols.Location = new System.Drawing.Point(8, 101);
            this.removeRepSymbols.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.removeRepSymbols.Name = "removeRepSymbols";
            this.removeRepSymbols.Size = new System.Drawing.Size(81, 20);
            this.removeRepSymbols.TabIndex = 2;
            this.removeRepSymbols.Text = "Remove";
            this.removeRepSymbols.UseVisualStyleBackColor = true;
            this.removeRepSymbols.CheckedChanged += new System.EventHandler(this.removeRepSymbols_CheckedChanged);
            // 
            // suppressRepPhrases
            // 
            this.suppressRepPhrases.AutoSize = true;
            this.suppressRepPhrases.Location = new System.Drawing.Point(0, 1);
            this.suppressRepPhrases.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.suppressRepPhrases.Name = "suppressRepPhrases";
            this.suppressRepPhrases.Size = new System.Drawing.Size(247, 20);
            this.suppressRepPhrases.TabIndex = 3;
            this.suppressRepPhrases.Text = "Suppress repetition of phrases, trace";
            this.suppressRepPhrases.UseVisualStyleBackColor = true;
            this.suppressRepPhrases.CheckedChanged += new System.EventHandler(this.suppressRepPhrases_CheckedChanged);
            // 
            // alwaysOnTop
            // 
            this.alwaysOnTop.AutoSize = true;
            this.alwaysOnTop.Location = new System.Drawing.Point(8, 162);
            this.alwaysOnTop.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.alwaysOnTop.Name = "alwaysOnTop";
            this.alwaysOnTop.Size = new System.Drawing.Size(112, 20);
            this.alwaysOnTop.TabIndex = 5;
            this.alwaysOnTop.Text = "Always on top";
            this.alwaysOnTop.UseVisualStyleBackColor = true;
            this.alwaysOnTop.CheckedChanged += new System.EventHandler(this.alwaysOnTop_CheckedChanged);
            // 
            // autoCopyLabel
            // 
            this.autoCopyLabel.AutoSize = true;
            this.autoCopyLabel.Location = new System.Drawing.Point(245, 2);
            this.autoCopyLabel.Margin = new System.Windows.Forms.Padding(1, 2, 0, 0);
            this.autoCopyLabel.Name = "autoCopyLabel";
            this.autoCopyLabel.Size = new System.Drawing.Size(25, 16);
            this.autoCopyLabel.TabIndex = 7;
            this.autoCopyLabel.Text = "ms";
            // 
            // removeRepsLabel
            // 
            this.removeRepsLabel.AutoSize = true;
            this.removeRepsLabel.Location = new System.Drawing.Point(134, 101);
            this.removeRepsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.removeRepsLabel.Name = "removeRepsLabel";
            this.removeRepsLabel.Size = new System.Drawing.Size(163, 16);
            this.removeRepsLabel.TabIndex = 9;
            this.removeRepsLabel.Text = "repetitions of each symbol";
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.Location = new System.Drawing.Point(291, 4);
            this.xLabel1.Margin = new System.Windows.Forms.Padding(1, 4, 0, 0);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(14, 16);
            this.xLabel1.TabIndex = 12;
            this.xLabel1.Text = "×";
            // 
            // xLabel2
            // 
            this.xLabel2.AutoSize = true;
            this.xLabel2.Location = new System.Drawing.Point(236, 195);
            this.xLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xLabel2.Name = "xLabel2";
            this.xLabel2.Size = new System.Drawing.Size(14, 16);
            this.xLabel2.TabIndex = 15;
            this.xLabel2.Text = "×";
            // 
            // xLabel3
            // 
            this.xLabel3.AutoSize = true;
            this.xLabel3.Location = new System.Drawing.Point(298, 195);
            this.xLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xLabel3.Name = "xLabel3";
            this.xLabel3.Size = new System.Drawing.Size(14, 16);
            this.xLabel3.TabIndex = 17;
            this.xLabel3.Text = "×";
            // 
            // splitParamsLabel
            // 
            this.splitParamsLabel.AutoSize = true;
            this.splitParamsLabel.Location = new System.Drawing.Point(4, 195);
            this.splitParamsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.splitParamsLabel.Name = "splitParamsLabel";
            this.splitParamsLabel.Size = new System.Drawing.Size(170, 16);
            this.splitParamsLabel.TabIndex = 18;
            this.splitParamsLabel.Text = "Paragraph split parameters";
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.Location = new System.Drawing.Point(4, 229);
            this.optionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(53, 16);
            this.optionsLabel.TabIndex = 19;
            this.optionsLabel.Text = "Options";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.okButton.Location = new System.Drawing.Point(298, 326);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(69, 28);
            this.okButton.TabIndex = 15;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cancelButton.Location = new System.Drawing.Point(374, 326);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(69, 28);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(352, 225);
            this.helpButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(69, 28);
            this.helpButton.TabIndex = 11;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.agthTab);
            this.tabControl.Controls.Add(this.resolutionTab);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(432, 308);
            this.tabControl.TabIndex = 0;
            // 
            // agthTab
            // 
            this.agthTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.agthTab.Controls.Add(this.useChiiTrans);
            this.agthTab.Controls.Add(this.suppressRepPanel);
            this.agthTab.Controls.Add(this.autoCopyPanel);
            this.agthTab.Controls.Add(this.removeRepsCount);
            this.agthTab.Controls.Add(this.splitParam3);
            this.agthTab.Controls.Add(this.options);
            this.agthTab.Controls.Add(this.splitParam2);
            this.agthTab.Controls.Add(this.splitParam1);
            this.agthTab.Controls.Add(this.useAgth);
            this.agthTab.Controls.Add(this.helpButton);
            this.agthTab.Controls.Add(this.removeRepSymbols);
            this.agthTab.Controls.Add(this.alwaysOnTop);
            this.agthTab.Controls.Add(this.optionsLabel);
            this.agthTab.Controls.Add(this.splitParamsLabel);
            this.agthTab.Controls.Add(this.xLabel3);
            this.agthTab.Controls.Add(this.removeRepsLabel);
            this.agthTab.Controls.Add(this.xLabel2);
            this.agthTab.Location = new System.Drawing.Point(4, 25);
            this.agthTab.Margin = new System.Windows.Forms.Padding(2);
            this.agthTab.Name = "agthTab";
            this.agthTab.Padding = new System.Windows.Forms.Padding(2);
            this.agthTab.Size = new System.Drawing.Size(424, 279);
            this.agthTab.TabIndex = 0;
            this.agthTab.Text = "Translator";
            // 
            // useChiiTrans
            // 
            this.useChiiTrans.AutoSize = true;
            this.useChiiTrans.Location = new System.Drawing.Point(8, 38);
            this.useChiiTrans.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.useChiiTrans.Name = "useChiiTrans";
            this.useChiiTrans.Size = new System.Drawing.Size(176, 20);
            this.useChiiTrans.TabIndex = 20;
            this.useChiiTrans.Text = "Run game with ChiiTrans";
            this.useChiiTrans.UseVisualStyleBackColor = true;
            this.useChiiTrans.CheckedChanged += new System.EventHandler(this.useChiiTrans_CheckedChanged);
            // 
            // suppressRepPanel
            // 
            this.suppressRepPanel.AutoSize = true;
            this.suppressRepPanel.Controls.Add(this.suppressRepPhrases);
            this.suppressRepPanel.Controls.Add(this.traceParam1);
            this.suppressRepPanel.Controls.Add(this.xLabel1);
            this.suppressRepPanel.Controls.Add(this.traceParam2);
            this.suppressRepPanel.Location = new System.Drawing.Point(8, 131);
            this.suppressRepPanel.Margin = new System.Windows.Forms.Padding(2);
            this.suppressRepPanel.Name = "suppressRepPanel";
            this.suppressRepPanel.Size = new System.Drawing.Size(415, 28);
            this.suppressRepPanel.TabIndex = 4;
            this.suppressRepPanel.WrapContents = false;
            // 
            // traceParam1
            // 
            this.traceParam1.Location = new System.Drawing.Point(247, 0);
            this.traceParam1.Margin = new System.Windows.Forms.Padding(0);
            this.traceParam1.Name = "traceParam1";
            this.traceParam1.Size = new System.Drawing.Size(43, 22);
            this.traceParam1.TabIndex = 10;
            this.traceParam1.Text = "32";
            this.traceParam1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.traceParam1.TextChanged += new System.EventHandler(this.traceParam1_TextChanged);
            this.traceParam1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBox_KeyPress);
            // 
            // traceParam2
            // 
            this.traceParam2.Location = new System.Drawing.Point(305, 0);
            this.traceParam2.Margin = new System.Windows.Forms.Padding(0);
            this.traceParam2.Name = "traceParam2";
            this.traceParam2.Size = new System.Drawing.Size(43, 22);
            this.traceParam2.TabIndex = 11;
            this.traceParam2.Text = "16";
            this.traceParam2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.traceParam2.TextChanged += new System.EventHandler(this.traceParam2_TextChanged);
            this.traceParam2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBox_KeyPress);
            // 
            // autoCopyPanel
            // 
            this.autoCopyPanel.AutoSize = true;
            this.autoCopyPanel.Controls.Add(this.autoCopy);
            this.autoCopyPanel.Controls.Add(this.autoCopyDelay);
            this.autoCopyPanel.Controls.Add(this.autoCopyLabel);
            this.autoCopyPanel.Location = new System.Drawing.Point(8, 69);
            this.autoCopyPanel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.autoCopyPanel.Name = "autoCopyPanel";
            this.autoCopyPanel.Size = new System.Drawing.Size(362, 28);
            this.autoCopyPanel.TabIndex = 1;
            this.autoCopyPanel.WrapContents = false;
            // 
            // autoCopyDelay
            // 
            this.autoCopyDelay.Location = new System.Drawing.Point(192, 0);
            this.autoCopyDelay.Margin = new System.Windows.Forms.Padding(0);
            this.autoCopyDelay.Name = "autoCopyDelay";
            this.autoCopyDelay.Size = new System.Drawing.Size(52, 22);
            this.autoCopyDelay.TabIndex = 6;
            this.autoCopyDelay.Text = "150";
            this.autoCopyDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.autoCopyDelay.TextChanged += new System.EventHandler(this.autoCopyDelay_TextChanged);
            this.autoCopyDelay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBox_KeyPress);
            // 
            // removeRepsCount
            // 
            this.removeRepsCount.Location = new System.Drawing.Point(88, 99);
            this.removeRepsCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeRepsCount.Name = "removeRepsCount";
            this.removeRepsCount.Size = new System.Drawing.Size(43, 22);
            this.removeRepsCount.TabIndex = 3;
            this.removeRepsCount.Text = "1";
            this.removeRepsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.removeRepsCount.TextChanged += new System.EventHandler(this.removeRepsCount_TextChanged);
            this.removeRepsCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBox_KeyPress);
            // 
            // splitParam3
            // 
            this.splitParam3.Location = new System.Drawing.Point(314, 191);
            this.splitParam3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitParam3.Name = "splitParam3";
            this.splitParam3.Size = new System.Drawing.Size(43, 22);
            this.splitParam3.TabIndex = 8;
            this.splitParam3.Text = "1000";
            this.splitParam3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.splitParam3.TextChanged += new System.EventHandler(this.splitParam3_TextChanged);
            this.splitParam3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBox_KeyPress);
            // 
            // options
            // 
            this.options.Location = new System.Drawing.Point(68, 225);
            this.options.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(276, 22);
            this.options.TabIndex = 9;
            // 
            // splitParam2
            // 
            this.splitParam2.Location = new System.Drawing.Point(252, 191);
            this.splitParam2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitParam2.Name = "splitParam2";
            this.splitParam2.Size = new System.Drawing.Size(43, 22);
            this.splitParam2.TabIndex = 7;
            this.splitParam2.Text = "24";
            this.splitParam2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.splitParam2.TextChanged += new System.EventHandler(this.splitParam2_TextChanged);
            this.splitParam2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBox_KeyPress);
            // 
            // splitParam1
            // 
            this.splitParam1.Location = new System.Drawing.Point(192, 191);
            this.splitParam1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitParam1.Name = "splitParam1";
            this.splitParam1.Size = new System.Drawing.Size(43, 22);
            this.splitParam1.TabIndex = 6;
            this.splitParam1.Text = "4";
            this.splitParam1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.splitParam1.TextChanged += new System.EventHandler(this.splitParam1_TextChanged);
            this.splitParam1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBox_KeyPress);
            // 
            // resolutionTab
            // 
            this.resolutionTab.Controls.Add(this.resolutionGroup);
            this.resolutionTab.Location = new System.Drawing.Point(4, 25);
            this.resolutionTab.Margin = new System.Windows.Forms.Padding(2);
            this.resolutionTab.Name = "resolutionTab";
            this.resolutionTab.Padding = new System.Windows.Forms.Padding(2);
            this.resolutionTab.Size = new System.Drawing.Size(424, 279);
            this.resolutionTab.TabIndex = 1;
            this.resolutionTab.Text = "Resolution";
            this.resolutionTab.UseVisualStyleBackColor = true;
            // 
            // resolutionGroup
            // 
            this.resolutionGroup.Controls.Add(this.resolutionList);
            this.resolutionGroup.Location = new System.Drawing.Point(15, 15);
            this.resolutionGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resolutionGroup.Name = "resolutionGroup";
            this.resolutionGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resolutionGroup.Size = new System.Drawing.Size(388, 68);
            this.resolutionGroup.TabIndex = 7;
            this.resolutionGroup.TabStop = false;
            this.resolutionGroup.Text = "Desktop resolution while running this game";
            // 
            // resolutionList
            // 
            this.resolutionList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resolutionList.FormattingEnabled = true;
            this.resolutionList.Location = new System.Drawing.Point(8, 28);
            this.resolutionList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resolutionList.Name = "resolutionList";
            this.resolutionList.Size = new System.Drawing.Size(123, 24);
            this.resolutionList.TabIndex = 1;
            // 
            // restoreButton
            // 
            this.restoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.restoreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.restoreButton.Location = new System.Drawing.Point(12, 326);
            this.restoreButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(134, 28);
            this.restoreButton.TabIndex = 13;
            this.restoreButton.Text = "Restore defaults";
            this.restoreButton.UseVisualStyleBackColor = false;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // GamePropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(456, 365);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.restoreButton);
            this.Controls.Add(this.tabControl);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GamePropertiesForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Properties";
            this.tabControl.ResumeLayout(false);
            this.agthTab.ResumeLayout(false);
            this.agthTab.PerformLayout();
            this.suppressRepPanel.ResumeLayout(false);
            this.suppressRepPanel.PerformLayout();
            this.autoCopyPanel.ResumeLayout(false);
            this.autoCopyPanel.PerformLayout();
            this.resolutionTab.ResumeLayout(false);
            this.resolutionGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox useAgth;
        private System.Windows.Forms.CheckBox autoCopy;
        private System.Windows.Forms.CheckBox removeRepSymbols;
        private System.Windows.Forms.CheckBox suppressRepPhrases;
        private System.Windows.Forms.CheckBox alwaysOnTop;
        private System.Windows.Forms.Label autoCopyLabel;
        private System.Windows.Forms.Label xLabel1;
        private System.Windows.Forms.Label xLabel2;
        private System.Windows.Forms.Label xLabel3;
        private System.Windows.Forms.Label splitParamsLabel;
        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label removeRepsLabel;
        private System.Windows.Forms.Button helpButton;
        private TweakedTextBox removeRepsCount;
        private TweakedTextBox traceParam1;
        private TweakedTextBox traceParam2;
        private TweakedTextBox splitParam2;
        private TweakedTextBox splitParam1;
        private TweakedTextBox splitParam3;
        private TweakedTextBox options;
        private TweakedTextBox autoCopyDelay;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage agthTab;
        private System.Windows.Forms.TabPage resolutionTab;
        private System.Windows.Forms.GroupBox resolutionGroup;
        private System.Windows.Forms.ComboBox resolutionList;
        private System.Windows.Forms.Button restoreButton;
        private System.Windows.Forms.FlowLayoutPanel autoCopyPanel;
        private System.Windows.Forms.FlowLayoutPanel suppressRepPanel;
        private System.Windows.Forms.CheckBox useChiiTrans;
    }
}
