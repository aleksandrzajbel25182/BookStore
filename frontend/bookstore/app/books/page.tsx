"use client";

import Button from "antd/es/button/button"
import { Books } from "../components/Books";
import { useEffect, useState } from "react";
import { getAllBooks } from "../services/books";

export default function BooksPage() {
    const [books, setBooks] = useState<Book[]>([]);
    const [loading, setLoading] = useState(true);

    useEffect(() => {
        const getBooks = async () => {
            const books = await getAllBooks();
            setLoading(false);
            setBooks(books);
        }
        getBooks();
    }, []);

    return (
        <div>
            <Button>Add book</Button>

            <Books books={books} />
        </div>
    )
}