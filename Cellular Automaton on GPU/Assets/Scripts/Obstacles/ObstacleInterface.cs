﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleInterface : MonoBehaviour {

    protected List<CornerCoords> cornerCoordList = new List<CornerCoords>();

    public virtual List<CornerCoords> getObstacleCorners(GPUFluid.GridDimensions dimensions, float _scale) { return cornerCoordList; }


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
