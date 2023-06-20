using UnityEngine;
using UnityEngine.UI;

namespace GameLogic
{
    public sealed class ImagesGenerator : MonoBehaviour
    {
        [SerializeField] private Image _image;
        [SerializeField] private Transform _container;
        [SerializeField] private int _count;
        
        private void Start()
        {
            for (var i = 0; i < _count; i++)
            {
                var image = Instantiate(_image, Vector3.zero, Quaternion.identity, _container);
            }
        }
    }
}