// src/components/Navigation.js
import React from 'react';
import { Link } from 'react-router-dom';
import './Navigation.css';

const Navigation = () => {
  return (
    <div className="navigation">
      <Link to="/">Home</Link>
      <Link to="/resume">Resume</Link>
      <Link to="/works">Works</Link>
      <Link to="/about">About Me</Link>
    </div>
  );
};

export default Navigation;
