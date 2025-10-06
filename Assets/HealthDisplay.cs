using UnityEngine;

public class HealthDisplay : MonoBehaviour
{
    public PlayerHealth player;

    void OnGUI()
    {
        if (!player) return;
        var hp = Mathf.RoundToInt(player.GetCurrentHP());
        var max = Mathf.RoundToInt(player.GetMaxHP());
        GUI.Label(new Rect(10, 10, 200, 30), $"HP: {hp}/{max}");
    }
}
