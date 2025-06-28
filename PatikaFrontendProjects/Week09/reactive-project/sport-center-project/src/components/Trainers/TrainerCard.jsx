const TrainerCard = ({ name, specialty, image }) => {
  return (
    <div style={styles.card}>
      <img src={`/images/${image}`} alt={name} style={styles.image} />
      <h3>{name}</h3>
      <p>{specialty}</p>
    </div>
  );
};

const styles = {
  card: {
    width: "220px",
    background: "#fff",
    padding: "1.5rem",
    borderRadius: "10px",
    boxShadow: "0 4px 8px rgba(0,0,0,0.1)",
    textAlign: "center",
  },
  image: {
    width: "100%",
    borderRadius: "50%",
    marginBottom: "1rem",
  },
};

export default TrainerCard;