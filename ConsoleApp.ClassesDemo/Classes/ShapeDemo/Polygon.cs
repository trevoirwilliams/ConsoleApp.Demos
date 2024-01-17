using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ClassesDemo.Classes.ShapeDemo
{
    public abstract class Polygon
    {
        public double Width { get; set; }

        public abstract double Area();
        
        public virtual string GetShapeName()
        {
            throw new NotImplementedException();
        }
    }
}
