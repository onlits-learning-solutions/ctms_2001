using Microsoft.EntityFrameworkCore;

public class CTMSContext : DbContext
{
    public CTMSContext(DbContextOptions<CTMSContext> options) :
    base(options)
    {

    }
    
}