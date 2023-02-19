# Animal Shelter Api

### Contributors
* Athea DeLing

### Description
This is an api that allows a user through postman to access a database about animals in a animal shelter. The user through postman can access the api to get a full list of all animals in the database. The user can also depending on the version do specific query by name, type, or background. The user can also add new animals in to the system and update current animals in the database. Finally the user can also delete animals from the database system all in postman.

### Technologies Used
* C#
* .NET 6 SDK
* SQL
* Entity Framework

### Setup Instructions
#### Needed Application
1. MySQLWorkBench will need to be installed to do follow this [link](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql)
2. Postman you will also need to install postman to be able to interact with this api here is a [link](https://www.learnhowtoprogram.com/fidgetech-2-intermediate-javascript/2-3-asynchrony-and-apis/2-3-0-5-testing-api-calls-with-postman) on how to install

#### Running the program
1. Fork the repository to your own GitHub
2. Clone the newly forked repository on to your own personal computer
3. Once cloned open the file and open up your terminal
4. In the terminal navigate to Factory once the run **dotnet restore** this should add all need packages
5. You will then in the main folder and two new files called **appsettings.json** and **appsettings.Development.json**
6. Once added you will add the following code

**appsettings.json**
``` json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=firstname_lastname;uid=[uid];pwd=[password];"
  }
}
```
**appsettings.Development.json**
``` json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  }
}
```
7. You will replace the firstname and lastname with your first and last name and the [uid] and [pwd] including the brackets you will replace with your user name and password for your SQL Workbench
8. Once that file is added in the terminal in Factory you will run **dotnet ef migrations add Setup** and **then dotnet ef database update** this will setup your database that you will use
9. Once you have completed all of the previous steps run **dotnet watch run**

#### Using the Api with Postman
1. Now that you have done **dotnet watch run** you will now want to open up postman
2. Once opened there will be a dropdown that says GET a blank space and then a button that says SEND
3. In the blank space you will start with this link **http://localhost:5236/api**  this initial link will be the same for all commands that you run
4. After the initial link you can then select a version you would like to use each version has different capabilities
  a. There is v1 so your full link will look like **http://localhost:5236/api/v1** v1 gives you the capability to query only by the pets name. If you query the pets name you will only get pets back with that name. If you try to query any other values you will get the whole database back
  b. There is v2 so your full link will look like **http://localhost:5236/api/v2** v2 gives you the capability to query an animals name, type, or background. Each of these queries will return a small list connected to the query
5. There are multiple actions you can do within postman that will affect the data you are receiving
  a. First there is **GET** for this you will want to make sure the drop down says get next to where you input the link. There are then three types or queries you can do. There is the basic on **http://localhost:5236/api/(Selected Version)/animals** this will bring back the whole list of all animals. Next there is query by type that will look like **http://localhost:5236/api/(Selected Version/animals?(Type)=(Value)** This is where versioning really comes in to play as v1 has a limited type search compared to v2. The **Types** you can use is animalType, animalName, or animalBackground. You can get the specific value to search from the initial GET list a value example would be Izzy. Lastly you can search by the animals id the query would look like **http://localhost:5236/api/(Selected Version)/animals/(#)** this will bring up the animal based on their assigned id
  b. Second you can do a **POST** a post is adding a new animal to the database through postman. For this you will want to make sure your get drop down is selected to POST below that there are several different options you will want to make sure you are looking at **Body**. Once there, there will be two drop down options the first one you will want to make sure is on **raw** and the second should be on **JSON**. You will then be give space to add the information for a new animal this is what you will want it to look like
``` json
{
    "animalId": 4,
    "animalType": "Dog",
    "animalName": "Trinity",
    "animalBackground": "Is a Dog"
}
```
5. 
  b. Continued once all that information is put in you will want to have the link look like **http://localhost:5236/api/(Selected Version)/animals** this will then add a new animal to the database. If you want to check it was added you can the go back to the general get query to see it added
  c.Next there is **PUT** this allows you to edit a animal that is already within the database if you want to update there information. You will need to change the drop down next to the link to PUT. You will also want to be in the same location as most for the Body, raw, and JSON as this will be where you will edit. Just like in POST you will have all the information filled out for the animal you are updating.
``` json
{
    "animalId": 4,
    "animalType": "Dog",
    "animalName": "Peaches",
    "animalBackground": "Is a Dog"
}
```
5. 
  c. See as the above information looks the same as the post besides the name that is how you would then update the name. one the desired information is changed you then press send and this finishes the update. Again to check you can go back to the basic get search or for this one you could look by Id.
  d. Finial you can delete an animal from the database in postman. You will again want to change the drop down to **DELETE**. Once changes you will the have your link look like this **http://localhost:5236/api/(Selected Version)/animals/(#)** as you do the delete based on the animals id you can then press send and it will delete the animal. To check that is is gone you can the do the basic GET query to check
6. Those are the four functionalities of the API you can GET, POST, PUT, and DELETE

### Known Bugs
There are no known bug currently

### License
[GNU GPL 3.0](https://choosealicense.com/licenses/gpl-3.0/) Copyright (c) 02/11/2023 Athea DeLing