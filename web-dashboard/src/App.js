import React, { useState } from 'react';
import './styles/App.css';
import Navbar from './components/Navbar';
import PINSearch from './components/PINSearch';
import ResultsSection from './components/ResultsSection';
import Home from './pages/Home';

function App() {
  const [currentPage, setCurrentPage] = useState('home');
  const [pinData, setPinData] = useState(null);

  const handlePINSearch = (data) => {
    setPinData(data);
    setCurrentPage('results');
  };

  return (
    <div className="App">
      <Navbar onNavigate={setCurrentPage} />
      
      {currentPage === 'home' && <Home onNavigate={setCurrentPage} />}
      {currentPage === 'search' && <PINSearch onSearch={handlePINSearch} />}
      {currentPage === 'results' && <ResultsSection data={pinData} />}
    </div>
  );
}

export default App;
