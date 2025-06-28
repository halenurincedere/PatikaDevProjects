import React, { useState } from "react";
import BmiForm from "./BmiForm";
import BmiResult from "./BmiResult";

const BmiCalculator = () => {
  const [bmi, setBmi] = useState(null);
  const [category, setCategory] = useState("");

  const handleCalculate = (weight, height) => {
    const heightInMeters = height / 100;
    const result = (weight / (heightInMeters * heightInMeters)).toFixed(1);
    setBmi(result);

    if (result < 18.5) setCategory("Zayıf");
    else if (result < 25) setCategory("Normal");
    else if (result < 30) setCategory("Fazla Kilolu");
    else setCategory("Obez");
  };

  const sectionStyle = {
    padding: "4rem 0",
    backgroundColor: "white",
    textAlign: "center",
  };

  const titleStyle = {
    fontSize: "2rem",
    marginBottom: "1rem",
    color: "#355592",
  };

  const descStyle = {
    fontSize: "1rem",
    marginBottom: "2rem",
    color: "#444",
  };

  return (
    <section id="bmi" style={sectionStyle}>
      <h2 style={titleStyle}>BMI Calculator</h2>
      <p style={descStyle}>
        Kilonuzun boyunuza göre ideal olup olmadığını öğrenmek için VKİ'yi hesaplayın.
      </p>

      <BmiForm onCalculate={handleCalculate} />
      {bmi && <BmiResult bmi={bmi} category={category} />}
    </section>
  );
};

export default BmiCalculator;