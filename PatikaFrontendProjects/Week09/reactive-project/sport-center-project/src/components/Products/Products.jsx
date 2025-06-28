import ProductCard from "./ProductCard";
import Title from "../Statistics/Title";

const Products = () => {
  const productList = [
    {
      name: "Protein Tozu",
      price: 299,
      image: "purchase1.jpg",
    },
    {
      name: "Yoga Matı",
      price: 149,
      image: "purchase2.jpg",
    },
    {
      name: "Su Matarası",
      price: 89,
      image: "purchase3.jpg",
    },
    {
      name: "Spor Ayakkabı",
      price: 599,
      image: "purchase4.jpg",
    },
  ];

  return (
    <section style={styles.section}>
      <Title text="Fitness Market" />
      <div style={styles.grid}>
        {productList.map((product, i) => (
          <ProductCard
            key={i}
            name={product.name}
            price={product.price}
            image={product.image}
          />
        ))}
      </div>
    </section>
  );
};

const styles = {
  section: {
    padding: "2rem",
    backgroundColor: "#f0f0f0",
  },
  grid: {
    display: "flex",
    flexWrap: "wrap",
    gap: "2rem",
    justifyContent: "center",
    marginTop: "1rem",
  },
};

export default Products;