using System.Text.Json.Serialization;

public class TicketModel
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("ticketNumber")]
    public string TicketNumber { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("priority")]
    public string Priority { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("createdBy")]
    public int CreatedBy { get; set; }

    [JsonPropertyName("assignedTo")]
    public int? AssignedTo { get; set; }

    [JsonPropertyName("createdAt")]
    public string CreatedAt { get; set; }
}