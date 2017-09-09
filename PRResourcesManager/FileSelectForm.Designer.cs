namespace PRResourcesManager {
	partial class FileSelectForm {
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
			this.FileBox = new System.Windows.Forms.TextBox();
			this.BrowseButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.LoadButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// FileBox
			// 
			this.FileBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FileBox.Location = new System.Drawing.Point(13, 25);
			this.FileBox.Name = "FileBox";
			this.FileBox.Size = new System.Drawing.Size(502, 20);
			this.FileBox.TabIndex = 1;
			this.FileBox.TextChanged += new System.EventHandler(this.FileBox_TextChanged);
			// 
			// BrowseButton
			// 
			this.BrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BrowseButton.Location = new System.Drawing.Point(526, 23);
			this.BrowseButton.Name = "BrowseButton";
			this.BrowseButton.Size = new System.Drawing.Size(29, 23);
			this.BrowseButton.TabIndex = 2;
			this.BrowseButton.Text = "...";
			this.BrowseButton.UseVisualStyleBackColor = true;
			this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Select the resource file :";
			// 
			// LoadButton
			// 
			this.LoadButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LoadButton.Enabled = false;
			this.LoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoadButton.Location = new System.Drawing.Point(13, 52);
			this.LoadButton.Name = "LoadButton";
			this.LoadButton.Size = new System.Drawing.Size(542, 23);
			this.LoadButton.TabIndex = 0;
			this.LoadButton.Text = "Load";
			this.LoadButton.UseVisualStyleBackColor = true;
			this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
			// 
			// FileSelectForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(567, 83);
			this.Controls.Add(this.LoadButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BrowseButton);
			this.Controls.Add(this.FileBox);
			this.MaximumSize = new System.Drawing.Size(1080, 122);
			this.MinimumSize = new System.Drawing.Size(252, 122);
			this.Name = "FileSelectForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Resource Selection";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox FileBox;
		private System.Windows.Forms.Button BrowseButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button LoadButton;
	}
}