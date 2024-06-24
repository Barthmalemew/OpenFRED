using Microsoft.EntityFrameworkCore;
using OpenFRED.Entities;

namespace OpenFRED.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Participant> Participants { get; set; }
}