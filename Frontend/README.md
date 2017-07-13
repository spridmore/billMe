# Description

This application was built using Agile development, letting user stories guide project innovation. A RESTful service accesses a third party API to present the user with the most recently passed U.S. congressional bills, bills whose subject matches a user’s search query, and the ability to find their congressional representatives by zip code or by the location of their IP address. 
Technologies: C#, AngularJS, Bootstrap, HTML5, CSS


## Technologies
____

<!--<a href=“https://ibb.co/kmvGYF“><img src=“https://preview.ibb.co/cJOQSa/Rectangle.png” alt=“Rectangle” border=“0” /></a> -->
C# | .NET | ASP.NET | AngularJS | jQuery | Bootstrap | HTML5 | CSS | LINQ | Entity Framework

<br>

## User Model
___
| Parameters  | Value       | Description | Example |
| ----------- | ----------    | ------------ | ------- |
| Search Query        | String         | Area of Interest | "NASA Budget" |
| Zip Code | Integer | Locates Federal Reps | "'User my location'/'90638'"
| Comments         | String      |Reactions to Legislation  | "NASA is a financially resposible organization" |



<br>

## Planning and Approach
___
Two days of wire-framing and user story writing were followed by three one-week sprints. Daily scrum planning outlined daily procedures by verbalizing what was accomplished the prior day, what the goal of the current day, and what types of obstacles were foreseen in the way of sprint execution.
<br>


### Obstacles / Lessons
---
* Cross origin resource sharing errors were corrected by using a C# file to access a third party API.

* User search queries needed to access the data in the third party API. Angular services allowed specific requests to be passed to the API for individualized query retrieval.