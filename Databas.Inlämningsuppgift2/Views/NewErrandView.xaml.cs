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

namespace Databas.Inlämningsuppgift2.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        public BlankPage1()
        {
            this.InitializeComponent();
            
        }


        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Services.ErrandService.CreateErrandAsync(Description.Text, DateTime.Now, FirstName.Text, LastName.Text, Email.Text, Convert.ToInt32(Phonenumber.Text), Status.Text, Category.Text, CreatedBy.Text).GetAwaiter();

            }
            catch{ }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            Description.Text = "";
            FirstName.Text = "";
            LastName.Text = "";
            Email.Text = "";
            Phonenumber.Text = "";
            CreatedBy.Text = "";
        }
    }
}
