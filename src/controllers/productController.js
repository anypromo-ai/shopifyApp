import { fetchProducts } from '../biz/productBiz.js';

export const getProducts = (req, res) => {
  const products = fetchProducts();
  res.json(products);
};
