using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    public float lavaDamagePerSecond = 25f;
    public float healPerSecond = 15f;
    // inside PlayerHealth class
    public float GetCurrentHP() => health;
    public float GetMaxHP() => maxHealth;



    private float health;

    void Start()
    {
        health = maxHealth;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Lava"))
            health -= lavaDamagePerSecond * Time.deltaTime;
        else if (other.CompareTag("Heal"))
            health += healPerSecond * Time.deltaTime;

        health = Mathf.Clamp(health, 0, maxHealth);

        if (health <= 0f)
        {
            // restart scene
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }
}

