var ticketA = new Ticket { Id = 42, Title = "Let's show"};
var ticketB = new Ticket { Id = -0, Title = "Temp"};
Console.WriteLine(ticketA);

[System.Diagnostics.DebuggerDisplay("Ticket {Id}: {Title}")]
public class Ticket
{
    public int Id { get; set; }
    public string? Title { get; set; }
    //..
}

// Einchecken?