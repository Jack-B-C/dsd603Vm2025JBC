using dsd603Vm2025JBC.Data;
using dsd603Vm2025JBC.Models;
using System.Data;

namespace dsd603Vm2025JBC.Services
{
    public class DataSeeder : IDataSeeder
    {
        //Used DI to inject in the database context 
        private readonly ApplicationDbContext _context;
        public DataSeeder(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }
        //https://medium.com/executeautomation/seeding-data-using-ef-core-in-asp-net-core-6-0-minimalapi-d5f6ecdb350c
        //a method that seeds data  
        public async Task SeedAsync()
        {
            //if there are no fields in the StaffNames db 
            if (!_context.StaffNames.Any())
            {
                var staff = new List<StaffNames>
                   {
                    new StaffNames()
                    {Id = Guid.NewGuid(), Name = "Dwain Henson", Department ="Counselling", VisitorCount = 2},
                    new StaffNames()
                    {Id = Guid.NewGuid(), Name = "Ciara Head", Department ="Counselling", VisitorCount = 2},
                    new StaffNames()
                    {Id = Guid.NewGuid(), Name = "Dwain Henson", Department ="Web Design", VisitorCount = 2},
                    new StaffNames()
                    {Id = Guid.NewGuid(), Name = "Quentin Thwaite", Department ="NZ Bat", VisitorCount = 2},
                    new StaffNames()
                    {Id = Guid.NewGuid(), Name = "Madhav Benn", Department ="Web Design", VisitorCount = 2},
                    new StaffNames()
                    {Id = Guid.NewGuid(), Name = "Suniti Lood", Department ="Early Childhood", VisitorCount = 2},
                    new StaffNames()
                    {Id = Guid.NewGuid(), Name = "Susie Tyrrell", Department ="Early Childhood", VisitorCount = 2},
                    new StaffNames()
                    {Id = Guid.NewGuid(), Name = "Jie Roy", Department ="Web Design", VisitorCount = 2},
                    new StaffNames()
                    {Id = Guid.NewGuid(), Name = "Shobha Carpenter", Department ="Software", VisitorCount = 2},
                    new StaffNames()
                    {Id = Guid.NewGuid(), Name = "Merletta Winton", Department ="Ultimate", VisitorCount = 2}
                   };
                _context.StaffNames.AddRange(staff);
                await _context.SaveChangesAsync();
            }
        }
    }
}