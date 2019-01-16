using System;
using System.Windows.Controls;

namespace Command.Commands
{
    [Serializable]
    internal class ChangeTextCommand : AlterLabelCommand
    {
        private string _newText = string.Empty;
        private string _previousText = string.Empty;

        public ChangeTextCommand(Label label, TextBox box, MainWindow window) : base(label, box, window)
        {
        }

        public override void Execute()
        {
            if (!IsRedo()) StoreValues();

            if (!ChangeText()) return;

            UpdateCommandHistory();
        }

        public override void Undo()
        {
            _targetLabel.Content = _previousText;
        }

        public void StoreValues()
        {
            _previousText = _targetLabel.Content.ToString();
            _newText = _sourceTextBox.Text;
        }

        public void UpdateCommandHistory() => _ctx.PushToCommandHistory(this);

        public bool ChangeText()
        {
            if (_previousText != string.Empty && _previousText == _newText) return false;
            _targetLabel.Content = _newText;
            return true;
        }

        public bool IsRedo() => _previousText != string.Empty && _newText != string.Empty && _previousText != _newText;
    }
}