# The Complete ASP.NET MVC 5 Course

https://www.udemy.com/the-complete-aspnet-mvc-5-course

https://github.com/mosh-hamedani/vidly-mvc-5

Create project with 'Individual User Accounts' authentication, else we get errors
when we try to do the below.

Section 3, Lesson 25: <br>
In NuGet package manager:
	- Install-Package EntityFramework -IncludePrerelease
	- enable-migrations (need to have built the solution)
	- add-migration 'InitialModel'
	- when we change the DBContext run this again
		add-migration InitialModel -force
	- update-database (to generate the DB)