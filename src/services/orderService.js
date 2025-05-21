import { orders } from '../models/orderModel.js';

export const fetchOrders = () => {
  return orders;
};

export const syncOrders = () => {
  const nextId = orders.length + 1;
  orders.push({ id: nextId, number: `ORD00${nextId}`, total: 199.99 });
  return orders;
};
