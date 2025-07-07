import React, { useEffect, useState } from 'react';
import { useNavigate } from 'react-router-dom';
import starshipImage from './../assets/starship.jpg';

const getIdFromUrl = (url) => {
  const parts = url.split('/').filter(Boolean);
  return parts[parts.length - 1];
};

const StarshipCard = ({ starship }) => {
  const navigate = useNavigate();
  const id = getIdFromUrl(starship.url);
  const [details, setDetails] = useState(null);

  useEffect(() => {
    const fetchDetails = async () => {
      const res = await fetch(`https://www.swapi.tech/api/starships/${id}`);
      const data = await res.json();
      setDetails(data.result.properties);
    };

    fetchDetails();
  }, [id]);

  return (
    <div className="card" onClick={() => navigate(`/starship/${id}`)}>
      <img src={starshipImage} alt="starship" />
      <h3>{starship.name}</h3>
      {details && (
        <>
          <p><strong>Model:</strong> {details.model}</p>
          <p><strong>Hyperdrive Rating:</strong> {details.hyperdrive_rating}</p>
        </>
      )}
    </div>
  );
};

export default StarshipCard;
