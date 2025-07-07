function StarshipCard({ starship, onClick }) {
    return (
      <div className="card" onClick={onClick}>
        <img src="/millennium-falcon.png" alt="ship" />
        <h2>{starship.name}</h2>
        <p><strong>Model:</strong> {starship.model}</p>
        <p><strong>Hyperdrive Rating:</strong> {starship.hyperdrive_rating}</p>
      </div>
    );
  }
  
  export default StarshipCard;