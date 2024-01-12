---Count,Max,Min,sum,Avg

select * from sales
select count(*) as [count] from sales
select count(*) as[Result] from sales where qty>20
select min(qty) from sales
select max(qty) from sales
select avg(qty) as [AVG] from sales
select min(ord_date) from sales
select max(ord_date) from sales
select sum(qty) as Total from sales