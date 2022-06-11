namespace Mazes
{
	public static class EmptyMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
			TryDown(robot, width, height);
			TryRight(robot, width, height);
		}
		private static void TryDown(Robot robot, int width, int height)
        {
			for (int i = 1; i < height - 2; i++)
			{
				try
				{
					robot.MoveTo(Direction.Down);
				}
				finally
				{
				}
			}
		}
		private static void TryRight(Robot robot, int width, int height)
        {
			for (int i = 1; i < width - 2; i++)
			{
				try
				{
					robot.MoveTo(Direction.Right);
				}
				finally
				{
				}
			}
		}
	}
}