
using ConsoleApp1;


List<Product> products = new List<Product>()
{
    new Product(1, "iPhone 9", "An apple mobile which is nothing like apple", 549, 4.69, 94, "Apple", ProductCategory.Smartphones),
    new Product(2, "iPhone X", "SIM-Free, Model A19211 6.5-inch Super Retina HD display with OLED technology A12 Bionic chip with ...", 899, 4.44, 34, "Apple", ProductCategory.Smartphones),
    new Product(3, "Samsung Universe 9", "Samsung's new variant which goes beyond Galaxy to the Universe", 1249, 4.09, 36, "Samsung", ProductCategory.Smartphones),
    new Product(4, "OPPOF19", "OPPO F19 is officially announced on April 2021.", 280, 4.3, 123, "OPPO", ProductCategory.Smartphones),
    new Product(5, "Huawei P30", "Huawei’s re-badged P30 Pro New Edition was officially unveiled yesterday in Germany and now the device has made its way to the UK.", 499, 4.09, 32, "Huawei", ProductCategory.Smartphones),
    new Product(6, "MacBook Pro", "MacBook Pro 2021 with mini-LED display may launch between September, November", 1749, 4.57, 83, "Apple", ProductCategory.Laptops),
    new Product(7, "Samsung Galaxy Book", "Samsung Galaxy Book S (2020) Laptop With Intel Lakefield Chip, 8GB of RAM Launched", 1499, 4.25, 50, "Samsung", ProductCategory.Laptops),
    new Product(8, "Microsoft Surface Laptop 4", "Style and speed. Stand out on HD video calls backed by Studio Mics. Capture ideas on the vibrant touchscreen.", 1499, 4.43, 68, "Microsoft Surface", ProductCategory.Laptops),
    new Product(9, "Infinix INBOOK", "Infinix Inbook X1 Ci3 10th 8GB 256GB 14 Win10 Grey – 1 Year Warranty", 1099, 4.54, 96, "Infinix", ProductCategory.Laptops),
    new Product(10, "HP Pavilion 15-DK1056WM", "HP Pavilion 15-DK1056WM Gaming Laptop 10th Gen Core i5, 8GB, 256GB SSD, GTX 1650 4GB, Windows 10", 1099, 4.43, 89, "HP Pavilion", ProductCategory.Laptops),
    new Product(11, "perfume Oil", "Mega Discount, Impression of Acqua Di Gio by GiorgioArmani concentrated attar perfume Oil", 13, 4.26, 65, "Impression of Acqua Di Gio", ProductCategory.Fragrances),
    new Product(12, "Brown Perfume", "Royal_Mirage Sport Brown Perfume for Men & Women - 120ml", 40, 4, 52, "Royal_Mirage", ProductCategory.Fragrances),
    new Product(13, "Fog Scent Xpressio Perfume", "Product details of Best Fog Scent Xpressio Perfume 100ml For Men cool long lasting perfumes for Men", 13, 4.59, 61, "Fog Scent Xpressio", ProductCategory.Fragrances),
    new Product(14, "Non-Alcoholic Concentrated Perfume Oil", "Original Al Munakh® by Mahal Al Musk | Our Impression of Climate | 6ml Non-Alcoholic Concentrated Perfume Oil", 120, 4.21, 114, "Al Munakh", ProductCategory.Fragrances),
    new Product(15, "Eau De Perfume Spray", "Genuine  Al-Rehab spray perfume from UAE/Saudi Arabia/Yemen High Quality", 30, 4.7, 105, "Lord - Al-Rehab", ProductCategory.Fragrances),
    new Product(16, "Hyaluronic Acid Serum", "L'OrÃ©al Paris introduces Hyaluron Expert Replumping Serum formulated with 1.5% Hyaluronic Acid", 19, 4.83, 110, "L'Oreal Paris", ProductCategory.Skincare),
    new Product(17, "Tree Oil 30ml", "Tea tree oil contains a number of compounds, including terpinen-4-ol, that have been shown to kill certain bacteria,", 12, 4.52, 78, "Hemani Tea", ProductCategory.Skincare),
    new Product(18, "Oil Free Moisturizer 100ml", "Dermive Oil Free Moisturizer with SPF 20 is specifically formulated with ceramides, hyaluronic acid & sunscreen.", 40, 4.56, 88, "Dermive", ProductCategory.Skincare),
    new Product(19, "Skin Beauty Serum.", "Product name: rorec collagen hyaluronic acid white face serum riceNet weight: 15 m", 46, 4.42, 54, "ROREC White Rice", ProductCategory.Skincare),
    new Product(20, "Freckle Treatment Cream- 15gm", "Fair & Clear is Pakistan's only pure Freckle cream which helpsfade Freckles, Darkspots and pigments. Mercury level is 0%, so there are no side effects.", 70, 4.06, 140, "Fair & Clear", ProductCategory.Skincare),
    new Product(21, "- Daal Masoor 500 grams", "Fine quality Branded Product Keep in a cool and dry place", 20, 4.44, 133, "Saaf & Khaas", ProductCategory.Groceries),
    new Product(22, "Elbow Macaroni - 400 gm", "Product details of Bake Parlor Big Elbow Macaroni - 400 gm", 14, 4.57, 146, "Bake Parlor Big", ProductCategory.Groceries),
    new Product(23, "Orange Essence Food Flavou", "Specifications of Orange Essence Food Flavour For Cakes and Baking Food Item", 14, 4.85, 26, "Baking Food Items", ProductCategory.Groceries)
};


//1.Get all products that belong to the "Smartphones" category.
Console.WriteLine("1--------------------------------");

List<Product> smartphones = products
           .Where(p => p.Category == ProductCategory.Smartphones)
           .ToList();
foreach (Product product in smartphones)
{
    Console.WriteLine($"{product.Title} -{product.Brand}");
}


//2.Select the names(titles) of all products.
Console.WriteLine("2-------------------------------");

List<string> titles = products.Select(t => t.Title).ToList();

foreach (string title in titles)
{
    Console.WriteLine(title);
}


//3.Get all products with a price greater than 1000.
Console.WriteLine("3--------------------------");

List<Product> greaterThen = products.Where(g => g.Price > 1000).ToList();

foreach (Product product in greaterThen)
{
    Console.WriteLine($"{product.Title} - {product.Price}");
    
}

//4.Select the brands of all skincare products.
Console.WriteLine("4-------------------------------");

List<string> brands = products.Where(p=>p.Category== ProductCategory.Skincare).Select(p =>p.Brand).ToList();

foreach (string product in brands)
{
    Console.WriteLine(product);
}

//5.Get the first product that has a rating above 4.8.
Console.WriteLine("5-------------------------------");

Product rating = products.First(p => p.Rating > 4.8);
Console.WriteLine($"{rating.Title} - Rating: {rating.Rating} ");

//6.Get all products that are out of stock (stock equal to 0).
Console.WriteLine("6-------------------------------");

List<Product> stock = products.Where(s => s.Stock == 0).ToList();

foreach (Product product in stock)
{
    Console.WriteLine($"{product.Title} - Out of Stock");
}
//All the items are in  stock

//7.Select the prices of all fragrance products.

Console.WriteLine("7-------------------------------");

List<Product> fragrence = products.Where(f => f.Category == ProductCategory.Fragrances).ToList();
foreach (Product item in fragrence)
{
    Console.WriteLine($"{item.Title} - {item.Price}$");
   
}

//8.Retrieve the description of the first product with a rating equal to 4.43.
Console.WriteLine("8-------------------------------");

List<Product> ratingEqual = products.Where(r => r.Rating == 4.43).ToList();

foreach (Product item in ratingEqual)
{
    Console.WriteLine($"{item.Title} - {item.Rating}");
}

//9.Get the title of the last Skincare product with a price under $50.
Console.WriteLine("9-------------------------------");

List<Product> skincareUnder = products.Where(p => p.Category == ProductCategory.Skincare && p.Price < 50).ToList();
Product lastSkincare = skincareUnder.LastOrDefault();
Console.WriteLine(lastSkincare.Title);

//10.Get the title of the first product in the Fragrances category with a price above $100.
Console.WriteLine("10-------------------------------");
//Go iskoristiv kodot od 7mata zadaca sakav da probam se nadevam deka e okej. :)
Product fragrencesAbove = fragrence.FirstOrDefault(f => f.Price > 100);
Console.WriteLine($"{fragrencesAbove.Title} - {fragrencesAbove.Price}");

//11.Select the brand of the last product that has a stock lower than 40.
Console.WriteLine("11-------------------------------");

List<Product> stockLower = products.Where(s => s.Stock < 40).ToList();
Product lastStock = stockLower.LastOrDefault();
Console.WriteLine($"{lastStock.Brand} - {lastStock.Stock}");

//12.Select the title of the first Laptop that has a stock greater than 80.
Console.WriteLine("12-------------------------------");

List<Product> laptopStock = products.Where(l => l.Stock > 80).ToList();
Product firstLaptop = laptopStock.FirstOrDefault();
Console.WriteLine($"{firstLaptop.Title} - {firstLaptop.Stock}");

//13.Retrieve the title of the first product that has a price above $1200.
Console.WriteLine("13-------------------------------");

List<Product> firstProduct = products.Where(f => f.Price > 1200).ToList();
Product firstProductAbove = firstProduct.FirstOrDefault();
Console.WriteLine($"{firstProductAbove.Title} - {firstProductAbove.Price}$");


//14.Select the stock count of the last product that belongs to the Smartphones category.
Console.WriteLine("14-------------------------------");

List<Product> smartphoneStock = products.Where(s => s.Category == ProductCategory.Smartphones).ToList();
Product lastSmartphoneStock = smartphoneStock.LastOrDefault();
Console.WriteLine($"{lastSmartphoneStock.Title} - {lastSmartphoneStock.Stock}");

//15.Create new class ProductDetails with 3 properties: Id, Title and Price and map the
//existing product data to a collection of ProductDetails objects.
Console.WriteLine("15-------------------------------");

List<ProductDetails> productDetailsList = products.Select(p => new ProductDetails(p.Id, p.Title, p.Price)).ToList();

foreach (ProductDetails pd in productDetailsList )
{
    Console.WriteLine($"{pd.Id} - {pd.Title} - {pd.Price}");
}