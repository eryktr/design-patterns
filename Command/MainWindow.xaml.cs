using System.Collections.Generic;
using System.Windows;
using Command.Commands;
using ICommand = Command.Commands.ICommand;

namespace Command
{
    public partial class MainWindow : Window
    {
        
        private IList<ICommand> _commandHistory { get; }
        private int _commandPointer = -1;

        public MainWindow()
        {
            _commandHistory = new List<ICommand>();
            InitializeComponent();
        }

        public void PushToCommandHistory(ICommand command)
        {
            _commandHistory.Add(command);
            _commandPointer++;
        }

        private void UndoButton_Click(object sender, RoutedEventArgs e)
        {
            if (_commandPointer < 0 || _commandPointer > _commandHistory.Count - 1) return;
            _commandHistory[_commandPointer].Undo();
            _commandPointer--;
        }

        private void Redo_Click(object sender, RoutedEventArgs e)
        {
            if (_commandPointer < -1 || _commandPointer > _commandHistory.Count) return;
            _commandPointer++;
            _commandHistory[_commandPointer].Execute();
        }

        private void ChangeTextButton_Click(object sender, RoutedEventArgs e)
        {
            var command = new ChangeTextCommand(CommandLabel, ContentTextBox, this);
            command.Execute();
        }

        private void ChangeFontButton_Click(object sender, RoutedEventArgs e)
        {
            var command = new ChangeFontSizeCommand(CommandLabel, FontTextBox, this);
            command.Execute();
        }
    }
}