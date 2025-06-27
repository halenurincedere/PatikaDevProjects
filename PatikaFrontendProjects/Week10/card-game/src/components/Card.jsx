import React from 'react';
import { useDispatch } from 'react-redux';
import { flipCard } from '../redux/gameSlice';
import './Card.css';

const Card = ({ card }) => {
  const dispatch = useDispatch();

  const handleClick = () => {
    dispatch(flipCard(card.id));
  };

  return (
    <div
      className={`card ${card.flipped || card.matched ? 'flipped' : ''}`}
      onClick={handleClick}
    >
      <div className="front">
        {card.flipped || card.matched ? card.value : "?"}
      </div>
    </div>
  );
};

export default Card;
