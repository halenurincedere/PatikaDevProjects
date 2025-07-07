import React, { useEffect, useState } from 'react';
import { useParams, useNavigate } from 'react-router-dom';
import starship from './../assets/starship.jpg'

const StarshipDetail = () => {
  const { id } = useParams();
  const navigate = useNavigate();
  const [ship, setShip] = useState(null);

  useEffect(() => {
    const fetchDetail = async () => {
      const res = await fetch(`https://www.swapi.tech/api/starships/${id}/`);
      const data = await res.json();
      setShip(data.result.properties);
    };
    fetchDetail();
  }, [id]);
  

  if (!ship) return <p>Loading...</p>;

  return (
    <div className="detail-container">
      <button onClick={() => navigate(-1)}>←</button>
      <h2>{ship.name}</h2>
      <img src={starship} />
      <p><strong>Model:</strong> {ship.model}</p>
      <p><strong>Hyperdrive Rating:</strong> {ship.hyperdrive_rating}</p>
      <p><strong>Passengers:</strong> {ship.passengers}</p>
      <p><strong>Max Atmosphering Speed:</strong> {ship.max_atmosphering_speed}</p>
      <p><strong>Manufacturer:</strong> {ship.manufacturer}</p>
      <p><strong>Crew:</strong> {ship.crew}</p>
      <p><strong>Cargo Capacity:</strong> {ship.cargo_capacity}</p>
    </div>
  );
};

export default StarshipDetail;
