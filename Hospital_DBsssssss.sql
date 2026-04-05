CREATE DATABASE IF NOT EXISTS HospitalDB;
USE HospitalDB;
CREATE TABLE IF NOT EXISTS Patient ( 
PatientID INT AUTO_INCREMENT PRIMARY KEY,
 FirstName VARCHAR(50) NOT NULL, 
 LastName VARCHAR(50) NOT NULL, 
 Gender VARCHAR(10), DOB DATE, 
 Phone VARCHAR(15) ); 
INSERT INTO Patient (PatientID) VALUES (1),(2),(3);
CREATE TABLE IF NOT EXISTS OPD (
    OPDID INT AUTO_INCREMENT PRIMARY KEY,
    PatientID INT,
    VisitDate DATE,
    Symptoms VARCHAR(255),
    Doctor VARCHAR(50),
    FOREIGN KEY (PatientID) REFERENCES Patient(PatientID)
);
INSERT INTO OPD (PatientID, VisitDate, Symptoms, Doctor) VALUES
(1, '2026-04-01', 'Rashes, headache', 'Dr. Smith'),
(2, '2026-04-02', 'Cough, sore throat', 'Dr. Jane'),
(3, '2026-04-03', 'Stomach pain', 'Dr. Kim');
CREATE TABLE IF NOT EXISTS Ward (
    WardID INT AUTO_INCREMENT PRIMARY KEY,
    PatientID INT,
    WardNo VARCHAR(10),
    BedNo VARCHAR(10),
    AdmDate DATE,
    FOREIGN KEY (PatientID) REFERENCES Patient(PatientID)
);
INSERT INTO Ward (PatientID, WardNo, BedNo, AdmDate) VALUES
(1, 'A1', '01', '2026-03-30'),
(2, 'B2', '05', '2026-03-31'),
(3, 'C1', '03', '2026-04-01');
CREATE TABLE IF NOT EXISTS Discharge (
    DischargeID INT AUTO_INCREMENT PRIMARY KEY,
    PatientID INT,
    AdmNo INT,
    DischargeDate DATE,
    Summary VARCHAR(255),
    FOREIGN KEY (PatientID) REFERENCES Patient(PatientID)
);
INSERT INTO Discharge (PatientID, AdmNo, DischargeDate, Summary) VALUES
(1, 1, '2026-04-02', 'Recovered from fever'),
(2, 2, '2026-04-03', 'Recovered from cough'),
(3, 3, '2026-04-04', 'Stomach pain treated');
CREATE TABLE IF NOT EXISTS Diagnosis (
    DiagnosisID INT AUTO_INCREMENT PRIMARY KEY,
    PatientID INT,
    Diagnosis VARCHAR(100),
    Test VARCHAR(100),
    Doctor VARCHAR(50),
    FOREIGN KEY (PatientID) REFERENCES Patient(PatientID)
);

INSERT INTO Diagnosis (PatientID, Diagnosis, Test, Doctor) VALUES
(1, 'Malaria', 'Blood test', 'Dr. Smith'),
(2, 'Flu', 'Throat swab', 'Dr. Jane'),
(3, 'Gastritis', 'Stomach ultrasound', 'Dr. Kim');
DESCRIBE OPD;
