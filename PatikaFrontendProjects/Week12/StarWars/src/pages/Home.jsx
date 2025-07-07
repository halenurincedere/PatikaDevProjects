import React, { useEffect, useState } from 'react';
import StarshipCard from '../components/StarshipCard';

const Home = () => {
  const [starships, setStarships] = useState([]);
  const [search, setSearch] = useState('');
  const [filtered, setFiltered] = useState([]);
  const [nextUrl, setNextUrl] = useState('https://swapi.tech/api/starships');

  const fetchStarships = async (url) => {
    const res = await fetch(url);
    const data = await res.json();
    setStarships(prev => [...prev, ...data.results]);
    setFiltered(prev => [...prev, ...data.results]);
    setNextUrl(data.next);
  };

  useEffect(() => {
    fetchStarships(nextUrl);
  }, []);

  const handleSearch = () => {
    const lower = search.toLowerCase();
    const filteredResults = starships.filter(ship =>
      ship.name.toLowerCase().includes(lower)
    );
    setFiltered(filteredResults);
  };
  

  return (
    <div className="container">
      <h1>STAR WARS</h1>
      <div className="search-bar">
        <input
          type="text"
          placeholder="Name / Model"
          value={search}
          onChange={(e) => setSearch(e.target.value)}
        />
        <button onClick={handleSearch}>Filter</button>
      </div>
      <div className="grid">
        {filtered.map((ship, index) => (
          <StarshipCard key={index} starship={ship} />
        ))}
      </div>
      {nextUrl && (
        <button className="load-more" onClick={() => fetchStarships(nextUrl)}>
          Daha Fazla
        </button>
      )}
    </div>
  );
};

export default Home;
