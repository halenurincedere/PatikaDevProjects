import React from 'react';
import { Routes, Route } from 'react-router-dom';
import Home from './pages/Home';
import StarshipDetail from './components/StarshipDetail';

const App = () => {
  return (
    <Routes>
      <Route path="/" element={<Home />} />
      <Route path="/starship/:id" element={<StarshipDetail />} />
    </Routes>
  );
};

export default App;
