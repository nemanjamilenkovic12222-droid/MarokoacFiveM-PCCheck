const mongoose = require('mongoose');

const scanSchema = new mongoose.Schema({
    pin: {
        type: String,
        unique: true,
        required: true
    },
    scanDate: {
        type: Date,
        default: Date.now
    },
    cpu: String,
    ram: String,
    gpu: String,
    disk: String,
    fiveMLua: [String],
    fiveMMods: [String],
    dangerousStrings: [String],
    citos: [String],
    suspiciousPrograms: [String],
    status: {
        type: String,
        enum: ['CLEAN', 'WARNING', 'DANGER'],
        default: 'CLEAN'
    },
    riskScore: {
        type: Number,
        default: 0
    }
});

module.exports = mongoose.model('Scan', scanSchema);
