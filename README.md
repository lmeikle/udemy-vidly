# The Complete ASP.NET MVC 5 Course

https://www.udemy.com/the-complete-aspnet-mvc-5-course

https://github.com/mosh-hamedani/vidly-mvc-5

Create project with 'Individual User Accounts' authentication, else we get errors
when we try to do the below.

Section 3, Lesson 25: <br>
In NuGet package manager: <br>
- Install-Package EntityFramework -IncludePrerelease
- enable-migrations (need to have built the solution)
- add-migration 'InitialModel'
- when we change the DBContext run this again: add-migration InitialModel -force
- update-database (to generate the DB)


SET IDENTITY_INSERT [dbo].[Movies] ON
INSERT INTO [dbo].[Movies] ([Id], [Name], [ReleaseDate], [DateAdded], [NumberInStock], [GenreType_Id]) VALUES (1, N'Hangover', N'2001-01-01 00:00:00', N'2018-12-05 00:00:00', 3, 1)
INSERT INTO [dbo].[Movies] ([Id], [Name], [ReleaseDate], [DateAdded], [NumberInStock], [GenreType_Id]) VALUES (3, N'Die Hard', N'2002-02-02 00:00:00', N'2018-12-05 00:00:00', 5, 2)
INSERT INTO [dbo].[Movies] ([Id], [Name], [ReleaseDate], [DateAdded], [NumberInStock], [GenreType_Id]) VALUES (4, N'The Terminator', N'2003-03-03 00:00:00', N'2018-12-05 00:00:00', 9, 2)
INSERT INTO [dbo].[Movies] ([Id], [Name], [ReleaseDate], [DateAdded], [NumberInStock], [GenreType_Id]) VALUES (5, N'Toy Story', N'2004-04-04 00:00:00', N'2018-12-05 00:00:00', 12, 3)
INSERT INTO [dbo].[Movies] ([Id], [Name], [ReleaseDate], [DateAdded], [NumberInStock], [GenreType_Id]) VALUES (6, N'Titanic', N'2005-05-05 00:00:00', N'2018-12-05 00:00:00', 1, 4)
SET IDENTITY_INSERT [dbo].[Movies] OFF