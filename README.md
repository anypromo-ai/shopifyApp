# Shopify App

This is a minimal Express server demonstrating a layered architecture for syncing
Shopify data. Models, services, and controllers are organized under the `src`
directory.

## Endpoints

- `GET /products` - list products
- `POST /orders/sync` - add a sample order (sync)
- `GET /orders` - list orders
- `POST /customers/sync` - add a sample customer (sync)
- `GET /customers` - list customers

Use `node index.js` to start the server (requires installing dependencies with
`npm install`).
