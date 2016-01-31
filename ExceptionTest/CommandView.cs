using Sorzus.Wpf.Toolkit;
using Orcus.Administration.Plugins;

namespace ExceptionTest
{
    public class CommandView : ICommandView
    {
        private RelayCommand _throwUpCommand;
        private ExceptionTestCommand _exceptionTestCommand;

        public void Dispose()
        {
        }

        public string Name { get; } = "Exception Test";
        public Category Category { get; } = Category.Client;

        public int SelectedExceptionIndex { get; set; }
        public string Message { get; set; }

        public void Initialize(IClientController clientController)
        {
            _exceptionTestCommand = clientController.Commander.GetCommand<ExceptionTestCommand>();
        }

        public void LoadView()
        {
        }

        public RelayCommand ThrowUpCommand
        {
            get
            {
                return _throwUpCommand ??
                       (_throwUpCommand =
                           new RelayCommand(
                               parameter =>
                               {
                                   _exceptionTestCommand.ThrowException(SelectedExceptionIndex, Message ?? "");
                               }));
            }
        }
    }
}