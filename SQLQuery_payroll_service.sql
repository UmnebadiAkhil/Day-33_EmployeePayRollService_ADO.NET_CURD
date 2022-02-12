create database payroll_service

-- Create Table
create table payroll_service(EmployeeId int identity(1,1),EmployeeName varchar(20),PhoneNumber varchar(10) NOT NULL, Address varchar(20) NOT NULL, Department varchar(20) NOT NULL,Gender char(1) NOT NULL,BasicPay float NOT NULL , Deductions float NOT NULL,TaxablePay float NOT NULL ,Tax float  NOT NULL ,NetPay float NOT NULL , StartDate DATETIME DEFAULT GETDATE(),City varchar(10) DEFAULT 'Pune',Country varchar(10) DEFAULT 'IN');
select * from payroll_service;  ---Display table



--insert Values of the table
insert into payroll_service(EmployeeName,PhoneNumber,Address,Department,Gender,BasicPay,Deductions,TaxablePay,Tax,NetPay) values('Terisa','8788616249','Pune','HR','F','20000','2000','1000','200','18000');
select * from payroll_service;  ---Display table

--insert Values of the table
insert into payroll_service(EmployeeId,EmployeeName,PhoneNumber,Address,Department,Gender,BasicPay,Deductions,TaxablePay,Tax,NetPay,StartDate,City,Country) values('2','Akhil','8904839805','Sirugapuram','HR','M','210000','1000','100','1200','18000','2021-02-12','Kurnool','IN');
select * from payroll_service;  ---Display table
delete from payroll_service where EmployeeId=2;
drop table payroll_service;
