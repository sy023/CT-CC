using UnityEngine;

public class TitleAnimator : MonoBehaviour
{
    public float breathScale = 0.1f;
    public float breathSpeed = 1.0f;

    private Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
    }

    void Update()
    {
        float breath = Mathf.Sin(Time.time * breathSpeed) * breathScale;
        transform.localScale = originalScale + new Vector3(breath, breath, 0f);
    }
}
