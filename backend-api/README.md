# Backend API

## Setup

```bash
cd backend-api
npm install
```

## Konfiguracija

1. Kreiraj `.env` fajl iz `.env.example`
2. Postavi MongoDB URI

```bash
cp .env.example .env
```

## Pokretanje

### Development
```bash
npm run dev
```

### Production
```bash
npm start
```

Server će biti dostupan na `http://localhost:5000`

## API Endpoints

### POST /api/scans
Dodaj novi scan rezultat

```json
{
  "pin": "123456",
  "cpu": "Intel Core i7",
  "ram": "16 GB",
  "gpu": "RTX 3070",
  "disk": "C: (500 GB)",
  "fiveMMods": [...],
  "status": "CLEAN"
}
```

### GET /api/results/pin/:pin
Uzmi rezultat po PIN-u

### GET /api/results/top/latest
Uzmi top 10 najnovijih rezultata
