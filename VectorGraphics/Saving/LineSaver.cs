﻿using VectorGraphics.Drawables;

namespace VectorGraphics.Saving
{
    class LineSaver : IShapeSaver
    {
        private readonly DrawableLine _line;

        public LineSaver(DrawableLine line)
        {
            _line = line;
        }

        public ShapeSaveData GetSaveData()
        {
            ShapeSaveData result = new ShapeSaveData(_line)
            {
                ShapeType = "Line"
            };
            result.ShapeData["StartX"] = _line.StartPoint.X.ToString();
            result.ShapeData["StartY"] = _line.StartPoint.Y.ToString();
            result.ShapeData["EndX"] = _line.EndPoint.X.ToString();
            result.ShapeData["EndY"] = _line.EndPoint.Y.ToString();
            return result;
        }
    }
}
