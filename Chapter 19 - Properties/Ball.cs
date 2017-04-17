using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_19___Properties
{

    class Ball
    {
        private int size;
        private int color;
        private int timesThrown = 1;


        //public Ball(int size, int color)
        //{
        //    this.size = size;
        //    this.color = color;
        //}
        //public Ball()
        //{

        //}


        public int Size { get; set; }
        //{
        //    get
        //    {
        //        return size;
        //    }
        //    set
        //    {
        //        size = value;
        //    }
        //}

        public int Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public int TimesThrown
        {
            get
            {
                return timesThrown;
            }
            set
            {
                timesThrown = value;
            }
        }
        


        public void Pop()
        {
            this.size = 0;
        }
        public int? Throw()
        {
            if (this.size != 0)
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
