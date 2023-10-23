using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking.Domain.Entities;

namespace Booking.Application.Services.Interface
{
    public interface IBookingService
    {
        void CreateBooking(booking booking);
        booking GetBookingById(int bookingId);
        IEnumerable<booking> GetAllBookings(string userId="",string? statusFilterList="");

        void UpdateStatus(int bookingId, string bookingStatus, int villaNumber);
        void UpdateStripePaymentID(int bookingId, string sessionId, string paymentIntentId);

        public IEnumerable<int> GetCheckedInVillaNumbers(int villaId);
    }
}
