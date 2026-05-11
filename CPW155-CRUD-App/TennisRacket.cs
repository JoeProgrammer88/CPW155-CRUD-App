namespace CPW155_CRUD_App;

/// <summary>
/// Represents a single physical tennis racket to sell.
/// </summary>
public class TennisRacket
{
    /// <summary>
    /// The PK of the tennis racket in the database.
    /// </summary>
    public int ItemId { get; set; }

    /// <summary>
    /// The weight in ounces of the tennis racket.
    /// </summary>
    public byte Weight { get; set; }

    /// <summary>
    /// The size of the racket head or hoop in square centimeters
    /// </summary>
    public short HeadSize { get; set; }

    /// <summary>
    /// The brand name or manufacturer of the tennis racket.
    /// </summary>
    public required string Brand { get; set; }

    /// <summary>
    /// The price the racket will sell at retail in US dollars.
    /// </summary>
    public double Price { get; set; }
}
