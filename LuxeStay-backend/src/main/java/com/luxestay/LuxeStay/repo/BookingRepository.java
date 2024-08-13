package com.luxestay.LuxeStay.repo;

import org.springframework.data.jpa.repository.JpaRepository;

import com.luxestay.LuxeStay.entity.Booking;

import java.util.List;
import java.util.Optional;

public interface BookingRepository extends JpaRepository<Booking, Long> {

    Optional<Booking> findByBookingConfirmationCode(String confirmationCode);
    
	/*
	 * List<Booking> findByRoomId(Long roomId);
	 * 
	 * List<Booking> findByConfirmationCode(String confirmationCode);
	 * 
	 * List<Booking> findByUserId(Long userId);
	 */
}
