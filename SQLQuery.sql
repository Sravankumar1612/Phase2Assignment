--Creating database
create database OurExcercise1Db on primary
(NAME='Custs_Db' ,FILENAME='E:\Dotnet\Phase2\Assignments\Assignment1\OurExercise1_Db.mdf',
SIZE=24MB, MAXSIZE=64MB,FILEGROWTH=8MB)
LOG ON
(NAME='Custs_log', FILENAME='E:\Dotnet\Phase2\Assignments\Assignment1\OurExercise1_log.ldf',
SIZE=8MB, MAXSIZE=16MB,FILEGROWTH=4MB)
COLLATE SQL_Latin1_General_CP1_CI_AS
--------------------------------------------------------
use OurExcercise1Db
create table StudentRegistration(
StudentId int not null,
CourseId nvarchar(50) not null,
RegistrationDate date not null,
constraint pk_std primary key (StudentId,CourseId))

insert into StudentRegistration values(1,'j123','03/01/2023')
insert into StudentRegistration values(2,'P123','03/01/2023')
insert into StudentRegistration values(3,'S123','03/01/2023')
insert into StudentRegistration values(4,'H123','03/01/2023')
insert into StudentRegistration values(1,'C123','03/01/2023')
insert into StudentRegistration values(6,'j123','03/01/2023')
select *from StudentRegistration

insert into StudentRegistration values(2,'P123','03/01/2023')
--Violation of PRIMARY KEY constraint 'pk_std'. 
--Cannot insert duplicate key in object 'dbo.StudentRegistration'. The duplicate key value is (2, P123).
