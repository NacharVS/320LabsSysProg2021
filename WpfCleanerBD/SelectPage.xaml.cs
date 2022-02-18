using System;
using System.Collections.Generic;
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

namespace WpfCleanerBD
{
	/// <summary>
	/// Логика взаимодействия для SelectPage.xaml
	/// </summary>
	public partial class SelectPage : Page
	{
		public SelectPage()
		{
			InitializeComponent();
		}

		private void Select_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new CleanerPage());
		}

		private void All_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new AllPage());
		}
	}
}
