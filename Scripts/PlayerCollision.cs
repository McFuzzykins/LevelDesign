using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    private InputHandler _input;

    void Start()
    {
        _input = FindObjectOfType<InputHandler>();
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "jump")
        {
            movement.jumpPill = true;
        }
    }
}
