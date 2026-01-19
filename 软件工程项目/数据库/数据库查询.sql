
create database username;
create database StudentDatabase;

drop table Student
use StudentDatabase
create table Student
(
id int  PRIMARY KEY IDENTITY(1, 1),
Name nvarchar(5), 
age int,
Gender nvarchar(5), 
course nvarchar(5), 
HomeAddress nvarchar(30), 
Phone nvarchar(11)
)
INSERT INTO Student (Name, age,Gender, course, HomeAddress, Phone)
VALUES
('张伟', 12, '男', '素描', '武汉市江岸区', '13812345678'),
('李娜', 10, '女', '油画', '武汉市武昌区', '15887654321'),
('王强', 14, '男', '水彩', '武汉市汉阳区', '18898765432'),
('赵丽', 9, '女', '素描', '武汉市青山区', '13912345678'),
('刘洋', 11, '男', '水彩', '武汉市洪山区', '15987654321'),
('陈静', 13, '女', '素描', '武汉市江汉区', '13887654321'),
('吴敏', 8, '女', '油画', '武汉市硚口区', '15812345678'),
('郭强', 15, '男', '水彩', '武汉市东西湖区', '18887654321'),
('孙伟', 12, '男', '油画', '武汉市汉南区', '13987654321'),
('周梅', 10, '女', '素描', '武汉市蔡甸区', '15912345678');

select  * from Student;
select  * from Student where course='素描' and name='*'

select * from Student where id = 1

update Student set Name='张思',age=30,Gender='男',course='水彩',HomeAddress='武汉',Phone=12313412412 where id=4

DECLARE @course VARCHAR(50) = '素描'
DECLARE @name VARCHAR(50) = 'NULL'

SELECT name, course
FROM Student
WHERE 
    (@course IS NULL OR course = @course)
    AND (@name IS NULL OR name = @name);





drop table utable
use username
create table utable
(
id int,
Name nvarchar(5), 
pwd int
)

INSERT INTO utable (id,Name, pwd)
VALUES
(24223048,'王宝原',123456),
(24223047,'王鼎',123456),
(24223050,'黄坤',123456)







