// src/components/Statistics/StatCard.jsx
const StatCard = ({ number, label }) => {
    return (
      <div style={styles.card}>
        <h2>{number}</h2>
        <p>{label}</p>
      </div>
    );
  };
  
  const styles = {
    card: {
      background: "#f5f5f5",
      padding: "1rem",
      borderRadius: "8px",
      textAlign: "center",
      boxShadow: "0 2px 8px rgba(0,0,0,0.1)",
      flex: "1",
      margin: "0.5rem",
    },
  };
  
  export default StatCard;