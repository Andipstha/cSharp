--create database bit3sem

Use bit3rdsem
go

--CREATE TABLE Student2 ( id int identity(1,1) not null, name nvarchar(255) not null, address nvarchar(255) not null, contact nvarchar(25) not null, primary key (id) );

--Alter table Student2 add college nvarchar (255) NULL

--INSERT INTO Student2 (name,address,contact,college) values ('Sandip','Kathmandu','984767676','KIST' ),
--('andip','Kathmandu','984767676','KIST' ),
--('ndip','Kathmandu','984767676','IST' ),
--('dip','Kathmandu','984767676','NIST' ),
--('ip','Kathmandu','984767676','KISS' ),
--('p','Kathmandu','984767676','LIST' )

/*Select * from Student2 where id>3
Select * from Student2 where name='andip'*/

--update student2 set name='Sandip', address='Kathmandu' ,contact ='9852145254',college='KIST' 

--Select * from Student2

-----------------------------------------------------NEW TABLE CREATED
--CREATE TABLE subject ( id int identity(1,1) not null, sub_name nvarchar(255) not null, faculty nvarchar(255) not null, price nvarchar(25) not null, primary key (id) );


-----------------------------------------------------NEW DATA INSERTED
/*
INSERT INTO subject (sub_name,faculty,price) values ('C Programming','BIT','2000' ),
('A Programming','BIT','2000' ),
('B Programming','BBA','2000' ),
('D Programming','BCA','2000' ),
('E Programming','BIM','2000' )
*/

-----------------------------------------------------SELECT DATA
--Select * from subject where id>3
SELECT * FROM subject 

-----------------------------------------------------UPDATE DATA

--update subject set sub_name='Sandip', faculty='Kathmandu' ,price ='9852145254'

-----------------------------------------------------DELETE DATA

--DELETE FROM subject where id=5



