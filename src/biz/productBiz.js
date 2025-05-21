import { getAllProducts } from '../dac/productDac.js';

export const fetchProducts = () => {
  return getAllProducts();
};
