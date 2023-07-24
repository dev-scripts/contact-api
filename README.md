# Contact API

CRUD API is created by using DontNet Core 7 and InMemoery storeage.

Rrpositiry Design pattern is used to create the API.

Repository Pattern makes your app more structured, easy to maintain, and very easy to interact with something(e.g model) with the database.

Repositories are classes or components that encapsulate the logic required to access data sources. They centralize common data access functionality, providing better maintainability and decoupling the infrastructure or technology used to access databases from the domain model layer.

In this app we have following layers.

## Models
Model is the data access layer. It acts as a gagateway to access the database.

## Repositories
The repository is a gateway between domain/business/service layer and a data mapping layer, which is the layer that accesses the database and does the operations. Basically the repository is an abstraction to the database access layer.

## Services
 Business logic can be written in service layer, service layer act as an abstraction to the repository. We can say the service layer encapsulates application logic. In our app we don't have much complex business logics in service layer.

## Controller
The Controller works as a gateway between input and the domain logic, is decides what to do with the input and how to output the response.




