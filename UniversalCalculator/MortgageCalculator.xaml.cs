using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MortgageCalculator : Page
	{
		public MortgageCalculator()
		{
			this.InitializeComponent();
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			double principleBorrow, pay, rate = 0;
			double duration = 0;

			rate = Convert.ToDouble(monthlyRateTextBox.Text);
			duration = Convert.ToInt16(monthsTextBox.Text) * 12;
			principleBorrow = Convert.ToDouble(principleBorrowTextBox.Text);
			if (rate > 1)
			{
				rate = rate / 100;
			}
			pay=(principleBorrow*Math.Pow((rate/12)+1,(duration))*rate/12)/(Math.Pow(rate/12+1,(duration))-1);
			monthlyRepaymentTextBox.Text = pay.ToString();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(MainMenu));
		}
	}
}
