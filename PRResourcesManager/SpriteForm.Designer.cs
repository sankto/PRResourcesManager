namespace PRResourcesManager {
	partial class SpriteForm {
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
			this.MainTabs = new System.Windows.Forms.TabControl();
			this.PatternsTab = new System.Windows.Forms.TabPage();
			this.PatternPreviewOffsetYBox = new System.Windows.Forms.NumericUpDown();
			this.PatternPreviewOffsetXBox = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.PatternPreviewBox = new System.Windows.Forms.ComboBox();
			this.PatternBox = new System.Windows.Forms.PictureBox();
			this.PatternSEBox = new System.Windows.Forms.CheckBox();
			this.PatternSBox = new System.Windows.Forms.CheckBox();
			this.PatternSWBox = new System.Windows.Forms.CheckBox();
			this.PatternEBox = new System.Windows.Forms.CheckBox();
			this.PatternNoneBox = new System.Windows.Forms.CheckBox();
			this.PatternWBox = new System.Windows.Forms.CheckBox();
			this.PatternNEBox = new System.Windows.Forms.CheckBox();
			this.PatternNBox = new System.Windows.Forms.CheckBox();
			this.PatternNWBox = new System.Windows.Forms.CheckBox();
			this.PatternIdBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.PatternsList = new System.Windows.Forms.ListBox();
			this.SheetsTab = new System.Windows.Forms.TabPage();
			this.PreviewPanel = new System.Windows.Forms.Panel();
			this.PreviewBox = new System.Windows.Forms.PictureBox();
			this.SheetMixBox = new System.Windows.Forms.CheckBox();
			this.SheetStyleBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SheetBrowseButton = new System.Windows.Forms.Button();
			this.SheetFileBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SheetIdBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SheetsList = new System.Windows.Forms.ListBox();
			this.SetsTab = new System.Windows.Forms.TabPage();
			this.PatternDirectionsPanel = new System.Windows.Forms.Panel();
			this.MainTabs.SuspendLayout();
			this.PatternsTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PatternPreviewOffsetYBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PatternPreviewOffsetXBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PatternBox)).BeginInit();
			this.SheetsTab.SuspendLayout();
			this.PreviewPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).BeginInit();
			this.PatternDirectionsPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainTabs
			// 
			this.MainTabs.Controls.Add(this.PatternsTab);
			this.MainTabs.Controls.Add(this.SheetsTab);
			this.MainTabs.Controls.Add(this.SetsTab);
			this.MainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainTabs.Location = new System.Drawing.Point(0, 0);
			this.MainTabs.Name = "MainTabs";
			this.MainTabs.SelectedIndex = 0;
			this.MainTabs.Size = new System.Drawing.Size(871, 522);
			this.MainTabs.TabIndex = 0;
			// 
			// PatternsTab
			// 
			this.PatternsTab.Controls.Add(this.PatternDirectionsPanel);
			this.PatternsTab.Controls.Add(this.PatternPreviewOffsetYBox);
			this.PatternsTab.Controls.Add(this.PatternPreviewOffsetXBox);
			this.PatternsTab.Controls.Add(this.label7);
			this.PatternsTab.Controls.Add(this.label6);
			this.PatternsTab.Controls.Add(this.label5);
			this.PatternsTab.Controls.Add(this.PatternPreviewBox);
			this.PatternsTab.Controls.Add(this.PatternBox);
			this.PatternsTab.Controls.Add(this.PatternIdBox);
			this.PatternsTab.Controls.Add(this.label4);
			this.PatternsTab.Controls.Add(this.PatternsList);
			this.PatternsTab.Location = new System.Drawing.Point(4, 22);
			this.PatternsTab.Name = "PatternsTab";
			this.PatternsTab.Size = new System.Drawing.Size(863, 496);
			this.PatternsTab.TabIndex = 2;
			this.PatternsTab.Text = "Sheet Patterns";
			this.PatternsTab.UseVisualStyleBackColor = true;
			// 
			// PatternPreviewOffsetYBox
			// 
			this.PatternPreviewOffsetYBox.Location = new System.Drawing.Point(450, 97);
			this.PatternPreviewOffsetYBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.PatternPreviewOffsetYBox.Name = "PatternPreviewOffsetYBox";
			this.PatternPreviewOffsetYBox.Size = new System.Drawing.Size(43, 20);
			this.PatternPreviewOffsetYBox.TabIndex = 20;
			// 
			// PatternPreviewOffsetXBox
			// 
			this.PatternPreviewOffsetXBox.Location = new System.Drawing.Point(450, 62);
			this.PatternPreviewOffsetXBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.PatternPreviewOffsetXBox.Name = "PatternPreviewOffsetXBox";
			this.PatternPreviewOffsetXBox.Size = new System.Drawing.Size(43, 20);
			this.PatternPreviewOffsetXBox.TabIndex = 19;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(354, 99);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(90, 13);
			this.label7.TabIndex = 18;
			this.label7.Text = "Preview offset Y :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(354, 64);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(90, 13);
			this.label6.TabIndex = 17;
			this.label6.Text = "Preview offset X :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(351, 146);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(225, 13);
			this.label5.TabIndex = 16;
			this.label5.Text = "Use this Sheet as background (Preview only) :";
			// 
			// PatternPreviewBox
			// 
			this.PatternPreviewBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PatternPreviewBox.FormattingEnabled = true;
			this.PatternPreviewBox.Location = new System.Drawing.Point(351, 165);
			this.PatternPreviewBox.Name = "PatternPreviewBox";
			this.PatternPreviewBox.Size = new System.Drawing.Size(179, 21);
			this.PatternPreviewBox.TabIndex = 15;
			// 
			// PatternBox
			// 
			this.PatternBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PatternBox.BackColor = System.Drawing.Color.Black;
			this.PatternBox.Location = new System.Drawing.Point(181, 204);
			this.PatternBox.Name = "PatternBox";
			this.PatternBox.Size = new System.Drawing.Size(674, 284);
			this.PatternBox.TabIndex = 14;
			this.PatternBox.TabStop = false;
			// 
			// PatternSEBox
			// 
			this.PatternSEBox.Appearance = System.Windows.Forms.Appearance.Button;
			this.PatternSEBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PatternSEBox.Location = new System.Drawing.Point(103, 104);
			this.PatternSEBox.Name = "PatternSEBox";
			this.PatternSEBox.Size = new System.Drawing.Size(41, 41);
			this.PatternSEBox.TabIndex = 13;
			this.PatternSEBox.TabStop = false;
			this.PatternSEBox.Text = "SE";
			this.PatternSEBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.PatternSEBox.UseVisualStyleBackColor = true;
			// 
			// PatternSBox
			// 
			this.PatternSBox.Appearance = System.Windows.Forms.Appearance.Button;
			this.PatternSBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PatternSBox.Location = new System.Drawing.Point(56, 104);
			this.PatternSBox.Name = "PatternSBox";
			this.PatternSBox.Size = new System.Drawing.Size(41, 41);
			this.PatternSBox.TabIndex = 12;
			this.PatternSBox.TabStop = false;
			this.PatternSBox.Text = "S";
			this.PatternSBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.PatternSBox.UseVisualStyleBackColor = true;
			// 
			// PatternSWBox
			// 
			this.PatternSWBox.Appearance = System.Windows.Forms.Appearance.Button;
			this.PatternSWBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PatternSWBox.Location = new System.Drawing.Point(9, 104);
			this.PatternSWBox.Name = "PatternSWBox";
			this.PatternSWBox.Size = new System.Drawing.Size(41, 41);
			this.PatternSWBox.TabIndex = 11;
			this.PatternSWBox.TabStop = false;
			this.PatternSWBox.Text = "SW";
			this.PatternSWBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.PatternSWBox.UseVisualStyleBackColor = true;
			// 
			// PatternEBox
			// 
			this.PatternEBox.Appearance = System.Windows.Forms.Appearance.Button;
			this.PatternEBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PatternEBox.Location = new System.Drawing.Point(103, 57);
			this.PatternEBox.Name = "PatternEBox";
			this.PatternEBox.Size = new System.Drawing.Size(41, 41);
			this.PatternEBox.TabIndex = 10;
			this.PatternEBox.TabStop = false;
			this.PatternEBox.Text = "E";
			this.PatternEBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.PatternEBox.UseVisualStyleBackColor = true;
			// 
			// PatternNoneBox
			// 
			this.PatternNoneBox.Appearance = System.Windows.Forms.Appearance.Button;
			this.PatternNoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PatternNoneBox.Location = new System.Drawing.Point(56, 57);
			this.PatternNoneBox.Name = "PatternNoneBox";
			this.PatternNoneBox.Size = new System.Drawing.Size(41, 41);
			this.PatternNoneBox.TabIndex = 9;
			this.PatternNoneBox.TabStop = false;
			this.PatternNoneBox.Text = "None";
			this.PatternNoneBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.PatternNoneBox.UseVisualStyleBackColor = true;
			// 
			// PatternWBox
			// 
			this.PatternWBox.Appearance = System.Windows.Forms.Appearance.Button;
			this.PatternWBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PatternWBox.Location = new System.Drawing.Point(9, 57);
			this.PatternWBox.Name = "PatternWBox";
			this.PatternWBox.Size = new System.Drawing.Size(41, 41);
			this.PatternWBox.TabIndex = 8;
			this.PatternWBox.TabStop = false;
			this.PatternWBox.Text = "W";
			this.PatternWBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.PatternWBox.UseVisualStyleBackColor = true;
			// 
			// PatternNEBox
			// 
			this.PatternNEBox.Appearance = System.Windows.Forms.Appearance.Button;
			this.PatternNEBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PatternNEBox.Location = new System.Drawing.Point(103, 10);
			this.PatternNEBox.Name = "PatternNEBox";
			this.PatternNEBox.Size = new System.Drawing.Size(41, 41);
			this.PatternNEBox.TabIndex = 7;
			this.PatternNEBox.TabStop = false;
			this.PatternNEBox.Text = "NE";
			this.PatternNEBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.PatternNEBox.UseVisualStyleBackColor = true;
			// 
			// PatternNBox
			// 
			this.PatternNBox.Appearance = System.Windows.Forms.Appearance.Button;
			this.PatternNBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PatternNBox.Location = new System.Drawing.Point(56, 10);
			this.PatternNBox.Name = "PatternNBox";
			this.PatternNBox.Size = new System.Drawing.Size(41, 41);
			this.PatternNBox.TabIndex = 6;
			this.PatternNBox.TabStop = false;
			this.PatternNBox.Text = "N";
			this.PatternNBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.PatternNBox.UseVisualStyleBackColor = true;
			// 
			// PatternNWBox
			// 
			this.PatternNWBox.Appearance = System.Windows.Forms.Appearance.Button;
			this.PatternNWBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PatternNWBox.Location = new System.Drawing.Point(9, 10);
			this.PatternNWBox.Name = "PatternNWBox";
			this.PatternNWBox.Size = new System.Drawing.Size(41, 41);
			this.PatternNWBox.TabIndex = 5;
			this.PatternNWBox.TabStop = false;
			this.PatternNWBox.Text = "NW";
			this.PatternNWBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.PatternNWBox.UseVisualStyleBackColor = true;
			// 
			// PatternIdBox
			// 
			this.PatternIdBox.Location = new System.Drawing.Point(202, 8);
			this.PatternIdBox.Name = "PatternIdBox";
			this.PatternIdBox.Size = new System.Drawing.Size(136, 20);
			this.PatternIdBox.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(178, 11);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(18, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "ID";
			// 
			// PatternsList
			// 
			this.PatternsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.PatternsList.FormattingEnabled = true;
			this.PatternsList.Location = new System.Drawing.Point(8, 8);
			this.PatternsList.Name = "PatternsList";
			this.PatternsList.Size = new System.Drawing.Size(156, 485);
			this.PatternsList.TabIndex = 1;
			// 
			// SheetsTab
			// 
			this.SheetsTab.Controls.Add(this.PreviewPanel);
			this.SheetsTab.Controls.Add(this.SheetMixBox);
			this.SheetsTab.Controls.Add(this.SheetStyleBox);
			this.SheetsTab.Controls.Add(this.label3);
			this.SheetsTab.Controls.Add(this.SheetBrowseButton);
			this.SheetsTab.Controls.Add(this.SheetFileBox);
			this.SheetsTab.Controls.Add(this.label2);
			this.SheetsTab.Controls.Add(this.SheetIdBox);
			this.SheetsTab.Controls.Add(this.label1);
			this.SheetsTab.Controls.Add(this.SheetsList);
			this.SheetsTab.Location = new System.Drawing.Point(4, 22);
			this.SheetsTab.Name = "SheetsTab";
			this.SheetsTab.Padding = new System.Windows.Forms.Padding(3);
			this.SheetsTab.Size = new System.Drawing.Size(863, 496);
			this.SheetsTab.TabIndex = 0;
			this.SheetsTab.Text = "SpriteSheets";
			this.SheetsTab.UseVisualStyleBackColor = true;
			// 
			// PreviewPanel
			// 
			this.PreviewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PreviewPanel.AutoScroll = true;
			this.PreviewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PreviewPanel.Controls.Add(this.PreviewBox);
			this.PreviewPanel.Location = new System.Drawing.Point(454, 7);
			this.PreviewPanel.Name = "PreviewPanel";
			this.PreviewPanel.Size = new System.Drawing.Size(403, 481);
			this.PreviewPanel.TabIndex = 11;
			// 
			// PreviewBox
			// 
			this.PreviewBox.Location = new System.Drawing.Point(3, 3);
			this.PreviewBox.Name = "PreviewBox";
			this.PreviewBox.Size = new System.Drawing.Size(237, 233);
			this.PreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PreviewBox.TabIndex = 10;
			this.PreviewBox.TabStop = false;
			// 
			// SheetMixBox
			// 
			this.SheetMixBox.AutoSize = true;
			this.SheetMixBox.Location = new System.Drawing.Point(171, 96);
			this.SheetMixBox.Name = "SheetMixBox";
			this.SheetMixBox.Size = new System.Drawing.Size(239, 17);
			this.SheetMixBox.TabIndex = 9;
			this.SheetMixBox.Text = "Mix with other tiles with the same style name?";
			this.SheetMixBox.UseVisualStyleBackColor = true;
			// 
			// SheetStyleBox
			// 
			this.SheetStyleBox.Location = new System.Drawing.Point(235, 70);
			this.SheetStyleBox.Name = "SheetStyleBox";
			this.SheetStyleBox.Size = new System.Drawing.Size(136, 20);
			this.SheetStyleBox.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(168, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Style Name";
			// 
			// SheetBrowseButton
			// 
			this.SheetBrowseButton.Location = new System.Drawing.Point(334, 41);
			this.SheetBrowseButton.Name = "SheetBrowseButton";
			this.SheetBrowseButton.Size = new System.Drawing.Size(24, 23);
			this.SheetBrowseButton.TabIndex = 6;
			this.SheetBrowseButton.Text = "...";
			this.SheetBrowseButton.UseVisualStyleBackColor = true;
			this.SheetBrowseButton.Click += new System.EventHandler(this.SheetBrowseButton_Click);
			// 
			// SheetFileBox
			// 
			this.SheetFileBox.Location = new System.Drawing.Point(192, 43);
			this.SheetFileBox.Name = "SheetFileBox";
			this.SheetFileBox.Size = new System.Drawing.Size(136, 20);
			this.SheetFileBox.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(168, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(23, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "File";
			// 
			// SheetIdBox
			// 
			this.SheetIdBox.Location = new System.Drawing.Point(192, 16);
			this.SheetIdBox.Name = "SheetIdBox";
			this.SheetIdBox.Size = new System.Drawing.Size(136, 20);
			this.SheetIdBox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(168, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "ID";
			// 
			// SheetsList
			// 
			this.SheetsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.SheetsList.FormattingEnabled = true;
			this.SheetsList.Location = new System.Drawing.Point(6, 6);
			this.SheetsList.Name = "SheetsList";
			this.SheetsList.Size = new System.Drawing.Size(156, 485);
			this.SheetsList.TabIndex = 0;
			// 
			// SetsTab
			// 
			this.SetsTab.Location = new System.Drawing.Point(4, 22);
			this.SetsTab.Name = "SetsTab";
			this.SetsTab.Padding = new System.Windows.Forms.Padding(3);
			this.SetsTab.Size = new System.Drawing.Size(863, 496);
			this.SetsTab.TabIndex = 1;
			this.SetsTab.Text = "SpriteSets";
			this.SetsTab.UseVisualStyleBackColor = true;
			// 
			// PatternDirectionsPanel
			// 
			this.PatternDirectionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PatternDirectionsPanel.Controls.Add(this.PatternEBox);
			this.PatternDirectionsPanel.Controls.Add(this.PatternNWBox);
			this.PatternDirectionsPanel.Controls.Add(this.PatternNBox);
			this.PatternDirectionsPanel.Controls.Add(this.PatternNEBox);
			this.PatternDirectionsPanel.Controls.Add(this.PatternWBox);
			this.PatternDirectionsPanel.Controls.Add(this.PatternNoneBox);
			this.PatternDirectionsPanel.Controls.Add(this.PatternSWBox);
			this.PatternDirectionsPanel.Controls.Add(this.PatternSBox);
			this.PatternDirectionsPanel.Controls.Add(this.PatternSEBox);
			this.PatternDirectionsPanel.Location = new System.Drawing.Point(181, 34);
			this.PatternDirectionsPanel.Name = "PatternDirectionsPanel";
			this.PatternDirectionsPanel.Size = new System.Drawing.Size(155, 158);
			this.PatternDirectionsPanel.TabIndex = 21;
			// 
			// SpriteForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(871, 522);
			this.Controls.Add(this.MainTabs);
			this.Name = "SpriteForm";
			this.Text = "Project Rogue - Resources Manager";
			this.MainTabs.ResumeLayout(false);
			this.PatternsTab.ResumeLayout(false);
			this.PatternsTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PatternPreviewOffsetYBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PatternPreviewOffsetXBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PatternBox)).EndInit();
			this.SheetsTab.ResumeLayout(false);
			this.SheetsTab.PerformLayout();
			this.PreviewPanel.ResumeLayout(false);
			this.PreviewPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).EndInit();
			this.PatternDirectionsPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl MainTabs;
		private System.Windows.Forms.TabPage SheetsTab;
		private System.Windows.Forms.ListBox SheetsList;
		private System.Windows.Forms.TabPage SetsTab;
		private System.Windows.Forms.CheckBox SheetMixBox;
		private System.Windows.Forms.TextBox SheetStyleBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button SheetBrowseButton;
		private System.Windows.Forms.TextBox SheetFileBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox SheetIdBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox PreviewBox;
		private System.Windows.Forms.Panel PreviewPanel;
		private System.Windows.Forms.TabPage PatternsTab;
		private System.Windows.Forms.TextBox PatternIdBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListBox PatternsList;
		private System.Windows.Forms.CheckBox PatternSEBox;
		private System.Windows.Forms.CheckBox PatternSBox;
		private System.Windows.Forms.CheckBox PatternSWBox;
		private System.Windows.Forms.CheckBox PatternEBox;
		private System.Windows.Forms.CheckBox PatternNoneBox;
		private System.Windows.Forms.CheckBox PatternWBox;
		private System.Windows.Forms.CheckBox PatternNEBox;
		private System.Windows.Forms.CheckBox PatternNBox;
		private System.Windows.Forms.CheckBox PatternNWBox;
		private System.Windows.Forms.PictureBox PatternBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox PatternPreviewBox;
		private System.Windows.Forms.NumericUpDown PatternPreviewOffsetYBox;
		private System.Windows.Forms.NumericUpDown PatternPreviewOffsetXBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel PatternDirectionsPanel;
	}
}

