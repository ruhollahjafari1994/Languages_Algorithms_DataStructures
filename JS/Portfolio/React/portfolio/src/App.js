// src/App.js
import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Sidebar from './components/Sidebar';
import Navigation from './components/Navigation';
import Home from './pages/Home';
import Resume from './pages/Resume';
import Works from './pages/Works';
import About from './pages/About';
import './App.css';

function App() {
  return (
    <Router>
      <div className="container">
        <Sidebar />
        <div className="main-content">
          <Navigation />
          <Routes>
            <Route path="/" element={<Home />} />
            <Route path="/resume" element={<Resume />} />
            <Route path="/works" element={<Works />} />
            <Route path="/about" element={<About />} />
          </Routes>
        </div>
      </div>
    </Router>
  );
}

export default App;
