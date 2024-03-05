# WebAPI_CQRS_Mediator_Pattern

Cách triển khai 1 Web API theo CQRS Pattern

## Layer 1: Application Core Layer
* Setup Application Core
  * Domain and Application Projects
* Added MediaR and Automapper
  * CQRS - Request and Handlers
  * Object Mapping
* Fluent Validation
  * Complex but flexible validation logic
 
## Layer 2: Infrasture Layer
* Implementations of contracts
  * E.g Repository Implementations
* Entity Framework Core
* Third-party Services
  * Email
  * Logging
 
## Layer 3: Devep API
* Configured API
  * Injecting project dependencies
  * Create Database using EF Core commands
  * Implemented Thin Controller
  * Setup Global Exception Handing (using MediaR)
  * Add application configuration (email and database)

## Layer 4: UI
