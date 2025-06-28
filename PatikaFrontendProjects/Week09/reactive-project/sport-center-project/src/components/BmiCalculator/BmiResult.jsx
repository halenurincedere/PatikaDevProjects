import React from "react";

const BmiResult = ({ bmi, category }) => {
  const resultStyle = {
    marginTop: "2rem",
    backgroundColor: "#f0f0f0",
    padding: "1.5rem",
    borderRadius: "10px",
    textAlign: "center",
    maxWidth: "400px",
    margin: "2rem auto 0",
  };

  return (
    <div style={resultStyle}>
      <h3>VKI: {bmi}</h3>
      <p>Kategori: {category}</p>
    </div>
  );
};

export default BmiResult;