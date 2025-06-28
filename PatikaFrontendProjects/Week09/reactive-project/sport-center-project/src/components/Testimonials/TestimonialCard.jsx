const TestimonialCard = ({ name, message, image }) => {
  return (
    <div style={styles.card}>
      <img src={`/images/${image}`} alt={name} style={styles.image} />
      <p style={styles.message}>"{message}"</p>
      <h4>{name}</h4>
    </div>
  );
};

const styles = {
  card: {
    width: "280px",
    backgroundColor: "#fff",
    borderRadius: "10px",
    padding: "1.5rem",
    textAlign: "center",
    boxShadow: "0 4px 10px rgba(0,0,0,0.1)",
    margin: "1rem",
  },
  image: {
    width: "80px",
    height: "80px",
    borderRadius: "50%",
    objectFit: "cover",
    marginBottom: "1rem",
  },
  message: {
    fontStyle: "italic",
    marginBottom: "0.5rem",
  },
};

export default TestimonialCard;