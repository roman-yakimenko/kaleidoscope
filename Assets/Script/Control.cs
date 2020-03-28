using UnityEngine;

public class Control : MonoBehaviour
{
    public Transform hand, camera, sphere;
    public bool left;

    void Update()
    {
        if (InputManager.i.getTrigger(left) > 0.5f)
        {
            camera.transform.position = hand.transform.position;
            camera.transform.rotation = hand.transform.rotation;
        }

        if (InputManager.i.getDpad(left).y > 0.01f)
        {
            float s = sphere.localScale.x * (1.0f + InputManager.i.getDpad(left).y / 30.0f);
            sphere.localScale = new Vector3(s, s, s);
        }
        if (InputManager.i.getDpad(left).y < 0.01f)
        {
            float s = sphere.localScale.x / (1.0f - InputManager.i.getDpad(left).y / 30.0f);
            sphere.localScale = new Vector3(s, s, s);
        }
    }
}
