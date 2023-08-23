using EasyCashIdentityProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace EasyCashIdentityProject.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-D4V39LT\\MSSQLSERVER2022; initial catalog=EasyCashDb; integrated Security=true; TrustServerCertificate=True;");
        }
        public DbSet<CustomerAccount> CustomerAccounts { get; set; }
        public DbSet<CustomerAccountProcess> CustomerAccountProcesses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<CustomerAccountProcess>()
                   .HasOne(s=>s.SenderCustomer)
                   .WithMany(c=>c.CustomerSender)
                   .HasForeignKey(s=>s.CustomerSenderId)
                   .OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<CustomerAccountProcess>()
                   .HasOne(r => r.ReceiverCustomer)
                   .WithMany(c => c.CustomerReceiver)
                   .HasForeignKey(r => r.CustomerReceiverId)
                   .OnDelete(DeleteBehavior.ClientSetNull);
                   
        }
    }
}
