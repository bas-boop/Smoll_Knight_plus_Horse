using UnityEngine;
using UnityEngine.SceneManagement;

namespace Baz_geluk9.SKPH
{
    public sealed class SceneSwitcher : MonoBehaviour
    {
        [SerializeField] private bool loadSceneInAwake;
        [SerializeField] private string sceneToLoad;

        private void Awake()
        {
            if (loadSceneInAwake)
                LoadScene();
        }

        public void LoadScene() => SceneManager.LoadScene(sceneToLoad);
    }   
}
