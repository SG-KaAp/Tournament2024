using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLogic : MonoBehaviour
{
    public void GameObjectSetEnableOn(GameObject gameobject)
    {
        gameobject.SetActive(true);
    }
    public void GameObjectSetEnableOff(GameObject gameobject)
    {
        gameobject.SetActive(false);
    }
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
