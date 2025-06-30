IF OBJECT_ID('sp_GetEmployeeCountByDepartment') IS NOT NULL
    DROP PROCEDURE sp_GetEmployeeCountByDepartment;
GO

CREATE PROCEDURE sp_GetEmployeeCountByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT COUNT(*) AS TotalEmployees
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;
GO

EXEC sp_GetEmployeeCountByDepartment @DepartmentID = 1;
