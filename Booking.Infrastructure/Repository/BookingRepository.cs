using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Booking.Application.Common.Interfaces;
using Booking.Application.Common.Utility;
using Booking.Domain.Entities;
using Booking.Infrastructure.Data;

namespace Booking.Infrastructure.Repository
{
    public class BookingRepository : Repository<booking>, IBookingRepository
    {
        private readonly ApplicationDbContext _db;

        public BookingRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }
        
        public void Update(booking entity)
        {
            _db.Bookings.Update(entity);
        }

       
    }
}
