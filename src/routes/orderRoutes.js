import express from 'express';
import { getOrders, syncOrdersHandler } from '../controllers/orderController.js';

const router = express.Router();

router.get('/', getOrders);
router.post('/sync', syncOrdersHandler);

export default router;
