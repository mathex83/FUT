using System.Windows;
using System.Windows.Controls;

namespace MathexFUT.Elements.Windows
{
	/// <summary>
	/// Interaction logic for ShowGoals.xaml
	/// </summary>
	public partial class ShowGoals : Window
	{
		public ShowGoals()
		{
			InitializeComponent();
			HideAllStackPanels();
		}

		private void TopMenuClick(object sender, RoutedEventArgs e)
		{
			HideAllStackPanels();
			Button btn = sender as Button;
			switch (btn.Content)
			{
				case "Squad Battles":
					sb.Visibility = Visibility.Visible;
					break;
				case "Venskabskampe":
					f.Visibility = Visibility.Visible;
					break;
				case "Venskabskampe online":
					of.Visibility = Visibility.Visible;
					break;
				case "Division Rivals":
					r.Visibility = Visibility.Visible;
					break;
				case "Weekend League":
					wl.Visibility = Visibility.Visible;
					break;
			}
		}

		void HideAllStackPanels()
		{
			sb.Visibility = Visibility.Hidden;
			f.Visibility = Visibility.Hidden;
			of.Visibility = Visibility.Hidden;
			r.Visibility = Visibility.Hidden;
			wl.Visibility = Visibility.Hidden;
		}

		private void CloseClick(object sender, RoutedEventArgs e)
		{
			Close();
		}
	}
}
