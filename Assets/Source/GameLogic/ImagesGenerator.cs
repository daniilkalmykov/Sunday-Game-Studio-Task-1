using System;
using System.Collections;
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
        [SerializeField] private SpriteSetter _spriteSetter;

        private void Start()
        {
            for (var i = 0; i < _count; i++)
            {
                var image = Instantiate(_galleryImageBlinder, Vector3.zero, Quaternion.identity, _container);

                if (image.TryGetComponent(out GalleryImageView galleryImageView) == false)
                    throw new ArgumentNullException();
                
                image.Init(i);

                StartCoroutine(_spriteSetter.LoadImage(galleryImageView, i + 1));
            }
        }
    }
}