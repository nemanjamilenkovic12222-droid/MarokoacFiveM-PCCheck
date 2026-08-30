import React from 'react';
import '../styles/Home.css';

function Home({ onNavigate }) {
  return (
    <div className="home">
      <div className="hero">
        <h1>🎮 MAROKO AC</h1>
        <p>Profesionalan FiveM PC Sigurnosni Sistem</p>
        <button className="cta-button" onClick={() => onNavigate('search')}>
          🔎 PRONAĐI REZULTATE
        </button>
      </div>

      <div className="features">
        <div className="feature">
          <h3>✅ Brz Scan</h3>
          <p>Kompletan PC scan za sekunde</p>
        </div>
        <div className="feature">
          <h3>🔐 PIN Zaštita</h3>
          <p>Sigurna 6-cifrena lozinka za rezultate</p>
        </div>
        <div className="feature">
          <h3>🎮 FiveM Check</h3>
          <p>Detektuj sve FiveM mod-ove i scriptove</p>
        </div>
        <div className="feature">
          <h3>⚡ Instant Upload</h3>
          <p>Результati dostupni odmah na Web-u</p>
        </div>
      </div>
    </div>
  );
}

export default Home;
