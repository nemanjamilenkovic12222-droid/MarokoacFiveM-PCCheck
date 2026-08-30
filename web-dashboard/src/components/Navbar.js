import React from 'react';
import '../styles/Navbar.css';

function Navbar({ onNavigate }) {
  return (
    <nav className="navbar">
      <div className="nav-container">
        <div className="nav-brand" onClick={() => onNavigate('home')}>
          🎮 MAROKO AC
        </div>
        <ul className="nav-menu">
          <li><button onClick={() => onNavigate('home')}>🏠 Početna</button></li>
          <li><button onClick={() => onNavigate('search')}>🔍 Pronađi PIN</button></li>
          <li><button onClick={() => onNavigate('results')}>📊 Rezultati</button></li>
        </ul>
      </div>
    </nav>
  );
}

export default Navbar;
