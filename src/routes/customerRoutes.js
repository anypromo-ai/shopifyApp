import express from 'express';
import { getCustomers, syncCustomersHandler } from '../controllers/customerController.js';

const router = express.Router();

router.get('/', getCustomers);
router.post('/sync', syncCustomersHandler);

export default router;
