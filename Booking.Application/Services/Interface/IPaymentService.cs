using Stripe.Checkout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking.Domain.Entities;

namespace Booking.Application.Services.Interface
{
    public interface IPaymentService
    {
        SessionCreateOptions CreateStripeSessionOptions(booking booking, Villa villa, string domain);
        Session CreateStripeSession(SessionCreateOptions options);

    }
}
