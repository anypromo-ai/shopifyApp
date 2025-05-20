# ShopifyApp

This solution illustrates a simple layered architecture using **.NET Framework 4.7.2**. The projects are:

- **Info**: model classes shared across layers.
- **Dac**: data access layer that calls Shopify's REST API. Replace the placeholder shop URL and access token in `ProductDac` before running.
- **Biz**: business layer providing operations that use the data layer.
- **WebApi**: OWIN self‑hosted ASP.NET Web API exposing endpoints. `GET /api/products` returns Shopify product data.

## Build

Open `ShopifyApp.sln` in Visual Studio 2019 or run:

```bash
msbuild ShopifyApp.sln
```

## Run

After building, run the `WebApi` project. The server listens on `http://localhost:9000/`.

```
GET http://localhost:9000/api/products
```
