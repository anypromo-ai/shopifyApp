# ShopifyApp (.NET Framework 4.7.2)

This sample demonstrates a simple layered architecture for integrating with Shopify using C#.

## Projects

- **Info** - Model classes shared across layers.
- **Dac** - Data access layer handling Shopify API calls and SQL Server operations.
- **Biz** - Business logic orchestrating synchronization between Shopify and the local database.
- **WebApi** - Self-hosted Web API using OWIN to expose endpoints.

## Build

Open `ShopifyApp.sln` in Visual Studio 2019 or later and restore NuGet packages. The solution targets **.NET Framework 4.7.2**.

## Usage

Run the WebApi project. It hosts an HTTP service at `http://localhost:9000/` with the following endpoint:

- `POST /api/products/sync` – fetch products from Shopify and store them in SQL Server.

Order and customer APIs are left as TODOs.

Credentials and connection strings should be configured in `Startup.cs` when constructing `ShopifyDac` and `SqlServerDac`.
