use EmployeeDB


Create table Employees(
	ID int primary key identity,
	FirstName nvarchar(50),
	LastName nvarchar(50),
	Gender nvarchar(50),
	Salary int
)
GO

Insert into Employees values('Mark', 'Hastings', 'Male', 60000)
Insert into Employees values('Steve', 'Pound', 'Male', 45000)
Insert into Employees values('Ben', 'Hoskins', 'Male', 70000)
Insert into Employees values('Philip', 'Hastings', 'Male', 45000)
Insert into Employees values('Mary', 'Lambeth', 'Female', 30000)
Insert into Employees values('Valarie', 'Vikings', 'Female', 35000)
Insert into Employees values('Jahn', 'Stanmore', 'Male', 80000)