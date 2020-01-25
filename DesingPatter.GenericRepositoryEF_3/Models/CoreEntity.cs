namespace DesingPatter.GenericRepositoryEF_3.Models
{
    public class CoreEntity : ICoreEntity
    {
        public int Id { get; set; }

        public string CreatedComputerName { get; set; }
        public string ModifiedComputerName { get; set; }
    }
}
