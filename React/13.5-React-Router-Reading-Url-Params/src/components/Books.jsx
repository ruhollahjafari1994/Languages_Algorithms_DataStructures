import { Link, Outlet } from "react-router-dom";

import { getBooks } from "../data/data";

const Books = () => {
  const books = getBooks();

  return (
    <div style={{ display: "flex" }}>
      <nav style={{ borderLeft: "solid 35px", padding: "1rem" }}>
        <input type="text" placeholder="جستجوی کتاب" />
        {books.map((book) => (
          <Link
            style={{ display: "block" }}
            to={`/books/${book.number}`}
            key={book.number}
          >
            {book.name}
          </Link>
        ))}
      </nav>
      <Outlet />
    </div>
  );
};

export default Books;
