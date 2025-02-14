﻿using System;
using ToDoListApplication.TODOlist;

namespace ToDoListApplication.Commands
{
    internal class HelloCommand : CommandBase
    {
        public HelloCommand(IHost host) : base(host)
        {
        }

        public override string Name => "hello";

        public override void Execute()
        {
            Host.WriteLine("Hello, User!");
        }
    }
}
