namespace ProductAPI.Utilities.Exceptions
{
    public class NotFoundException :Exception
    {
        public NotFoundException(string message) : base(message) { }
        public NotFoundException() : base("Entity was not found") { }

    }
}
