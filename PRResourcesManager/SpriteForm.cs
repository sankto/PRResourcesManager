using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PRResourcesManager {
	public partial class SpriteForm : Form {
		const string PREVIEW_NONE = "(none)";
		const int CELL_SIZE = 32;

		PRResourceFile ResFile = null;
		bool IsChangingSheet = false;
		bool IsChangingPattern = false;

		PatternTile PatternSelectedTile = null;

		public SpriteForm(PRResourceFile resfile) {
			InitializeComponent();
			ResFile = resfile;

			FillSheets();
			FillPatterns();
			FillPatternPreviews();

			SheetsList.SelectedIndexChanged += SheetsList_SelectedIndexChanged;
			SheetIdBox.TextChanged += SheetIdBox_TextChanged;
			SheetFileBox.TextChanged += SheetFileBox_TextChanged;
			SheetStyleBox.TextChanged += SheetStyleBox_TextChanged;
			SheetMixBox.CheckedChanged += SheetMixBox_CheckedChanged;

			PatternsList.SelectedIndexChanged += PatternsList_SelectedIndexChanged;
			PatternIdBox.TextChanged += PatternIdBox_TextChanged;
			PatternPreviewOffsetXBox.ValueChanged += PatternPreviewOffsetXBox_ValueChanged;
			PatternPreviewOffsetYBox.ValueChanged += PatternPreviewOffsetYBox_ValueChanged;
			PatternPreviewBox.SelectionChangeCommitted += PatternPreviewBox_SelectionChangeCommitted;

			PatternBox.Paint += PatternBox_Paint;
			PatternBox.Click += PatternBox_Click;
		}

		private void PatternBox_Click(object sender, EventArgs e) {
			var loc = ((MouseEventArgs)e).Location;
			PatternSelectedTile = GetCurrentPattern().GetTile(
				loc.X / CELL_SIZE,
				loc.Y / CELL_SIZE
			);
			IsChangingPattern = true;
			PatternDirectionsPanel.Enabled = true;
			PatternSelectedTile.Directions = GetPatternDirections();
			RefreshPatternButtons(PatternSelectedTile);
			IsChangingPattern = false;
			PatternBox.Invalidate();
		}

		private void PatternIdBox_TextChanged(object sender, EventArgs e) {
			if (IsChangingPattern)
				return;
			GetCurrentPattern().Id = PatternIdBox.Text;
		}

		private void PatternPreviewOffsetXBox_ValueChanged(object sender, EventArgs e) {
			if (IsChangingPattern)
				return;
			var currentPattern = GetCurrentPattern();
			currentPattern.PreviewX = (int)PatternPreviewOffsetXBox.Value;
			SetPatternImage(currentPattern);
		}

		private void PatternPreviewOffsetYBox_ValueChanged(object sender, EventArgs e) {
			if (IsChangingPattern)
				return;
			var currentPattern = GetCurrentPattern();
			currentPattern.PreviewY = (int)PatternPreviewOffsetYBox.Value;
			SetPatternImage(currentPattern);
		}

		private void PatternPreviewBox_SelectionChangeCommitted(object sender, EventArgs e) {
			if (IsChangingPattern)
				return;
			var currentPattern = GetCurrentPattern();
			currentPattern.PreviewSheetId = PatternPreviewBox.SelectedItem as string;
			SetPatternImage(currentPattern);
		}

		private void PatternsList_SelectedIndexChanged(object sender, EventArgs e) {
			IsChangingPattern = true;
			ResetPatternDirections();

			var currentPattern = GetCurrentPattern();
			PatternIdBox.Text = currentPattern.Id ?? "";
			PatternPreviewOffsetXBox.Value = currentPattern.PreviewX;
			PatternPreviewOffsetYBox.Value = currentPattern.PreviewY;
			PatternPreviewBox.SelectedItem = currentPattern.PreviewSheetId;
			PatternSelectedTile = null;

			var isAnySelected = currentPattern.Id != null;
			PatternIdBox.Enabled = isAnySelected;
			PatternPreviewOffsetXBox.Enabled = isAnySelected;
			PatternPreviewOffsetYBox.Enabled = isAnySelected;
			PatternPreviewBox.Enabled = isAnySelected;
			PatternDirectionsPanel.Enabled = false;

			IsChangingPattern = false;

			SetPatternImage(currentPattern);
		}

		private void SheetMixBox_CheckedChanged(object sender, EventArgs e) {
			if (IsChangingSheet)
				return;
			GetCurrentSheet().MixWithOwnStyle = SheetMixBox.Checked;
		}

		private void SheetStyleBox_TextChanged(object sender, EventArgs e) {
			if (IsChangingSheet)
				return;
			GetCurrentSheet().Style = SheetStyleBox.Text;
		}

		private void SheetFileBox_TextChanged(object sender, EventArgs e) {
			if (IsChangingSheet)
				return;
			GetCurrentSheet().File = SheetFileBox.Text;
			SetImage(PreviewBox, SheetFileBox.Text);
		}

		private void SheetIdBox_TextChanged(object sender, EventArgs e) {
			if (IsChangingSheet)
				return;
			GetCurrentSheet().Id = SheetIdBox.Text;
			FillPatternPreviews();
		}

		private void SheetsList_SelectedIndexChanged(object sender, EventArgs e) {
			IsChangingSheet = true;
			var currentSheet = GetCurrentSheet();
			SheetIdBox.Text = currentSheet.Id ?? "";
			SheetFileBox.Text = currentSheet.File ?? "";
			SheetStyleBox.Text = currentSheet.Style ?? "";
			SheetMixBox.Checked = currentSheet.MixWithOwnStyle;

			var isAnySelected = currentSheet.Id != null;
			SheetIdBox.Enabled = isAnySelected;
			SheetFileBox.Enabled = isAnySelected;
			SheetStyleBox.Enabled = isAnySelected;
			SheetMixBox.Enabled = isAnySelected;
			SheetBrowseButton.Enabled = isAnySelected;
			IsChangingSheet = false;
		}

		private void PatternBox_Paint(object sender, PaintEventArgs e) {
			Graphics g = e.Graphics;
			int numOfCells = 200;
			Pen p = new Pen(Color.White);

			for (int y = 0; y < numOfCells; ++y)
				g.DrawLine(p, 0, y * CELL_SIZE, numOfCells * CELL_SIZE, y * CELL_SIZE);
			for (int x = 0; x < numOfCells; ++x)
				g.DrawLine(p, x * CELL_SIZE, 0, x * CELL_SIZE, numOfCells * CELL_SIZE);

			if (PatternSelectedTile != null) {
				Pen selP = new Pen(Color.Red);
				g.DrawRectangle(selP, new Rectangle(
					PatternSelectedTile.X * CELL_SIZE,
					PatternSelectedTile.Y * CELL_SIZE,
					CELL_SIZE, CELL_SIZE
				));
			}
		}

		protected override void OnFormClosed(FormClosedEventArgs e) {
			base.OnFormClosed(e);
			Application.Exit();
		}

		private void SheetBrowseButton_Click(object sender, EventArgs e) {
			var resFileDir = Path.GetDirectoryName(Properties.Settings.Default.ResourceFilepath) + @"\SpriteSheets\";
			using (var dialog = new OpenFileDialog()) {
				if (dialog.ShowDialog() == DialogResult.OK) {
					if (Directory.GetFiles(resFileDir, Path.GetFileName(dialog.FileName), SearchOption.AllDirectories).FirstOrDefault() != null) {
						SheetFileBox.Text = dialog.FileName.Remove(0, resFileDir.Length);
					} else {
						MessageBox.Show("The file must be in the directory of the main resource file, or one of its child folders.");
					}
				}
			}
		}

		private SpriteSheet GetCurrentSheet() {
			var result = ResFile.SpriteSheets.FirstOrDefault(s => s.Id == SheetsList.SelectedItem as string);
			return result ?? new SpriteSheet() { Id = null };
		}

		private Pattern GetCurrentPattern() {
			var result = ResFile.Patterns.FirstOrDefault(p => p.Id == PatternsList.SelectedItem as string);
			return result ?? new Pattern() { Id = null, PreviewSheetId = PREVIEW_NONE };
		}

		private void FillSheets() {
			IsChangingSheet = true;
			SheetsList.Items.Clear();
			SheetsList.Items.AddRange((from sheet in ResFile.SpriteSheets select sheet.Id).ToArray());
			IsChangingSheet = false;
			SheetsList_SelectedIndexChanged(null, null);
		}

		private void FillPatterns() {
			IsChangingPattern = true;
			PatternsList.Items.Clear();
			PatternsList.Items.AddRange((from pattern in ResFile.Patterns select pattern.Id).ToArray());
			IsChangingPattern = false;
			PatternsList_SelectedIndexChanged(null, null);
		}

		private void FillPatternPreviews() {
			IsChangingPattern = true;
			PatternPreviewBox.Items.Clear();
			PatternPreviewBox.Items.Add(PREVIEW_NONE);
			PatternPreviewBox.Items.AddRange((from sheet in ResFile.SpriteSheets select sheet.Id).ToArray());
			PatternPreviewBox.SelectedItem = GetCurrentPattern().PreviewSheetId;
			IsChangingPattern = false;

			SetPatternImage(GetCurrentPattern());
		}

		private void ResetPatternDirections() {
			foreach (var button in PatternDirectionsPanel.Controls.Cast<CheckBox>())
				button.Checked = false;
		}

		private Direction GetPatternDirections() {
			Direction result = Direction.None;
			if (PatternNWBox.Checked)
				result |= Direction.NorthWest;
			if (PatternNBox.Checked)
				result |= Direction.North;
			if (PatternNEBox.Checked)
				result |= Direction.NorthEast;

			if (PatternWBox.Checked)
				result |= Direction.West;
			if (PatternNoneBox.Checked)
				result |= Direction.None;
			if (PatternEBox.Checked)
				result |= Direction.East;

			if (PatternSWBox.Checked)
				result |= Direction.SouthWest;
			if (PatternSBox.Checked)
				result |= Direction.South;
			if (PatternSEBox.Checked)
				result |= Direction.SouthEast;
			return result;
		}

		private void RefreshPatternButtons(PatternTile tile) {
			ResetPatternDirections();
			if (tile.Directions.HasFlag(Direction.NorthWest))
				PatternNWBox.Checked = true;
			if (tile.Directions.HasFlag(Direction.North))
				PatternNBox.Checked = true;
			if (tile.Directions.HasFlag(Direction.NorthEast))
				PatternNEBox.Checked = true;

			if (tile.Directions.HasFlag(Direction.West))
				PatternWBox.Checked = true;
			if (tile.Directions.HasFlag(Direction.East))
				PatternEBox.Checked = true;

			if (tile.Directions.HasFlag(Direction.SouthWest))
				PatternSWBox.Checked = true;
			if (tile.Directions.HasFlag(Direction.South))
				PatternSBox.Checked = true;
			if (tile.Directions.HasFlag(Direction.SouthEast))
				PatternSEBox.Checked = true;
		}

		private void SetImage(PictureBox box, string relpath, int offsetX = 0, int offsetY = 0) {
			try {
				var resFileDir = Path.GetDirectoryName(Properties.Settings.Default.ResourceFilepath) + @"\SpriteSheets\";
				var img = Image.FromFile(resFileDir + relpath);
				box.Image = Exts.ResizeImage(img, img.Width * 2, img.Height * 2, offsetX, offsetY);
				//box.Image = new Bitmap(img, new Size(img.Width * 2, img.Height * 2));
			} catch {
				box.Image = null;
			}
		}

		private void SetPatternImage(Pattern currentPattern) {
			SetImage(
				PatternBox,
				ResFile.SpriteSheets.FirstOrDefault(s => s.Id == currentPattern.PreviewSheetId)?.File,
				currentPattern.PreviewX * 32,
				currentPattern.PreviewY * 32
			);
		}
	}
}
