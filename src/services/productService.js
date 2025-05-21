import { products } from '../models/productModel.js';

export const fetchProducts = () => {
  // In a real app, this would fetch from Shopify API or database
  return products;
};
