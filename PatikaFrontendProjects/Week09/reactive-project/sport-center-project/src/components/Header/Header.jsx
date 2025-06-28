import React from "react";

const Header = () => {
  const headerStyle = {
    height: "100vh",
    width: "100%",
    backgroundImage: `url("/images/hero-man.jpg")`, // Görsel yolu senin public/images klasöründeki isme göre olmalı
    backgroundSize: "cover",
    backgroundPosition: "center",
    display: "flex",
    alignItems: "center",
    justifyContent: "center",
    position: "relative",
    paddingTop: "80px", // Navbar sabit olduğu için içerik aşağıdan başlasın
  };

  const overlayStyle = {
    backgroundColor: "rgba(0, 0, 0, 0.6)",
    color: "#fff",
    padding: "3rem",
    textAlign: "center",
    maxWidth: "700px",
    borderRadius: "10px",
  };

  const titleStyle = {
    fontSize: "2.5rem",
    fontWeight: "bold",
    marginBottom: "1rem",
  };

  const paragraphStyle = {
    fontSize: "1.1rem",
    marginBottom: "2rem",
  };

  const buttonGroupStyle = {
    display: "flex",
    justifyContent: "center",
    gap: "1rem",
  };

  const primaryButtonStyle = {
    backgroundColor: "#007bff",
    color: "#fff",
    padding: "0.6rem 1.5rem",
    border: "none",
    borderRadius: "5px",
    fontWeight: "bold",
    cursor: "pointer",
  };

  const secondaryButtonStyle = {
    backgroundColor: "#fff",
    color: "#333",
    padding: "0.6rem 1.5rem",
    border: "none",
    borderRadius: "5px",
    fontWeight: "bold",
    cursor: "pointer",
  };

  return (
    <header style={headerStyle}>
      <div style={overlayStyle}>
        <h1 style={titleStyle}>Hayalindeki Vücuda Ulaş</h1>
        <p style={paragraphStyle}>
          Profesyonel antrenörlerle, gelişmiş ekipmanlarla ve kişisel programlarla hedeflerine ulaş.
        </p>
        <div style={buttonGroupStyle}>
          <button style={primaryButtonStyle}>Başla</button>
          <button style={secondaryButtonStyle}>Daha Fazla</button>
        </div>
      </div>
    </header>
  );
};

export default Header;