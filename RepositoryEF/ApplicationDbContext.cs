using BookingLibrary.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RepositoryModel.Interfaces;
using RepositoryModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEF
{
    public class ApplicationDbContext :IdentityDbContext<AppUser>
    {
        //private UserManager<AppUser> userManager;
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) :base(options) //UserManager<AppUser> userManager
        {
            //this.userManager = userManager;
            this.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            this.ChangeTracker.DetectChanges();
            this.ChangeTracker.AutoDetectChangesEnabled = false;
            this.Database.SetCommandTimeout(60);
            this.Database.EnsureCreated();
            this.ChangeTracker.StateChanged += (sender, args) =>
            {
                if (args.Entry.Entity != null)
                {
                    Console.WriteLine($"Entity {args.Entry.Entity.GetType().Name} " +
                        $"{args.Entry.State.ToString()} " +
                        $"Key: {string.Join(',', args.Entry.Metadata.FindPrimaryKey().Properties.Select(x => x.Name + "=" + args.Entry.Property(x.Name).CurrentValue))}");
                }
            };
        }

        public ApplicationDbContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-QG04GD4\\INTAKE43;Initial Catalog=Booking_System;Integrated Security=True; trust server certificate = true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>().HasData(new[]
            {
                 new AppUser
                     {
                            Id="22",
                            UserName="sara",
                            NormalizedUserName="SARA",
                            NID="12345678901234",
                            gender=Gender.Male,
                            City="sowhag",
                            Country="Egypt",
                            Street="jijdijdied",
                            IsDeleted=false,
                            PasswordHash="AQAAAAIAAYagAAAAEI5ZO8VZttKTq1PRDEllj0x48WuBLarQ0WcORmDm+TWdXW5c3c9qygjRRt6FBOOGLQ==" // Sara.1234
                     },

				 new AppUser
					 {
							Id="1",
							UserName="ahmed",
							NormalizedUserName="AHMED",
							NID="12345678901234",
							gender=Gender.Male,
							City="sowhag",
							Country="Egypt",
							Street="jijdijdied",
							IsDeleted=false,
							PasswordHash="Ag1234#"
					 },

				 new AppUser
					 {
							Id="2",
							UserName="Mahmod",
							NormalizedUserName="MAHMOD",
							NID="12345678901234",
							gender=Gender.Male,
							City="sowhag",
							Country="Egypt",
							Street="jijdijdied",
							IsDeleted=false,
							PasswordHash="Ag1234#"
					 }

			});
            modelBuilder.Entity<Admin>().HasData(new[]
            {
                 new Admin
                     {
                        AppUserId="22",
                        TotalProfit=0,

                     }

            });
                        modelBuilder.Entity<Customer>().HasData(new[]
            {
                 new Customer
                     {
                        AppUserId="1",

                     }

            });
            modelBuilder.Entity<Hotel_Manager>().HasData(new[]
			{
				 new Hotel_Manager
					 {
						AppUserId="1"

					 },

				 new Hotel_Manager
					 {
						AppUserId="2"
					 }

			});

			modelBuilder.Entity<Hotel>().HasData(new[]
			{
				 new Hotel
					 {
						Id=1,
                        Name="Haway",
                        Description="vhmvhhbhggjhjklmkl",
                        Rate=Hotel_Rate_Star.FiveStars,
                        City="hurgada",
                        Country="egypt",
                        Street="ghghg",
                        Hotel_ManagerId="1",
                        IsConfermed=true,
                        IsDeleted=false,

					 },

				 new Hotel
					 {
						Id=2,
						Name="Holy",
						Description="vhmvhhbhggjhjklmkl",
						Rate=Hotel_Rate_Star.FiveStars,
						City="hurgada",
						Country="egypt",
						Street="ghghg",
						Hotel_ManagerId="2",
						IsConfermed=true,
						IsDeleted=false,

					 }

			});


			modelBuilder.Entity<Room>().HasData(new[]
            {
                 new Room
                     {
                        Id=1,
                        Description="hhuehuehuhdjhskcsndvjvjnjjjjhhduewyromknzvbmxb",
                        Room_Num=200,
                        NumOfAdults=3,
                        Cost_Per_Night=900,
                        ISavailable=true,
                        HotelId=1,
                        IsDeleted=false,
                        IsNormalRoom=true,

                     },
                 new Room
                     {
                        Id=2,
                        Description="hhuehuehuhdjhskcsndvjvjnjjjjhhduewyromknzvbmxb",
                        Room_Num=210,
                        NumOfAdults=2,
                        Cost_Per_Night=700,
                        ISavailable=true,
                        HotelId=2,
                        IsDeleted=false,
                        IsNormalRoom=true,

                     },
                 new Room
                     {
                        Id=3,
                        Description="hhuehuehuhdjhskcsndvjvjnjjjjhhduewyromknzvbmxb",
                        Room_Num=100,
                        NumOfAdults=6,
                        Cost_Per_Night=1500,
                        ISavailable=true,
                        HotelId=2,
                        IsDeleted=false,
                        IsNormalRoom=false,

                     },
                 new Room
                     {
                        Id=4,
                        Description="hhuehuehuhdjhskcsndvjvjnjjjjhhduewyromknzvbmxb",
                        Room_Num=110,
                        NumOfAdults=2,
                        Cost_Per_Night=700,
                        ISavailable=true,
                        HotelId=1,
                        IsDeleted=false,
                        IsNormalRoom=true,

                     },
                 new Room
                     {
                        Id=5,
                        Description="hhuehuehuhdjhskcsndvjvjnjjjjhhduewyromknzvbmxb",
                        Room_Num=180,
                        NumOfAdults=1,
                        Cost_Per_Night=600,
                        ISavailable=true,
                        HotelId=2,
                        IsDeleted=false,
                        IsNormalRoom=true,

                     },
                 new Room
                     {
                        Id=6,
                        Description="hhuehuehuhdjhskcsndvjvjnjjjjhhduewyromknzvbmxb",
                        Room_Num=200,
                        NumOfAdults=7,
                        Cost_Per_Night=2000,
                        ISavailable=true,
                        HotelId=1,
                        IsDeleted=false,
                        IsNormalRoom=false,

                     }

            });
            modelBuilder.Entity<Normal_Room>().HasData(new[]
            {
                 new Normal_Room
                     {
                        RoomId=1,
                        Type_Of_Room=Type_Of_Room.Triple

                     },
               new Normal_Room
                     {
                        RoomId=2,
                        Type_Of_Room=Type_Of_Room.Double

                     },
               new Normal_Room
                     {
                        RoomId=4,
                        Type_Of_Room=Type_Of_Room.Double

                     },
               new Normal_Room
                     {
                        RoomId=5,
                        Type_Of_Room=Type_Of_Room.Single

                     },

            });
            modelBuilder.Entity<Suit>().HasData(new[]
            {
                 new Suit
                     {
                        RoomId=3,
                        Num_Of_Rooms=3,

                     },
               new Suit
                     {
                       RoomId=6,
                       Num_Of_Rooms=3,

                     }

            });
            //AppUser userModel = new AppUser();

            //userModel.UserName = "Youstina";
            //userModel.PasswordHash = "Y10002000#";
            //userModel.Email = "shagon288@gmail.com";
            //userModel.gender = Gender.Female;
            //userManager.AddToRoleAsync(userModel, "Admin");
            //userManager.CreateAsync(userModel);


            //Admin admin = new Admin();
            //admin.AppUserId = userModel.Id;

            //var modelsCreating = new List<IOnModelCreate>();
            //modelsCreating.Add(userModel);
            //modelsCreating.Add(admin);



            //modelBuilder.Entity<AppUser>().HasData(new AppUser()
            //{
            //    UserName = "Youstina",
            //    PasswordHash = "Y10002000#",
            //    Email = "shagon288@gmail.com",
            //    gender = Gender.Female,

            //});

            DateTime startDate = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime endDate = new DateTime(DateTime.Now.Year, 12, 31);

            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                modelBuilder.Entity<BookingDate>().HasData(new BookingDate
                {
                    Id = Guid.NewGuid(),
                    Date = date,
                    // Value = // set your desired value for this date here
                });
            }

            modelBuilder.Entity<BookingCheck>()
           .HasKey(e => new { e.RoomId, e.BookingDateId });
            foreach (var relation in modelBuilder.Model.GetEntityTypes().SelectMany(r => r.GetForeignKeys()))
            {
                relation.DeleteBehavior = DeleteBehavior.NoAction;
            }

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityUserLogin<string>>()
                .HasKey(l => new { l.LoginProvider, l.ProviderKey });
        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Hotel_Manager> Hotel_Managers { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Normal_Room> normal_Rooms { get; set; }
        public DbSet<Suit> Suits { get; set; }

        public DbSet<Review> Reviews { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<image> image { get; set; }
        public DbSet<BookingCheck> bookingChecks { get; set; }
        public DbSet<BookingDate> bookingDates { get; set; }




    }
}
