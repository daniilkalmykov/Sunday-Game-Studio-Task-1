using System;
using System.Collections;
using UI;
using UnityEngine;
using UnityEngine.Networking;

namespace GameLogic
{
    public sealed class SpriteSetter : MonoBehaviour
    {
        private const string Url = "https://data.ikppbb.com/test-task-unity-data/pics/";

        public static IEnumerator LoadImage(GalleryImageView imageView, int id)
        {
            var webRequest = UnityWebRequestTexture.GetTexture(Url + id + ".jpg");

            yield return webRequest.SendWebRequest();

            if (webRequest.isDone == false)
                throw new ArgumentNullException();
            
            var texture = ((DownloadHandlerTexture)webRequest.downloadHandler).texture;
            imageView.TrySetSprite(Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height),
                Vector2.zero));
        }
    }
}