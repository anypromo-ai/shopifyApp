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
