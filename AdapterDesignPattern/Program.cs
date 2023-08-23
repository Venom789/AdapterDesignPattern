namespace AdapterDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            IMediaPlayer mp3Player = new NewMediaPlayer("aac");
            mp3Player.Play("song.aac");

            Console.ReadLine();
        }
    }
}