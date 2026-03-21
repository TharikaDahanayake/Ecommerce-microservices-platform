# Ecommerce-microservices-platform

## Everyday is a learning day !

The Ecommerce Microservices Platform is a modular and scalable system designed to manage key business functions of an online store. It uses a Microservices Architecture, where each service operates independently and communicates through an API Gateway. The project includes the following independent services. They are APIGateway, UserServiceAPI, ProductServiceAPI, OrderServiceAPI. Each service runs independently and follows the microservices approach.

### Features

#### User Service
- User registration & authentication
- Login & profile management
- Secure handling of user data

#### Product Service
- Add, update, list, and delete products
- Product inventory management
- Category-based product organization

#### Order Service
- Create and manage customer orders
- Track order history
- Connects users and product details to complete purchases

#### API Gateway
- Central entry point for all requests
- Handles routing to microservices
- Improves security and request management

### Prerequisites

- .NET SDK
- Visual Studio / VS Code
- Swagger
- Git

## Run With Docker

### Prerequisites for containers

- Docker Desktop

### Build and start all services

From the repository root, run:

```bash
docker compose up --build
```

<img width="1365" height="889" alt="Screenshot 2026-02-18 180139" src="https://github.com/user-attachments/assets/8431fd59-1b4a-41b1-b28d-9e47b5f8f831" />


### Services and exposed ports

- API Gateway: `http://localhost:5251`
- User Service: `http://localhost:5036`
- Product Service: `http://localhost:5103`
- Order Service: `http://localhost:5256`

### Gateway routes

- `GET/POST http://localhost:5251/users`
- `GET/POST http://localhost:5251/products`
- `GET/POST http://localhost:5251/orders`

### Stop containers

```bash
docker compose down
```

#### Thank You Guys & Good Luck! Best Regards, 
**_Tharika Dahanayake_**
