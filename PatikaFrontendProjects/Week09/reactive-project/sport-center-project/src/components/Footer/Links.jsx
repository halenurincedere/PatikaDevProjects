import React from "react";

const Links = () => {
  const sectionStyle = {
    flex: "1",
    minWidth: "200px",
    textAlign: "left",
  };

  const titleStyle = {
    fontSize: "1.2rem",
    marginBottom: "1rem",
    fontWeight: "bold",
    color: "#fff",
  };

  const listStyle = {
    listStyle: "none",
    padding: 0,
    margin: 0,
  };

  const linkStyle = {
    color: "#fff",
    textDecoration: "none",
    display: "block",
    marginBottom: "0.5rem",
    fontSize: "1rem",
  };

  return (
    <div style={sectionStyle}>
      <h4 style={titleStyle}>Bağlantılar</h4>
      <ul style={listStyle}>
        <li><a href="#statistics" style={linkStyle}>İstatistikler</a></li>
        <li><a href="#classes" style={linkStyle}>Sınıflar</a></li>
        <li><a href="#trainers" style={linkStyle}>Eğitmenler</a></li>
        <li><a href="#contact" style={linkStyle}>İletişim</a></li>
      </ul>
    </div>
  );
};

export default Links;