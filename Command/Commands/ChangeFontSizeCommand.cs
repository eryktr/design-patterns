using System.Windows.Controls;

namespace Command.Commands
{
    internal class ChangeFontSizeCommand : AlterLabelCommand
    {
        private string _newFontSize = string.Empty;
        private string _oldFontSize = string.Empty;

        public ChangeFontSizeCommand(Label label, TextBox box, MainWindow ctx) : base(label, box, ctx)
        {
        }

        public override void Execute()
        {
            if (!isUndo()) SetUp();

            ChangeFont();
            UpdateCommandHistory();
        }

        public override void Undo()
        {
            _targetLabel.FontSize = double.Parse(_oldFontSize);
        }

        private void SetUp()
        {
            _oldFontSize = _targetLabel.FontSize.ToString();
            _newFontSize = _sourceTextBox.Text;
        }

        private bool isUndo() => !_oldFontSize.Equals(string.Empty);
        private void ChangeFont() => _targetLabel.FontSize = double.Parse(_newFontSize);
        private void UpdateCommandHistory() => _ctx.PushToCommandHistory(this);
    }
}