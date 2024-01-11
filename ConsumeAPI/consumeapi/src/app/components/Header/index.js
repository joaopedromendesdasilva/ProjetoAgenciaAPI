import Link from 'next/link';

export default function Header() {
  return (
    <div>
      <header>
        <h1>Meu Site</h1>
      </header>

      <nav>
        <ul>
          <li>
            <Link href="/RotaUm">
              <a>Rota 1</a>
            </Link>
          </li>
          <li>
            <Link href="/RotaDois">
              <a>Rota 2</a>
            </Link>
          </li>
          <li>
            <Link href="/RotaTres">
              <a>Rota 3</a>
            </Link>
          </li>
        </ul>
      </nav>

      <main>
        <p>Conteúdo da página inicial</p>
      </main>
    </div>
  );
};

