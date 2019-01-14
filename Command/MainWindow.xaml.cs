using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Command.Commands;
using ICommand = Command.Commands.ICommand;

namespace Command
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
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
            _commandHistory[_commandPointer].Undo();
            _commandPointer--;
        }

        private void Redo_Click(object sender, RoutedEventArgs e)
        {
            _commandPointer++;
            _commandHistory[_commandPointer].Execute();
        }

        private void ChangeTextButton_Click(object sender, RoutedEventArgs e)
        {
            var command = new ChangeTextCommand(CommandLabel, ContentTextBox, this);
            command.Execute();
        }
    }
}