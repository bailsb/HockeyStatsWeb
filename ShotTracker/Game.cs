using System;
using System.Collections.Generic;

namespace ShotTracker
{
    public class Game
    {
        private int _sizeLimitX = 100;
        private int _sizeLimitY = 100;
        
        public List<Shot> Shots { get; }

        public Game()
        {
            Shots = new List<Shot>();
        }

        public void SetSizeLimit(int x, int y)
        {
            _sizeLimitX = x;
            _sizeLimitY = y;
        }

        public void AddShot(Shot shot)
        {
            if(shot.Location.X > _sizeLimitX || shot.Location.Y > _sizeLimitY)
                throw new ArgumentException("Shot Outside of Game Bounds");
            Shots.Add(shot);
        }
        
    }
}