using System;
using System.Collections.Generic;
using UnityEngine;

namespace CommandSystem
{
	public class CommandSystem : MonoBehaviour
	{
		private Stack<ICommand> _commands = new Stack<ICommand>();

		public void AddCommand(ICommand command)
		{
			command.Execute();
			_commands.Push(command);
		}

		public void Undo()
		{
			if (_commands.Count > 0)
			{
				var c = _commands.Pop();
				c.Undo();	
			}
		}

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.Z))
			{
				Undo();
			}
		}
	}
}