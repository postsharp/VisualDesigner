﻿using Glass.Design.Pcl.Core;

namespace Glass.Design.Pcl.DesignSurface.VisualAids.Snapping
{
    public class GridSnappingEngine : SnappingEngine
    {
        public ISize GridSize { get; set; }        

        public GridSnappingEngine(ISize gridSize, double threshold)
            : base(threshold)
        {
            GridSize = gridSize;            
        }

        public override double SnapPoint(double pointToSnap)                   
        {                       
            var nearestGridX = MathOperations.NearestMultiple(pointToSnap, GridSize.Width);
            var x = MathOperations.Snap(pointToSnap, nearestGridX, Threshold);
            
            return x;
        
        }
    }
}