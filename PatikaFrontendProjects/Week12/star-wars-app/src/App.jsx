import { useState, useEffect } from 'react';
import StarshipList from './components/StarshipList';
import StarshipDetail from './components/StarshipDetail';
import './index.css';

function App() {
  const [starships, setStarships] = useState([]);
  const [nextUrl, setNextUrl] = useState('https://swapi.dev/api/starships/');
  const [selected, setSelected] = useState(null);
  const [search, setSearch] = useState('');

  const fetchStarships = async () => {
    if (!nextUrl) return;
    const res = await fetch(nextUrl);
    const data = await res.json();
    setStarships(prev => [...prev, ...data.results]);
    setNextUrl(data.next);
  };

  useEffect(() => {
    fetchStarships();
  }, []);

  const handleSearch = (e) => setSearch(e.target.value.toLowerCase());

  const filtered = starships.filter(ship =>
    ship.name.toLowerCase().includes(search) ||
    ship.model.toLowerCase().includes(search)
  );

  return (
    <div className="container">
      <h1 className="title">⭐ STAR WARS</h1>

      {!selected ? (
        <>
          <div className="search-bar">
            <input
              type="text"
              placeholder="Name / Model"
              onChange={handleSearch}
            />
            <button onClick={fetchStarships}>Load More</button>
          </div>

          <StarshipList starships={filtered} onSelect={setSelected} />
        </>
      ) : (
        <StarshipDetail starship={selected} onBack={() => setSelected(null)} />
      )}
    </div>
  );
}

export default App;