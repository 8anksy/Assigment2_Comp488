using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassAssignment2_NET
{
    class Triangle : Shape
    {
        public Triangle (float width, float height)
        {
            this.width = width;
            this.height = height;
        }
        public override float getArea()
        {
            return (width * (height / 2));
        }

        public override string ToString()
        {
            return "triangle";
        }
    }
}
