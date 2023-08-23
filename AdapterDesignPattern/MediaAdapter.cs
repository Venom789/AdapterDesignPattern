using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace AdapterDesignPattern
{
    public class MediaAdapter : IMediaPlayer
    {
        private MP3Player mp3Player;
        public MediaAdapter()
        {
            mp3Player = new MP3Player();
        }
        void IMediaPlayer.Play(string fileName)
        {
            // Assuming the file is in AAC format, convert it to MP3 and play
            ConvertAACtoMP3(fileName);
            mp3Player.PlayMP3(fileName + ".mp3");
        }

        private void ConvertAACtoMP3(string fileName)
        {
            Console.WriteLine($"Converting AAC to MP3: {fileName}");
            // Logic for converting AAC to MP3 goes here
        }
    }
}
