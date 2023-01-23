#  Parks Lookup / StateParksAPI

#### By Yodel Guanzon <yodelguanzon@gmail.com>

#### This is an independent project to test our skills in building Web API using .Net 6

------------------------------
### <u>Table of Contents</u>
* <a href="#-about-the-project">About the Project</a>
    * <a href="#description">Description</a>
    * <a href="#technologies-used">Technology Used</a>
    * <a href="#-Known Bugs">Known Bugs</a>
* <a href="#-getting-started">Getting Started</a>
    * <a href="#-prerequisites">Prerequisites</a>
    * <a href="#%EF%B8%8F-setup-and-use">Setup and Use</a>
* <a href="#%EF%B8%8F-api-documentation">API Documentation</a>
* <a href="#%EF%B8%8F-license">License</a>
* <a href="#-acknowledgements">Acknowledgements</a>
    
------------------------------

## 🌐 About the Project



### Description

#### API Project - Parks Lookup / StateParksAPI

An API for listing surrounding State and National Parks. There's two versions of the app. V1 and V2 endpoints are the same except V2 requires authenication in order to create, update and delete records.

##### Project Requirements

* [x] Full CRUD functionality.
* [x] Further exploration of one of the following objectives: authentication, versioning, pagination, or CORS.
* [x] Complete documentation of API endpoints and the further exploration you did.

### Technologies Used

* .Net 6 SDK
* C#
* EF Core 6
* EF Core Migrations
* ASP.Net MVC
* Razor
* MySql 6
* MySql Workbench
* Swagger
* Postman

### 🦠 Known Bugs

* None

Found a bug? Email me at <yodelguanzon@gmail.com>

------------------------------

## 🏁 Getting Started

### 📋 Prerequisites

#### Install Database Tools

* Download and install MySQL Community Server and MySQL Workbench using the following link: (https://downloads.mysql.com/archives/get/p/25/file/mysql-installer-web-community-8.0.19.0.msi)

#### Install Postman

(Optional) [Download and install Postman](https://www.postman.com/downloads/).

#### Code Editor

  To view or edit the code, you will need an code editor or text editor. The popular open-source choices for an code editor are Atom and VisualStudio Code.

  1) Code Editor Download:
     * Option 1: [Atom](https://nodejs.org/en/)
     * Option 2: [VisualStudio Code](https://www.npmjs.com/)
  2) Click the download most applicable to your OS and system.
  3) Wait for download to complete, then install -- Windows will run the setup exe and macOS will drag and drop into applications.
  4) Optionally, create a [GitHub Account](https://github.com)

### ⚙️ Setup and Use

  #### Cloning

  1) Navigate to the [StateParksAPI.Solution Reposity Here](https://github.com/delguanzon/StateParksApi.Solution).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Open up your system Terminal or GitBash, navigate to your desktop with the command: `cd Desktop`, or whichever location suits you best.
  4) Clone the repository to your desktop: `$ git clone https://github.com/delguanzon/StateParksApi.Solution`
  5) Run the command `cd StateParksApi.Solution` to enter into the project directory.
  6) View or Edit:
      * Code Editor - Run the command `atom .` or `code .` to open the project in Atom or VisualStudio Code respectively for review and editing.
      * Text Editor - Open by double clicking on any of the files to open in a text editor.

  #### Download

  1) Navigate to the [StateParksAPI.Solution Reposity Here](https://github.com/delguanzon/StateParksApi.Solution).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Click 'Download ZIP' and unextract.
  4) Open by double clicking on any of the files to open in a text editor.

  #### AppSettings

  1) Create a new file in the StateParksAPI.Solution/StateParksAPI directory named `appsettings.json`
  2) Add in the following code snippet to the new appsettings.json file:
  
  ```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=stateparksapi;uid=[USERNAME];pwd=[PASSWORD];"
  }
}
  ```
  3) Change the server, port, and user id as necessary. Replace 'PASSWORD' with relevant MySQL password (set at installation of MySQL).

  #### Database
  * Using the terminal, Navigate to the main project directory located at ../Factory.Solution/Factory
  * Run ```dotnet restore``` to restore all dependencies (optional)
  * Run ```dotnet ef database update``` command to automatically create the database using the migrations in the Factory Project
       - Optionally, you could run the command `dotnet ef migrations add MigrationName` where `MigrationName` is your custom name for the migration to create your own migration before running the database update command. You could do this if for some reason ../Factory.Solution/Factory/Migrations is missing..

  #### Launch the API
  1) Navigate to StateParksAPI.Solution/StateParksAPI directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/CoffeeTrackerAPI.Solution/CoffeeTrackerAPI`).
  2) Run the command `dotnet run` to have access to the API in Postman or browser.

------------------------------

## 🛰️ API Documentation
Explore the API endpoints in Postman or a browser. You will not be able to utilize authentication in a browser.

### Using Swagger Documentation 
* To explore the StateParks API with NSwag, launch the project using `dotnet run` with the Terminal or Powershell, and input the following URL into your browser: `http://localhost:5000/swagger`
* Alternatively, you can use `dotnet watch run` to open a watcher and automatically open swagger in a browser


### Versioning

API have two versions, V1 and V2. API Endpoints are identical except that V2 requires authentication via JWT before accessing the API.
Please also take note that V2 is not possible to be used via Swagger due since the functionality for authentication for Swagger have not been added yet.

### Using the JSON Web Token
In order to be authorized to use the POST, PUT, DELETE functionality of the API, please authenticate yourself through Postman.
* Open Postman and create a POST request using the URL: `http://localhost:5000/api/parks/authenticate`
* Add the following query to the request as raw data in the Body tab:
```
{
    "UserName": "admin",
    "Password": "password"
}
```
* The token will be generated in the response. Copy and paste it as the Token paramenter in the Authorization tab:
<img src=".\readme\assets\img\auth-jwt.png">  

### Pagination
The StatePark API returns a default of 5 results per page.
To modify this, use the query parameters `pageSize` to specify how many items will return for display.
Use query parameter `pageNumber` to navigate through pages.

#### Example Query
```
https://localhost:5000/api/parks/?pageSize=3&pageNumber=2
```

To use default, _don't include_ `pageSize` and `pageNumber` or set them equal to zero.

..........................................................................................

### Endpoints
Base URL: `https://localhost:5000`

#### HTTP Request Structure
```
GET /api/{component}
POST /api/{component}
GET /api/{component}/{id}
PUT /api/{component}/{id}
DELETE /api/{component}/{id}
```

#### Example Query

```
https://localhost:5000/api/parks/1
```

#### Sample JSON Response

```
{
  "id": 1,
  "parkId": "TACWA-S0001",
  "name": "Point Defiance Park",
  "location": "Tacoma, WA",
  "description": "Point Defiance Park is a 760-acre park in Tacoma, Washington, United States. It is located on the tip of the peninsula that separates Commencement Bay from Puget Sound. The park is operated by the City of Tacoma and is the largest park in the city.",
  "imageUrl": "../pdp.jpg",
  "rating": 5
}
```

..........................................................................................

### Parks
Access information on State and National Parks around you.

#### HTTP Request
```
GET /api/parks
POST /api/parks
GET /api/parks/{id}
PUT /api/parks/{id}
DELETE /api/parks/{id}
```

#### Path Parameters
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| id | int | none | true | Id for the park in the schema.
| parkId | string | none | true | Park Code which is different from Id.
| name | string | none | true | Name of the Park.
| location | string | none | true | Location of the park |
| description | string | none | true | Brief description of the park. |
| imageUrl | string | none | false | Location for the image/thumbnail of the park. |
| rating | int | none | false | Park Rating |

#### Example Query 
```
https://localhost:5000/parks/1
```

#### Sample JSON Response
```
{
  "id": 1,
  "parkId": "TACWA-S0001",
  "name": "Point Defiance Park",
  "location": "Tacoma, WA",
  "description": "Point Defiance Park is a 760-acre park in Tacoma, Washington, United States. It is located on the tip of the peninsula that separates Commencement Bay from Puget Sound. The park is operated by the City of Tacoma and is the largest park in the city.",
  "imageUrl": "../pdp.jpg",
  "rating": 5
}
```

#### Listing existing Parks

<details>
 <summary><code>GET</code><code><b>/</b></code><code>parks</code><code><b>/</b></code> <code>(Gets all Parks)</code></summary>

##### Parameters

> None

##### Responses

> | http code     | content-type                      | response                                                            |
> |---------------|-----------------------------------|---------------------------------------------------------------------|
> | `200`         | `application/json`                | `Returns a list of parks in inrements of 5`                         |
</details>

<details>
 <summary><code>GET</code><code><b>/</b></code><code>parks</code><code><b>/</b></code><code>{id}</code> <code>(Gets Park by Id)</code></summary>

##### Parameters

> | name      |  type     | data type               | description                                                           |
> |-----------|-----------|-------------------------|-----------------------------------------------------------------------|
> | id        |  required | int                     | The specific park numeric Id                                          |

##### Responses

> | http code     | content-type                      | response                                                            |
> |---------------|-----------------------------------|---------------------------------------------------------------------|
> | `200`         | `application/json`        | <details> <summary>...</summary>{"id": 1,"parkId": "TACWA-S0001","name": "Point Defiance Park","location": "Tacoma, WA","description": "Point Defiance Park is a 760-acre park in Tacoma, Washington, United States. It is located on the tip of the peninsula that separates Commencement Bay from Puget Sound. The park is operated by the City of Tacoma and is the largest park in the city.","imageUrl": "../pdp.jpg","rating": 5 } </details>|
</details>

#### Creating/Adding a New Park

<details>
 <summary><code>POST</code> <code><b>/</b></code></b></code><code>parks</code><code><b>/</b></code> <code>(Create/Add a Park)</code></summary>

##### Parameters

> | name      |  type     | data type               | description                                                           |
> |-----------|-----------|-------------------------|-----------------------------------------------------------------------|
> | None      |  required | object (JSON)   | N/A  |

##### Responses

> | http code     | content-type                      | response                                                            |
> |---------------|-----------------------------------|---------------------------------------------------------------------|
> | `201`         | `text/plain;charset=UTF-8`        | `Park created successfully`                                         |
> | `400`         | `application/json`                | `{"code":"400","message":"Bad Request"}`                            |
> | `401`         | `text/html;charset=utf-8`         | `Unauthorized`                                                      |

</details>

#### Updating a Park

<details>
 <summary><code>PUT</code><code><b>/</b></code><code>parks</code><code><b>/</b></code><code>{id}</code> <code>(Update Park by Id)</code></summary>

##### Parameters

> | name      |  type     | data type               | description                                                           |
> |-----------|-----------|-------------------------|-----------------------------------------------------------------------|
> | None      |  required | object (JSON)   | N/A  |

##### Responses

> | http code     | content-type                      | response                                                            |
> |---------------|-----------------------------------|---------------------------------------------------------------------|
> | `201`         | `text/plain;charset=UTF-8`        | `Updated successfully`                                         |
> | `400`         | `application/json`                | `{"type": "https://tools.ietf.org/html/rfc7231#section-6.5.1","title": "Bad Request","status": 400,"traceId":"00-ec3ce56b7ab5afb0bf4aec5a4b3a22f9-694189daed0c5ec0-00"}` |
> | `401`         | `text/html;charset=utf-8`         | `Unauthorized`                                                      |

</details>

#### Deleting a Park

<details>
 <summary><code>PUT</code><code><b>/</b></code><code>parks</code><code><b>/</b></code><code>{id}</code> <code>(Update Park by Id)</code></summary>

##### Parameters

> | name      |  type     | data type               | description                                                           |
> |-----------|-----------|-------------------------|-----------------------------------------------------------------------|
> |id         |  required | int                     | The specific park numeric Id                                          |

##### Responses

> | http code     | content-type                      | response                                                            |
> |---------------|-----------------------------------|---------------------------------------------------------------------|
> | `201`         | `text/plain;charset=UTF-8`        | `Updated successfully`                                         |
> | `400`         | `application/json`                | `{"type": "https://tools.ietf.org/html/rfc7231#section-6.5.1","title": "Bad Request","status": 400,"traceId":"00-ec3ce56b7ab5afb0bf4aec5a4b3a22f9-694189daed0c5ec0-00"}` |
> | `401`         | `text/html;charset=utf-8`         | `Unauthorized`                                                      |

</details>

#### Deleting a Park

<details>
 <summary><code>DELETE</code><code><b>/</b></code><code>parks</code><code><b>/</b></code><code>{id}</code> <code>(Delete Park by Id)</code></summary>

##### Parameters

> | name      |  type     | data type               | description                                                           |
> |-----------|-----------|-------------------------|-----------------------------------------------------------------------|
> |id         |  required | int                     | The specific park numeric Id                                          |

##### Responses

> | http code     | content-type                      | response                                                            |
> |---------------|-----------------------------------|---------------------------------------------------------------------|
> | `201`         | `text/plain;charset=UTF-8`        | `Deleted successfully`                                         |
> | `400`         | `application/json`                | `{"type": "https://tools.ietf.org/html/rfc7231#section-6.5.1","title": "Bad Request","status": 400,"traceId":"00-ec3ce56b7ab5afb0bf4aec5a4b3a22f9-694189daed0c5ec0-00"}` |
> | `401`         | `text/html;charset=utf-8`         | `Unauthorized`                                                      |

</details>

------------------------------

### ⚖️ License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT). Copyright (C) 2023 Yodel Guanzon. All Rights Reserved.

```
MIT License

Copyright (c) 2023 Yodel Guanzon.

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
```

------------------------------

### 🌟 Acknowledgements

#### [Epicodus](https://www.epicodus.com/)
>"A school for tech careers... to help people learn the skills they need to get great jobs."

#### [The Internet](https://webfoundation.org/)
> "...the first thing that humanity has built that humanity doesn't understand..."
> - Eric Schmidt, Google (Alphabet Inc.)

------------------------------

<center><a href="#">Return to Top</a></center>