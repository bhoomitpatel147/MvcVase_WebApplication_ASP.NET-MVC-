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
Yeeeehh!!!! I ran the application and I fatched the data from the SeedData.cs file and it displayed in screen Now I can edit delete and Get details :)

END

