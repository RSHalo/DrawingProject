﻿using DrawingProject.Drawables;
using DrawingProject.Resizing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingProject.Tools
{
    class Pointer : Tool
    {
        public override void MouseUp(MouseEventArgs e)
        {
			// Tell the Canvas what shape we hit. If no shape hit, value is null (because we are using FirstOrDefault).
			var shape = Canvas.Drawables.FirstOrDefault(d => d.HitTest(WorldX, WorldY));
			Canvas.UpdateSelection(shape);
        }
    }
}
