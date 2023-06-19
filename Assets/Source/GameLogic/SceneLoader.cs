using System;
using System.Collections;
using Enums;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameLogic
{
    public sealed class SceneLoader : MonoBehaviour
    {
        private static SceneName _nextSceneName = SceneName.MainMenu;

        public event Action<float> ProgressChanged;
        
        private void Start()
        {
            StartCoroutine(LoadScene());
        }
        
        public static void TrySetSceneName(SceneName sceneName)
        {
            if (sceneName == SceneName.Loading)
                throw new ArgumentNullException();

            _nextSceneName = sceneName;
        }
        
        private IEnumerator LoadScene()
        {
            var asyncOperation = SceneManager.LoadSceneAsync(_nextSceneName.ToString());

            while (asyncOperation.isDone == false)
            {
                ProgressChanged?.Invoke(Mathf.Clamp01(asyncOperation.progress));

                yield return null;
            }
        }
    }
}