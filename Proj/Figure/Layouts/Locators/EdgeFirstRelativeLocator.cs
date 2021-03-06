﻿/*
 * Copyright (c) 2007-2012, Masahiko Kamo (mkamo@mkamo.com).
 * All Rights Reserved.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mkamo.Figure.Core;
using System.Drawing;

namespace Mkamo.Figure.Layouts.Locators {
    [Serializable]
    public class EdgeFirstRelativeLocator: ILocator {
        // ========================================
        // field
        // ========================================
        private Point _relativeLocation;

        // ========================================
        // constructor
        // ========================================
        public EdgeFirstRelativeLocator(Point relativeLocation) {
            _relativeLocation = relativeLocation;
        }

        // ========================================
        // property
        // ========================================

        // ========================================
        // method
        // ========================================
        public void Relocate(IFigure figure, IFigure parent) {
            var edge = (IEdge) parent;
            figure.Location = edge.First + (Size) _relativeLocation;
        }
    }
}
