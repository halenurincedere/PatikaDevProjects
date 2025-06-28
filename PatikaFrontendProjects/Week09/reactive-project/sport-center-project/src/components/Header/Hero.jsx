import React from "react";

const Hero = () => {
  const heroStyle = {
    backgroundImage: "url('/images/hero-man.jpg')", // Görseli public/images/hero.jpg yoluna koy
    backgroundSize: "cover",
    backgroundPosition: "center",
    height: "100vh",
    display: "flex",
    alignItems: "center",
    justifyContent: "center",
    position: "relative",
  };

  const overlayStyle = {
    backgroundColor: "rgba(0, 0, 0, 0.6)",
    color: "#fff",
    padding: "3rem",
    borderRadius: "10px",
    textAlign: "center",
    maxWidth: "700px",
  };

  const headingStyle = {
    fontSize: "3rem",
    marginBottom: "1rem",
    fontWeight: "bold",
  };

  const paragraphStyle = {
    fontSize: "1.2rem",
    marginBottom: "2rem",
  };

  const buttonContainer = {
    display: "flex",
    gap: "1rem",
    justifyContent: "center",
    flexWrap: "wrap",
  };

  const primaryBtn = {
    backgroundColor: "#007bff",
    color: "#fff",
    padding: "0.8rem 1.5rem",
    border: "none",
    borderRadius: "5px",
    fontWeight: "bold",
    cursor: "pointer",
  };

  const secondaryBtn = {
    backgroundColor: "#fff",
    color: "#333",
    padding: "0.8rem 1.5rem",
    border: "none",
    borderRadius: "5px",
    fontWeight: "bold",
    cursor: "pointer",
  };

  return (
    <section style={heroStyle}>
      <div style={overlayStyle}>
        <h1 style={headingStyle}>Hayalindeki Vücuda Ulaş</h1>
        <p style={paragraphStyle}>
          Profesyonel antrenörlerle, gelişmiş ekipmanlarla ve kişisel programlarla hedeflerine ulaş.
        </p>
        <div style={buttonContainer}>
          <button style={primaryBtn}>Başla</button>
          <button style={secondaryBtn}>Daha Fazla</button>
        </div>
      </div>
    </section>
  );
};

export default Hero;