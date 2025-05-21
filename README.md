# Shopify App (Node.js)

This example demonstrates a layered Node.js project with Express. The layers follow the **Info**, **Dac**, and **Biz** naming convention.

## Structure

- `src/info` - data models (Info layer)
- `src/dac` - data access code that retrieves data
- `src/biz` - business logic that orchestrates calls to the Dac layer
- `src/controllers` - request handlers used by the API
- `src/routes` - Express routes
- `index.js` - application entry point

## Running

1. Install dependencies (requires internet access):
   ```bash
   npm install
   ```
2. Start the server:
   ```bash
   node index.js
   ```
3. Open `http://localhost:3000/products` to list products.

The example uses in-memory data but the Dac layer can be extended to call Shopify APIs or a database.
