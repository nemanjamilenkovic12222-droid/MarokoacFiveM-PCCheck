require('dotenv').config();
const express = require('express');
const cors = require('cors');
const mongoose = require('mongoose');
const scanRoutes = require('./routes/scans');
const resultsRoutes = require('./routes/results');

const app = express();

// Middleware
app.use(cors());
app.use(express.json());

// MongoDB Connection
mongoose.connect(process.env.MONGODB_URI || 'mongodb://localhost:27017/maroko-ac', {
    useNewUrlParser: true,
    useUnifiedTopology: true
});

// Routes
app.use('/api/scans', scanRoutes);
app.use('/api/results', resultsRoutes);

// Health Check
app.get('/health', (req, res) => {
    res.json({ status: 'Maroko AC Backend Running ✓' });
});

const PORT = process.env.PORT || 5000;
app.listen(PORT, () => {
    console.log(`🚀 Maroko AC Backend na portu ${PORT}`);
});
