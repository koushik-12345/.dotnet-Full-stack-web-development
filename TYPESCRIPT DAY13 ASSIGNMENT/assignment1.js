var Products = /** @class */ (function () {
    function Products(productId, ProductName, UnitPrice, Qty) {
        this.ProductId = productId;
        this.ProductName = ProductName;
        this.UnitPrice = UnitPrice;
        this.Qty = Qty;
    }
    Products.prototype.getTotal = function () {
        return this.UnitPrice * this.Qty;
    };
    Products.prototype.showDetails = function () {
        console.log("Product ID: ".concat(this.ProductId));
        console.log("Product Name: ".concat(this.ProductName));
        console.log("Unit Price: ".concat(this.UnitPrice));
        console.log("Quantity: ".concat(this.Qty));
        console.log("Total Price: ".concat(this.getTotal()));
    };
    return Products;
}());
var Product1 = new Products(101, 'cool drink', 2, 100);
var Product2 = new Products(102, 'watch', 10000, 10);
Product1.showDetails();
Product2.showDetails();
