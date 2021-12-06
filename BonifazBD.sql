Create DataBase CitasMedicas2
Use CitasMedicas2

Create table Administrador(
IDAdministrador int identity(1,1) primary key not null,
CorreoElectronico varchar(30),
Contrase�a varchar(30)
)

Create Table Especialidad(
IDEspecialidad_Nombre varchar(40) primary key not null,
Descripcion varchar(100)  not null
)

Create Table Medico(
IdMedico int identity(1,1) primary key not null,
ApellidoPaterno varchar(30)not null,
ApellidoMaterno varchar(30)not null,
Nombre varchar(30)not null,
Genero char (15)not null,
FechaNacimiento date not null,
CorreoElectronico varchar(30) not null,
Contrase�a varchar(30) not null,
IDEspecialidad_Nombre VARCHAR(40) not null FOREIGN KEY REFERENCES Especialidad(IDEspecialidad_Nombre)
)

Create Table Horarios(
IDHorario int identity(1,1) primary key not null,
Hora_Entrada Time not null,
Hora_Salida Time not null,
IdMedico Int not null FOREIGN KEY REFERENCES Medico(IdMedico)
)


Create Table Paciente(
IdPaciente int identity(1,1) primary key not null,
ApellidoPaterno varchar(30)not null,
ApellidoMaterno varchar(30)not null,
Nombre varchar(30)not null,
Genero char not null,
FechaNacimiento date not null,
CorreoElectronico varchar(30) not null,
Contrase�a varchar(30) not null,
)

--DROP TABLE PACIENTE;
--DROP DATABASE CitasMedicas2

USE Northwind;


Create Table Cita(
IdPaciente int not null FOREIGN KEY REFERENCES Paciente(Idpaciente),
IdMedico Int not null FOREIGN KEY REFERENCES Medico(IdMedico),
Fecha date not null,
Hora TIME not null,
Folio int primary key not null,
StatusS varchar(20)
)

SELECT * FROM PACIENTE;
SELECT * FROM ESPECIALIDAD;


