import { useState } from "react";

import {
  AddContact,
  Contact,
  Contacts,
  EditContact,
  Navbar,
  ViewContact,
} from "./components";

import "./App.css";

const App = () => {
  const [loading, setLoading] = useState(false);
  const [getContacts, setContacts] = useState([]);

  return (
    <div className="App">
      <Navbar />
      <Contacts contacts={getContacts} loading={loading} />
    </div>
  );
};

export default App;
