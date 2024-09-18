class Products {
    public ProductId: number;
    public ProductName: string;
    public UnitPrice: number;
    public Qty: number;


    constructor(productId: number,ProductName: string, UnitPrice: number, Qty: number) {
        this.ProductId = productId;
        this.ProductName= ProductName;
        this.UnitPrice= UnitPrice;
        this.Qty= Qty;
 }

    public getTotal(): number {
        return this.UnitPrice * this.Qty;
    }

    
    public showDetails(): void {
        console.log(`Product ID: ${this.ProductId}`);
        console.log(`Product Name: ${this.ProductName}`);
        console.log(`Unit Price: ${this.UnitPrice}`);
        console.log(`Quantity: ${this.Qty}`);
        console.log(`Total Price: ${this.getTotal()}`);
    }
}
let Product1=new Products(101,'cool drink',2,100)
let Product2=new Products(102,'watch',10000,10)
Product1.showDetails();
Product2.showDetails();
