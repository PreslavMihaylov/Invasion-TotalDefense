﻿using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace TowerDefenseGame.Models.Towers
{
    using System.Windows.Media;
    using TowerDefenseGame.Core;

    public class SlowTower : Tower
    {
        private const int Speed = 50;
        private const int Range = 250;

        public SlowTower(double x, double y)
            : base(x, y, Constants.FieldSegmentSize, Constants.FieldSegmentSize, SlowTower.Speed, SlowTower.Range, new ImageBrush(new CroppedBitmap(new BitmapImage(
             new Uri(@"..\..\Common\slowtower.png", UriKind.Relative)), new Int32Rect(0, 0, 32, 32))))
        {
        }
    }
}
