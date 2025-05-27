2025-05-05 1210
Created a new ASP.NET Core MVC web project named MvcMovie.

Generated a controller (HelloWorldController) with two actions: Index and Welcome.

Configured route patterns in Program.cs to support controller/action/id URL formats.

Ran the app using Ctrl + F5 and tested endpoints such as:

/HelloWorld/

/HelloWorld/Welcome

/HelloWorld/Welcome?name=Rick&numTimes=4

/HelloWorld/Welcome/3?name=Rick

Demonstrated parameter binding and use of HtmlEncoder to prevent injection.

Added a new controller named HelloWorldController.

Understood how URL segments map to controllers and actions.

Added Parameters and Dynamic Output

Modified the Welcome method to accept query string parameters:

Used HtmlEncoder.Default.Encode() to safely render input and avoid XSS attacks.

Updated to show route data (like ID) as well:

2025-05-19    1230

Modified the HelloWorldController to return a Razor view instead of a plain string.

Changed the Index() method to use return View();.
1240
Added a new view named Index.cshtml inside Views/HelloWorld/.

Displayed a static message and set the page title using ViewData["Title"].
0110
Changed the layout title from "MvcMovie" to "Movie App".
0115
Updated the navbar branding and footer text to reflect the new app name.
0118
Ensured that the browser tab shows the correct title for each view.
0130
Modified the Welcome() method to accept parameters (name, numTimes) and pass them to the view via ViewData.
0150
Created Welcome.cshtml to loop and display the message multiple times using Razor syntax.
0230
Launched the app using a URL like:
https://localhost:{PORT}/HelloWorld/Welcome?name=Rick&numtimes=4

Verified that it dynamically displays "Hello Rick" four times using the passed parameters.

it displayed sucessfully.

0240
created a new class movies.cs in models folder
0245
added nuget packages 

0255
Use scaffolding to generate:

A controller (MoviesController.cs)

Views for Create, Read, Update, and Delete under Views/Movies

0300
added initial migration 
20250519222854_IntialCreate.cs was created 

0310
updated database 

2025-05-26
2100
created a new class named seeddata unedr the models folder.
2110
added the seed initializer to the program.cs 
2113
tested the app . all are going well it showing the seeded data.
2115 
started part 6 controller methods and views
2116
modified the code under the models/Movies.ca
2118
added the code that mentioned in the instruction under the views/movies/index.cshtml file .
2125
 tested the app it was showing the information is  required under the empty bars. its running successsfully.
 2130
 started the part 7, updated the index found inside the controllers/moviescontroller.cs 
 2132
 navigated to the /movies/index. added ?searchstring=Ghost to the url . it resulted  the output successfully.
 2137
 Updated index method with id parameter.
 2140
 added the given code to the Views/Movies/Index.cshtml 
 2143
 Tested the fiter the search index is added to the index successfully.
 2147
 Added search by genre to the MovieGenreViewModel class to the Models folder.
 2150
  Tested the app by searching by genre, by movie title, and by both. The result is sucessful.
  2152
  Added a Rating property to Models/Movies.cs
  2154
  binded the app successfully.
  2155
  edited the code , added a rating field under the /Views/Movies/Index.cshtml file.
  2157
  updated the rating field in the views/Movies/Create.cshtml
  2158
   Updated the rating field  in SeedData class also.
  2200
  Tested the app running suceessfully without any SqlExceptions.
  2210
  Started part 9 add validation
  2211
  Updated the Movie class with the validation attributes Required,StringLength/ RegularExpression, Range amd the Datatype 
  2215 
  Tested the app, its successfully showing the validation error 
  2230
  Created the Github account with the college mail w0877406@myscc.ca
  2240
 Successfully Pushed the code to the github account.