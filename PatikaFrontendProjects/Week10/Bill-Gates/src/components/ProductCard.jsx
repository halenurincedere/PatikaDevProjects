import React from "react";
import "./ProductCard.css";

function ProductCard({ product, count, onBuy, onSell, canBuy, canSell }) {
  return (
    <div className="card">
      <img src={product.image} alt={product.name} />
      <h3>{product.name}</h3>
      <p>${product.price.toLocaleString()}</p>

      <div className="buttons">
        <button
          className="sell-btn"
          onClick={onSell}
          disabled={!canSell}
        >
          Sell
        </button>

        <span className="count-box">{count}</span>

        <button
          className="buy-btn"
          onClick={onBuy}
          disabled={!canBuy}
        >
          Buy
        </button>
      </div>
    </div>
  );
}

export default ProductCard;
