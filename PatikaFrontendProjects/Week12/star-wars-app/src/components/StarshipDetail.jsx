function StarshipDetail({ starship, onBack }) {
    return (
      <div className="detail">
        <button className="back-btn" onClick={onBack}>⬅</button>
        <h2>{starship.name}</h2>
        <img src="/millennium-falcon.png" alt="ship" />
        <ul>
          <li><strong>Model:</strong> {starship.model}</li>
          <li><strong>Hyperdrive Rating:</strong> {starship.hyperdrive_rating}</li>
          <li><strong>Passengers:</strong> {starship.passengers}</li>
          <li><strong>Max Speed:</strong> {starship.max_atmosphering_speed}</li>
          <li><strong>Manufacturer:</strong> {starship.manufacturer}</li>
          <li><strong>Crew:</strong> {starship.crew}</li>
          <li><strong>Cargo:</strong> {starship.cargo_capacity}</li>
        </ul>
      </div>
    );
  }
  
  export default StarshipDetail;