public class Delivery
{
    public int IdOrder { get; set; }
    public string CustomerName { get; set; }
    public DateTime OrderDate { get; set; }
    public string DeliveryStatus { get; set; }
    // public string DeliveryStatusIndo
    // {
    //     get
    //     {
    //         return DeliveryStatus switch
    //         {
    //             "Pending" => "Belum Diproses",
    //             "Confirmed" => "Dikonfirmasi",
    //             "Shipped" => "Dikirim",
    //             "Delivered" => "Selesai",
    //             _ => DeliveryStatus
    //         };
    //     }
    // }

    public string TruckNoPolisi { get; set; }
    public string DriverName { get; set; }
}
