namespace ClasseInterface
{
    public abstract class Cliente
    {
       public int Id { get; set; }
       public string Email { get; set; }
       public Endereco End { get; set; }
       
    }
}