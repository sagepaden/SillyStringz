# SillyStringz.Solution

#### _MVC web application using MySQL to manage engineers and machines_

#### By **Sage Paden**

## Technologies Used

* _MS EntityFrameworkCore v6.0.0_
* _Pomelo EntityFrameworkCore MySQL v6.0.0_
* _C#_
* _.NET v6.0_
* _MySQLWorkbench_
* _Git_
* _VSCode_

## Description

_This application demonstrates the use of EFCore and MySQL to create and connect database schemas to the project models. Databases are generated through migrations using the command line. The application utilizes HTML helper methods, LINQ commands, and navigation properties to enable the owner of Dr. Sillystringz to add engineers and machines and link them through many-to-many relationships._

## Setup/Installation Requirements

**Project Set-Up**
* _Clone "SillyStringz.Solution“ to your desktop_
* _Navigate to "SillyStringz.Solution" directory_
* _Create ".gitignore" in the "SillyStringz.Solution" directory_
```
$ touch .gitignore
```
* _Add the three items below to your .gitignore file:_
```
obj
bin
appsettings.json
```
* _Navigate to the "Factory" directory_
* _create "appsettings.json" inside of the "Factory" directory_
```
$ touch appsettings.json
```
* _Add the following text within the file:_
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=dr_silly_stringz;uid=[USER-ID];pwd=[USER-PW];"
  }
}
```
* _Replace USER-ID and USER-PW your own ID and password_
* _Navigate to "Factory" and execute command "dotnet build"_
* _To initialize and update the migrations database, type the following commands in the terminal:_
```
$ dotnet ef migrations add Initial 
$ dotnet ef database update
```
* _Add the following packages through your command line:_
```
$ dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0
$ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0
$ dotnet tool install --global dotnet-ef --version 6.0.0
$ dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0
```
* _Execute "dotnet watch run" - this should automatically open a browser to the web app_


## Known Bugs

* _No known bugs as of 08/05/23_

## License

MIT License

Copyright (c) [2023] [Sage Paden]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

_If you run into any issues or have questions, ideas or concerns, please reach out to me via email: sagepaden@gmail.com _