import { customers } from '../models/customerModel.js';

export const fetchCustomers = () => {
  return customers;
};

export const syncCustomers = () => {
  const nextId = customers.length + 1;
  customers.push({ id: nextId, name: `Customer${nextId}`, email: `customer${nextId}@example.com` });
  return customers;
};
