using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Controls;

namespace Command.Commands
{
    abstract class AlterLabelCommand : ICommand
    {
        protected Label _targetLabel;
        protected TextBox _sourceTextBox;
        protected MainWindow _ctx;

        protected AlterLabelCommand(Label label, TextBox box, MainWindow ctx)
        {
            _targetLabel = label;
            _sourceTextBox = box;
            _ctx = ctx;
        }

        public abstract void Execute();
        public abstract void Undo();
    }
}
