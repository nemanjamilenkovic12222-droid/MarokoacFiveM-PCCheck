const express = require('express');
const router = express.Router();
const Scan = require('../models/Scan');

// POST - Dodaj novi scan rezultat
router.post('/', async (req, res) => {
    try {
        const newScan = new Scan(req.body);
        const savedScan = await newScan.save();
        res.status(201).json({ 
            success: true, 
            pin: savedScan.pin,
            message: 'Scan rezultat uspješno pohranjen' 
        });
    } catch (error) {
        res.status(400).json({ error: error.message });
    }
});

// GET - Uzmi sve scane
router.get('/', async (req, res) => {
    try {
        const scans = await Scan.find().sort({ scanDate: -1 }).limit(50);
        res.json(scans);
    } catch (error) {
        res.status(500).json({ error: error.message });
    }
});

// GET - Uzmi jedan scan po PIN-u
router.get('/:pin', async (req, res) => {
    try {
        const scan = await Scan.findOne({ pin: req.params.pin });
        if (!scan) {
            return res.status(404).json({ error: 'PIN nije pronađen' });
        }
        res.json(scan);
    } catch (error) {
        res.status(500).json({ error: error.message });
    }
});

module.exports = router;
