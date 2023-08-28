create database ContentDb
use ContentDb

create table Articles
(ArticleId int primary key,
Title nvarchar(50),
Content nvarchar(50),
PublishDate Datetime)

insert into Articles values (1,'ABC','comic','11/12/2022')
insert into Articles values (2,'Hello','Novel','11/08/2021')
insert into Articles values (3,'AAA','Horror','03/10/2018')

select * from Articles