﻿namespace TowerDefenseGame.Controllers
{
    using System;
    using TowerDefenseGame.Enumerations;

    public static class PlayerInterfaceController
    {
        private static TowerType towerSelected=TowerType.Sniper;

        private static int money;

        public static int Money 
        {
            get
            {
                return money;
            }
            set
            {
                PlayerInterfaceController.money = value;
            }
        }
        public static TowerType TowerSelected
        {
            get
            {
                return PlayerInterfaceController.towerSelected;
            }

            set
            {
                PlayerInterfaceController.towerSelected = value;
            }
        }
    }
}
