use Assignment

create table Department(Dept_no varchar(5) ,Dept_name varchar(40) not null,[location] varchar(40))
select * from Department

insert into Department values('d1','Reasearch','Dallas')
insert into Department values('d2','Accounting','Scattle')
insert into Department values('d3','Marketing','Dallas')
select * from Department


create table Employee(emp_no varchar(5) ,emp_fname varchar(40) not null,emp_lname varchar(40) not null,dept_no varchar(40) not null)
select * from Employee

insert into Employee values (25348,'Mathews','Smith','d3') 
insert into Employee values (10102,'Ann','Jones','d3') 
insert into Employee values (18316,'John','Barrimore','d1') 
insert into Employee values (29346,'James','James','d2') 
select * from Employee

