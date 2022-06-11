namespace Mazes
{
	public static class DiagonalMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
			int biggestStep = (int)(width > height ? System.Math.Round(width / (double)height) : System.Math.Round(height / (double)width));
			int stepDown, stepRight = 0;
			if (width > height)
			{
				stepRight = biggestStep;
				stepDown = 1;
			}
			else if (height + 1 == width || height == width + 1)
			{
				stepRight = stepDown = 1;
			}
			else
			{
				stepRight = 1;
				stepDown = biggestStep;
			}
			while (!robot.Finished)
			{
				Move(robot, width, height, stepRight, stepDown);
			}
		}
		private static void Move(Robot robot, int width, int height, int stepRight, int stepDown)
		{
            if (width > height)
            {
				for (int i = 0; i < stepRight; i++)
				{
					robot.MoveTo(Direction.Right);
				}
				for (int i = 0; i < stepDown; i++)
				{
					if (robot.Finished) break;
					robot.MoveTo(Direction.Down);
				}
			}
			if (width < height)
			{
				for (int i = 0; i < stepDown; i++)
				{
					robot.MoveTo(Direction.Down);
				}
				for (int i = 0; i < stepRight; i++)
				{
					if (robot.Finished) break;
					robot.MoveTo(Direction.Right);
				}
			}

		}
	}
}