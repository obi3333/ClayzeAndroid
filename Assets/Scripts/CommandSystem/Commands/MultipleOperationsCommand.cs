using System.Collections.Generic;
using Clayze;
using Clayze.Marching.Operations;

namespace CommandSystem.Commands
{
	public class MultipleOperationsCommand : ICommand
	{
		private IOperation[] _ops;
		private OperationCollection _collection;

		public MultipleOperationsCommand(OperationCollection collection, IOperation[] ops)
		{
			_ops = ops;
			_collection = collection;
		}
		
		public MultipleOperationsCommand(OperationCollection collection, List<IOperation> ops)
		{
			_ops = ops.ToArray();
			_collection = collection;
		}
		
		public void Execute()
		{
			foreach (var op in _ops)
			{
				_collection.Add(op);
			}
		}

		public void Undo()
		{
			foreach (var op in _ops)
			{
				_collection.Remove(op);
			}
		}
	}
}