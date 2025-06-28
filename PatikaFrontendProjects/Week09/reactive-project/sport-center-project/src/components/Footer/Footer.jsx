import React from "react";
import Links from "./Links";

const Footer = () => {
  const footerStyle = {
    backgroundColor: "#355592",
    color: "#fff",
    padding: "3rem 1rem",
    textAlign: "center",
  };

  const containerStyle = {
    display: "flex",
    flexWrap: "wrap",
    justifyContent: "space-around",
    maxWidth: "1200px",
    margin: "0 auto",
    gap: "2rem",
  };

  const columnStyle = {
    flex: "1",
    minWidth: "200px",
    textAlign: "left",
  };

  const titleStyle = {
    fontSize: "1.2rem",
    marginBottom: "1rem",
    fontWeight: "bold",
  };

  const bottomTextStyle = {
    marginTop: "2rem",
    fontSize: "0.9rem",
    color: "#ccc",
  };

  return (
    <footer style={footerStyle}>
      <div style={containerStyle}>
        <div style={columnStyle}>
          <h4 style={titleStyle}>Hakkımızda</h4>
          <p>
            POWERFULL, spor ve sağlıklı yaşam alanında lider bir merkezdir.
            Misyonumuz, herkes için daha aktif ve mutlu bir yaşam sunmaktır.
          </p>
        </div>

        {/* Bağlantılar: Links.jsx bileşeni */}
        <Links />

        <div style={columnStyle}>
          <h4 style={titleStyle}>İletişim</h4>
          <p>📍 Ankara, Türkiye</p>
          <p>📞 +90 312 000 00 00</p>
          <p>📧 info@powerfull.com</p>
        </div>
      </div>

      <div style={bottomTextStyle}>
        © {new Date().getFullYear()} POWERFULL. Tüm hakları saklıdır.
      </div>
    </footer>
  );
};

export default Footer;