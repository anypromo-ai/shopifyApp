# ShopifyApp

This is a simple C# layered example targeting **.NET Framework 4.7.2**. The layers are named according to the instructions:

- **Info**: data models
- **Dac**: data access logic (mocked data here)
- **Biz**: business logic

## Building

1. Ensure you have the .NET SDK that supports building .NET Framework 4.7.2 projects (for example Visual Studio or `dotnet` with the correct targeting packs).
2. Run `dotnet build` or open the project in Visual Studio and build.

## Running

```bash
# from the project directory
# this requires the .NET SDK with net472 targeting pack
 dotnet run
```

The application prints a list of products to the console.
