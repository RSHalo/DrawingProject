﻿using VectorGraphics.Drawables;
using VectorGraphics.Drawables.Resizable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorGraphics.Resizing.Rectangle
{
	class BottomRectangleResizer : RectangleResizer
	{
		public BottomRectangleResizer(IDrawableRectangle shape) : base(shape)
		{
			// Set the control to be displayed in the middle of the bottom line of the rectangle.
			WorldX = shape.Rectangle.X + (shape.Rectangle.Width / 2f) - (DefaultSideLength / 2f);
			WorldY = shape.Rectangle.Y + shape.Rectangle.Height - (DefaultSideLength / 2f);

			_cursor = Cursors.SizeNS;
		}

		protected override void ResizeShape()
		{
			int newHeight = RectangleHeight + DyWorld;

			_shape.Rectangle = new System.Drawing.Rectangle(RectangleX, RectangleY, RectangleWidth, newHeight);
		}

		protected override void MoveControl(MouseEventArgs e)
		{
			base.MoveControl(e);

			// Only move this control vertically.
			Top += dy;
		}

		protected override void UpdateWorldCoords()
		{
			WorldX = RectangleX + (RectangleWidth / 2f) - (DefaultSideLength / 2f);
			WorldY = RectangleY + RectangleHeight - (DefaultSideLength / 2f);
		}
	}
}
