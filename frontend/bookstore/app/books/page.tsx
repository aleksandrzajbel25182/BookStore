"use client";

import Button from "antd/es/button/button"
import { Books } from "../components/Books";
import { useEffect } from "react";

export default function BookPage() {
    useEffect(() => {

    }, [])

    return (
        <div>
            <Button>Add book</Button>

            <Books book={books} />
        </div>
    )
} ы