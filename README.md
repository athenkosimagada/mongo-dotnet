# Repository Overview

## Description
This repository is dedicated to learning microservices architecture in .NET Core. The primary focus is on building various APIs, with a central Authentication API (authAPI) playing a crucial role in the architecture. These APIs are secured using JWT tokens, allowing access only to authorized users.

## Technologies Used
- **.NET Core**: The framework used for building the microservices.
- **Microsoft SQL Server**: The database management system utilized for storing data.
- **Entity Framework Core**: The ORM (Object-Relational Mapping) framework for interacting with the database.
- **Automapper**: A library used for mapping between different objects, particularly DTOs (Data Transfer Objects).
- **JWT (JSON Web Tokens)**: Used for generating and validating authentication tokens.

## Features
- **Microservices Architecture**: The project follows a microservices architecture, allowing for scalability and modularity.
- **Authentication API**: The authAPI handles authentication and authorization, providing secure access to other APIs.
- **Token-based Security**: JWT tokens are generated and validated to control access to protected APIs.
- **Microsoft SQL Server Integration**: Integration with Microsoft SQL Server for data storage and retrieval.
- **Entity Framework Core**: Utilized for seamless interaction with the database, including CRUD operations.
- **Automapper for DTOs**: Automapper is used to map between domain models and DTOs, improving code maintainability.


