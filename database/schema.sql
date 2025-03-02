USE sql7764122;

CREATE TABLE Patient (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    Phone VARCHAR(20),
    Password VARCHAR(255) NOT NULL
);

CREATE TABLE Doctor (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Specialization ENUM('Cardiologist', 'Dentist', 'Dermatologist', 'Neurologist', 'Orthopedist', 'Pediatrician', 'Psychiatrist', 'Radiologist', 'General_Practitioner') NOT NULL
);

CREATE TABLE Appointment (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    PatientID INT NOT NULL,
    DoctorID INT NOT NULL,
    StartTime DATETIME NOT NULL,
    EndTime DATETIME NOT NULL,
    Status ENUM('Scheduled', 'Completed', 'Canceled', 'Missed') NOT NULL,
    FOREIGN KEY (PatientID) REFERENCES Patient(ID) ON DELETE CASCADE,
    FOREIGN KEY (DoctorID) REFERENCES Doctor(ID) ON DELETE CASCADE
);

-- Insert Patients
INSERT INTO Patient (Name, Email, Phone, Password) VALUES
('Alice Johnson', 'alice.johnson@example.com', '1234567890', 'hashed_password1'),
('Bob Smith', 'bob.smith@example.com', '2345678901', 'hashed_password2'),
('Charlie Brown', 'charlie.brown@example.com', '3456789012', 'hashed_password3'),
('David Wilson', 'david.wilson@example.com', '4567890123', 'hashed_password4'),
('Emma Davis', 'emma.davis@example.com', '5678901234', 'hashed_password5'),
('Frank Miller', 'frank.miller@example.com', '6789012345', 'hashed_password6'),
('Grace Lee', 'grace.lee@example.com', '7890123456', 'hashed_password7'),
('Henry Clark', 'henry.clark@example.com', '8901234567', 'hashed_password8'),
('Ivy Martinez', 'ivy.martinez@example.com', '9012345678', 'hashed_password9'),
('Jack Anderson', 'jack.anderson@example.com', '1234509876', 'hashed_password10'),
('Katherine Lewis', 'katherine.lewis@example.com', '2345610987', 'hashed_password11'),
('Liam Walker', 'liam.walker@example.com', '3456721098', 'hashed_password12'),
('Mia Hall', 'mia.hall@example.com', '4567832109', 'hashed_password13'),
('Nathan Allen', 'nathan.allen@example.com', '5678943210', 'hashed_password14'),
('Olivia Scott', 'olivia.scott@example.com', '6789054321', 'hashed_password15'),
('Peter Young', 'peter.young@example.com', '7890165432', 'hashed_password16'),
('Quinn King', 'quinn.king@example.com', '8901276543', 'hashed_password17'),
('Rachel Baker', 'rachel.baker@example.com', '9012387654', 'hashed_password18'),
('Samuel Perez', 'samuel.perez@example.com', '1234890765', 'hashed_password19'),
('Tina Carter', 'tina.carter@example.com', '2345901876', 'hashed_password20');

-- Insert Doctors
INSERT INTO Doctor (Name, Specialization) VALUES
('Dr. William Harris', 'Cardiologist'),
('Dr. Susan Clark', 'Dentist'),
('Dr. Thomas Walker', 'Dermatologist'),
('Dr. Emily Rodriguez', 'Neurologist'),
('Dr. James Martinez', 'Orthopedist'),
('Dr. Sarah Lee', 'Pediatrician'),
('Dr. Michael Taylor', 'Psychiatrist'),
('Dr. Laura White', 'Radiologist'),
('Dr. Daniel Hall', 'General_Practitioner'),
('Dr. Jessica Allen', 'Cardiologist');

-- Insert Appointments
INSERT INTO Appointment (PatientID, DoctorID, StartTime, EndTime, Status) VALUES
(1, 1, '2025-03-05 09:00:00', '2025-03-05 09:30:00', 'Scheduled'),
(1, 2, '2025-03-10 10:00:00', '2025-03-10 10:30:00', 'Completed'),
(2, 3, '2025-03-06 11:00:00', '2025-03-06 11:30:00', 'Scheduled'),
(2, 4, '2025-03-12 12:00:00', '2025-03-12 12:30:00', 'Completed'),
(3, 5, '2025-03-07 14:00:00', '2025-03-07 14:30:00', 'Scheduled'),
(3, 6, '2025-03-14 15:00:00', '2025-03-14 15:30:00', 'Completed'),
(4, 7, '2025-03-08 09:30:00', '2025-03-08 10:00:00', 'Scheduled'),
(4, 8, '2025-03-15 10:30:00', '2025-03-15 11:00:00', 'Completed'),
(5, 9, '2025-03-09 11:30:00', '2025-03-09 12:00:00', 'Scheduled'),
(5, 10, '2025-03-16 13:00:00', '2025-03-16 13:30:00', 'Completed'),
(6, 1, '2025-03-10 14:30:00', '2025-03-10 15:00:00', 'Scheduled'),
(6, 2, '2025-03-17 16:00:00', '2025-03-17 16:30:00', 'Completed'),
(7, 3, '2025-03-11 09:00:00', '2025-03-11 09:30:00', 'Scheduled'),
(7, 4, '2025-03-18 10:00:00', '2025-03-18 10:30:00', 'Completed'),
(8, 5, '2025-03-12 11:00:00', '2025-03-12 11:30:00', 'Scheduled'),
(8, 6, '2025-03-19 12:00:00', '2025-03-19 12:30:00', 'Completed'),
(9, 7, '2025-03-13 13:30:00', '2025-03-13 14:00:00', 'Scheduled'),
(9, 8, '2025-03-20 15:00:00', '2025-03-20 15:30:00', 'Completed'),
(10, 9, '2025-03-14 09:30:00', '2025-03-14 10:00:00', 'Scheduled'),
(10, 10, '2025-03-21 11:30:00', '2025-03-21 12:00:00', 'Completed'),
(11, 1, '2025-03-15 14:00:00', '2025-03-15 14:30:00', 'Scheduled'),
(11, 2, '2025-03-22 15:30:00', '2025-03-22 16:00:00', 'Missed'),
(12, 3, '2025-03-16 09:00:00', '2025-03-16 09:30:00', 'Scheduled'),
(12, 4, '2025-03-23 10:30:00', '2025-03-23 11:00:00', 'Completed'),
(13, 5, '2025-03-17 12:30:00', '2025-03-17 13:00:00', 'Scheduled'),
(13, 6, '2025-03-24 14:00:00', '2025-03-24 14:30:00', 'Completed'),
(14, 7, '2025-03-18 15:30:00', '2025-03-18 16:00:00', 'Scheduled'),
(14, 8, '2025-03-25 09:30:00', '2025-03-25 10:00:00', 'Completed'),
(15, 9, '2025-03-19 11:00:00', '2025-03-19 11:30:00', 'Scheduled'),
(15, 10, '2025-03-26 12:30:00', '2025-03-26 13:00:00', 'Completed'),
(16, 1, '2025-03-20 14:00:00', '2025-03-20 14:30:00', 'Scheduled'),
(16, 2, '2025-03-27 15:30:00', '2025-03-27 16:00:00', 'Completed'),
(17, 3, '2025-03-21 09:00:00', '2025-03-21 09:30:00', 'Scheduled'),
(17, 4, '2025-03-28 10:30:00', '2025-03-28 11:00:00', 'Completed'),
(18, 5, '2025-03-22 12:30:00', '2025-03-22 13:00:00', 'Scheduled'),
(18, 6, '2025-03-29 14:00:00', '2025-03-29 14:30:00', 'Missed');


