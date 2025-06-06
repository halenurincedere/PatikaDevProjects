const menu = [
    {
      id: 1,
      title: "Tteokbokki",
      category: "Korea",
      price: 10.99,
      img: "https://d17wu0fn6x6rgz.cloudfront.net/img/w/tarif/mgt/2_2_11zon-221.webp",
      desc: "Spicy rice cakes, serving with fish cake."
    },
    {
      id: 2,
      title: "Chicken Ramen",
      category: "Japan",
      price: 7.99,
      img: "https://img.hellofresh.com/f_auto,fl_lossy,h_640,q_auto,w_1200/hellofresh_s3/image/62164054b9b4ec558362b243-0b7c599a.jpg",
      desc: "Chicken noodle soup, serving with vegetables such as soy bean, green onion."
    },
    {
      id: 3,
      title: "Bibimbap",
      category: "Korea",
      price: 8.99,
      img: "https://dwellbymichelle.com/wp-content/uploads/2020/05/DWELL-bibimbap.jpg",
      desc: "Boiling vegetables, serving with special hot sauce."
    },
    {
      id: 4,
      title: "Dan Dan Mian",
      category: "China",
      price: 5.99,
      img: "https://i0.wp.com/seonkyounglongest.com/wp-content/uploads/2019/10/Dan-Dan-Noodles-11.jpg?fit=2000%2C1333&ssl=1",
      desc: "Dan dan noodle, serving with green onion."
    },
    {
      id: 5,
      title: "Yangzhou Fried Rice",
      category: "China",
      price: 12.99,
      img: "https://salu-salo.com/wp-content/uploads/2013/02/Yangzhou-Fried-Rice1.jpg",
      desc: "Yangzhou style fried rice, serving with bean and pickles."
    },
    {
      id: 6,
      title: "Onigiri",
      category: "Japan",
      price: 9.99,
      img: "https://ichef.bbci.co.uk/food/ic/food_16x9_1600/recipes/onigiri_39079_16x9.jpg",
      desc: "Rice sandwich, serving with soy sauce."
    },
    {
        id: 7,
        title: "Pho",
        category: "Vietnam",
        price: 11.99,
        img: "https://harbiyiyorum.com/wp-content/uploads/pho-nedir-ft.jpg",
        desc: "Vietnamese noodle soup with beef, herbs, and rice noodles."
      },
      {
        id: 8,
        title: "Pad Thai",
        category: "Thailand",
        price: 10.49,
        img: "https://images.ctfassets.net/uexfe9h31g3m/3HRQmwGA3Ke4y8ukoy4aEk/e7da70846538442c4cb3fd8fcd9dcc96/PadThai_1024x768.jpg?w=2000&h=2000&fm=webp&fit=thumb&q=100",
        desc: "Stir-fried rice noodles with shrimp, tofu, and tamarind sauce."
      },
      {
        id: 9,
        title: "Sushi",
        category: "Japan",
        price: 14.99,
        img: "https://upload.wikimedia.org/wikipedia/commons/6/60/Sushi_platter.jpg",
        desc: "Vinegared rice with seafood and vegetables."
      },
      {
        id: 10,
        title: "Kimchi Jjigae",
        category: "Korea",
        price: 9.49,
        img: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQZp2k-skHrKi2nY9bgjWixXJh6Gc1kdwox3Q&s",
        desc: "Spicy Korean stew made with kimchi, tofu, and pork."
      },
      {
        id: 11,
        title: "Mapo Tofu",
        category: "China",
        price: 8.99,
        img: "https://www.seriouseats.com/thmb/CaR7btHrJgEO3OKZD1Z_795VmII=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/__opt__aboutcom__coeus__resources__content_migration__serious_eats__seriouseats.com__2011__07__2021-02-12-Mapo-Tofu-MHOM-10-804db1211f1d47dbae505341d1e7b994.jpg",
        desc: "Spicy Sichuan dish with tofu, minced meat, and chili bean paste."
      },
      {
        id: 12,
        title: "Miso Soup",
        category: "Japan",
        price: 4.99,
        img: "https://int.japanesetaste.com/cdn/shop/articles/mixed-miso-soup-recipe-japanese-taste.jpg?v=1737982159&width=5760",
        desc: "Traditional Japanese soup with miso paste, seaweed, and tofu."
      }
  ];
  
  const sectionCenter = document.querySelector(".section-center");
  const btnContainer = document.querySelector(".btn-container");
  
  window.addEventListener("DOMContentLoaded", () => {
    displayMenuItems(menu);
    displayMenuButtons();
  });
  
  function displayMenuItems(menuItems) {
    let displayMenu = menuItems.map(item => {
      return `
        <div class="col-md-6">
          <div class="menu-item d-flex">
            <img src="${item.img}" class="menu-img" alt="${item.title}">
            <div class="menu-info">
              <div class="menu-title-price">
                <h5>${item.title}</h5>
                <h5>${item.price}</h5>
              </div>
              <p class="menu-desc">${item.desc}</p>
            </div>
          </div>
        </div>`;
    });
    sectionCenter.innerHTML = displayMenu.join("");
  }
  
  function displayMenuButtons() {
    const categories = ["All", ...new Set(menu.map(item => item.category))];
    const buttons = categories.map(category => {
      return `<button class="btn btn-outline-dark filter-btn" data-id="${category}">${category}</button>`;
    }).join("");
    btnContainer.innerHTML = buttons;
  
    const filterBtns = document.querySelectorAll(".filter-btn");
  
    filterBtns.forEach(btn => {
      btn.addEventListener("click", e => {
        const category = e.currentTarget.dataset.id;
        const filteredMenu = category === "All" ? menu : menu.filter(item => item.category === category);
        displayMenuItems(filteredMenu);
      });
    });
  }