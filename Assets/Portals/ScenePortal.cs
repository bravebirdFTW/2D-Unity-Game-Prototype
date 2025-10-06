using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenePortal : MonoBehaviour
{
    [Tooltip("Scene name to load, e.g., Area 1")]
    public string sceneToLoad = "Area 1";

    [Tooltip("Spawn point GameObject name in the target scene")]
    public string spawnPointName = "Spawn_FromArea1";

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;

        // remember which spawn to use in the next scene
        PlayerPrefs.SetString("spawnPoint", spawnPointName);
        SceneManager.LoadScene(sceneToLoad);
    }
}

