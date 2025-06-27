import { createSlice } from '@reduxjs/toolkit';

const totalCards = 25;

const generateShuffledCards = () => {
  const pairs = Array.from({ length: Math.floor(totalCards / 2) }, (_, i) => i + 1);
  let cards = [...pairs, ...pairs];
  if (totalCards % 2 === 1) cards.push(0);
  return cards
    .sort(() => Math.random() - 0.5)
    .map((value, index) => ({
      id: index,
      value,
      flipped: false,
      matched: false,
    }));
};

const initialState = {
  cards: generateShuffledCards(),
  flippedCards: [],
  score: 0,
  gameCompleted: false,
};

const gameSlice = createSlice({
  name: 'game',
  initialState,
  reducers: {
    flipCard: (state, action) => {
      const cardIndex = state.cards.findIndex(c => c.id === action.payload);
      const card = state.cards[cardIndex];
      if (card.flipped || card.matched || state.flippedCards.length === 2) return;

      // Kartı flipped = true olarak güncelle (immutable şekilde)
      state.cards[cardIndex] = { ...card, flipped: true };

      // flippedCards dizisine ekle
      state.flippedCards.push(state.cards[cardIndex]);

      if (state.flippedCards.length === 2) {
        const [first, second] = state.flippedCards;

        if (first.value === second.value && first.id !== second.id) {
          // matched = true olarak kartları güncelle (immutable)
          state.cards = state.cards.map(c =>
            c.id === first.id || c.id === second.id ? { ...c, matched: true } : c
          );

          state.score += 50;
          state.flippedCards = [];
        } else {
          state.score -= 10;
          // flippedCards dizisi burada temizlenmeyecek,
          // kapanma işlemi App.jsx'teki resetFlippedCards ile yapılacak
        }
      }
      
      state.gameCompleted = state.cards
      .filter(c => c.value !== 0)
      .every(c => c.matched);
    },

    resetFlippedCards: (state) => {
      const [first, second] = state.flippedCards;

      if (first && second && first.value !== second.value) {
        // Eşleşmeyen kartları flipped: false yap (immutable)
        state.cards = state.cards.map(c =>
          !c.matched && (c.id === first.id || c.id === second.id)
            ? { ...c, flipped: false }
            : c
        );
      }

      state.flippedCards = [];
    },

    restartGame: (state) => {
      state.cards = generateShuffledCards();
      state.flippedCards = [];
      state.score = 0;
      state.gameCompleted = false;
    },
  },
});

export const { flipCard, resetFlippedCards, restartGame } = gameSlice.actions;
export default gameSlice.reducer;
