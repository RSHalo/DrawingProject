﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrawingProject.Drawables;

namespace DrawingProject.Tools
{
    class Tool
    {
        public Canvas Canvas { get; set; }
        public bool IsDrawing { get; protected set; }
        public bool IsControlHeld { get; set; }

        /// <summary>The X co-ordinate of the tool's mouse position, in world space.</summary>
        public int WorldX { get; set; }
        /// <summary>The Y co-ordinate of the tool's mouse position, in world space.</summary>
        public int WorldY { get; set; }

        public Point WorldPoint => new Point(WorldX, WorldY);

        /// <summary>The shape to be drawn while the tool is creating a final result.</summary>
        // E.g. The rectangle that moves along with the mouse when you are drawing a rectangle.
        public IDrawable CreationDrawable { get; protected set; }

        public Cursor Cursor { get; protected set; } = Cursors.Default;

        /// <summary>Transforms screen coordinates to world co-ordinates and assigns them to the tool.</summary>
        public void UpdateWorldCoords(MouseEventArgs e)
        {
            // World coordinates will not equal screen coordinates if the canvas has been panned. We need to consider the offset caused by panning.
            WorldX = (int)(e.X - Canvas.OffsetX);
            WorldY = (int)(e.Y - Canvas.OffsetY);
        }

        public virtual void MouseDown(MouseEventArgs e)
        {

        }

        public virtual void MouseMoved(MouseEventArgs e)
        {

        }

        public virtual void MouseUp(MouseEventArgs e)
        {

        }

        public virtual void Clicked(MouseEventArgs e)
        {

        }
    }
}