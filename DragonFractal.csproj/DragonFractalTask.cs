using System;
using System.Drawing;

namespace Fractals
{
	internal static class DragonFractalTask
	{
		public static void DrawDragonFractal(Pixels pixels, int iterationsCount, int seed)
		{
			/*
			Начните с точки (1, 0)
			Создайте генератор рандомных чисел с сидом seed
			
			На каждой итерации:

			1. Выберите случайно одно из следующих преобразований и примените его к текущей точке:

				Преобразование 1. (поворот на 45° и сжатие в sqrt(2) раз):
				x' = (x · cos(45°) - y · sin(45°)) / sqrt(2)
				y' = (x · sin(45°) + y · cos(45°)) / sqrt(2)

				Преобразование 2. (поворот на 135°, сжатие в sqrt(2) раз, сдвиг по X на единицу):
				x' = (x · cos(135°) - y · sin(135°)) / sqrt(2) + 1
				y' = (x · sin(135°) + y · cos(135°)) / sqrt(2)
		
			2. Нарисуйте текущую точку методом pixels.SetPixel(x, y)

			*/
			double x = 1.0;
			double y = 0.0;
			var random = new Random(seed);
			var angle45 = 45 * Math.PI / 180;
			var angle135 = 135 * Math.PI / 180;
            for (int i = 0; i < iterationsCount; i++)
            {
				var newNumber = random.Next(100);
                if (newNumber % 2 == 0)
                {
					var x1 = (x * Math.Cos(angle45) - y * Math.Sin(angle45)) / Math.Sqrt(2);
					var y1 = (x * Math.Sin(angle45) + y * Math.Cos(angle45)) / Math.Sqrt(2);
					x = x1;
					y = y1;
				}
				else
                {
					var x1 = (x * Math.Cos(angle135) - y * Math.Sin(angle135)) / Math.Sqrt(2) + 1;
					var y1 = (x * Math.Sin(angle135) + y * Math.Cos(angle135)) / Math.Sqrt(2);
					x = x1;
					y = y1;
				}
				pixels.SetPixel(x, y);
			}

		}
	}
}