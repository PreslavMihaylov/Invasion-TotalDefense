﻿namespace TowerDefenseGame.Models
{
    using System;
    using System.Windows.Media;
    using TowerDefenseGame.Core;
    using TowerDefenseGame.Enumerations;
    using TowerDefenseGame.Interfaces;
    using TowerDefenseGame.Models.Enemies;

    public class FieldSegment : GameObject
    {
        private FieldType fieldType;
        private bool occupied = false;

        public FieldSegment(double x, double y)
            : base(x, y, Constants.FieldSegmentSize, Constants.FieldSegmentSize, Brushes.AliceBlue)
        {
            this.Model.Stroke = Brushes.DarkBlue;
        }

        public FieldType FieldType
        {
            get
            {
                return this.fieldType;
            }

            set
            {
                this.fieldType = value;
            }
        }

        public bool Occupied
        {
            get
            {
                return this.occupied;
            }
            set
            {
                this.occupied = value;
            }
        }
    }
}
