SELECT Products.Name AS Product, Categories.Name AS Category FROM Products
LEFT JOIN ProductsCategories ON Products.ID = ProductsCategories.product
LEFT JOIN Categories ON ProductsCategories.category = Categories.ID