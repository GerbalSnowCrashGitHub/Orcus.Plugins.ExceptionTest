using System;
using Orcus.Administration.Plugins;

namespace ExceptionTest
{
    public class Plugin : ICommandAndViewPlugin
    {
        public Command Command { get; } = new ExceptionTestCommand();
        public ICommandView CommandView { get; } = new CommandView();
        public Type View { get; } = typeof (ExceptionTestView);
    }
}