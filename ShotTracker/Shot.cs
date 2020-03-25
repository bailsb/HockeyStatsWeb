using System;
using System.Reflection;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

namespace ShotTracker
{
    public class Shot
    {
        public Point Location { get; }
        //private Guid shotID;

        public Shot(Point location)
        {
            if (ValidationLocation(location))
                Location = location;
            else
            {
                throw new ArgumentException("Invalid Shot Location");
            }
        }

        private bool ValidationLocation(Point location)
        {
            if (location.X < 0)
                throw new ArgumentException("Shot X Location can't be negative");
            if (location.Y < 0)
                throw new ArgumentException("Shot Y Location can't be negative");
            return true;
        }
    }
}