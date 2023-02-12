# Animal Shelter Api

### Contributors
* Athea DeLing

### Description


### Technologies Used
* C#
* .NET 6 SDK
* SQL
* Entity Framework

### Setup Instructions
#### Database Install
1. To run this program you will need to install MySQL, to do so please follow this [link](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql)
2. Once MySql is installed you can create your database to do so follow these [instructions](https://www.learnhowtoprogram.com/c-and-net-part-time/database-basics/introduction-to-mysql-workbench-creating-a-database) to create the initial database
3. You should name your database firstname_lastname with your first and last name

#### Running the program
1. Fork the repository to your own GitHub
2. Clone the newly forked repository on to your own personal computer
3. Once cloned open the file and open up your terminal
4. In the terminal navigate to Factory once the run **dotnet restore** this should add all need packages
5. You will then in the main folder and a new file called **appsettings.json**
6. Once added you will add the following code
``` json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=firstname_lastname;uid=[uid];pwd=[pwd];"
  }
}
```
7. You will replace the firstname and lastname with your first and last name and the [uid] and [pwd] including the brackets you will replace with your user name and password for your SQL Workbench
8. Once that file is add in the terminal in Factory you will run **dotnet ef migrations add Setup** and **then dotnet ef database update** this will setup your database that you will use
9. Once you have completed all of the previous steps run **dotnet watch run**
10. Once the application is running to be able to add and access information, you will have to create an account and log in once you have done that you can use the application

### Known Bugs
There are no known bug currently

### License
[GNU GPL 3.0](https://choosealicense.com/licenses/gpl-3.0/) Copyright (c) 02/11/2023 Athea DeLing