using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public void LoadSceneOnClick(int sceneNo)
    {
        SceneManager.LoadScene(sceneNo);
    }
}