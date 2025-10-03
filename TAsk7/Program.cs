void PSt(OrderStatus status)
{
    switch (status)
    {
        case OrderStatus.Pending:
            Console.WriteLine(" pending");
            break;
        case OrderStatus.Processing:
            Console.WriteLine("processing");
            break;
        case OrderStatus.Shipped:
            Console.WriteLine("Status has been shipped");
            break;
        case OrderStatus.Delivered:
            Console.WriteLine("Status delivered");
            break;
    }
}
PSt(OrderStatus.Pending);
PSt(OrderStatus.Shipped);

enum OrderStatus {
    Pending ,
    Processing ,
    Shipped ,
    Delivered 
}