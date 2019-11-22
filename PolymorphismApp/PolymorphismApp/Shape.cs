using System;

namespace PolymorphismApp
{
    /// <summary>
    /// 三角形
    /// </summary>
    public class Triangle : IShape
    {
        // 底辺
        private readonly double _base;

        // 高さ
        private readonly double _height;

        public Triangle(double triangleBase, double height)
        {
            _base = triangleBase;
            _height = height;
        }

        public double CalculateArea()
        {
            return _base * _height / 2;
        }
    }

    /// <summary>
    /// 四角形
    /// </summary>
    public class Rectangle : IShape
    {
        // 横
        private readonly double _width;

        // 縦
        private readonly double _height;

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public double CalculateArea()
        {
            return _width * _height;
        }
    }

    /// <summary>
    /// 円
    /// </summary>
    public class Circle : IShape
    {
        // 半径
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double CalculateArea()
        {
            return _radius * _radius * Math.PI;
        }
    }

    public class Trapezoid : IShape
    {
        // 上底
        private readonly double _upperBase;

        // 下底
        private readonly double _lowerBase;

        // 高さ
        private readonly double _height;

        public Trapezoid(double upper, double lower, double height)
        {
            _upperBase = upper;
            _lowerBase = lower;
            _height = height;
        }

        public double CalculateArea()
        {
            return (_upperBase + _lowerBase) * _height / 2;
        }
    }
}