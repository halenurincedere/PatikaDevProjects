import React from "react";

const ClassCard = ({ title, description, image, schedule }) => {
  const cardStyle = {
    display: "flex",
    flexDirection: "column",
    alignItems: "center",
    backgroundColor: "white",
    borderRadius: "10px",
    boxShadow: "0 4px 8px rgba(0,0,0,0.1)",
    padding: "2rem",
    maxWidth: "600px",
    margin: "0 auto",
  };

  const imageStyle = {
    width: "100%",
    height: "auto",
    borderRadius: "10px",
    marginBottom: "1rem",
  };

  const titleStyle = {
    fontSize: "1.5rem",
    color: "#355592",
    marginBottom: "0.5rem",
  };

  const textStyle = {
    fontSize: "1rem",
    color: "#444",
    marginBottom: "0.5rem",
  };

  return (
    <div style={cardStyle}>
      <img src={image} alt={title} style={imageStyle} />
      <h3 style={titleStyle}>{title}</h3>
      <p style={textStyle}>{description}</p>
      <p style={textStyle}><strong>Program:</strong> {schedule}</p>
    </div>
  );
};

export default ClassCard;