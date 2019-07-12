# Employee-System
Summary:
	Create a fictitious simple employee management system. The application should support adding 
new employee, viewing the employee's information, editing existing employee as well as soft deleting an employee. Also, users should log into the application to use it.

Details:
	
The application will support the types below:
User – used to authenticate login users.
Subordinate – ordinary employees of the company.
Supervisor – employees who are supervisors.
	(Think of self-referencing tables). 

User will have as minimum the following fields:
Id
UserName
Password
IsActive

Subordinate/Supervisor employee will have as minimum the following fields: 
Id
EmployeeNumber
FirstName
LastName
Gender
DOB (Date Of Birth)
EmployedOn
CreatedOn
CreatedBy
UpdatedOn
UpdatedBy
IsActive

(You can add additional fields to help you achieve the requirements of this project)


Expectations:

The application should be a web application.

The application should support only soft deletion, thus a record is considered deleted when it's IsActive property is set to false.

Users: 
Display the active users in a grid (table).
Provide functionalities to view/edit/delete a user.
Provide separate pages for the view/edit functionality. Delete may not have a separate page. (You can display a confirm dialog to allow/disallow the deletion).

Subordinate/Supervisor:
Display both active subordinates and supervisors in the same grid.
You should provide a column to differentiate between subordinates and supervisors.
Provide functionalities to view/edit/delete employees.-DONE
Provide separate pages for the view/edit functionality. Delete may not have a separate page. (You can display a confirm dialog to allow/disallow the deletion).
On the view page, if an employee is a supervisor, display a list of his subordinates as well. If the employee is a subordinate, display the full name of his/her supervisor.
On both the view/edit pages, display the audit information (CreatedOn, CreatedBy, UpdatedOn, UpdatedBy) for the employee as well.
