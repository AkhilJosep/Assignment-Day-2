select getdate()
select year('1/23/2023')
select month('1/23/2023')
select day('1/23/2023')
select * from sales where year(ord_date)=1994
select DATEPART(yy,'2.20.2020')
select DATEPART(mm,'2.20.2020')
select DATEPART(dd,'2.20.2020')
select DATEPART(dw,'1.12.2024')
select DATEPART(yy,'2.20.2020')
select DATEDIFF(yy,'3.30.2002',getdate())
select DATEDIFF(mm,'3.30.2002',getdate())
select DATEDIFF(dd,'3.30.2002',getdate())
select isDate('1.1.2000')
select isdate('100.1.2000')
select DATEADD(yy,3,'3.12.2010')
select DATEADD(mm,3,'3.12.2010')
select DATEADD(dd,3,'3.12.2010')

select LEN('Hello World') as [Length]
select UPPER('hello world')