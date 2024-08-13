package com.luxestay.LuxeStay.service.interfac;

import com.luxestay.LuxeStay.dto.Response;
import com.luxestay.LuxeStay.entity.Booking;

public interface IBookingService {

    Response saveBooking(Long roomId, Long userId, Booking bookingRequest);

    Response findBookingByConfirmationCode(String confirmationCode);

    Response getAllBookings();

    Response cancelBooking(Long bookingId);

}
