﻿using UnityEngine;
using System.Collections.Generic;

public class IObstacle : MonoBehaviour {

    protected List<CornerCoords> cornerCoordList = new List<CornerCoords>();

    public virtual List<CornerCoords> getObstacleCorners(GPUFluid.GridDimensions dimensions, Vector3 _scale) { return cornerCoordList; }


    public struct CornerCoords
    {
        public int xStart;
        public int xEnd;
        public int yStart;
        public int yEnd;
        public int zStart;
        public int zEnd;
    }
}
