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
using Databas.Inlämningsuppgift2.Models;
using Databas.Inlämningsuppgift2.Services;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Databas.Inlämningsuppgift2.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage2 : Page
    {

        public string UpdateStatus()
        {
            string statusText = Update.SelectionBoxItem.ToString();
            
            return statusText;
        }
        public string Comment()
        {
            string commentText = comments.Text;

            return commentText;
        }

        public BlankPage2()
        {
            this.InitializeComponent();
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            using DataContext context = new DataContext();
            var query = "select * from Errand";
            
            try
            {
                lvOpen.ItemsSource = query.ToList();
            }
            catch { }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ErrandService.UpdateErrandAsync(11, UpdateStatus(), Comment()).GetAwaiter();
                updatelabel.Visibility = Visibility.Visible;
            }
            catch { }
        }        
        
    }
}
