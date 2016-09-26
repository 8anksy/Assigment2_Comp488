using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassAssignment2_NET
{
    abstract class Shape
    {
        protected float width;
        protected float height;

        public void setWidth(float w) {
            width = w;
        }
        public void setHeight(float h) {
            height = h;
        }

        public float getWidth() {
            return width;
        }

        public float getHeight() {
            return height;
        }
        public abstract float getArea();
        public abstract override string ToString();

    }
}
