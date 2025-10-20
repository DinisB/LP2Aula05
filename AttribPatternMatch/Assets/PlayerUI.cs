using UnityEngine;

// This attribute automatically adds required components as dependencies of the
// game object
[RequireComponent(typeof(PlayerAttribs))]
public class PlayerUI : MonoBehaviour
{
    // We'll keep our Player component in this private instance variable
    private PlayerAttribs player;

    private void Awake()
    {
        // Get the Player component
        player = GetComponent<PlayerAttribs>();
    }

    // Quick hack to get a message in the center of the screen
    // Don't do this at home!
    private void OnGUI()
    {
        // Get the message and its color from the player object
        (string message, Color color) = player.Status;

        // Center text on screen
        GUIStyle style = new GUIStyle(GUI.skin.label)
        {
            alignment = TextAnchor.MiddleCenter,
            fontSize = 32,
            normal = { textColor = color }
        };

        // Draw centered in the screen
        Rect rect = new Rect(0, 0, Screen.width, Screen.height);
        GUI.Label(rect, message, style);
    }
}
