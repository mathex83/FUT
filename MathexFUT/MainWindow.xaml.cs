using MathexFUT.Elements.Windows;
using System.Windows;
using System.Windows.Controls;

namespace MathexFUT
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

		private void OpenClick(object sender, RoutedEventArgs e)
		{
			Button btn = sender as Button;

			switch (btn.Content)
			{
				case "Vis Målsætninger":
					ShowGoals sg = new ShowGoals();
					sg.Show();
					break;
			}
			
		}

		private void ExitClick(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}
	}
}
