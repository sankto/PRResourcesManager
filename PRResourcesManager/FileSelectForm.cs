using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PRResourcesManager {
	public partial class FileSelectForm : Form {
		public FileSelectForm() {
			InitializeComponent();
			FileBox.Text = Properties.Settings.Default.ResourceFilepath;
		}

		private void BrowseButton_Click(object sender, EventArgs e) {
			using (var dialog = new OpenFileDialog() { InitialDirectory = FileBox.Text }) {
				if (dialog.ShowDialog() == DialogResult.OK) {
					FileBox.Text = dialog.FileName;
				}
			}
		}

		private void LoadButton_Click(object sender, EventArgs e) {
			Properties.Settings.Default.ResourceFilepath = FileBox.Text;
			Properties.Settings.Default.Save();

			var resfile = JsonConvert.DeserializeObject<PRResourceFile>(File.ReadAllText(FileBox.Text));

			Hide();
			new SpriteForm(resfile).Show();
		}

		private void FileBox_TextChanged(object sender, EventArgs e) {
			LoadButton.Enabled = FileBox.Text.Length > 0;
		}
	}
}
