--- 1.	Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company. ---
--- o	Use a nested SELECT statement. ---

USE TelerikAcademy
SELECT FirstName, LastName, Salary 
FROM Employees
WHERE Salary = 
(SELECT MIN(Salary) FROM Employees)

--- 2.	Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% higher than the minimal salary for the company. ---

USE TelerikAcademy
SELECT FirstName, LastName, Salary 
FROM Employees
WHERE Salary 
BETWEEN (SELECT MIN(Salary) FROM Employees) AND (SELECT MIN(Salary) FROM Employees) * 1.1

--- 3.	Write a SQL query to find the full name, salary and department of the employees that take the minimal salary in their department. ---
--- o	Use a nested SELECT statement. ---

USE TelerikAcademy
SELECT e.FirstName +' '+ e.LastName AS [Full Name], e.Salary, d.Name
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE e.Salary =
(SELECT MIN(Salary) FROM Employees em WHERE em.DepartmentID = d.DepartmentID)

--- 4.	Write a SQL query to find the average salary in the department #1. ---

USE TelerikAcademy
SELECT AVG(Salary) AS [Average Salary For Department #1] 
FROM Employees
WHERE DepartmentID = 1

--- 5.	Write a SQL query to find the average salary in the "Sales" department. ---

USE TelerikAcademy
SELECT AVG(e.Salary) AS [Average Salary For 'Sales' Department]
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

--- 6.	Write a SQL query to find the number of employees in the "Sales" department. ---

USE TelerikAcademy
SELECT COUNT(*) AS [Employees Count In 'Sales' Department]
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

--- 7.	Write a SQL query to find the number of all employees that have manager. ---

USE TelerikAcademy
SELECT COUNT(*) AS [Employees Count That Have Manager]
FROM Employees e
JOIN Employees m
ON e.ManagerID = m.EmployeeID

--- 8.	Write a SQL query to find the number of all employees that have no manager. ---

USE TelerikAcademy
SELECT COUNT(*) AS [Employees Count That Haven't Manager]
FROM Employees e
LEFT OUTER JOIN Employees m
ON e.ManagerID = m.EmployeeID
WHERE m.LastName IS NULL

--- 9.	Write a SQL query to find all departments and the average salary for each of them. ---

USE TelerikAcademy
SELECT d.Name AS [Department], AVG(e.Salary) AS [Average Salary]
FROM Departments d
JOIN Employees e
ON d.DepartmentID = e.DepartmentID
GROUP BY d.Name

--- 10.	Write a SQL query to find the count of all employees in each department and for each town. ---

USE TelerikAcademy
SELECT t.Name AS [Town], d.Name AS [Department], COUNT(e.EmployeeID) AS [Employees Count]
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
JOIN Addresses a
ON e.AddressID = a.AddressID
JOIN Towns t 
ON a.TownID = t.TownID
GROUP BY t.Name, d.Name

--- 11.	Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name. ---

USE TelerikAcademy
SELECT m.FirstName AS [Manager Name], COUNT(*) AS [Employees Count]
FROM Employees e
JOIN Employees m
ON e.ManagerID = m.ManagerID
GROUP BY m.FirstName
HAVING COUNT(*) = 5

--- 12.	Write a SQL query to find all employees along with their managers. For employees that do not have manager display the value "(no manager)". ---

USE TelerikAcademy
SELECT e.FirstName, e.LastName, ISNULL(m.LastName, 'no manager') AS [Manager]
FROM Employees e
LEFT OUTER JOIN Employees m
ON e.ManagerID = m.EmployeeID

--- 13.	Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. Use the built-inLEN(str) function. ---

USE TelerikAcademy
SELECT FirstName, LastName
FROM Employees
WHERE LEN(LastName) = 5

--- 14.	Write a SQL query to display the current date and time in the following format "day.month.year hour:minutes:seconds:milliseconds". ---
--- o	Search in Google to find how to format dates in SQL Server. ---

USE TelerikAcademy
SELECT CONVERT(NVARCHAR(50), GETDATE(), 104) + ' '
 + CONVERT(NVARCHAR(50), GETDATE(), 114) AS [DateTime]

--- 15.	Write a SQL statement to create a table Users. Users should have username, password, full name and last login time. ---
--- o	Choose appropriate data types for the table fields. Define a primary key column with a primary key constraint. ---
--- o	Define the primary key column as identity to facilitate inserting records. ---
--- o	Define unique constraint to avoid repeating usernames. ---
--- o	Define a check constraint to ensure the password is at least 5 characters long. ---

USE TelerikAcademy
CREATE TABLE Users (
	Id INT IDENTITY NOT NULL,
	Username VARCHAR(16) NOT NULL,
	Password VARCHAR(20) NOT NULL,
	FullName NVARCHAR(20) NOT NULL,
	LastLoginTime DATETIME,
	CONSTRAINT PK_Users PRIMARY KEY CLUSTERED(Id ASC),
	CONSTRAINT Username UNIQUE(Username),
	CONSTRAINT PasswordLength CHECK(DATALENGTH(Password) > 5)
)

GO

--- 16.	Write a SQL statement to create a view that displays the users from the Users table that have been in the system today. ---
--- o	Test if the view works correctly. ---

CREATE VIEW [Recently Logged] AS
SELECT Username, LastLoginTime
FROM Users
WHERE
CONVERT(VARCHAR(10), LastLoginTime, 102) <= CONVERT(VARCHAR(10), GETDATE(), 102)
GO

--- 17.	Write a SQL statement to create a table Groups. Groups should have unique name (use unique constraint). ---
--- o	Define primary key and identity column. ---

USE TelerikAcademy
CREATE TABLE Groups (
	Id INT IDENTITY NOT NULL,
	Name NVARCHAR(20) NOT NULL,
	CONSTRAINT PK_Groups PRIMARY KEY CLUSTERED(Id ASC),
	CONSTRAINT Name UNIQUE(Name)
)

GO

--- 18.	Write a SQL statement to add a column GroupID to the table Users. ---
--- o	Fill some data in this new column and as well in the `Groups table. ---
--- o	Write a SQL statement to add a foreign key constraint between tables Users and Groups tables. ---

USE TelerikAcademy
ALTER TABLE Users
ADD GroupID INT,
CONSTRAINT FK_Users_Groups FOREIGN KEY(GroupID)
REFERENCES Groups(Id)

GO

--- 19.	Write SQL statements to insert several records in the Users and Groups tables. ---

USE TelerikAcademy
INSERT INTO Groups(Name)
VALUES ('VIP'),
		('Sports')
GO

INSERT INTO Users (Username, Password, LastLoginTime, GroupID)
VALUES ('Pesho', 'alabala', GETDATE(), 1),
		('Stamat', 'tintirimintiri', GETDATE(), 1)
GO

--- 20.	Write SQL statements to update some of the records in the Users and Groups tables. ---

USE TelerikAcademy
UPDATE Users
SET LastLoginTime = GETDATE()
WHERE Password IS NULL

--- 21.	Write SQL statements to delete some of the records from the Users and Groups tables. ---

USE TelerikAcademy
DELETE FROM Users
WHERE Username='Stamat'
GO

DELETE FROM Groups
WHERE Id=1
GO

--- 22.	Write SQL statements to insert in the Users table the names of all employees from the Employees table. ---
--- o	Combine the first and last names as a full name. ---
--- o	For username use the first letter of the first name + the last name (in lowercase). ---
--- o	Use the same for the password, and NULL for last login time. ---

USE TelerikAcademy
INSERT INTO Users(Fullname, Username, Password)
SELECT FirstName + ' ' + LastName, LOWER(SUBSTRING(FirstName, 1, 1) + MiddleName + LastName), LOWER(SUBSTRING(FirstName, 1, 1) + MiddleName + LastName)
FROM dbo.Employees 

--- 23.	Write a SQL statement that changes the password to NULL for all users that have not been in the system since 10.03.2010. ---

USE TelerikAcademy
UPDATE Users
SET Password = NULL
WHERE LastLoginTime <= '2010/03/10'

--- 24.	Write a SQL statement that deletes all users without passwords (NULL password). ---

USE TelerikAcademy
DELETE FROM Users
WHERE Password IS NULL

--- 25.	Write a SQL query to display the average employee salary by department and job title. ---

USE TelerikAcademy
SELECT d.Name, e.JobTitle, AVG(Salary) AS [Average Salary]
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle

--- 26.	Write a SQL query to display the minimal employee salary by department and job title along with the name of some of the employees that take it. ---

USE TelerikAcademy
SELECT d.Name AS Department, e.JobTitle AS [Job Title]
, MIN(e.FirstName + e.LastName) AS [Name]
, MIN(e.Salary) AS [Minimal Salary]
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle

--- 27.	Write a SQL query to display the town where maximal number of employees work. ---

USE TelerikAcademy
SELECT TOP 1 t.Name, COUNT(*) as [Employees Count]
FROM Employees e
JOIN Addresses a
ON e.AddressID = a.AddressID
JOIN Towns t
ON a.TownID = t.TownID
GROUP BY t.Name
ORDER BY [Employees Count] DESC

--- 28.	Write a SQL query to display the number of managers from each town. ---

USE TelerikAcademy
SELECT t.Name, COUNT(*) AS [Managers Count]
FROM Employees e
JOIN Employees m 
ON e.ManagerID = m.EmployeeID
JOIN Addresses a
ON m.AddressID = a.AddressID
JOIN Towns t
ON t.TownID = a.TownID
GROUP BY t.Name

--- 29.	Write a SQL to create table WorkHours to store work reports for each employee (employee id, date, task, hours, comments). ---
--- o	Don't forget to define identity, primary key and appropriate foreign key. ---
--- o	Issue few SQL statements to insert, update and delete of some data in the table. ---
--- o	Define a table WorkHoursLogs to track all changes in the WorkHours table with triggers. ---
--- o	For each change keep the old record data, the new record data and the command (insert / update / delete). ---

USE TelerikAcademy
CREATE TABLE WorkHours (
	EmployeeId INT IDENTITY,
	[Date] DATETIME,
	Task NVARCHAR(100),
	[Hours] INT,
	Comments NVARCHAR(300)
	CONSTRAINT PK_WorkHours PRIMARY KEY(EmployeeId)
	CONSTRAINT FK_WorkHours_Employees FOREIGN KEY(EmployeeId)
	REFERENCES Employees(EmployeeId)
)
GO

INSERT INTO WorkHours
VALUES (GETDATE(), 'Write homework', 5, 'Homework about advanced SQL'),
		(GETDATE(), 'Go go Lecture', 4, 'Attend to lecture in Telerik Academy'),
		(GETDATE(), 'Rest', 2, 'Rest after hard day')

UPDATE WorkHours
SET Date = '2015-10-05 18:00'
WHERE Task LIKE '%Lecture%'

DELETE FROM WorkHours
WHERE [Hours] < 3

CREATE TABLE WorkHoursLogs(
	LogId INT IDENTITY,
	OldRecord nvarchar(500),
	NewRecord nvarchar(500),
	Command nvarchar(10),
	EmployeeId INT,
	CONSTRAINT PK_WorkHoursLogs PRIMARY KEY(LogId),
	CONSTRAINT FK_WorkHoursLogs_WorkHours FOREIGN KEY(EmployeeId) 
	REFERENCES WorkHours(EmployeeId)
)
GO

CREATE TRIGGER tr_WorkHoursInsert ON WorkHours FOR INSERT
AS
	INSERT INTO WorkHoursLogs(OldRecord, NewRecord, Command, EmployeeId)
	VALUES('',
		   (SELECT 'Day: ' + CAST(Date AS nvarchar(50)) + ' ' + ' Task: ' + Task + ' ' + 
					' Hours: ' + CAST([Hours] AS nvarchar(50)) + ' ' + Comments
			FROM Inserted),
		   'INSERT',
		   (SELECT EmployeeID FROM Inserted))
GO

CREATE TRIGGER tr_WorkHoursUpdate ON WorkHours FOR UPDATE
AS
	INSERT INTO WorkHoursLogs(OldRecord, NewRecord, Command, EmployeeId)
	VALUES((SELECT 'Day: ' + CAST(Date AS nvarchar(50)) + ' ' + ' Task: ' + Task + ' ' +
					 ' Hours: ' + CAST([Hours] AS nvarchar(50)) + ' ' + Comments FROM Deleted),
		   (SELECT 'Day: ' + CAST(Date AS nvarchar(50)) + ' ' + ' Task: ' + Task + ' ' + 
					' Hours: ' + CAST([Hours] AS nvarchar(50)) + ' ' + Comments FROM Inserted),
		   'UPDATE',
		   (SELECT EmployeeID FROM Inserted))
GO

CREATE TRIGGER tr_WorkHoursDelete ON WorkHours FOR DELETE
AS
	INSERT INTO WorkHoursLogs(OldRecord, NewRecord, Command, EmployeeId)
	VALUES((SELECT 'Day: ' + CAST(Date AS nvarchar(50)) + ' ' + ' Task: ' + Task + ' ' + 
					' Hours: ' + CAST([Hours] AS nvarchar(50)) + ' ' + Comments FROM Deleted),
		   '',
		   'DELETE',
		   (SELECT EmployeeID FROM Deleted))
GO

INSERT INTO WorkHours
VALUES(GETDATE(), 'Sleep', 8, 'Sleep when its dark outside')

DELETE FROM WorkHours
WHERE Task = 'Rest'

UPDATE WorkHours
SET Task = 'Win Money'
WHERE EmployeeID = 1

--- 30.	Start a database transaction, delete all employees from the 'Sales' department along with all dependent records from the pother tables. ---
--- o	At the end rollback the transaction. ---

USE TelerikAcademy
BEGIN TRAN
	ALTER TABLE Departments
	DROP CONSTRAINT FK_Departments_Employees

	ALTER TABLE WorkHours
	DROP CONSTRAINT FK_WorkHours_Employees

	DELETE FROM Employees
	SELECT d.Name
	FROM Employees e
		JOIN Departments d
			ON e.DepartmentID = d.DepartmentID
	WHERE d.Name = 'Sales'
	GROUP BY d.Name
ROLLBACK TRAN

--- 31.	Start a database transaction and drop the table EmployeesProjects. ---
--- o	Now how you could restore back the lost table data? ---

USE TelerikAcademy


--- 32.	Find how to use temporary tables in SQL Server. ---
--- o	Using temporary tables backup all records from EmployeesProjects and restore them back after dropping and re-creating the table. ---

USE TelerikAcademy
CREATE TABLE #TemporaryTable (
	EmployeeId INT,
	ProjectId INT
)

INSERT INTO #TemporaryTable
SELECT EmployeeId, ProjectId
FROM EmployeesProjects

DROP TABLE EmployeesProjects

CREATE TABLE EmployeesProjects (
	EmployeeId INT,
	ProjectId INT,
	CONSTRAINT PK_EmployeesProjects PRIMARY KEY(EmployeeID, ProjectID),
	CONSTRAINT FK_EmployeesProjects_Employees FOREIGN KEY(EmployeeID) 
	REFERENCES Employees(EmployeeID),
	CONSTRAINT FK_EmployeesProjects_Projects FOREIGN KEY(ProjectID) 
	REFERENCES Projects(ProjectID)
)

INSERT INTO EmployeesProjects
SELECT EmployeeId, ProjectId
FROM #TemporaryTable

