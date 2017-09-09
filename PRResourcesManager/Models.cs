using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PRResourcesManager {
	[Flags]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Direction : byte {
		None = 0,
		North = 1 << 0,
		South = 1 << 1,
		West = 1 << 2,
		East = 1 << 3,
		NorthWest = 1 << 4,
		NorthEast = 1 << 5,
		SouthWest = 1 << 6,
		SouthEast = 1 << 7
	};

	public class Exts {
		// https://stackoverflow.com/questions/1922040/resize-an-image-c-sharp
		/// <summary>
		/// Resize the image to the specified width and height.
		/// </summary>
		/// <param name="image">The image to resize.</param>
		/// <param name="width">The width to resize to.</param>
		/// <param name="height">The height to resize to.</param>
		/// <returns>The resized image.</returns>
		public static Bitmap ResizeImage(Image image, int width, int height, int offsetX = 0, int offsetY = 0) {
			var destRect = new Rectangle(offsetX, offsetY, width, height);
			var destImage = new Bitmap(width, height);

			destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

			using (var graphics = Graphics.FromImage(destImage)) {
				graphics.CompositingMode = CompositingMode.SourceCopy;
				graphics.CompositingQuality = CompositingQuality.HighSpeed;
				graphics.InterpolationMode = InterpolationMode.Low;
				graphics.SmoothingMode = SmoothingMode.HighSpeed;
				graphics.PixelOffsetMode = PixelOffsetMode.HighSpeed;

				using (var wrapMode = new ImageAttributes()) {
					wrapMode.SetWrapMode(WrapMode.TileFlipXY);
					graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
				}
			}

			return destImage;
		}
	}

	public class PRResourceFile {
		public List<SpriteSheet> SpriteSheets;
		public List<Pattern> Patterns;
		public List<SpriteSet> SpriteSets;
	}

	public class SpriteSheet {
		public string Id { get; set; }
		public string File { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }
		public string Style { get; set; }
		public bool MixWithOwnStyle { get; set; }
		public string LinkedSheetId { get; set; }
	}

	public class Pattern {
		public string Id { get; set; }
		public string PreviewSheetId { get; set; }
		public int PreviewX { get; set; }
		public int PreviewY { get; set; }
		public List<PatternTile> Tiles { get; set; }

		public void CleanupTiles() {
			Tiles.RemoveAll(t => t.Directions == Direction.None);
		}

		public PatternTile GetTile(int x, int y) {
			if (Tiles == null)
				Tiles = new List<PatternTile>();
			var tile = Tiles.FirstOrDefault(t => t.X == x && t.Y == y);
			if (tile == null) {
				tile = new PatternTile() {
					X = x,
					Y = y
				};
				Tiles.Add(tile);
			}
			return tile;
		}
	}
	
	public class PatternTile {
		public int X { get; set; }
		public int Y { get; set; }
		public Direction Directions { get; set; }
	}

	public class SpriteSet {
		public string Id;
		public string SheetId;
		public string RepresentSetId;
		public List<SpriteSetTile> TileLocations;
	}

	public class SpriteSetTile {
		public string Id;
		public int X;
		public int Y;
	}
}
