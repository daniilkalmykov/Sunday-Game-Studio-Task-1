using Enums;
using GameLogic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace UI
{
    [RequireComponent(typeof(Button))]
    public sealed class ChangeSceneButton : MonoBehaviour
    {
        [SerializeField] private SceneName _sceneName;
        
        private Button _button;

        private void Awake()
        {
            _button = GetComponent<Button>();
        }

        private void OnEnable()
        {
            _button.onClick.AddListener(OnClick);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(OnClick);
        }

        private void OnClick()
        {
            SceneLoader.TrySetSceneName(_sceneName);
            SceneManager.LoadScene(SceneName.Loading.ToString());
        }
    }
}