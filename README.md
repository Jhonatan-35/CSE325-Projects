# CSE325-Projects

#Evidence of  Contoso Pizza CRUD Operation

### All CRUD Operations
[All Excersice CRUD](image.png)

### Display all Pizzas
[GET](image-1.png) 

### Adding new Pizza
[POST](image-2.png) 

### Get Pizza By id
[GET](image-3.png) 

### Update  name of Pizza adding Pizza
[PUT](image-4.png)  

### Delete specific Pizza by id
[Delete](image-5.png) 


## Additional Pizza 
new Pizza { Id = 4, Name = "Hawaii", IsGlutenFree = false }


### Summary sales

static void CreateSalesSummary()
{
    string report = """
Sales Summary
----------------------------
Total Sales: $13,801.50

Details:
sales-jan.txt: $4,500.75
sales-feb.txt: $6,200.50
sales-mar.txt: $3,100.25
""";

    File.WriteAllText("SalesSummary.txt", report);

    Console.WriteLine("Sales summary created.");
}