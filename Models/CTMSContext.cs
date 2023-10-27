using Microsoft.EntityFrameworkCore;

namespace ctms_2001.Models;
public class CTMSContext : DbContext
{
    public CTMSContext(DbContextOptions<CTMSContext> options) :
    base(options)
    {

    }

    public DbSet<Tournament> Tournaments { get; set; }
}