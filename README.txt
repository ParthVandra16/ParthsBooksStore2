28 oct 2022
1057am
Author name : PARTH vandra
Program Name: ParthsBookStore
Program purpose : create ParthsBookStore web application using .net 3.1
https selected
User account authentication

create readme.txt file

Create GITHUB Repository named ParthsBookStore and publish 
run web application

1249 pm
Change startup.cs file from the assignment2 file
go to the Boostwatch website and download Morph theme bootstrap.css file
and change bootstrap.css and Site.css file
add additional stylesheet from assignment2 file
change file name bootstrap.min.css to bootstrap.css in layout.cshtml

0124pm
I have remove some property from layout.cshtml line no 7, 23,27
go to the loginpartial.cshtml file and remove text-dark from all lines
run application

31 oct 2022
1205 pm
clone repo
add additional script in the layout.cshtml file 

1254
Add dropdown menu for content management in the layout.cshtml file.

0121
Add three new project 
Install nuget packages
Delete migration folder
Install nuget packages in the ParthsBooks.DataAccess project
modify namespace in the ApplicationDbContext.cs File

0131
Delete default Class1.cs file in all project
move models folder into the ParthsBooks.models project
get the error in startup.cs file...
try to solve error..
add this library file in the top
**************************************************************************************************

03 NOV 2022
0408

I start again because three project cannot cannot connect with main project.

Author name : PARTH VANDRA
Program Name: ParthsBookStore
Program purpose : create ParthsBookStore web application using .net 3.1
https selected
User account authentication

create readme.txt file

Create GITHUB Repository named ParthsBookStore and publish 
run web application

0414
Change startup.cs file from the assignment2 file
go to the Boostwatch website and download Morph theme bootstrap.css file
and change bootstrap.css and Site.css file
add additional stylesheet from assignment2 file
change file name bootstrap.min.css to bootstrap.css in layout.cshtml
I have remove some property from layout.cshtml line no 7, 23,27
go to the loginpartial.cshtml file and remove text-dark from all lines
run application

0421
add additional script in the layout.cshtml file 
Add dropdown menu for content management in the layout.cshtml file.

0432
Add three new project 
Install nuget packages
Delete migration folder
Install nuget packages in the ParthsBooks.DataAccess project
modify namespace in the ApplicationDbContext.cs File

0445
Delete default Class1.cs file in all project
move models folder into the ParthsBooks.models project
modify error.cshtml file
add project reference

0450
rename model folder to view folder ViewModels

0455
change the Errorviewmodels.cs tp .models.viewmodels
modify startup.cs file add library file "using ParthsBookStore.DataAccess.Data;"
correct default reference to ErrorViewModel

****************************************************************************************
START FROM SCRATCH
04 nov 2022
0753

create readme.txt file

Create GITHUB Repository named ParthsBookStore and publish 
run web application

0755
Change startup.cs file from the assignment2 file
go to the Boostwatch website and download minty theme bootstrap.css file
and change bootstrap.css and Site.css file
add additional stylesheet from assignment2 file
change file name bootstrap.min.css to bootstrap.css in layout.cshtml
I have remove some property from layout.cshtml line no 7, 23,27
go to the loginpartial.cshtml file and remove text-dark from all lines
run application

0820
add additional script in the layout.cshtml file 
Add dropdown menu for content management in the layout.cshtml file.

Add three new project 
Install nuget packages
Delete migration folder
Install nuget packages in the ParthsBooks.DataAccess project
modify namespace in the ApplicationDbContext.cs File

0825
Delete default Class1.cs file in all project
move models folder into the ParthsBooks.models project
modify error.cshtml file
add project reference

0850
rename model folder to view folder ViewModels
change the Errorviewmodels.cs tp .models.viewmodels
modify startup.cs file add library file "using ParthsBookStore.DataAccess.Data;"
correct default reference to ErrorViewModel
run code..
its run

1030
ADD customer area
change startup.cs
run app
it s not run 
get exception handing says index.cshtml not found

try to run but localhost page cannot found show

****************************************************************************************
****************************************************************************************
06 Nov 2022
1509pm

Create project ParthsBooksStore2
create readme.txt file
Create GITHUB Repository named ParthsBookStore and publish 
run web application

1512pm
change startup.cs file 
go to the Boostwatch website and download minty theme bootstrap.css file
and change bootstrap.css and Site.css file

1520pm
change file name bootstrap.min.css to bootstrap.css in layout.cshtml
I have remove some property from layout.cshtml line no 7, 23,27
go to the loginpartial.cshtml file and remove text-dark from all lines
add additional stylesheet from assignment2 file

1521pm
run code to see output..
its successfully run 

1525pm
add Three new projects
move data folder
install packages
delete migration folder
delete class1.cs file from three new project
move models folder
and rename models to ViewModels
add project reference

1538pm
modify startup.cs file
add file using ParthsBookStore.DataAccess.Data 

1540pm
get the error in error.cshtml file and homecontroller.cs file
change this line in error.cshtml file to solve error
"ParthsBooksStore2.Models.ViewModels.ErrorViewModel"

1542pm
also add this line into homecontroller.cs file to solve error
ParthsBookStore.Models.ViewModels.ErrorViewModel

1544pm
Build project and run
its runn

1555pm
add SD.cs class in the utility project
change property

1558pm
add project reference utility to main project
add project referenece dataaccess with models and utility

1600pm
Add area customers in the Area

1602pm
change route in startup.cs file

1604
move homecontroller.cs file into the area>customers>Controller
delete data and model folder

1606
edit homecontroller.cs file
modify homecontroller namespace

run application..
localhost not found

1740pm
I change "area=exists"to "area=Customers"
its working..

07 nov 2022
1220pm
add admin area in the AREA
delete model and data folder

1230pm
Assignment2 Part 1 Suceessfully running
now move to the Assignment2 Part2

***********************************************************************************
								ASSIGNMENT2 PART2
***********************************************************************************

2022-11-07
1232PM

Assignment part2 start
Build Application to confirm that there is no error
Build succeeded

1240pm
modify database name in the appsettings.json

1245pm
Add migration for ParthsBooks.DataAcess project
"Migration File Name:20221107174413_AddDefaultIdentityMigration.cs"

1248pm
Review new migration file
update database
review update database in the SQL server object explorer.
run application.
its successfully run

1257pm
Add new class in the models project named: Category.cs
add contain in the category.cs file

1300pm
Add migration for Category.cs class

2022-11-11
0800AM

clone repo from github
rebuild app
get the error in the application dbcotext file..

error solve because i forget to write public keyword while declare category class

0821AM
update database

0826am
Assignmnet2 part2 2.1 complete:)

0829am
Start part 2.1
craete Repository and IRepository folder inside the dataaccess project
add interface IRepository.cs
 
0838am
modify IRepository.cs file
modify IRepository.cs file to operate crud operation

0847am
Add repository.cs class in the Repository folder and modify
Solve error use of using statement by implement interface

0857AM
create constructor and dependency injection into Repository.cs

0914
modify CategoryRepository.cs and ICategoryRepository.cs
get error in the CategoryRepository.cs file 
solve error use of using statement genrate the Public object id in the category.cs file

0959AM
Create new ISP_CALL.cs interface in the IRepository
install nuget package for dapper
write code from tutorial

1124am
ADD new class SP_Call.cs in the Repository folder
ADD connection to the database
write code from tutorial

1156am
Add wrapper for unit work

1209pm
add new interface UnitOfWork.cs in the IRepository folder 
write code in the UnitOfWork.cs interface from the tutorial

1213pm
add UnitOfWork.cs class in the Repository
get the error in UnitOfWork.cs class

2022-11-13

1737pm
add mvc controller
add empty razor view

2220pm
add code form assignment2 file

2232pm
change content in layout.cshtml file

2239pm
modify index.cshtml in the category section font awesome

2259pm
add javascript file from ass2 file

2301pm
link js file to index.cshtml file

2308
apply code to activate edit and delete in the categorycontroller.cs

2312pm
add razor view for upsert and copy code fron assignment2 file

2322pm
add partialview edit and back button

2326pm
create another editpartialview edit and note code addition @model

2343pm
modify upsert.cshtml and add asp action in the index,cshtml file

2345
add script file in the upsert.cshtml

1203am
create upsert post action method

1205am
add API

1208am
implement HTTPDelete in the category.js

1210am
add Delete function code in category.js

0139am
run code

19 Nov 2022
2001pm
clone the repository from github
run code..
its showing 0 error but when the category page cannot load 
i got this exception handling when i click category page
"InvalidOperationException: RenderSectionAsync invocation in '/Views/Shared/_Layout.cshtml' is invalid. The section 'Scripts' has already been rendered."
i have did migration again using differnet name
"20221114063233_RecreateTheDatabase.cs"
"20221118175302_AddCatToDB"
but database cannot show inside the SQL server object explorer

again i did migration with different name
"20221118180305_RecreateTheDatabase1.cs"
but its not working properly.


2004pm
i delete all the migration from DataAccess project inside the migration folder

2012pm
Add new mgration with new name
"20221120011122_AddCategoryToDatabase.cs"
update database..
build successfull

Add migration 
"20221120011609_AddCatToDb.cs"
update database 
build successfully
done.

2017pm
cheack database in the sql server object explorer
database not showing.

2022-11-23
1617PM
when i click Category page its shows exception 
"InvalidOperationException: RenderSectionAsync invocation in '/Views/Shared/_Layout.cshtml' is invalid. The section 'Scripts' has already been rendered."

after that i search on google this line add three script line in the layout.cshtml

 @RenderSection("featured", false)
    @RenderBody()
    @RenderSection("scripts", false)

after that its run but cannot add data in the category.

1648pm
add covertype.cs in the model folder

1655pm
add ICoverTypeRepository and CoverTypeRepository repository

1658
add Product class in the model

1704pm
write code for product.cs

1708pm
Add referennce product to ApplicationDbContext 

1712
Add ProductRepository class and IProductRepository interface

2156
add product VM class
install packages

2221
add new index view
modify layout.cshtml

2224
add product controller
and modify

