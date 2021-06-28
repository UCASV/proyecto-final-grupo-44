--****************************************************
-- Database: Base de datos de registro de citas
-- Authors: Diego Alejandro Gasteazoro Coen 00315919, 
-- Diego Antonio Bonilla Rivera 00144019, 
-- Roberto Alexander Ramírez Argumedo 00066919,
-- Daniel Alberto Rodríguez Méndez 00035919
-- Group: 44
-- Version: 1.0
--****************************************************
-- Creating database
CREATE DATABASE SGCCDB;	
USE SGCCDB; 				
SET LANGUAGE us_english

-- Tables section.
CREATE TABLE CITIZEN(
	dui CHAR(10) PRIMARY KEY,
	full_name VARCHAR(100),
	email VARCHAR(50),
	phone_number CHAR(11),
	id_cabin INT,					--FK
	home_address VARCHAR(150),
	id_dose INT,					--FK 
	age INT,
	id_occupation INT			    --FK 
);

CREATE TABLE OCCUPATION(
	id INT PRIMARY KEY IDENTITY,
	occupation VARCHAR(30)
);

CREATE TABLE DOSE(
	id INT PRIMARY KEY IDENTITY,
	dose INT
);

CREATE TABLE CHRONIC_ILLNESS(
	id INT PRIMARY KEY IDENTITY,
	chronic_illness VARCHAR(50),
	dui_citizen CHAR(10)	--FK
);

CREATE TABLE APPOINTMENT(
	id INT PRIMARY KEY IDENTITY,
	dt_appointment DATETIME,
	dt_waitlist DATETIME,
	dt_vaccination DATETIME,
	appt_address VARCHAR(150),
	id_status INT,	-- FK
	dui_citizen CHAR(10)	-- FK
);

CREATE TABLE APPT_STATUS(
	id INT PRIMARY KEY IDENTITY,
	appt_status VARCHAR(15)
);

CREATE TABLE OBSERVATION_PERIOD(
	id_appointment INT NOT NULL,		--FK
	id_side_effect INT NOT NULL,		--FK
);

CREATE TABLE SIDE_EFFECT(
	id INT PRIMARY KEY IDENTITY,
	id_symptom INT,		--FK		
	side_effect_time TIME 
);

CREATE TABLE SYMPTOM(
	id INT PRIMARY KEY IDENTITY,
	symptom VARCHAR(30)
);

CREATE TABLE EMPLOYEE(
	id INT PRIMARY KEY IDENTITY,
	employee_name VARCHAR(50),
	employee_address VARCHAR(150),
	email VARCHAR(50),
	manager_username VARCHAR(15),
	manager_password VARCHAR(20),
	id_employee_type INT		--FK
);

CREATE TABLE EMPLOYEE_TYPE(
	id INT PRIMARY KEY IDENTITY,
	employee_type VARCHAR(20)
);

CREATE TABLE CABIN(
	id INT PRIMARY KEY IDENTITY,
	phone_number VARCHAR(11),
	email VARCHAR(50),
	cabin_address VARCHAR(150),
	id_employee INT			--FK
);

CREATE TABLE CABIN_LOGIN(
	id INT PRIMARY KEY IDENTITY,
	id_employee INT NOT NULL,			--FK
	id_cabin INT NOT NULL,			    --FK
	dt_login DATETIME,
);
	
-- Adding primary keys foreign keys
ALTER TABLE OBSERVATION_PERIOD ADD PRIMARY KEY(id_appointment, id_side_effect);
--
ALTER TABLE CITIZEN ADD CONSTRAINT fk_cabin_citizen FOREIGN KEY (id_cabin) REFERENCES CABIN (id) ON DELETE CASCADE;
ALTER TABLE CITIZEN ADD CONSTRAINT fk_dose_citizen FOREIGN KEY (id_dose) REFERENCES DOSE (id) ON DELETE CASCADE;
ALTER TABLE CITIZEN ADD CONSTRAINT fk_occupation_citizen FOREIGN KEY (id_occupation) REFERENCES OCCUPATION (id) ON DELETE CASCADE;

ALTER TABLE CHRONIC_ILLNESS ADD CONSTRAINT fk_citizen_illness FOREIGN KEY (dui_citizen) REFERENCES CITIZEN (dui) ON DELETE CASCADE;

ALTER TABLE APPOINTMENT ADD CONSTRAINT fk_status_appointment FOREIGN KEY (id_status) REFERENCES APPT_STATUS (id);
ALTER TABLE APPOINTMENT ADD CONSTRAINT fk_citizen_appointment FOREIGN KEY (dui_citizen) REFERENCES CITIZEN (dui);

ALTER TABLE OBSERVATION_PERIOD ADD CONSTRAINT fk_appointment_period FOREIGN KEY (id_appointment) REFERENCES APPOINTMENT (id);
ALTER TABLE OBSERVATION_PERIOD ADD CONSTRAINT fk_side_effect_period FOREIGN KEY (id_side_effect) REFERENCES SIDE_EFFECT (id);

ALTER TABLE SIDE_EFFECT ADD CONSTRAINT fk_symptom_effect FOREIGN KEY (id_symptom) REFERENCES SYMPTOM (id) ON DELETE CASCADE;

ALTER TABLE CABIN ADD CONSTRAINT fk_employee_cabin FOREIGN KEY (id_employee) REFERENCES EMPLOYEE (id) ON DELETE CASCADE;

ALTER TABLE CABIN_LOGIN ADD CONSTRAINT fk_cabin_cabin_login FOREIGN KEY (id_cabin) REFERENCES CABIN (id);
ALTER TABLE CABIN_LOGIN ADD CONSTRAINT fk_employee_cabin_login FOREIGN KEY (id_employee) REFERENCES EMPLOYEE (id);

ALTER TABLE EMPLOYEE ADD CONSTRAINT fk_employee_type_employee FOREIGN KEY (id_employee_type) REFERENCES EMPLOYEE_TYPE (id) ON DELETE CASCADE;

-- Inserting necessary data
INSERT INTO EMPLOYEE_TYPE VALUES ('Gestor');
INSERT INTO EMPLOYEE_TYPE VALUES ('Vacunador');
INSERT INTO EMPLOYEE_TYPE VALUES ('Asistente de Salud');
INSERT INTO EMPLOYEE_TYPE VALUES ('Otro trabajo');

SELECT * FROM APPOINTMENT



INSERT INTO EMPLOYEE VALUES ('Diego Gasteazoro', 'San Salvador Flor Blanca Casa 47', 'dgasteazoro@vacuna.gov','Jesus', 'DireEclat', (SELECT id FROM EMPLOYEE_TYPE WHERE employee_type = 'Gestor'));
INSERT INTO EMPLOYEE VALUES ('Diego Bonilla', 'Sonsonate Casa 56', 'dbonilla@vacuna.gov', 'Diego', 'roco11', (SELECT id FROM EMPLOYEE_TYPE WHERE employee_type = 'Gestor'));
INSERT INTO EMPLOYEE VALUES ('Roberto Ramirez', 'Lourdes Colon Casa 40', 'rramirez@vacuna.gov', 'Roberto', 'designer1', (SELECT id FROM EMPLOYEE_TYPE WHERE employee_type = 'Gestor'));
INSERT INTO EMPLOYEE VALUES ('Daniel Mendez', 'San Salvador Casa 15', 'dmendez@vacuna.gov', 'Daniel', '00035919', (SELECT id FROM EMPLOYEE_TYPE WHERE employee_type = 'Gestor'));
INSERT INTO EMPLOYEE VALUES ('Ronaldo Canizalez', 'Antiguo Cuscatlan Casa 26', 'rcanizalez@vacuna.gov', 'Ronaldo', 'POO0121', (SELECT id FROM EMPLOYEE_TYPE WHERE employee_type = 'Gestor'));
INSERT INTO EMPLOYEE VALUES ('Erick Varela', 'Santa Elena Casa 24', 'evarela@vacuna.gov', 'Erick', 'DaTaBaSe', (SELECT id FROM EMPLOYEE_TYPE WHERE employee_type = 'Gestor'));
INSERT INTO EMPLOYEE VALUES ('Miguel Rodriguez', 'San Miguel Casa 9', 'mrodriguez@vacuna.gov', 'Miguel', 'MiGiGiM', (SELECT id FROM EMPLOYEE_TYPE WHERE employee_type = 'Gestor'));
INSERT INTO EMPLOYEE VALUES ('Juan Perez', 'Antiguo Cuscatlan Casa 17', 'jperez@vacuna.gov', NULL, NULL, (SELECT id FROM EMPLOYEE_TYPE WHERE employee_type = 'Vacunador'));
INSERT INTO EMPLOYEE VALUES ('Lorena Diaz', 'Santa Elena Casa 4', 'ldiaz@vacuna.gov', NULL, NULL, (SELECT id FROM EMPLOYEE_TYPE WHERE employee_type = 'Vacunador'));
INSERT INTO EMPLOYEE VALUES ('Diana Escobar', 'Lourdes Casa 22', 'descobar@vacuna.gov', NULL, NULL, (SELECT id FROM EMPLOYEE_TYPE WHERE employee_type = 'Vacunador'));
INSERT INTO EMPLOYEE VALUES ('Brian Flores', 'San Salvador Escalon Casa 29', 'bflores@vacuna.gov', NULL, NULL, (SELECT id FROM EMPLOYEE_TYPE WHERE employee_type = 'Vacunador'));
INSERT INTO EMPLOYEE VALUES ('Alejandra Villalobos', 'Apopa Casa 15', 'avillalobos@vacuna.gov', NULL, NULL, (SELECT id FROM EMPLOYEE_TYPE WHERE employee_type = 'Asistente de Salud'));
INSERT INTO EMPLOYEE VALUES ('Andres Puentes', 'San Miguel Casa 23', 'apuentes@vacuna.gov', NULL, NULL, (SELECT id FROM EMPLOYEE_TYPE WHERE employee_type = 'Asistente de Salud'));
INSERT INTO EMPLOYEE VALUES ('Walter Morales', 'Santa Ana Casa 2', 'wmorales@vacuna.gov', NULL, NULL, (SELECT id FROM EMPLOYEE_TYPE WHERE employee_type = 'Asistente de Salud'));
INSERT INTO EMPLOYEE VALUES ('Ana Henriquez', 'Ciudad Merliot Casa 31', 'ahenriquez@vacuna.gov', NULL, NULL, (SELECT id FROM EMPLOYEE_TYPE WHERE employee_type = 'Otro trabajo'));
INSERT INTO EMPLOYEE VALUES ('Darwin Monke', 'Olocuilta Casa 16', 'dmonke@vacuna.gov', NULL, NULL, (SELECT id FROM EMPLOYEE_TYPE WHERE employee_type = 'Otro trabajo')); 

INSERT INTO APPT_STATUS VALUES ('Agendada');
INSERT INTO APPT_STATUS VALUES ('En proceso');
INSERT INTO APPT_STATUS VALUES ('Finalizada');

INSERT INTO SYMPTOM VALUES ('Dolor y/o sensibilidad');
INSERT INTO SYMPTOM VALUES ('Enrojecimiento');
INSERT INTO SYMPTOM VALUES ('Fatiga');
INSERT INTO SYMPTOM VALUES ('Dolor de cabeza');
INSERT INTO SYMPTOM VALUES ('Fiebre');
INSERT INTO SYMPTOM VALUES ('Mialgia');
INSERT INTO SYMPTOM VALUES ('Artralgia');
INSERT INTO SYMPTOM VALUES ('Anafilaxia');
INSERT INTO SYMPTOM VALUES ('Otros sintomas');

INSERT INTO OCCUPATION VALUES ('Educacion');
INSERT INTO OCCUPATION VALUES ('Personal de salud');
INSERT INTO OCCUPATION VALUES ('Seguridad nacional');
INSERT INTO OCCUPATION VALUES ('Gobierno');
INSERT INTO OCCUPATION VALUES ('Periodismo');
INSERT INTO OCCUPATION VALUES ('Otra o ninguna ocupacion');

INSERT INTO DOSE VALUES (0);
INSERT INTO DOSE VALUES (1);
INSERT INTO DOSE VALUES (2);

INSERT INTO CABIN VALUES ('50322223333', 'cabina1@vacuna.gov', 'San Salvador', (SELECT id FROM EMPLOYEE WHERE employee_name = 'Diego Gasteazoro'));
INSERT INTO CABIN VALUES ('50322237224', 'cabina2@vacuna.gov', 'San Salvador', (SELECT id FROM EMPLOYEE WHERE employee_name = 'Diego Gasteazoro')); 
INSERT INTO CABIN VALUES ('50325176542', 'cabina3@vacuna.gov', 'San Salvador', (SELECT id FROM EMPLOYEE WHERE employee_name = 'Diego Gasteazoro')); 
INSERT INTO CABIN VALUES ('50322789025', 'cabina4@vacuna.gov', 'Sonsonate', (SELECT id FROM EMPLOYEE WHERE employee_name = 'Diego Bonilla')); 
INSERT INTO CABIN VALUES ('50325509879', 'cabina5@vacuna.gov', 'Lourdes', (SELECT id FROM EMPLOYEE WHERE employee_name = 'Roberto Ramirez')); 
INSERT INTO CABIN VALUES ('50322436675', 'cabina6@vacuna.gov', 'San Salvador', (SELECT id FROM EMPLOYEE WHERE employee_name = 'Daniel Mendez')); 
INSERT INTO CABIN VALUES ('50322500790', 'cabina7@vacuna.gov', 'Antiguo Cuscatlan', (SELECT id FROM EMPLOYEE WHERE employee_name = 'Ronaldo Canizalez'));
INSERT INTO CABIN VALUES ('50325007005', 'cabina8@vacuna.gov', 'Santa Elena', (SELECT id FROM EMPLOYEE WHERE employee_name = 'Erick Varela')); 
INSERT INTO CABIN VALUES ('50322221111', 'cabina9@vacuna.gov', 'San Miguel', (SELECT id FROM EMPLOYEE WHERE employee_name = 'Miguel Rodriguez')); 
INSERT INTO CABIN VALUES ('50322558750', 'cabina10@vacuna.gov', 'San Miguel', (SELECT id FROM EMPLOYEE WHERE employee_name = 'Miguel Rodriguez')); 