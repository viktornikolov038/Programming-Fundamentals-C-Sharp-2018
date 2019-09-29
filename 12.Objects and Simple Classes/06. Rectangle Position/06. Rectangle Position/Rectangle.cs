using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rectangle_Position
{
    class Rectangle
    {
        public int Top { get; set; }

        public int Width { get; set; }

        public int Left { get; set; }

        public int Height { get; set; } 

        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }
        public int Right
        {
            get
            {
                return Left + Width;
            }
        }
        public bool IsInside(Rectangle r)
        {
            return (r.Left <= Left) && (r.Right >= Right) && (r.Top <= Top) & (r.Bottom >= Bottom);
        }
    }
}
