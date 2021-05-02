using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class Seed
    {
        public static async Task DataSeed(DataContext _context)
        {
            if (_context.Abouts.Any()) return;
            var abouts = new List<About>
            {
                new About
                {
                    Id=new Guid(),
                    Text="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor " +
                         "incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam , quis " +
                         "nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." +
                         "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore " +
                         "eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident,   " +
                         "sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Title = "About us",
                    PhotoURL="https://www.esellerde.com/wp-content/uploads/2020/01/about-us.png",
                },
                 new About
                {
                    Id=new Guid(),
                    Text="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor " +
                         "incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam , quis " +
                         "nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." +
                         "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore " +
                         "eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident,   " +
                         "sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Title = "About me",
                    PhotoURL="http://3.bp.blogspot.com/-awcchP27iX4/VT_UiNcSzgI/AAAAAAAAF9g/kLTOjEnvBMg/w1200-h630-p-k-no-nu/About%2BMe%2BModel%2BMayhem.png",
                }
            };

            await _context.Abouts.AddRangeAsync(abouts);
            await _context.SaveChangesAsync();

   
        }
    }
}
