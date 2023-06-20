using UI;
using UnityEngine;

namespace GameLogic
{
    public sealed class ViewSceneBootstrap : MonoBehaviour
    {
        [SerializeField] private GalleryImageView _imageView;
        
        private static int _imageId;

        private void Start()
        {
            StartCoroutine(SpriteSetter.LoadImage(_imageView, _imageId));
        }

        public static void TrySetId(int id)
        {
            if (id <= 0)
                return;

            _imageId = id;
        }
    }
}