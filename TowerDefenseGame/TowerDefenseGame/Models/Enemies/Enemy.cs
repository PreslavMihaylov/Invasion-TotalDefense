﻿using System.Windows;

namespace TowerDefenseGame.Models.Enemies
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Shapes;
    using TowerDefenseGame.Geometry;
    using TowerDefenseGame.Interfaces;
using TowerDefenseGame.Models.Effects.Debuffs;

    public abstract class Enemy : GameObject, IEnemy
    {
        private int speed;
        private int lifePoints;
        private List<Point> beacons = new List<Point>();
        private IDebuff debuff = new NullDebuff();

        protected Enemy(double x, double y, int width, int height, int lifePoints, int speed, Brush fillType)
            : base(x, y, width, height, fillType)
        {
            this.EnemyLifePoints = lifePoints;
            this.EnemySpeed = speed;
        }

        public List<Point> Beacons
        {
            get
            {
                return this.beacons;
            }

            private set
            {
                this.beacons = value;
            }
        }

        public int EnemySpeed
        {
            get
            {
                return this.speed;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The speed cannot be a negative number");
                }

                this.speed = value;
            }
        }

        public int EnemyLifePoints
        {
            get
            {
                return this.lifePoints;
            }

            private set
            {
                this.lifePoints = value;
            }
        }

        public IDebuff Debuff 
        {
            get
            {
                return this.debuff;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The value cannot be null");
                }
                this.debuff = value;
            }
        }

        public override void Update()
        {
            if (this.Beacons.Count == 0)
            {
                this.Exists = false;
                return;
            }
            else if (this.EnemyLifePoints <= 0) 
            {
                this.Exists = false;
            }

            Point.HandleMovement(this.Coordinates, this.Beacons[0], this.EnemySpeed);

            if (this.Beacons[0].IsInside(this))
            {
                this.Beacons.RemoveAt(0);
                this.Update();
            }  
        }

        public void SetBeacons(List<Point> beacons)
        {
            this.Beacons = beacons;
        }

        public void TakeDamage(int damage)
        {
            this.EnemyLifePoints -= damage;
        }
    }
}
