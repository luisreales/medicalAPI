-- Database: medicaldb

--DROP DATABASE IF EXISTS medicaldb;


---CREATE TABLES FOR PROYECT

-- Create facilities table
CREATE TABLE facilities (
    id SERIAL PRIMARY KEY,
    name VARCHAR(255),
    city VARCHAR(255)
);

-- Create patients table
CREATE TABLE patients (
    id SERIAL PRIMARY KEY,
    first_name VARCHAR(255),
    last_name VARCHAR(255),
    age INT
);

-- Create payers table
CREATE TABLE payers (
    id SERIAL PRIMARY KEY,
    name VARCHAR(255),
    city VARCHAR(255)
);

-- Create encounters table
CREATE TABLE encounters (
    id SERIAL PRIMARY KEY,
    patient_id INT REFERENCES patients(id),
    facility_id INT REFERENCES facilities(id),
    payer_id INT REFERENCES payers(id)
    
);

--INSERT DATA facilities

INSERT INTO facilities (id, name, city) VALUES
(1, 'General Hospital', 'New York'),
(2, 'Sunshine Clinic', 'Los Angeles'),
(3, 'City Health Center', 'Chicago'),
(4, 'Downtown Medical', 'Houston'),
(5, 'Mercy Hospital', 'Phoenix'),
(6, 'Saint Marys', 'Philadelphia'),
(7, 'Green Valley Clinic', 'San Antonio'),
(8, 'Lakeside Medical', 'San Diego'),
(9, 'Central Health', 'Dallas'),
(10, 'Northside Hospital', 'San Jose'),
(11, 'Riverbank Clinic', 'Austin'),
(12, 'Eastside Medical', 'Jacksonville'),
(13, 'West End Health', 'Fort Worth'),
(14, 'Pine Tree Clinic', 'Columbus'),
(15, 'Sunnybrook Hospital', 'Charlotte'),
(16, 'Oakwood Medical', 'San Francisco'),
(17, 'Cedar Grove Health', 'Indianapolis'),
(18, 'Maple Leaf Clinic', 'Seattle'),
(19, 'Hilltop Hospital', 'Denver'),
(20, 'Valley View Medical', 'Washington');

--INSERT DATA patients

INSERT INTO patients (id, first_name, last_name, age) VALUES
(1, 'John', 'Doe', 15),
(2, 'Jane', 'Smith', 34),
(3, 'Alice', 'Johnson', 28),
(4, 'Robert', 'Brown', 10),
(5, 'Emily', 'Davis', 30),
(6, 'Michael', 'Miller', 40),
(7, 'Jessica', 'Wilson', 27),
(8, 'Daniel', 'Moore', 11),
(9, 'Laura', 'Taylor', 36),
(10, 'James', 'Anderson', 10),
(11, 'Sarah', 'Thomas', 16),
(12, 'David', 'Jackson', 17),
(13, 'Karen', 'White', 37),
(14, 'Matthew', 'Harris', 14),
(15, 'Lisa', 'Martin', 41),
(16, 'Kevin', 'Thompson', 32),
(17, 'Nancy', 'Garcia', 44),
(18, 'Paul', 'Martinez', 35),
(19, 'Sandra', 'Robinson', 46),
(20, 'Mark', 'Clark', 39);


--INSERT DATA payers

INSERT INTO payers (id, name, city) VALUES
(1, 'HealthPlus Insurance', 'New York'),
(2, 'MediCare Solutions', 'Los Angeles'),
(3, 'Wellness Coverage', 'Chicago'),
(4, 'Secure Health', 'Houston'),
(5, 'HealthyLife Insurance', 'Phoenix'),
(6, 'PrimeCare', 'Philadelphia'),
(7, 'Total Health', 'San Antonio'),
(8, 'CareFirst', 'San Diego'),
(9, 'United Health', 'Dallas'),
(10, 'Optimum Care', 'San Jose'),
(11, 'First Health', 'Austin'),
(12, 'BlueShield', 'Jacksonville'),
(13, 'WellCare', 'Fort Worth'),
(14, 'Aetna', 'Columbus'),
(15, 'Cigna', 'Charlotte'),
(16, 'Humana', 'San Francisco'),
(17, 'MetLife', 'Indianapolis'),
(18, 'Anthem', 'Seattle'),
(19, 'Liberty Health', 'Denver'),
(20, 'Kaiser Permanente', 'Washington');


--INSERT DATA FOR encounters
INSERT INTO encounters (id, patient_id, facility_id, payer_id) VALUES
(1, 1, 1, 1),
(2, 2, 2, 2),
(3, 3, 3, 3),
(4, 4, 4, 4),
(5, 5, 5, 5),
(6, 6, 6, 6),
(7, 7, 7, 7),
(8, 8, 8, 8),
(9, 9, 9, 9),
(10, 10, 10, 10),
(11, 11, 11, 11),
(12, 12, 12, 12),
(13, 13, 13, 13),
(14, 14, 14, 14),
(15, 15, 15, 15),
(16, 16, 16, 16),
(17, 17, 17, 17),
(18, 18, 18, 18),
(19, 19, 19, 19),
(20, 20, 20, 20),
(21, 1, 2, 3),
(22, 2, 3, 4),
(23, 3, 4, 5),
(24, 4, 5, 6),
(25, 5, 6, 7),
(26, 6, 7, 8),
(27, 7, 8, 9),
(28, 8, 9, 10),
(29, 9, 10, 11),
(30, 10, 11, 12),
(31, 11, 12, 13),
(32, 12, 13, 14),
(33, 13, 14, 15),
(34, 14, 15, 16),
(35, 15, 16, 17),
(36, 16, 17, 18),
(37, 17, 18, 19),
(38, 18, 19, 20),
(39, 19, 20, 1),
(40, 20, 1, 2),
(41, 1, 3, 3),
(42, 2, 4, 4),
(43, 3, 5, 5),
(44, 4, 6, 6),
(45, 5, 7, 7),
(46, 6, 8, 8),
(47, 7, 9, 9),
(48, 8, 10, 10),
(49, 9, 11, 11),
(50, 10, 12, 12);
