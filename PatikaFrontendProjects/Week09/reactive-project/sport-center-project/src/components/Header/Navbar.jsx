import React from "react";
import Logo from "./Logo";

const Navbar = () => {
  const navbarStyle = {
    backgroundColor: "#355592",
    color: "#fff",
    padding: "1rem 2rem",
    display: "flex",
    justifyContent: "space-between",
    alignItems: "center",
    flexWrap: "wrap",
    position: "fixed",
    top: 0,
    left: 0,
    width: "100%",
    zIndex: 1000,
  };

  const navListStyle = {
    listStyle: "none",
    display: "flex",
    gap: "1rem",
    margin: 0,
    padding: 0,
    flexWrap: "wrap",
  };

  const linkStyle = {
    color: "#fff",
    textDecoration: "none",
    fontWeight: "500",
    fontSize: "1rem",
  };

  return (
    <nav style={navbarStyle}>
      <Logo />
      <ul style={navListStyle}>
        <li><a href="#statistics" style={linkStyle}>İstatistikler</a></li>
        <li><a href="#classes" style={linkStyle}>Sınıflar</a></li>
        <li><a href="#trainers" style={linkStyle}>Eğitmenler</a></li>
        <li><a href="#contact" style={linkStyle}>İletişim</a></li>
      </ul>
    </nav>
  );
};

export default Navbar;