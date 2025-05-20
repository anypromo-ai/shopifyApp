# ShopifyApp

This repository demonstrates a layered ASP.NET Web API application targeting **.NET Framework 4.7.2**.

## Projects

- **Info**: Contains model classes used across layers.
- **Dac**: Data access layer returning product data. Replace placeholder code with calls to Shopify or a database as needed.
- **Biz**: Business logic layer that consumes `Dac` and exposes operations for higher layers.
- **Web**: ASP.NET Web API project exposing REST endpoints.

All projects are included in the `ShopifyApp.sln` solution file.

## Build

Open the solution in Visual Studio 2017 or newer with .NET Framework 4.7.2 installed. Build the solution or run:

```bash
msbuild ShopifyApp.sln
```

## Run

Set `ShopifyApp.Web` as the startup project in Visual Studio and run the application. The `ProductController` exposes `GET /api/products` which returns sample products.

## Notes

This setup uses placeholder data. Integrate your Shopify credentials and API calls in the `Dac` layer for a complete implementation.
