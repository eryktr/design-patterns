using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Command.GUI
{
    class CommandButton : Button
    {
        protected override void OnClick()
        {
            MessageBox.Show("I do work");
        }
    }
}
