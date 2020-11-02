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
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using Windows.Devices.Input;
using System.Globalization;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Databas.Inlämningsuppgift2.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage2 : Page
    {

        public BlankPage2()
        {
            this.InitializeComponent();
        }

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

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            lvActive.ItemsSource = ErrandService.GetErrandsActive((Application.Current as App).connectionString);
        }

        private void btnClosed_Click(object sender, RoutedEventArgs e)
        {
            lvActive.ItemsSource = ErrandService.GetErrandsClosed((Application.Current as App).connectionString);
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ErrandService.UpdateErrandAsync(Convert.ToInt32(idLoad.Text), UpdateStatus(), Comment()).GetAwaiter();
                updatelabel.Visibility = Visibility.Visible;
            }
            catch { }
        }

        private void lvActive_ItemClick(object sender, ItemClickEventArgs e)
        {
            Errand errand = (Errand)lvActive.SelectedItem;
            idLoad.Text = Convert.ToString(errand.Id);
            descriptionLoad.Text = errand.Description;
            firstnameLoad.Text = errand.CustomerFirstName;
            lastnameLoad.Text = errand.CustomerLastName;
            phonenumberLoad.Text = Convert.ToString(errand.CustomerPhonenumber);
            emailLoad.Text = errand.CustomerEmail;

        }

    }
}
