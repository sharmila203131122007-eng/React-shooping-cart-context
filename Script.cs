import { useShop } from "../context/ShopContext";
import ProductCard from "./ProductCard";

function ProductList() {
  const { products } = useShop();

  return (
    <section>
      <h2>Our Products</h2>

      <div className="products">
        {products.map((product) => (
          <ProductCard
            key={product.id}
            product={product}
          />
        ))}
      </div>
    </section>
  );
}

export default ProductList;
