import React from 'react';

function Dice({ value }) {
  return (
    <div className="dice">
      <img 
        src={`/dice${value}.png`} 
        alt={`Zar ${value}`} 
        width="100"
      />
    </div>
  );
}

export default Dice;