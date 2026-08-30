import React from 'react';
import '../styles/ResultsSection.css';

function ResultsSection({ data }) {
  if (!data) return <div className="results"><p>Nema podataka</p></div>;

  const getStatusIcon = (status) => {
    switch(status) {
      case 'CLEAN': return '✅';
      case 'WARNING': return '⚠️';
      case 'DANGER': return '❌';
      default: return '❓';
    }
  };

  return (
    <div className="results-section">
      <div className="results-header">
        <h1>📊 REZULTATI SKENIRANJA</h1>
        <div className="pin-badge">
          <span>PIN:</span>
          <strong>{data.pin}</strong>
        </div>
      </div>

      <div className="results-grid">
        <div className="result-card status-card">
          <h3>STATUS</h3>
          <div className="status-badge">
            {getStatusIcon(data.status)} {data.status}
          </div>
          <p>Risk Score: <strong>{data.riskScore}/100</strong></p>
        </div>

        <div className="result-card">
          <h3>💻 HARDWARE</h3>
          <ul>
            <li><strong>CPU:</strong> {data.cpu}</li>
            <li><strong>RAM:</strong> {data.ram}</li>
            <li><strong>GPU:</strong> {data.gpu}</li>
            <li><strong>Disk:</strong> {data.disk}</li>
          </ul>
        </div>

        <div className="result-card">
          <h3>🎮 FIVEM MODOVI</h3>
          <ul>
            {data.fiveMMods && data.fiveMMods.length > 0 ? (
              data.fiveMMods.map((mod, i) => <li key={i}>• {mod}</li>)
            ) : (
              <li>Nema detektovanih modova</li>
            )}
          </ul>
        </div>

        <div className="result-card">
          <h3>⚡ FIVEM LUA SCRIPTS</h3>
          <ul>
            {data.fiveMLua && data.fiveMLua.length > 0 ? (
              data.fiveMLua.map((lua, i) => <li key={i}>• {lua}</li>)
            ) : (
              <li>Nema detektovanih skripti</li>
            )}
          </ul>
        </div>

        <div className="result-card danger">
          <h3>⛔ OPASNI STRINGOVI</h3>
          <ul>
            {data.dangerousStrings && data.dangerousStrings.length > 0 ? (
              data.dangerousStrings.map((str, i) => <li key={i}>• {str}</li>)
            ) : (
              <li>✓ Nema opasnih stringova</li>
            )}
          </ul>
        </div>

        <div className="result-card danger">
          <h3>🚫 CITOTI / CHEATS</h3>
          <ul>
            {data.citos && data.citos.length > 0 ? (
              data.citos.map((cito, i) => <li key={i}>• {cito}</li>)
            ) : (
              <li>✓ Bez citota detektovanih</li>
            )}
          </ul>
        </div>

        <div className="result-card">
          <h3>🔍 SUMNJIVI PROGRAMI</h3>
          <ul>
            {data.suspiciousPrograms && data.suspiciousPrograms.length > 0 ? (
              data.suspiciousPrograms.map((prog, i) => <li key={i}>• {prog}</li>)
            ) : (
              <li>✓ Svi programi su sigurni</li>
            )}
          </ul>
        </div>
      </div>

      <div className="results-footer">
        <p>Datum skeniranja: <strong>{new Date(data.scanDate).toLocaleString('sr-RS')}</strong></p>
      </div>
    </div>
  );
}

export default ResultsSection;
