using Euterpe.CustomAlbums.Data;

namespace Euterpe.CustomAlbums.ModExtensions
{
    public class AlbumEventArgs : EventArgs
    {
        public Album Album;

        public AlbumEventArgs(Album album)
        {
            Album = album;
        }
    }
}
