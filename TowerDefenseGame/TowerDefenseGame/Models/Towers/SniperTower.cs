﻿namespace TowerDefenseGame.Models.Towers
{
    using System.Windows.Media;
    using TowerDefenseGame.Core;

    public class SniperTower : Tower
    {
        private const int Speed = 100;
        private const int Range = 100;

        public SniperTower(double x, double y)
            : base(x, y, Constants.FieldSegmentSize, Constants.FieldSegmentSize, SniperTower.Speed, SniperTower.Range, Brushes.Yellow)
        {
        }
    }
}