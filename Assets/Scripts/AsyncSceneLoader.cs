using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Base.AsyncSceneLoader
{

    public class AsyncSceneLoader : MonoBehaviour
    {
        [SerializeField] private GameObject menuPanel;
        [SerializeField] private GameObject loadingPanel;
        [SerializeField] private Image loadingProgressBar;
        private AsyncOperation level;

        public void LoadScene(string sceneName)
        {
            level = SceneManager.LoadSceneAsync(sceneName);
            if (menuPanel != null) menuPanel.SetActive(false);
            loadingPanel.SetActive(true);
            level.allowSceneActivation = false;
            while (level.progress < 0.9f)
            {
                loadingProgressBar.fillAmount = level.progress;
            }
            level.allowSceneActivation = true;
        }
    }
}