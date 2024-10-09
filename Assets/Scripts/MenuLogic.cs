using UnityEngine;

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
}
