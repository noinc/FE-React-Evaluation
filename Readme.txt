This solution provides a REST API that could possibly be used together with a Front End
implementation of the NoInc coding project.

I added POST, GET, PUT, and DELETE actions for 3 entities: User, Interest, and Skill.
Theoretically, everything could be done with just a User API; however, it does seem like
manipulation of Interest and Skill objects would work better with their own API.

I used ASP .NET with Entity Framework scaffolding, which takes care of the db setup,
endpoint setup, and also provides a nice UI test page with Swagger. I created base
classes  for the controllers and the SQL repositories to cut down on duplicate code,
so that the 3 concrete entity controllers and SQL repositories are extremelly lightweight.

I also added a jwt authentication layer. The User's POST request does not require
authentication, so you are able to add new users w/o any authentication; however,
none of the other request types can be used w/o authenticating a user. More specifics
below.

I ran this against my own Microsoft SQL Server instance (you can still see the
connection string I was using in the appsettings.json file); however, to make this
easier for someone else to run this, I commented out the use of the connection
string on Startup.cs line line #50 and replaced it with a localdb setup. So if you have
Visual Studio, with the built in SQL Server Object Explorer, you should be able to get
the project running using the following steps:
1) Restore NuGet packages
2) Using the developer propmpt, run "dotnet ef database update" to setup the database
3) Run the project using IIS express. This will open up the Swagger UI
4) Since most of the APIs are hidden behind the authentication, you will need to
   use the User POST command to create a user that has a username and password
5) Now, you can use the User/Authenticate command, passing in the username
   and password to get back a JWT token
6) At the top-right of the page, there is a green "Authorize" button. If you click that,
you can enter the jwt token into the available field, but make sure you follow the
instructions to add the word "Bearer" and a space before the token
7) Now you should have access to all the APIs

I realize that storing passwords in the database is a terrible idea if this
were a production application, and that the jwt secret key shouldn't be hardcoded
into the Startup file, and that there's more work to be done
to make sure individual users only have access to their own data, and not others,
but that all seemed outside the scope of this project.
