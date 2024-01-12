use pubs
select * from employee
select emp_id,fname,lname from employee
select emp_id,hire_date from employee
select emp_id,fname+' '+lname as fullname from employee
select * from employee where job_id=10
select * from employee where job_id=10 and pub_id=1389
select * from employee where job_id=10 or pub_id=1389
select * from employee where job_id in(14,10,8)
select * from employee where fname in('Aria','Anabela','Manuel')
select * from employee where hire_date between '1.0.1990' and '12,31,1992'
select * from employee where job_id not in (14,10,8)
select * from authors where city ='Oakland' 
select * from employee where fname like'%p'
select * from employee where fname like 'e%'
select * from employee where fname like'p%e'
select * from employee where fname like '%j%'
select * from employee where fname like '_a%'
select * from employee where fname like '[kp]%'
select * from employee where fname not like '[kp]%'
select * from employee where fname like '[^kp]%'