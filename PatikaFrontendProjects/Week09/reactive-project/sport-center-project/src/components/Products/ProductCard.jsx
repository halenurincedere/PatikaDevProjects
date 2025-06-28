const ProductCard = ({ name, price, image }) => {
  return (
    <div style={styles.card}>
      <img src={`/images/${image}`} alt={name} style={styles.image} />
      <h3>{name}</h3>
      <p>{price} ₺</p>
      <button style={styles.button}>Satın Al</button>
    </div>
  );
};

const styles = {
  card: {
    width: "200px",
    backgroundColor: "#fff",
    borderRadius: "10px",
    padding: "1rem",
    textAlign: "center",
    boxShadow: "0 4px 12px rgba(0, 0, 0, 0.1)",
    transition: "transform 0.2s",
  },
  image: {
    width: "100%",
    borderRadius: "10px",
    marginBottom: "0.5rem",
  },
  button: {
    marginTop: "0.5rem",
    padding: "0.5rem 1rem",
    backgroundColor: "#28a745",
    color: "#fff",
    border: "none",
    borderRadius: "4px",
    cursor: "pointer",
  },
};

export default ProductCard;