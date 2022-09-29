using APIModels.Entities;
using Microsoft.EntityFrameworkCore;

namespace APIDataAccess
{
    public class CarTenderDataContext : DbContext
    {
        public CarTenderDataContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<BidOfferDetail>().HasKey(t => new { t.BidCarID, t.BidUserOfferID });

            modelBuilder.Entity<RoleAuthorization>().HasKey(t => new { t.RoleID, t.AuthorizationID, t.PageAuthorizationID });

            modelBuilder.Entity<PackageCorporate>().HasKey(t => new { t.PackageID, t.CorporateID });

            #region Advert              

            modelBuilder.Entity<Advert>()
                .HasOne(x => x.Adder)
                .WithMany()
                .HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region AdvertStatusHistory

            modelBuilder.Entity<AdvertStatusHistory>()
                .HasOne(x => x.Adder)
                .WithMany()
                .HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<AdvertStatusHistory>()
                .HasOne(x => x.Modifier)
                .WithMany()
                .HasForeignKey(x => x.ModifiedBy).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<AdvertStatusHistory>()
                .HasOne(x => x.Status)
                .WithMany(x => x.OfferStatusHistories)
                .HasForeignKey(x => x.StatuID).OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region BidCar

            modelBuilder.Entity<BidCar>()
               .HasOne(x => x.Adder)
               .WithMany()
               .HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<BidCar>()
                .HasOne(x => x.Modifier)
                .WithMany()
                .HasForeignKey(x => x.ModifiedBy).OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region BidCorporateUser            

            modelBuilder.Entity<BidCorporateUser>()
               .HasOne(x => x.Adder)
               .WithMany()
               .HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<BidCorporateUser>()
                .HasOne(x => x.Modifier)
                .WithMany()
                .HasForeignKey(x => x.ModifiedBy).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<BidCorporateUser>()
                .HasOne(x => x.BidInformation)
                .WithMany(x => x.BidCorporateUser)
                .HasForeignKey(x => x.BidID).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<BidCorporateUser>()
                .HasOne(x => x.User)
                .WithMany(x => x.BidCorporateUsers)
                .HasForeignKey(x => x.UserID).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<BidCorporateUser>()
                .HasOne(x => x.Corporate)
                .WithMany(x => x.BidCorporateUsers)
                .HasForeignKey(x => x.CorporateID).OnDelete(DeleteBehavior.NoAction);

            #endregion            

            #region BidInfo

            modelBuilder.Entity<BidInformation>()
               .HasOne(x => x.Approver)
               .WithMany()
               .HasForeignKey(x => x.ApprovedBy).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<BidInformation>()
                .HasOne(x => x.Finisher)
                .WithMany()
                .HasForeignKey(x => x.FinishedBy).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<BidInformation>()
                .HasOne(x => x.Adder)
                .WithMany()
                .HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<BidInformation>()
                .HasOne(x => x.Modifier)
                .WithMany()
                .HasForeignKey(x => x.ModifiedBy).OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region BidStatusHistory

            modelBuilder.Entity<BidStatusHistory>()
                .HasOne(x => x.Adder)
                .WithMany()
                .HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<BidStatusHistory>()
                .HasOne(x => x.Modifier)
                .WithMany()
                .HasForeignKey(x => x.ModifiedBy).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<BidStatusHistory>()
                .HasOne(x => x.Status)
                .WithMany(x => x.BidStatusHistories)
                .HasForeignKey(x => x.StatuID).OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region BidUserOffer

            modelBuilder.Entity<BidUserOffer>()
               .HasOne(x => x.BidCorporateUser)
               .WithMany(x => x.BidUserOffers)
               .HasForeignKey(x => x.BidCorporateUserID).OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region CarBuyer

            modelBuilder.Entity<CarBuyerInformation>()
                .HasOne(ps => ps.Car)
                .WithMany()
                .HasForeignKey(ps => ps.CarID).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<CarBuyerInformation>()
                .HasOne(ps => ps.User)
                .WithMany()
                .HasForeignKey(ps => ps.UserID).OnDelete(DeleteBehavior.NoAction);

            #endregion           

            #region CarModification

            modelBuilder.Entity<CarModification>().HasKey(t => new { t.ModificationID, t.CarID });

            #endregion

            #region CarStatusHistory

            modelBuilder.Entity<CarStatusHistory>()
                .HasOne(x => x.Adder)
                .WithMany()
                .HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<CarStatusHistory>()
                .HasOne(x => x.CarStatus)
                .WithMany(x => x.CarStatusHistories)
                .HasForeignKey(x => x.CarStatuID).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<CarStatusHistory>()
                .HasOne(x => x.Modifier)
                .WithMany()
                .HasForeignKey(x => x.ModifiedBy).OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region CarValue

            modelBuilder.Entity<CarValue>()
                .HasKey(t => new { t.CarID, /*t.CarDetailID,*/ t.CarValueID });

            modelBuilder.Entity<CarValue>()
                .HasOne(ps => ps.Car)
                .WithMany(p => p.CarValues)
                .HasForeignKey(ps => ps.CarID).OnDelete(DeleteBehavior.NoAction);

            /* modelBuilder.Entity<CarValue>()
                 .HasOne(ps => ps.CarDetail)
                 .WithMany(p => p.CarValue)
                 .HasForeignKey(ps => ps.CarDetailID).OnDelete(DeleteBehavior.NoAction);*/

            modelBuilder.Entity<CarValue>()
                .HasOne(ps => ps.CarDetailValue)
                .WithMany(p => p.CarValue)
                .HasForeignKey(ps => ps.CarValueID).OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region CorporateStatusHistory

            modelBuilder.Entity<CorporateStatusHistory>()
                .HasOne(x => x.Adder)
                .WithMany()
                .HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<CorporateStatusHistory>()
                .HasOne(x => x.Modifier)
                .WithMany()
                .HasForeignKey(x => x.ModifiedBy).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<CorporateStatusHistory>()
                .HasOne(x => x.Status)
                .WithMany(x => x.CorporateStatusHistories)
                .HasForeignKey(x => x.StatuID).OnDelete(DeleteBehavior.NoAction);

            #endregion                     

            #region CorporateUser

            modelBuilder.Entity<CorporateUser>().HasKey(t => new { t.CorporateID, t.UserID });

            modelBuilder.Entity<CorporateUser>()
                .HasOne(x => x.Corporate)
                .WithMany(x => x.CorporateUsers)
                .HasForeignKey(x => x.CorporateID).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<CorporateUser>()
                .HasOne(x => x.User)
                .WithMany(x => x.CorporateUsers)
                .HasForeignKey(x => x.UserID).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<CorporateUser>()
                .HasOne(x => x.CorporateRole)
                .WithMany(x => x.CorporateUsers)
                .HasForeignKey(x => x.CorporateRoleID).OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region TramerInformation

            modelBuilder.Entity<TramerInformation>()
                .HasOne(ps => ps.Adder)
                .WithMany()
                .HasForeignKey(ps => ps.CreatedBy).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TramerInformation>()
                .HasOne(ps => ps.Modifier)
                .WithMany()
                .HasForeignKey(ps => ps.ModifiedBy).OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region TramerInformationComponent

            modelBuilder.Entity<TramerInformationComponent>().HasKey(t => new { t.TramerInformationID, t.TramerComponentID });

            modelBuilder.Entity<TramerInformationComponent>()
               .HasOne(ps => ps.TramerComponent)
               .WithMany(p => p.TramerComponentStatus)
               .HasForeignKey(ps => ps.TramerComponentID).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TramerInformationComponent>()
                .HasOne(ps => ps.TramerInformation)
                .WithMany(p => p.TramerComponentStatus)
                .HasForeignKey(ps => ps.TramerInformationID).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<UserCar>().HasKey(t => new { t.UserID, t.CarID });

            #endregion

            #region TramerStatusHistory

            modelBuilder.Entity<TramerStatusHistory>()
                .HasOne(x => x.Adder)
                .WithMany()
                .HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TramerStatusHistory>()
               .HasOne(x => x.Status)
               .WithMany(x => x.TramerStatusHistories)
               .HasForeignKey(x => x.StatuID).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TramerStatusHistory>()
                .HasOne(x => x.Modifier)
                .WithMany()
                .HasForeignKey(x => x.ModifiedBy).OnDelete(DeleteBehavior.NoAction);

            #endregion        

            #region UserCar

            modelBuilder.Entity<UserCar>()
                .HasKey(t => new { t.CarID, t.UserID });

            modelBuilder.Entity<UserCar>()
                .HasOne(ps => ps.Car)
                .WithMany(x => x.UserCars)
                .HasForeignKey(ps => ps.CarID).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<UserCar>()
                .HasOne(ps => ps.User)
                .WithMany(p => p.UserCars)
                .HasForeignKey(ps => ps.UserID).OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region UserFavoriteCar

            modelBuilder.Entity<UserFavoriteCar>().HasKey(t => new { t.UserID, t.CarID });

            modelBuilder.Entity<UserFavoriteCar>()
                .HasOne(ps => ps.Car)
                .WithMany(p => p.UserFavoriteCars)
                .HasForeignKey(ps => ps.CarID).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<UserFavoriteCar>()
                .HasOne(ps => ps.User)
                .WithMany(p => p.UserFavoriteCars)
                .HasForeignKey(ps => ps.UserID).OnDelete(DeleteBehavior.NoAction);

            #endregion         

        }
        public DbSet<AddressInformation> AddressInformation { get; set; }
        public DbSet<Advert> Advert { get; set; }
        public DbSet<AdvertStatusHistory> AdvertStatusHistory { get; set; }
        public DbSet<Authorization> Authorazition { get; set; }
        public DbSet<BidCar> BidCar { get; set; }
        public DbSet<BidCorporateUser> BidCorporateUser { get; set; }
        public DbSet<BidInformation> BidInformation { get; set; }
        public DbSet<BidOfferDetail> BidOfferDetail { get; set; }
        public DbSet<BidStatusHistory> BidStatusHistory { get; set; }
        public DbSet<BidUserOffer> BidUserOffer { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<CarBuyerInformation> CarBuyerInformation { get; set; }
        public DbSet<CarDetail> CarDetail { get; set; }
        public DbSet<CarDetailValue> CarDetailValue { get; set; }
        public DbSet<CarImage> CarImage { get; set; }
        public DbSet<CarModification> CarModification { get; set; }
        public DbSet<CarStatusHistory> CarStatusHistory { get; set; }
        public DbSet<CarValue> CarValue { get; set; }
        public DbSet<Corporate> Corporate { get; set; }
        public DbSet<CorporateRole> CorporateRole { get; set; }
        public DbSet<CorporateStatusHistory> CorporateStatusHistory { get; set; }
        public DbSet<CorporateUser> CorporateUser { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<Expertise> Expertise { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<MessageContent> MessageContent { get; set; }
        public DbSet<Modification> Modification { get; set; }
        public DbSet<Neighborhood> Neighborhood { get; set; }
        public DbSet<Package> Package { get; set; }
        public DbSet<PackageCorporate> PackageCorporate { get; set; }
        public DbSet<PageAuthorization> PageAuthorization { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<RoleAuthorization> RoleAutherization { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Town> Town { get; set; }
        public DbSet<TramerComponent> TramerComponent { get; set; }
        public DbSet<TramerInformation> TramerInformation { get; set; }
        public DbSet<TramerInformationComponent> TramerInformationComponent { get; set; }
        public DbSet<TramerStatusHistory> TramerStatusHistory { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserCar> UserCar { get; set; }
        public DbSet<UserFavoriteCar> UserFavoriteCar { get; set; }

    }
}
