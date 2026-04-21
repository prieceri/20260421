using UnityEngine;

public class zoom : MonoBehaviour
{
    public float zoomFOV = 30f;
    public float normalFOV = 60f;
    public float smoothSpeed = 5f;

    private Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        if (Input.GetMouseButton(1)) // ¿ìÅ¬¸¯
        {
            cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, zoomFOV, Time.deltaTime * smoothSpeed);
        }
        else
        {
            cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, normalFOV, Time.deltaTime * smoothSpeed);
        }
    }
}

