# ShopifyApp

This sample demonstrates a .NET Framework 4.7.2 console application using a layered architecture to retrieve products from Shopify.

## Layers
- **Info**: model classes
- **Dac**: data access for Shopify APIs
- **Biz**: business logic using the Dac layer

## Build
Run `msbuild ShopifyApp.csproj` in a machine with Visual Studio Build Tools or the full .NET Framework SDK installed.

## Run
After building, execute the compiled `ShopifyApp.exe`. It will attempt to fetch products from Shopify and print their titles.

Replace the placeholder Shopify credentials in `Dac/ProductDac.cs` with your own before running.

