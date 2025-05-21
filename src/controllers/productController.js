import { fetchProducts } from '../services/productService.js';

export const getProducts = (req, res) => {
  const products = fetchProducts();
  res.json(products);
};
