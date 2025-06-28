import React from "react";
import ContactForm from "./ContactForm";
import Map from "./Map";

const Contact = () => {
  const sectionStyle = {
    padding: "4rem 1rem",
    backgroundColor: "#f5f9fc",
  };

  const containerStyle = {
    display: "flex",
    flexWrap: "wrap",
    justifyContent: "space-between",
    gap: "2rem",
    maxWidth: "1200px",
    margin: "0 auto",
  };

  const titleStyle = {
    textAlign: "center",
    fontSize: "2rem",
    color: "#355592",
    marginBottom: "2rem",
  };

  return (
    <section id="contact" style={sectionStyle}>
      <h2 style={titleStyle}>Bize Ulaşın</h2>
      <div style={containerStyle}>
        <ContactForm />
        <Map />
      </div>
    </section>
  );
};

export default Contact;