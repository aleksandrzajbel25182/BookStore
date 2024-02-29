import { Layout, Menu } from "antd";
import "./globals.css";
import { Content, Footer, Header } from "antd/es/layout/layout";
import Link from "next/link";

const items = [
  { key: "home", label: <Link href={"/"}>Home</Link> },
  { key: "books", label: <Link href={"/books"}>Books</Link> },
];
export default function RootLayout({
  children,
}: {
  children: React.ReactNode;
}) {
  return (
    <html lang="en">
      <body>
        <Layout style={{ minHeight: "100vh" }}>

          <Header>
            <Menu
              theme="dark"
              mode="horizontal"
              items={items}
              style={{ flex: 1, minWidth: 0 }} />


          </Header>
          <Content style={{ padding: "0 48px" }}>{children}</Content>
          <Footer style={{ textAlign: "center" }}>
            Book store 2024 Test web application
          </Footer>

        </Layout>
      </body>
    </html>
  );
}
