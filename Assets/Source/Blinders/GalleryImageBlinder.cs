using Interfaces;
using Models;
using UnityEngine;

namespace Blinders
{
    public sealed class GalleryImageBlinder : MonoBehaviour
    {
        private IGalleryImage _galleryImage;
        
        public void Init(int id)
        {
            _galleryImage = new GalleryImage(id);
        }
    }
}