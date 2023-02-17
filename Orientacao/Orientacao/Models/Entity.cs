namespace Orientacao.Models
{
    public abstract class Entity
    {
        public Entity()
        {
            Id = Guid.NewGuid();

            DataCadastro = DateTime.Now;
        }
        Guid Id { get; set; }
        DateTime DataCadastro { get; set; }
    }
}