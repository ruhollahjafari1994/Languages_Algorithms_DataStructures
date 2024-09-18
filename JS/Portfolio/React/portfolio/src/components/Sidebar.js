// src/components/Sidebar.js
import React from 'react';
import './Sidebar.css'; // Create a separate CSS file or use inline styling

const Sidebar = () => {
  return (
    <div className="sidebar">
      <img src="images/profile image.png" alt="Profile Picture" />
      <h2>Roohollah Jafari</h2>
      <h4>Software Engineer</h4>

      <div className="contact-icons">
        <a href="#" target="_blank">🔗</a>
        <a href="#" target="_blank">💼</a>
        <a href="#" target="_blank">✉️</a>
        <a href="#" target="_blank">🐦</a>
      </div>

      <div className="info">
        <p><strong>Date of birth:</strong> 1372/12/13</p>
        <p><strong>Residence:</strong> Tehran</p>
        <p><strong>Experience:</strong> 7+ Years</p>
        <p><strong>Freelance:</strong> Available</p>
      </div>

      <div className="skills">
        <h3>Skills</h3>
        <ul>
          <li>C# and .NET</li>
          <li>Microservices Architecture Design</li>
          <li>Entity Framework Core</li>
          <li>SQL and T-SQL</li>
          <li>Architectural Pattern Design</li>
          <li>Test-Driven Development (TDD)</li>
        </ul>
      </div>

      <div className="languages">
        <p><strong>Languages:</strong></p>
        <p>English: B2</p>
      </div>
    </div>
  );
};

export default Sidebar;
