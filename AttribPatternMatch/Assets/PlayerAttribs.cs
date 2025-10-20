using UnityEngine;

public class PlayerAttribs : MonoBehaviour
{
    [field: Tooltip("This is how much the player can stand!")]
    [field: SerializeField]
    [field: Range(0, 100)]
    public float Health { get; private set; }

    public (string, Color) Status => Health switch
    {
        0 => ( "Player is dead!", Color.gray ),
        > 0 and <= 30 => ( "Critical Health", Color.red ),
        > 30 and <= 71 => ( "Injured!", Color.red ),
        > 70 and <= 100 => ( "Healthy", Color.green ),
        _ => ( "Invalid health value", Color.white )
    };
}
