using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    [Header("Scene")]
    [SerializeField] private Object scene;

    public void LoadSchene()
    {
        if (scene != null)
        {
            SceneManager.LoadScene(scene.name);
        }
        else
        {
            Debug.LogError("scene is not chosen");
        }

        
    }

}
