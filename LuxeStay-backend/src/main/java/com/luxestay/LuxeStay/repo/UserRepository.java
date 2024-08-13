package com.luxestay.LuxeStay.repo;

import org.springframework.data.jpa.repository.JpaRepository;

import com.luxestay.LuxeStay.entity.User;

import java.util.Optional;

public interface UserRepository extends JpaRepository<User, Long> {

    boolean existsByEmail(String email);

    Optional<User> findByEmail(String email);
}
