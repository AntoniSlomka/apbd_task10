1. How to run the application:
- Setup the default connection to the database in appsettings.json
- Before runing the app the first time setup the Admin credentials in Program.cs
- Run the application, the Admin user will be created - after the first run the part of code
that creates the Admin User can be removed
2. How to create a test User:
- Go to the /Account/Register and fill out the register form
- After correctly creating the user you can log in through Account/Login
3. How to log in as Admin:
- Go to Account/Login and enter the Admin credentials specified on the first run
4. Where password hashing is:
- Password hashing is managed by ASP.NET Core Identity PasswordHasher
- The password hash code is stored in the AppUser table in the database
5. Where the authentication is configured:
- Authentication is done with ASP.NET SignInManager with PasswordSignInAsync() method
6. Which actions are protected with [Authorize]:
- All the action in the DashboardController.cs (The whole class is annoted with [Authorize]
- Additionally the /Dashboard/Admin is annoted with [Authorize(Roles = "Admin")] so that only
the user with Admin role can access it


Anwsers to questions:
1. Because database isn't secure enough to store raw values of passwords 
and anyone with access to it could use the information to access user's accounts.
2. Because SHA-256 is easily brute-forcable and susceptible to rainbow table attacks.
3. We use salt so that two different users with the same password will produce different hashes.
4. Salt is random, unique per user, and stored alongside the hash whereas pepper is a secret value 
shared across all passwords, stored separately.
5. Authentication is verifying who you are and authorization is verifying what you're allowed to do.
6. A user can still call the URL directly.
7. It reveals that the usernames exists in the system, which helps attackers gain 
information about valid accounts.