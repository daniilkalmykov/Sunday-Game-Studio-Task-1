using Interfaces;
using Models;
using UnityEngine;

namespace Blinders
{
    public sealed class GalleryImageBlinder : MonoBehaviour
    {
        public IGalleryImage Image { get; private set; }

        public void Init(int id)
        {
            Image = new GalleryImage(id);
        }
    }
}