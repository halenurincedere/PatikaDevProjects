import React from "react";

const ContactForm = () => {
  const formStyle = {
    flex: "1",
    display: "flex",
    flexDirection: "column",
    gap: "1rem",
    minWidth: "300px",
  };

  const inputStyle = {
    padding: "0.8rem",
    borderRadius: "5px",
    border: "1px solid #ccc",
    fontSize: "1rem",
  };

  const buttonStyle = {
    padding: "0.8rem",
    backgroundColor: "#355592",
    color: "#fff",
    border: "none",
    borderRadius: "5px",
    fontWeight: "bold",
    cursor: "pointer",
  };

  return (
    <form style={formStyle}>
      <input type="text" placeholder="Adınız" style={inputStyle} />
      <input type="email" placeholder="E-posta" style={inputStyle} />
      <textarea placeholder="Mesajınız" rows="5" style={inputStyle}></textarea>
      <button type="submit" style={buttonStyle}>Gönder</button>
    </form>
  );
};

export default ContactForm;