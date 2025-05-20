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
