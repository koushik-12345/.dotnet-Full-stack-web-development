class customer
{
    public cid:number = 0;
    public cname:string  = "";
    public ccity:string  = "";
 
    constructor(cid:number, cname:string = "", ccity:string = "")
    {
        this.cid = cid;
        this.cname = cname;
        this.ccity = ccity;
    }
  

    public showDetails():void
    {
        console.log("customer Id : " + this.cid,"customer Name : " + this.cname,"customer city : " + this.ccity);


    }
}

 
let s1:customer= new customer(100,"john", "hyderabad");
let s2:customer = new customer(200,  " " ,"pune");
let s3:customer = new customer(300, "Scott");
let s4:customer = new customer(400, "vinay", "banglore");

s1.showDetails();
s2.showDetails();
s3.showDetails();
s4.showDetails();