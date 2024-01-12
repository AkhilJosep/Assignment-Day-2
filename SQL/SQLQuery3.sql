create database TrainingDB
--select db
--create a new table
Create table ParticipantList(
Id bigint identity(1,1) not null,
FirstName varchar(20),
LastName varchar(20),
Email varchar(50)
)
select * from ParticipantList
--insert row
insert into ParticipantList values('abiya','Varghese','abiyaelsavarghese@gmail.com')
select * from ParticipantList;
truncate table ParticipantList
drop table ParticipantList;
drop database TrainingDB;
 
--change table name
sp_rename 'ParticipantList','participant'
--change table columnn
sp_rename 'Participant.Email','PEmail'
has context menu
Compose