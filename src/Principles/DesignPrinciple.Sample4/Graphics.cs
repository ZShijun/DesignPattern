using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciple.Sample4
{
    public class Graphics
    {
        private Shape _shape;
        public Graphics(Shape shape)
        {
            this._shape = shape;
        }

        public void SetShape(Shape shape)
        {
            this._shape = shape;
        }

        public void Stroke()
        {
            string path = _shape.GetPath();
            Console.WriteLine($"描边{path}");
        }

        public void Fill()
        {
            string path = _shape.GetPath();
            Console.WriteLine($"填充{path}");
        }
    }
}
