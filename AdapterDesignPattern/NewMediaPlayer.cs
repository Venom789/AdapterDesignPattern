using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class NewMediaPlayer: IMediaPlayer
    {
        private IMediaPlayer mediaAdapter;

        public NewMediaPlayer(string audioType)
        {
            if (audioType.Equals("aac", StringComparison.OrdinalIgnoreCase))
            {
                mediaAdapter = new MediaAdapter();
            }
        }

        void IMediaPlayer.Play(string fileName)
        {
            mediaAdapter.Play(fileName);
        }
    }
}
