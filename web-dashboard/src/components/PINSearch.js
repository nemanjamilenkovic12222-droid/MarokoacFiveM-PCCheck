import React, { useState, useEffect } from 'react';
import axios from 'axios';
import '../styles/PINSearch.css';

function PINSearch({ onSearch }) {
  const [pin, setPin] = useState('');
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState('');

  const handleSearch = async (e) => {
    e.preventDefault();
    if (!pin.match(/^\d{6}$/)) {
      setError('PIN mora biti 6 brojeva!');
      return;
    }

    setLoading(true);
    try {
      const response = await axios.get(`http://localhost:5000/api/results/pin/${pin}`);
      onSearch(response.data);
      setError('');
    } catch (err) {
      setError('PIN nije pronađen!');
    } finally {
      setLoading(false);
    }
  };

  return (
    <div className="pin-search">
      <div className="search-container">
        <h1>🔍 PRONAĐI REZULTATE</h1>
        <form onSubmit={handleSearch}>
          <input
            type="text"
            placeholder="Unesite PIN (6 brojeva)..."
            value={pin}
            onChange={(e) => setPin(e.target.value)}
            maxLength="6"
            pattern="[0-9]*"
          />
          <button type="submit" disabled={loading}>
            {loading ? 'Učitavanje...' : '🔎 PRETRAŽI'}
          </button>
        </form>
        {error && <p className="error">{error}</p>}
      </div>
    </div>
  );
}

export default PINSearch;
