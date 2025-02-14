﻿using System;
using ToDoListApplication.TODOlist;

namespace ToDoListApplication.Commands
{
    internal class DeleteAllTODOCommand : CommandBase
    {
        private TodoList todoList;

        public DeleteAllTODOCommand(IHost host, TodoList todoList) : base(host)
        {
            this.todoList = todoList;
        }

        public override string Name => "delete";

        public override void Execute()
        {
            Host.WriteLine("If you want to delete every task from you TODO-list type in 'yes' !");
            Host.Write("Input:");
            string confirmation = Host.ReadLine();
            todoList.DeleteAllTODO(confirmation);
        }
    }
}


