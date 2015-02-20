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
        private const int TowerSpeed = 50;
        private const int TowerRange = 200;
        public const int TowerPrice = 30;
        private const int TowerDamage = 5;

        private static readonly ImageBrush TowerImage = SpritesManager.FireTower;
        public FireTower(double x, double y)
            : base(x, y, Constants.FieldSegmentSize, Constants.FieldSegmentSize, TowerSpeed, TowerRange, TowerDamage, TowerImage, TowerPrice)
        {
        }
    }
}
