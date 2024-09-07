const express = require('express');
const app = express();
const port = 3000;

// Define a route
app.get('/', (req, res) => {
  res.send('Hello World!');
});

// Start the server
app.listen(port, () => {
  console.log(`App is running at http://localhost:${port}`);
});
