import React, { useState } from 'react';
import Dice from './components/Dice';
import './App.css';

// 1-6 arasında rastgele sayı üret
const getRandom = () => Math.floor(Math.random() * 6) + 1;

function App() {
  const [playerName, setPlayerName] = useState('Player 1');
  const [pcName, setPcName] = useState('Player 2');
  const [dice1, setDice1] = useState(1);
  const [dice2, setDice2] = useState(1);
  const [message, setMessage] = useState('Press Roll to Start');
  const [rolling, setRolling] = useState(false);

  const rollDice = () => {
    if (rolling) return;
    setRolling(true);
    setMessage('Rolling... ⏳');

    const anim = setInterval(() => {
      setDice1(getRandom());
      setDice2(getRandom());
    }, 100);

    setTimeout(() => {
      clearInterval(anim);

      const final1 = getRandom();
      const final2 = getRandom();
      setDice1(final1);
      setDice2(final2);

      if (final1 > final2) setMessage(`${playerName} Wins! 🏆`);
      else if (final1 < final2) setMessage(`${pcName} Wins! 🤖`);
      else setMessage('Draw! 🤝');

      setRolling(false);
    }, 3000);
  };

  return (
    <div className="app-wrapper">
      <div className="content">
        <h1>{message}</h1>

        <div className="players">
          <div>
            <input
              className="name-input"
              value={playerName}
              onChange={(e) => setPlayerName(e.target.value)}
            />
            <p className="player-label">{playerName}</p>
            <Dice value={dice1} />
          </div>

          <div>
            <input
              className="name-input"
              value={pcName}
              onChange={(e) => setPcName(e.target.value)}
            />
            <p className="player-label">{pcName}</p>
            <Dice value={dice2} />
          </div>
        </div>

        <button onClick={rollDice} disabled={rolling}>
          {rolling ? 'Rolling...' : '🎲 Roll'}
        </button>
      </div>

      <footer>www 🎲 Dice Game 🎲 com</footer>
    </div>
  );
}

export default App;