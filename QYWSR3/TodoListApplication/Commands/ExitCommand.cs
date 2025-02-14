﻿using System;
using ToDoListApplication.TODOlist;

namespace ToDoListApplication.Commands
{
    internal class ExitCommand : CommandBase
    {
        public ExitCommand(IHost host) : base(host)
        {
        }

        public override string Name => "exit";

        public override void Execute()
        {
            Host.Exit();
        }
    }
}

