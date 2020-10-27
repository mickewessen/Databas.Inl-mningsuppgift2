using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Databas.Inlämningsuppgift2.Models;
using System.Collections.ObjectModel;
using Microsoft.Data.SqlClient;

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

        //public static async ObservableCollection<Errand> GetErrandsAsync()
        //{
        //    using DataContext context = new DataContext();
        //    { }



        //    return await context.Errand.ToListAsync();




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

        //public static async Task UpdateErrandAsync(int id)
        //{
        //    using DataContext context = new DataContext();

        //    var Errand = await context.Errands.FindAsync(id);

        //    if (Errand != null)
        //    {
        //        Errand.Completed = true;
        //        context.Entry(Errand).State = EntityState.Modified;
        //        await context.SaveChangesAsync();
        //    }
        //}

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
