var customer = /** @class */ (function () {
    function customer(cid, cname, ccity) {
        if (cname === void 0) { cname = ""; }
        if (ccity === void 0) { ccity = ""; }
        this.cid = 0;
        this.cname = "";
        this.ccity = "";
        this.cid = cid;
        this.cname = cname;
        this.ccity = ccity;
    }
    customer.prototype.showDetails = function () {
        console.log("customer Id : " + this.cid, "customer Name : " + this.cname, "customer city : " + this.ccity);
    };
    return customer;
}());
var s1 = new customer(100, "john", "hyderabad");
var s2 = new customer(200, " ", "pune");
var s3 = new customer(300, "Scott");
var s4 = new customer(400, "vinay", "banglore");
s1.showDetails();
s2.showDetails();
s3.showDetails();
s4.showDetails();
