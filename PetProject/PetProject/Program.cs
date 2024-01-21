namespace PetProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pet pet = new Pet();
            TicketSeller tickets = new TicketSeller();
            Album album = new Album();
            Monitor monitor = new Monitor();

            pet.Run();
            tickets.Run();
            album.Run();
            monitor.Run();
        }
    }
}
