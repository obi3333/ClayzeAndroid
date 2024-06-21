using Clayze;
using Clayze.Marching.Operations;

namespace CommandSystem.Commands
{
	public class SingleOperationCommand : ICommand
	{
		private IOperation _op;
		private OperationCollection _collection;

		public SingleOperationCommand(OperationCollection collection, IOperation op)
		{
			_op = op;
			_collection = collection;
		}
		
		public void Execute()
		{
			_collection.Add(_op);
		}

		public void Undo()
		{
			_collection.Remove(_op);
		}
	}
}