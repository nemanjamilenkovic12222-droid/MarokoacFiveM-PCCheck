const express = require('express');
const router = express.Router();
const Scan = require('../models/Scan');

// GET - Svi rezultati po PIN-u
router.get('/pin/:pin', async (req, res) => {
    try {
        const result = await Scan.findOne({ pin: req.params.pin });
        if (!result) {
            return res.status(404).json({ error: 'Rezultat nije pronađen' });
        }
        res.json(result);
    } catch (error) {
        res.status(500).json({ error: error.message });
    }
});

// GET - Top rezultati
router.get('/top/latest', async (req, res) => {
    try {
        const topScans = await Scan.find().sort({ scanDate: -1 }).limit(10);
        res.json(topScans);
    } catch (error) {
        res.status(500).json({ error: error.message });
    }
});

module.exports = router;
