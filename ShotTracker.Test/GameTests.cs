

using System;
using System.Drawing;
using System.Runtime.Serialization.Formatters;
using NUnit.Framework;

namespace ShotTracker.Test
{
    [TestFixture]
    public class GameTests
    {
        private Game _game;
        
        [SetUp]
        public void Setup()
        {
            _game = new Game();
        }
        
        [Test]
        public void canCreateGame_true()
        {
            Assert.NotNull(_game);
            Assert.NotNull(_game.Shots);
        }
        
        /* TODO - add Teams to Games
        [Test]
        public void addTeams_twoTeams_true()
        {
            _game.AddTeam("Riders");
            _game.AddTeam("")
        }
        */
        
        private void AddShotToGame(int x, int y)
        {
            Shot shot = new Shot(new Point(x, y));
            _game.AddShot(shot);
        }
        
        [Test]
        public void addShot_simpleShot_true()
        {
            AddShotToGame(0,0);
            
            Assert.True(_game.Shots.Count == 1);
        }

        [Test]
        public void addShot_100Shots_true()
        {
            for (int i = 0; i < 100; i++)
            {
                AddShotToGame(0, 0);
            }
            
            Assert.True(_game.Shots.Count == 100);
        }

        [Test]
        public void addShot_outsideOfGameSizeX_exception()
        {
             _game.SetSizeLimit(15,15);
             
             Assert.Throws<ArgumentException>(() => AddShotToGame(16, 15));
        }
        
        [Test]
        public void addShot_outsideOfGameSizeY_exception()
        {
            _game.SetSizeLimit(15,15);
            
            Assert.Throws<ArgumentException>(() => AddShotToGame(15, 16));
        }
    }
}