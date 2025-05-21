import { fetchOrders, syncOrders } from '../services/orderService.js';

export const getOrders = (req, res) => {
  const data = fetchOrders();
  res.json(data);
};

export const syncOrdersHandler = (req, res) => {
  const data = syncOrders();
  res.json({ message: 'Orders synced', orders: data });
};
