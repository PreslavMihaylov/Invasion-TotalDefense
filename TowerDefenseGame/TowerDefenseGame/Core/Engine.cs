﻿using System;

namespace TowerDefenseGame.Core
{
    using TowerDefenseGame.Controllers;
    using TowerDefenseGame.Interfaces;

    public class Engine : IEngine
    {
        public Engine()
        {
            GameFieldController.Initialize();
            Timers.InitializeTimers(this);
            PlayerInterfaceController.Money = Constants.StartingMoney;
            PlayerInterfaceController.PlayerLife = Constants.PlayerStartingLife;
        }

        public void Update()
        {
            EnemyController.Update();
            TowerController.Update();
            ProjectileController.Update();  
            Statistics.Update();
        }

        public void Render()
        {
            TowerController.Render();
            EnemyController.Render();
            ProjectileController.Render();    
            Statistics.Render();
        }
    }
}
