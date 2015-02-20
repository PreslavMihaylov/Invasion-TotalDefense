﻿using System;
using System.ComponentModel.Design.Serialization;
using System.Windows;
using System.Windows.Media.Imaging;
using TowerDefenseGame.Resources;

namespace TowerDefenseGame.Models.Towers
{
    using System.Windows.Media;
    using TowerDefenseGame.Core;

    public class FireTower : Tower
    {
        private const int Speed = 50;
        private const int Range = 200;
        public const int Price = 30;
       
        public FireTower(double x, double y)
            : base(x, y, Constants.FieldSegmentSize, Constants.FieldSegmentSize, FireTower.Speed, FireTower.Range, SpritesManager.FireTower, Price)
        {
        }
    }
}
