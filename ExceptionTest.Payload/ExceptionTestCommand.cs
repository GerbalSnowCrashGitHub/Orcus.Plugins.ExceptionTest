using System;
using System.Text;
using Orcus.Plugins;

namespace ExceptionTest.Payload
{
    public class ExceptionTestCommand : Command
    {
        public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
        {
            var message = Encoding.UTF8.GetString(parameter, 4, parameter.Length - 4);
            switch (BitConverter.ToInt32(parameter, 0))
            {
                case 0:
                    throw new Exception(message);
                case 1:
                    throw new ArgumentException(message);
                case 2:
                    throw new InvalidOperationException(message);
                case 3:
                    throw new YoMamaIsntSuckingException(message);
            }
        }

        protected override uint GetId()
        {
            return 1001;
        }
    }
}