--only required columns
select firstame,email from students

--fetch only the distinct values of a column
select distinct firstame from students

--count the number of items
select count(*) from students

--order by a column
select * from students
order by firstame desc --asc

--Filter data
select * from students
where age > 20

--Filter by like
select * from students
where age > 20 and firstame like 'S%'

select * from students
where firstame like 'B%'

--Filter by between
select * from students
where age between 18 and 30

--Aggrate - count
select count(*) from students
where age between 18 and 30

--Aggrate - Max and min, Avg, Sum
select max(age) from students
select min(age) from students
select avg(age) from students
select sum(age) from students

--Limit the records
select  top 5 * from students
order by firstame

--Group By
select age,firstame,count(*) from students
group by age,firstame

--Having
select age,count(*) from students
group by age
having count(*) > 1





