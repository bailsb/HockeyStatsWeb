using System;
using System.Reflection;
using NUnit.Framework;
using System.Drawing;

namespace ShotTracker.Test
{
    [TestFixture]
    public class ShotTests
    {
        
        [Test]
        public void createShot_SimpleShot()
        {
            Shot shot = new Shot(new Point(0,0));
            Assert.True(shot.Location.X == 0 && shot.Location.Y == 0);
        }
        
        [Test]
        public void createShot_negativeX_exception()
        {
            Point point = new Point(-1, 0);

            Assert.Throws<ArgumentException>(() => new Shot(point));
        }
        
        [Test]
        public void createShot_negativeY_exception()
        {
            Point point = new Point(0, -1);

            Assert.Throws<ArgumentException>(() => new Shot(point));
        }
    }
}