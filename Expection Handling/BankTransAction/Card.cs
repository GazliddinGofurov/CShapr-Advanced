class Card
{
 
    public int ID { get; set; }
    public string Owner { get; set; }
    public decimal Balance  { get; set; }
    public CardType type {get; set;}

}
   public enum CardType
    {
        UZCARD,
        HUMO,
        VIZA,
        UNIONPAY
    }

