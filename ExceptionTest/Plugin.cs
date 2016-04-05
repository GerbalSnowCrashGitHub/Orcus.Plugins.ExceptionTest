using System;
using Orcus.Administration.Plugins;

namespace ExceptionTest
{
    public class Plugin : ICommandAndViewPlugin
    {
        public Type Command { get; } = typeof (ExceptionTestCommand);
        public Type CommandView { get; } = typeof (CommandView);
        public Type View { get; } = typeof (ExceptionTestView);
    }
}