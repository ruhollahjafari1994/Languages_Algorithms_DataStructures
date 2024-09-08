// const express = require('express');
// const app = express();
// const port = 3000;

// // Define a route
// app.get('/', (req, res) => {
//   res.send('Hello World!');
// });

// // Start the server
// app.listen(port, () => {
//   console.log(`App is running at http://localhost:${port}`);
// });


const express = require('express');
const bodyParser = require('body-parser');
const app = express();
const port = 3000;

// Use bodyParser to parse JSON bodies
app.use(bodyParser.json());

// In-memory array to store users
let users = [];

// Create User (POST)
app.post('/users', (req, res) => {
  const user = req.body;
  
  // Assign a unique ID to the user
  user.id = users.length + 1;
  
  users.push(user);
  res.status(201).send(`User added with ID: ${user.id}`);
});

// Read All Users (GET)
app.get('/users', (req, res) => {
  res.status(200).json(users);
});

// Read One User by ID (GET)
app.get('/users/:id', (req, res) => {
  const id = parseInt(req.params.id);
  const user = users.find(u => u.id === id);

  if (!user) {
    return res.status(404).send('User not found');
  }
  
  res.status(200).json(user);
});

// Update User by ID (PUT)
app.put('/users/:id', (req, res) => {
  const id = parseInt(req.params.id);
  const userIndex = users.findIndex(u => u.id === id);

  if (userIndex === -1) {
    return res.status(404).send('User not found');
  }

  const updatedUser = req.body;
  updatedUser.id = id; // Ensure the ID remains the same
  users[userIndex] = updatedUser;

  res.status(200).send(`User with ID ${id} updated.`);
});

// Delete User by ID (DELETE)
app.delete('/users/:id', (req, res) => {
  const id = parseInt(req.params.id);
  const userIndex = users.findIndex(u => u.id === id);

  if (userIndex === -1) {
    return res.status(404).send('User not found');
  }

  users.splice(userIndex, 1);
  res.status(200).send(`User with ID ${id} deleted.`);
});

// Start the server
app.listen(port, () => {
  console.log(`App is running at http://localhost:${port}`);
});
