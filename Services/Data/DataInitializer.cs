using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Data
{
    public class DataInitializer
    {
        private readonly ApplicationContext _applicationContext;

        public DataInitializer(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public void SeedDate()
        {
            _applicationContext.Database.EnsureDeleted();
            if (_applicationContext.Database.EnsureCreated())
            {
                Fill();
            }
        }

        public void Fill()
        {
            _applicationContext.Events.Add(new Event(700, "test"));

            _applicationContext.SaveChanges();
        }
    }
}
