import React from "react";
import "./Receipt.css";

function Receipt({ basket, products }) {
  const basketEntries = Object.entries(basket).filter(([_, quantity]) => quantity > 0);

  const total = basketEntries.reduce((sum, [id, quantity]) => {
    const product = products.find((p) => p.id === parseInt(id));
    return sum + product.price * quantity;
  }, 0);

  const formatMoney = (amount) => {
    return `$${amount.toLocaleString()}`;
  };

  return (
    <div className="receipt">
      <h2>Your Receipt</h2>
      <div className="receipt-list">
        {basketEntries.map(([id, quantity]) => {
          const product = products.find((p) => p.id === parseInt(id));
          return (
            <div className="receipt-item" key={id}>
              <span className="item-name">{product.name}</span>
              <span className="item-qty">x{quantity}</span>
              <span className="item-price">{formatMoney(product.price * quantity)}</span>
            </div>
          );
        })}
      </div>

      <hr />

      <div className="receipt-total">
        <span className="total-label">TOTAL</span>
        <span className="total-amount">{formatMoney(total)}</span>
      </div>
    </div>
  );
}

export default Receipt;
