import express from 'express';
import productRoutes from './src/routes/productRoutes.js';
import orderRoutes from './src/routes/orderRoutes.js';
import customerRoutes from './src/routes/customerRoutes.js';

const app = express();
const PORT = process.env.PORT || 3000;

app.use(express.json());
app.use('/products', productRoutes);
app.use('/orders', orderRoutes);
app.use('/customers', customerRoutes);


app.get('/', (req, res) => {
  res.json({ message: 'Welcome to the Shopify App!' });
});

app.listen(PORT, () => {
  console.log(`Server is running on port ${PORT}`);
});
