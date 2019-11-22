using System;

namespace PolymorphismApp
{
    public interface IShape
    {
        /// <summary>
        /// 面積を計算する
        /// </summary>
        /// <returns>面積</returns>
        double CalculateArea();
    }
}