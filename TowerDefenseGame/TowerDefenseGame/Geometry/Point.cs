﻿using System;

namespace TowerDefenseGame.Geometry
{
    public class Point
    {
        private double x;
        private double y;
        
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }
        public double Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            } 
        }
    }
}
