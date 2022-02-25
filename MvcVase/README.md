// Program name: MvcVase
// Program purpose: To learn about creating an ASP.NET Core Application using Model  View Controller
// Program author: Bhoomit Kiritbhai Patel
// Create Date: 2022-02-24 [ISO 8601]*
// author Student Number: 0780326

2022-02-24
Began tutorial with the process of creating a default ASP.NET Core MVC application

PART 1:
START
1410
In Visual Studio created a new project name MvcVase with the ASP.NET Code App (Model View Controller)
Changed the .Net Core version to 5.0
Boom!!! I got the default MVC web application with some default code.......

1430
Reviewed the code like Statup.cs, Program.cs, Properties, Controllers, Models, Views etc.........

1437
I ran the application using IIS Express SSL certificate and development certificate
Displayed: Welcome .. Lear about Web apps with ASP.NET Core.

1439
In Views>Home Add one razor view file name About.cshtml for the entering the data about the Vases their propertie, images, history etc....
In Shared folder add the link of About page to the _Layout.cshtml to access the about page from the Home page(Index) or from anywhere
Ohhhh Do not forget to add the IactionResult method for the about page into the Controllers>HomeController.cs because it controll the every page (If this step is not completed then You got error like you page is not found in the system becase I faced this issue :) )...

1543
Now time to change the text font, add image and some css to make better look of the about page

1613
I added images in the wwwroot/img (New created img folder)
Changed some css for the better look in the wwwroot/css/site.css file with proper style
END

After a cup of tea start the MVC application to Add model, controller and view in the application

PART 2:
START

Now I have to move forward to the application building and database

1700
Based on tutorial I added one controller HelloWorldController in my application
It will be use for the Handle browser requests, Retrive model data and Call view templates that return a response etc..

Did some minor change in the file name HelloWorldController.cs to display a different result based on the changes and It ran successfully :)

END

1730
PART 3:
Now have time to add a view for the HelloWorld
START 

1750
Change the Index method of HelloWorldController to display the return View data
Made new folder into the Views called HelloWorld and add empty view called Index.cshtml in that HelloWorld folder
Added default Title of index page and One little paragraph to display some important details

1820 
Tested the application manually going to the file location and it worked perfectly fine :)

1842
Changed the Welcome method to retive the data using looping and it will show the n times data when user define the value of n.
Added the Welcome view file and tried to retrive the data from Controller
Change the browser URL and gave the name and numTimes so I got the numTimes time value of name in the display now I am happy :)

END

PART 4:
START

1843
Adding a Model
Now I added one model name Vase and provided 6 attribute in that like Id, Name, Shape, Antique, Type etc...

1859
Now its time to add some EntityFramework of microsoft in the our MVC applcation
By using Nuget Package manager added some following framwork:
	Microsoft.EntityFrameworkCore.SQLite
	Microsoft.VisualStudio.Web.CodeGeneration.Design
	Microsoft.EntityFrameworkCore.SqlServe
	Microsoft.EntityFrameworkCore.Design

Oopps Ohhh No!! I got error to add this package but I know how to add this EntityFramework in out project because I faced this same issue earlier
It shows that 
Install-Package : NU1202: Package Microsoft.EntityFrameworkCore.Design 6.0.2 is not compatible with net5.0 
So it means Nuget Package manager directly tried to install the latest version of frameworks and It show error because our project is beased on the .Net Core version 5.0 but Manager tried to install latest version of framework.
So I have to add packages manually by the use Nuget package manager tool
I added those all four packages manually
So go to the project option and You will found the manager nuget packages and add manually by selecting the version 5.x.x no more than 5 its must be followed:)

1913
Hmm... Now its time to scaffolding the Vases Page....

1916
By using the Controller I added scaffold item of MvcVase.Model.... Taking some load.....
Yeeeeehhh I did the scaffolding the Vase page without facing any error So that's mean my trick worked perfectly fine here ...... :)

1919
Lets do the Initial Migration of the Vases page..
Updated the database
Yes, I tested the application and opened the VaseApp link it worked perfectly fine :)


1925
Now it's time to examine the each and every files which are created by scaffolding and Migration process so we got idea about the CRUD methods

1926
Now scaffolding the Startup.ConfigureServices

1929
Scaffolding added a connection string to the appsettings.json it will show the connectionstring of the database

1931
Examined the InitialCreate class and the VasesController.cs file 

1937
End of part 4 ..... :) feeling good 
END

1938
PART 5:
START

Work with the database in an ASP.NET Core MvcVase App

1949
Now it's time to check the database table and I found the total SQL code for the table
Checked the table of Vase by using the SQL Server ObjectExplorer
I checked the data and the design it exactly same as the sql server :)

1950
Time to seed the data 

2004
Add class named SeedData.cs and added some library for MvcVase data, Entityframework Library and SQL injection library

Now Add data into the Vase properties like Name, Type, Shape, Anitique and Material 

2223
I completed my dinner and came back to update the Program.cs file

2244
Added try and catch function to seeding the data from SeedData.cs file 
Now run the application but before that make sure that you do not have any data into the Local Storage if have any data then delete every data from the Table
Now debug the Application

2246
Yeeeehh!!!! I ran the application and I fetched the data from the SeedData.cs file and it displayed in screen Now I can edit delete and Get details :)

END

2252

PART 6:
Controller methods and views in ASP.NET Core

START
Added library DataAnnotation.Schema for the decimal value but unfortunately I don't have any decimal properties 

2348
In the VasesController set the edit method to the HTTPPOST we can also set to the GET as well but post is most secure than the GET method

Check the edit Page and Form HTML code that show that convention of the code that we reqire correct date, Id and price must be a number etc... :)

END

0018
PART 7:
Add a search to an ASP.NET Core MVC App

START
0021
Changed index method for the search the Vases by their name property so I changed the Index method of VasesController and its simple SQL code that Found This Data from this name so on......

0033
Now Chnage the Vases/Index.cshtml file
In that file add one form tag for searching the name of the Vases and fetch the data and show only those data which matched with the perticular vases name

0034
Yeeeeehhhhh!! Now I can find the perticular vases by search filter
0035
Add the HTTPPOST method for the index

0047
In the form tag i added the method GET to get the searchstring into the URL 
I ran the code successully ...:)

0048
Add the search by Material property

0053
Now Make one class name VaseMaterialViewModel in the Models and set some properties inside that by following
Vases, Materials, VaseMaterial, SearchString 

0108
Now its time to change the VasesController file

0143
Updated data of VaseController file View/Index.cshtml file data
In the index.cshtml file I updated the form data for the Material 
In the Controller added the new query for the fetching the data of the Material

0145
Ran the code and apply some filter for the Material and Name of Vases and it saw the correct data by fetching the Original data
Successfully added the search filter

END

PART 8:
Add a new field to an ASP.NET Core MVC App
START

0147
Now I added one field called Rating inside the Vase.cs with string value
Changed VasesController file and add Bind value of Rating

0213
Chnage the all SeedData and add one more field for the Rating 
Change every index, create, delete, details, edit cshtml files and add Rating tag
 
0214
Add Migration for the Rating 
Update Database
Yehhh!! Ran successfully with the rating data :)

END

0215

PART 8:
START

Add the validation rule for the Vase model

0223
Now Updated the Vase.cshtml fiel
Add Required field 
No field will be empty 
Set the minimum value for the every field like no more than 60 and no minimum of 3 etc..

0224
Now Ran the code and check the entry It saw an error for the field which not follow the convention of the given conditions
Sucessfully Ran  :)

END

0227
PART 10:
Examin the Details and Delete methods of ASP.NET Core
START

Examined the Details and Delete method of Vase Application

FINALLY THE APPLICATION IS BUILDED SUCCESSFULLY :)

NOW one more step is I have to publish this application to the Azure


