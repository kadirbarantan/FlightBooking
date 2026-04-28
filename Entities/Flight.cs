using MongoDB.Bson.Serialization.Attributes;

namespace FlightBooking.Entities
{
    public class Flight
    {
        [BsonId] //mongodb'de id alanı olarak kullanılır, otomatik olarak ObjectId türünde oluşturulur
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)] //string olarak temsil edilir, ancak MongoDB'de ObjectId olarak saklanır.Object türlü (mongoda obj türlü) id'i string olarak temsil eder, ancak MongoDB'de ObjectId olarak saklanır. Bu sayede C# kodunda string olarak kullanabiliriz, ancak MongoDB'de ObjectId olarak saklanır.
        public string FlightId { get; set; } // ObjectId
        public string FlightNumber { get; set; } // TK123, PC2023
        public string AirlineCode { get; set; } // TK, PC, LH
        public string DepartureAirportCode { get; set; } // IST
        public string DepartureAirportName { get; set; } // İstanbul Havalimanı
        public string ArrivalAirportCode { get; set; } // LHR
        public string ArrivalAirportName { get; set; } // London Heathrow
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int DurationMinutes { get; set; }
        public int TotalSeats { get; set; }
        public int AvailableSeats { get; set; }
        public decimal BasePrice { get; set; }
        public string Currency { get; set; } // TRY, EUR, USD
        public string Status { get; set; } // Scheduled, Delayed, Cancelled, Completed
    }
}
