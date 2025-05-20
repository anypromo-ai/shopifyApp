# ShopifyApp

This repository demonstrates a simple layered architecture in **C# .NET Framework 4.7.2**. The solution contains four projects:

- **Info**: model classes representing Shopify data
- **Dac**: data access classes saving data to SQL Server
- **Biz**: business logic that talks to the Shopify API and stores results via the Dac layer
- **WebApi**: an OWIN self-hosted Web API exposing sync and query endpoints

## Building

Use `msbuild` to build the solution:

```bash
msbuild ShopifyApp.sln
```

The environment here doesn't have `msbuild` installed, so building may fail unless configured in your setup.

## Running

After a successful build, run the WebApi project:

```bash
WebApi/bin/Debug/WebApi.exe
```

This starts the API on `http://localhost:9000/` with endpoints:

- `POST /api/sync` – fetch products from Shopify and store them in SQL Server
- `GET /api/products` – list stored products
- `GET /api/orders` – list stored orders
- `GET /api/customers` – list stored customers

Connection strings and Shopify credentials are placeholders; replace them with real values before running.
=======
# ShopifyApp (.NET Framework 4.7.2)

This sample solution demonstrates a layered architecture for integrating with Shopify and storing the data locally in SQL Server. It contains four projects:

- **Info** – Plain model classes representing products, orders and customers.
- **Dac** – Data access layer. Contains code that fetches data from Shopify via REST API and saves it to SQL Server tables using ADO.NET.
- **Biz** – Business layer. Coordinates data synchronization by calling the Dac layer.
- **WebApi** – Self-hosted Web API (OWIN). Provides endpoints to trigger synchronization and read data.

## Build

1. Install the **.NET Framework 4.7.2 Developer Pack** and MSBuild.
2. Restore NuGet packages for each project.
3. Run `msbuild ShopifyApp.sln` to build all projects.
4. Start the Web API by running the generated executable in the `WebApi` project.

## Notes

- Replace placeholders in `ShopifyDac` with your Shopify credentials and SQL Server connection string.
- Create `Products`, `Orders`, and `Customers` tables in SQL Server to match the insert statements in `ShopifyDac`.
- The solution is intended as a minimal sample and does not include full error handling.
