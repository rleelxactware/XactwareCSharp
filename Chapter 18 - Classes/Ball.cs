using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18___Making_Your_Own_Classes
{

    class Ball
    {
        private float radius;
        private Color color;
        private int timesThrown = 1;
        private int v1;
        private int v2;

        public Ball(float radius, Color color)
        {
            this.radius = radius;
            this.color = color;
        }
        public Ball()
        {

        }

        public Ball(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public float GetSize()
        {
            return radius;
        }
        public Color GetColor()
        {
            return color;
        }
        public int GetTimesThrown()
        {
            return timesThrown;
        }


        public void SetSize(float radius)
        {
            this.radius = radius;
        }
        public void SetColor(Color color)
        {
            this.color = color;
        }
        public void SetTimesThrown(int timesThrown)
        {
            this.timesThrown = timesThrown;
        }


        public void Pop()
        {
            this.radius = 0;
        }
        public float? Throw()
        {
            if (this.radius != 0)
            {
                return timesThrown++;
            }
            else
            {
                Console.WriteLine("Sorry!!! The ball has been popped!!");
                return null;
            }

        }
    }


}
