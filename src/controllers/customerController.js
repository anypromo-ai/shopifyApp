import { fetchCustomers, syncCustomers } from '../services/customerService.js';

export const getCustomers = (req, res) => {
  const data = fetchCustomers();
  res.json(data);
};

export const syncCustomersHandler = (req, res) => {
  const data = syncCustomers();
  res.json({ message: 'Customers synced', customers: data });
};
