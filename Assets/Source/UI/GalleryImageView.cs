using System;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    [RequireComponent(typeof(Image))]
    public sealed class GalleryImageView : MonoBehaviour
    {
        private Image _image;

        private void Awake()
        {
            _image = GetComponent<Image>();
        }

        public void TrySetSprite(Sprite sprite)
        {
            if (sprite == null)
                throw new ArgumentNullException();

            _image.sprite = sprite;
        }
    }
}