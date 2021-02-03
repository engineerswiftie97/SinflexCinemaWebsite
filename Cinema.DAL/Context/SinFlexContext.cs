using Cinema.MAP.options;
using Cinema.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Cinema.DAL.Context
{
    public class SinFlexContext:DbContext
    {

        public SinFlexContext() : base("SinflexConnection")
        {

        }

        private static SinFlexContext _dbInstance;

        public static SinFlexContext DBInstance
        {
            get
            {
                if (_dbInstance == null)
                {
                    _dbInstance = new SinFlexContext();
                }
                return _dbInstance;
            }
        }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MemberMap());
            modelBuilder.Configurations.Add(new MovieHallMap());
            modelBuilder.Configurations.Add(new MovieHallSessionMap());
            modelBuilder.Configurations.Add(new MovieMap());
            modelBuilder.Configurations.Add(new MovieSessionMap());
            modelBuilder.Configurations.Add(new ReservationMap());
            modelBuilder.Configurations.Add(new SeatMap());
            modelBuilder.Configurations.Add(new TicketMap());

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Member> Members { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<MemberDetail> MemberDetails { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieHall > MovieHalls { get; set; }
        public DbSet<MovieHallSession> MovieHallSessions { get; set; }
        public DbSet<MovieSession> MovieSessions { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Seat> Seats { get; set; }
    }
}
