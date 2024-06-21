namespace CommandSystem
{
	public interface ICommand
	{
		public void Execute();
		public void Undo();
	}
}