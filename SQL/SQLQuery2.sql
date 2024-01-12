create table Dept(Dept_code char(5) primary key,Dept_Name Varchar(30) unique not null)
create table Employee(Id int primary key,Name varchar(30),JoinDate Date default getdate(),
salary int check(salary>0),Dept_Code char(5) 
constraint Dept_Code_FK Foreign key(Dept_Code) References Dept(Dept_Code)on delete cascade)

select* from Employee
select*from Dept

insert into Employee values(1,'Ram','12/01/2004',5499,null)
--Add Multiple row

insert into Dept(Dept_code,Dept_Name) values('D001','IT'),('D002','Admin') 
select*from Dept

insert into Employee(Id,Name,Dept_Code) values(2,'Cherry','D0001')
select* from Employee

-----update
update Employee set salary=50000 where id=2
update Employee set salary=53544,Dept_Code='D0001' where id=2
select* from Employee