import React, { useState } from "react";

const BmiForm = ({ onCalculate }) => {
  const [weight, setWeight] = useState("");
  const [height, setHeight] = useState("");

  const handleSubmit = (e) => {
    e.preventDefault();
    if (!weight || !height) return;
    onCalculate(weight, height);
  };

  const formStyle = {
    display: "flex",
    flexDirection: "column",
    gap: "1rem",
    marginTop: "2rem",
    maxWidth: "400px",
    marginInline: "auto",
  };

  const inputStyle = {
    padding: "0.8rem",
    borderRadius: "5px",
    border: "1px solid #ccc",
    fontSize: "1rem",
  };

  const buttonStyle = {
    backgroundColor: "#355592",
    color: "#fff",
    padding: "0.8rem",
    border: "none",
    borderRadius: "5px",
    cursor: "pointer",
    fontWeight: "bold",
  };

  return (
    <form onSubmit={handleSubmit} style={formStyle}>
      <input
        type="number"
        placeholder="Boy (cm)"
        value={height}
        onChange={(e) => setHeight(e.target.value)}
        style={inputStyle}
      />
      <input
        type="number"
        placeholder="Kilo (kg)"
        value={weight}
        onChange={(e) => setWeight(e.target.value)}
        style={inputStyle}
      />
      <button type="submit" style={buttonStyle}>
        Hesapla
      </button>
    </form>
  );
};

export default BmiForm;