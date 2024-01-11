import Header from "./components/Header"
import Header from "./components/Footer"
import './globals.css'


export default function RootLayout({ children }) {
  return (
    <html lang="PT-BR">
      <body>
        <Header/>
        <main>{children}</main>
        <Footer/>
        </body>
    </html>
  )
}
