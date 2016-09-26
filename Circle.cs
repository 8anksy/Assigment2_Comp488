using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassAssignment2_NET
{
    class Circle : Shape
    {
        private float radius;
        public Circle(float diameter)
        {
            this.width = diameter;
            this.height = diameter;
            this.radius = diameter / 2;
        }
        public override float getArea()
        {
            return (float)(2 * (Math.PI * (radius*radius)));
        }
        public override string ToString()
        {
            return "circle";
        }
    }
}
