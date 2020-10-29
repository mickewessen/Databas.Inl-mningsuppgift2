using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Databas.Inlämningsuppgift2.Models;
using System.Collections.ObjectModel;
using Microsoft.Data.SqlClient;
using Windows.UI.Xaml.Controls;
using Databas.Inlämningsuppgift2.Views;

namespace Databas.Inlämningsuppgift2.Services
{
    public static class ErrandService
    {

        public static async Task CreateErrandAsync(string description, DateTime creationTime, string customerFirstName, string customerLastName, string customerEmail, int? customerPhonenumber, string status, string category, string createdby)
        {
            using DataContext context = new DataContext();

            context.Errand.Add(new Errand(description, creationTime, customerFirstName, customerLastName, customerEmail, customerPhonenumber, status, category, createdby));
            await context.SaveChangesAsync();
        }

        //public static async Task<IEnumerable<Errand>> GetErrandsAsync()
        //{
        //    using DataContext context = new DataContext();

        //    var output = await context.Errand.ToListAsync();
        //    return output;
        //}

        //private static async Task ListAllErrandsAsync()
        //{
        //    var errands = await GetErrandsAsync();
        //    foreach (var errand in errands)
        //    {
                
        //    }
        //}

        //public static async Task<Errand> GetErrandAsync(int id)
        //{
        //    using DataContext context = new DataContext();

        //    return await context.Errands.FindAsync(id);
        //}

        //public static async Task<IEnumerable<Errand>> GetErrandsByCompletedAsync(bool completed)
        //{
        //    using DataContext context = new DataContext();

        //    return await context.Errands.Where(Errand => Errand.Completed == completed).ToListAsync();
        //}

        public static async Task UpdateErrandAsync(int id, string status, string comment)
        {
            using DataContext context = new DataContext();

            var Errand = await context.Errand.FindAsync(id);

            if (Errand != null)
            {
                Errand.Status = status;
                Errand.Comment = comment;
                context.Entry(Errand).State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
        }

        //public static async Task RemoveErrandAsync(int id)
        //{
        //    using DataContext context = new DataContext();

        //    var Errand = await context.Errands.FindAsync(id);

        //    if (Errand != null)
        //    {
        //        context.Errands.Remove(Errand);
        //        await context.SaveChangesAsync();
        //    }
        //}
    }
}
