using Interfaces;

namespace Models
{
    public sealed class GalleryImage : IGalleryImage
    {
        public GalleryImage(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }
}