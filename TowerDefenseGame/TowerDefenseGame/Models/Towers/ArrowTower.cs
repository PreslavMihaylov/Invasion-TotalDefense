﻿namespace TowerDefenseGame.Models.Towers
{
    using System.Windows.Media;
    using TowerDefenseGame.Core;

    public class ArrowTower : Tower
    {
        private const int Speed = 10;
        private const int Range = 400;

        public ArrowTower(double x, double y)
            : base(x, y, Constants.FieldSegmentSize, Constants.FieldSegmentSize, ArrowTower.Speed, ArrowTower.Range, Brushes.LawnGreen)
        {
        }
    }
}
