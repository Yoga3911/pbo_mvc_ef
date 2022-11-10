using Microsoft.EntityFrameworkCore;

public class PboContext : DbContext
{
    public DbSet<Model.User>? Users { get; set; }

    public string DbPath { get; }

    public PboContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "pbo.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}