create table student([sid] int, [name] varchar(30) not null,class varchar(30) not null,section char(1) not null,mobile varchar(20),constraint com_pk primary key([sid],mobile))
insert into student values(1,'Akhil','4','A',9090909090)
insert into student values(2,'Amal','2','A',9394959631)
insert into student values(3,'Alen','1','A',7838593721)
select * from student
create table person (pid int identity(1,1) primary key,[name] varchar(20) not null)
insert into person values('james')
insert into person values('Manoj')
select * from person