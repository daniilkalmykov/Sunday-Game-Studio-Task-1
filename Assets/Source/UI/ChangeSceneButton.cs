using Enums;
using GameLogic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace UI
{
    [RequireComponent(typeof(Button))]
    public class ChangeSceneButton : MonoBehaviour
    {
        [SerializeField] private SceneName _sceneName;
        
        private Button _button;

        protected virtual void Awake()
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

        protected virtual void OnClick()
        {
            SceneLoader.TrySetSceneName(_sceneName);
            SceneManager.LoadScene(SceneName.Loading.ToString());
        }
    }
}