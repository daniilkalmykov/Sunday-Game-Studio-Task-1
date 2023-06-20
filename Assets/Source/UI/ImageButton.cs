using Blinders;
using GameLogic;
using UnityEngine;

namespace UI
{
    [RequireComponent(typeof(GalleryImageBlinder))]
    public sealed class ImageButton : ChangeSceneButton
    {
        private GalleryImageBlinder _galleryImageBlinder;

        protected override void Awake()
        {
            base.Awake();
            _galleryImageBlinder = GetComponent<GalleryImageBlinder>();
        }

        protected override void OnClick()
        {
            ViewSceneBootstrap.TrySetId(_galleryImageBlinder.Image.Id);
            print(_galleryImageBlinder.Image.Id);
            
            base.OnClick();
        }
    }
}