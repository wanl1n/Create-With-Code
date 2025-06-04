using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Time (in seconds) for a full day cycle (360 degrees rotation)")]
    [SerializeField]
    private float dayLengthInSeconds = 120f; // Default: 2 minutes for a full day

    private void Update()
    {
        // Calculate the degrees to rotate this frame
        float degreesPerSecond = 360f / dayLengthInSeconds;
        float rotationThisFrame = degreesPerSecond * Time.deltaTime;

        // Rotate around the X axis to simulate the sun's movement
        transform.Rotate(Vector3.right, rotationThisFrame);
    }
}