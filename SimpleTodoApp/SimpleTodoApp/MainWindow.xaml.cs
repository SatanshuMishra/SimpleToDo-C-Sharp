using System.Windows;
using System.Windows.Controls;

namespace SimpleTodoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddTask(object sender, RoutedEventArgs e)
        {
            string taskText = TaskInput.Text;

            if (!string.IsNullOrEmpty(taskText))
            {
                TextBlock textBlock = new TextBlock
                {
                    Text = taskText,
                    Margin = new Thickness(10),
                };
                TaskList.Children.Add(textBlock);
                TaskInput.Clear();
            }
        }
    }
}
