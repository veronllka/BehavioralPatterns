using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CommandDemo
{
    class AddTextCommand : ICommand
    {
        private readonly TextBox _textBox;
        private readonly string _text;

        public AddTextCommand(TextBox textBox, string text)
        {
            _textBox=textBox;
            _text=text;
        }

        public void Execute()
        {
            _textBox.AppendText(_text);
        }

        public void Undo()
        {
            var currentText = _textBox.Text;    
            if (currentText.EndsWith(_text))
            {
                _textBox.Text = currentText.Substring(0, currentText.Length - _text.Length);       
            }

        }
    }
}
