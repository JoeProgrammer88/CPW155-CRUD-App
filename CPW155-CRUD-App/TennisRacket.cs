namespace CPW155_CRUD_App;

/// <summary>
/// Represents a single physical tennis racket to sell.
/// </summary>
public class TennisRacket
{
    private double _price;

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
    public double Price 
    {
        get 
        { 
            return _price; 
        }
        set 
        { 
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Price must be positive");
            }
            _price = value; 
        }
    }

    /// <summary>
    /// Returns a string representation of the racket. WinForms controls
    /// like ListBox will call this method by default to determine
    /// what to display.
    /// </summary>
    /// <returns>A formatted string containing the brand and item identifier.</returns>
    public override string ToString()
    {
        // *Note * VS says 0 references because this method is called implicitly
        // by WinForms controls
        return $"{Brand} racket has id {ItemId}";
    }
}
