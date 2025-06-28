const Map = () => {
  return (
    <div style={styles.map}>
      <iframe
        title="Harita"
        src="https://www.google.com/maps/embed?pb=!1m18..."
        width="100%"
        height="300"
        style={{ border: 0 }}
        allowFullScreen=""
        loading="lazy"
      ></iframe>
    </div>
  );
};

const styles = {
  map: {
    width: "100%",
    maxWidth: "500px",
    marginTop: "1rem",
  },
};

export default Map;