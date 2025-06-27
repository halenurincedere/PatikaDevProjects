import React, { useEffect } from "react";
import { useSelector, useDispatch } from "react-redux";
import Card from "./components/Card";
import Footer from "./components/Footer";
import { resetFlippedCards, restartGame } from "./redux/gameSlice";
import "./App.css";

function App() {
  const dispatch = useDispatch();
  const { cards, flippedCards, score, gameCompleted } = useSelector(
    (state) => state.game
  );

  useEffect(() => {
    if (flippedCards.length === 2) {
      const [first, second] = flippedCards;
      if (first.value !== second.value) {
        const timer = setTimeout(() => {
          dispatch(resetFlippedCards());
        }, 1000);
        return () => clearTimeout(timer); // cleanup
      }
    }
  }, [flippedCards, dispatch]);

  return (
    <div className="container">
      <h1>Hafıza Oyunu</h1>
      <p>Puan: {score}</p>
      <div className="grid">
        {cards.map((card) => (
          <Card key={`${card.id}-${card.value}`} card={card} />
        ))}
      </div>
      {gameCompleted && (
        <button className="restart" onClick={() => dispatch(restartGame())}>
          Yeniden Oyna
        </button>
      )}
      {/* Sabit Footer */}
      <Footer />
    </div>
  );
}

export default App;
