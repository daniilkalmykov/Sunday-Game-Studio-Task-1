using System;
using Blinders;
using UI;
using UnityEngine;

namespace GameLogic
{
    public sealed class ImagesGenerator : MonoBehaviour
    {
        [SerializeField] private GalleryImageBlinder _galleryImageBlinder;
        [SerializeField] private Transform _container;
        [SerializeField] private int _count;

        private void Start()
        {
            for (var i = 0; i < _count; i++)
            {
                var image = Instantiate(_galleryImageBlinder, Vector3.zero, Quaternion.identity, _container);

                if (image.TryGetComponent(out GalleryImageView galleryImageView) == false)
                    throw new ArgumentNullException();
                
                image.Init(i + 1);

                StartCoroutine(SpriteSetter.LoadImage(galleryImageView, i + 1));
            }
        }
    }
}