using UnityEngine;

public class SpawnAtPoint : MonoBehaviour
{
    void Start()
    {
        string spawnName = PlayerPrefs.GetString("spawnPoint", "");
        if (string.IsNullOrEmpty(spawnName)) return;

        var player = GameObject.FindWithTag("Player");
        var spawn  = GameObject.Find(spawnName);
        if (player && spawn) player.transform.position = spawn.transform.position;
    }
}
