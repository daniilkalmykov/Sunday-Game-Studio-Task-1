using UnityEngine;

namespace GameLogic
{
    public sealed class ScreenOrientationSetter : MonoBehaviour
    {
        [SerializeField] private ScreenOrientation _screenOrientation;
        [SerializeField] private bool _canRotate;

        private void Start()
        {
            Screen.orientation = _screenOrientation;
            
            Screen.autorotateToPortrait = _canRotate;
            Screen.autorotateToPortraitUpsideDown = _canRotate;
            Screen.autorotateToLandscapeLeft = _canRotate;
            Screen.autorotateToLandscapeRight = _canRotate;
        }
    }
}