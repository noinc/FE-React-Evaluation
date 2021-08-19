This solution provides a REST API that could possibly be used together with a Front End
implementation of the NoInc coding project.

I added POST, GET, PUT, and DELETE actions for 3 entities: User, Interest, and Skill.
Possibly everything could be done with just a User API; however, it does seem like
manipulation of Interest and Skill objects would work better with their own API.

I used ASP .NET with Entity Framework scaffolding, which takes care of the db setup,
endpoint setup, and also provides a nice UI test page with Swagger. I built a small
framework on top to cut down on duplicate code, so that the 3 concrete entity controllers
and SQL repositories are extremelly lightweight.

I did run this against my own Microsoft SQL Server instance (you can still see the
connection string I was using in the appsettings.json file; however, to make this
easier for someone else to run this, I commented out the use of the connection
string on Startup.cs line line #50 and replaced it with a localdb setup. So if you have
Visual Studio, you should be able to get the project running by 1st refreshing the NuGet
packages