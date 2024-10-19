using Accessibility;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CommandDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly CommandManager _commandManager = new CommandManager();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var command = new AddTextCommand((TextBox)sender, e.Text);
            _commandManager.ExecuteCommand(command);
        }

        private void undoButton_Click(object sender, RoutedEventArgs e)
        {
            _commandManager.Undo();
        }

        private void redoButton_Click(object sender, RoutedEventArgs e)
        {
            _commandManager.Redo();
        }
    }
}