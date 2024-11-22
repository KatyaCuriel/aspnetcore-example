using Microsoft.EntityFrameworkCore;
using Empresa.Proyecto.Core.Entities;
using System.Reflection.Emit;


namespace Empresa.Proyecto.Infra.Data
{
    public class MyProjectContext : DbContext
    {
        /// <summary>
        /// Constructor para DI
        /// </summary>
        /// <param name="options"></param>
        public MyProjectContext(DbContextOptions<MyProjectContext> options) : base(options)
        {

        }

        public DbSet<SimpleEntity> SimpleEntity => Set<SimpleEntity>();
        public DbSet<ComplexEntity> ComplexEntity => Set<ComplexEntity>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<SimpleEntity>().HasData(
                new SimpleEntity
                {
                    Id = 1,
                    Name = "Nuevo",
                    Value = "Valor inicial 1",
                    Created = DateTime.UtcNow,
                    Modified = DateTime.UtcNow
                },
                new SimpleEntity
                {
                    Id = 2,
                    Name = "Existente",
                    Value = "Valor inicial 2",
                    Created = DateTime.UtcNow,
                    Modified = DateTime.UtcNow
                },
                 new SimpleEntity
                 {
                     Id = 3,
                     Name = "Reconstruido",
                     Value = "Valor inicial 3",
                     Created = DateTime.UtcNow,
                     Modified = DateTime.UtcNow
                 }
               );

            //builder.ApplyConfigurationsFromAssembly(System.Reflection.Assembly.GetExecutingAssembly());
        }
    }
}
