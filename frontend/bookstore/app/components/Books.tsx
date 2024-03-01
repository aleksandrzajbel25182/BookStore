import Card from "antd/es/card/Card"
import { CarTitle } from "./Cardtitle"
import { title } from "process"
import Button from "antd/es/button/button"

interface Props {
    books: Book[];
    handelDelete: (id: string) => void;
    handelOpen: (book: Book) => void;
}
export const Books = ({ books, handelDelete, handelOpen }: Props) => {
    return (
        <div className="cards">
            {books.map((book: Book) => (
                <Card
                    key={book.id}
                    title={<CarTitle title={book.title} price={book.price} />}
                    bordered={false}
                >
                    <p>{book.description}</p>
                    <div className="card__buttons">
                        <Button onClick={() => handelOpen(book)}> Edit</Button>
                        <Button
                            onClick={() => handelDelete(book.id)}
                            danger
                            style={{ flex: 1 }}
                        >Delete</Button>
                    </div>
                </Card>
            ))}
        </div>
    )
}