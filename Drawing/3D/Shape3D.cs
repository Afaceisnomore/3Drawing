﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    abstract class Shape3D
    {
        abstract public void DrawLines(Painter painter);
        abstract public void DrawPolygons(Painter painter);
    }
}
