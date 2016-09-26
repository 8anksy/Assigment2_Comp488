using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassAssignment2_NET
{
    class Rectangle : Shape
    {
        public Rectangle (float width, float height)
        {
            this.width = width;
            this.height = height;
        }
        public override float getArea()
        {
            return ((height * 2) + (width * 2));
        }

        public override string ToString()
        {
            return "rectangle";
        }
    }
}
