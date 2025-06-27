import React, { useState, useEffect } from "react";
import products from "./data/products";
import ProductCard from "./components/ProductCard";
import Receipt from "./components/Receipt";
import "./App.css";
import Footer from "./components/Footer"; // Footer bileşeni eklendi

function App() {
  const [balance, setBalance] = useState(100_000_000_000);
  const [displayedBalance, setDisplayedBalance] = useState(100_000_000_000);
  const [basket, setBasket] = useState({});

  useEffect(() => {
    const interval = setInterval(() => {
      setDisplayedBalance((prev) => {
        if (prev === balance) {
          clearInterval(interval);
          return prev;
        }
        const diff = balance - prev;
        const step = Math.max(1, Math.floor(Math.abs(diff) / 20));
        return prev + (diff > 0 ? step : -step);
      });
    }, 16); // yaklaşık 60fps

    return () => clearInterval(interval);
  }, [balance]);

  const handleBuy = (product) => {
    if (balance >= product.price) {
      setBalance(balance - product.price);
      setBasket((prev) => ({
        ...prev,
        [product.id]: (prev[product.id] || 0) + 1,
      }));
    }
  };

  const handleSell = (product) => {
    if (basket[product.id]) {
      setBalance(balance + product.price);
      setBasket((prev) => ({
        ...prev,
        [product.id]: prev[product.id] - 1,
      }));
    }
  };

  return (
    <div className="container min-h-screen flex flex-col">
      <img src="/assets/Bill-Gates.jpeg" alt="Bill Gates" className="bill-img" />
      <h1 className="main-title">Spend Bill Gates' Money</h1>

      <div className="balance">💵 ${displayedBalance.toLocaleString()}</div>

      <div className="products">
        {products.map((product) => (
          <ProductCard
            key={product.id}
            product={product}
            count={basket[product.id] || 0}
            onBuy={() => handleBuy(product)}
            onSell={() => handleSell(product)}
            canBuy={balance >= product.price}
            canSell={(basket[product.id] || 0) > 0}
          />
        ))}
      </div>

      <Receipt basket={basket} products={products} />

      
      <Footer />
    </div>
  );
}

export default App;
