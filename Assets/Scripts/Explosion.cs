using UnityEngine;

public class ParticleTest : MonoBehaviour
{
    public ParticleSystem ps;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            ps.Play(); // Start playing
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            ps.Stop(); // Stop emitting new particles
        }
    }
}
