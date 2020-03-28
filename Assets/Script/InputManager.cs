using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class InputManager : MonoBehaviour
{
    private class Controller
    {
        public bool primary, primaryDown, primaryUp;
        public bool secondary, secondaryDown, secondaryUp;
        public bool grip, gripDown, gripUp;
        public float trigger;
        public Vector2 dpad;
    }
    public static InputManager i;
    private InputDevice ld, rd;
    private Controller lc, rc;
    public Transform lh, rh;

    void Awake()
    {
        i = this;
    }

    void Start()
    {
        lc = new Controller();
        rc = new Controller();
        Init();
    }

    void Init()
    {
        var devices = new List<InputDevice>();
        InputDevices.GetDevicesAtXRNode(XRNode.LeftHand, devices);
        if (devices.Count == 1)
        {
            ld = devices[0];
        }
        devices = new List<InputDevice>();
        InputDevices.GetDevicesAtXRNode(XRNode.RightHand, devices);
        if (devices.Count == 1)
        {
            rd = devices[0];
        }
        XRDevice.SetTrackingSpaceType(TrackingSpaceType.RoomScale);
        Vector3 p1, p2;
        ld.TryGetFeatureValue(CommonUsages.devicePosition, out p1);
        rd.TryGetFeatureValue(CommonUsages.devicePosition, out p2);
        if (p1 == Vector3.zero || p2 == Vector3.zero)
        {
            Invoke("Init", 1.0f);
        }
    }

    void Update()
    {
        UpdateDevice(ld, lc, lh);
        UpdateDevice(rd, rc, rh);
    }

    private void UpdateDevice(InputDevice d, Controller c, Transform t)
    {
        Vector3 p;
        Quaternion q;
        bool b;
        d.TryGetFeatureValue(CommonUsages.devicePosition, out p);
        d.TryGetFeatureValue(CommonUsages.deviceRotation, out q);
        d.TryGetFeatureValue(CommonUsages.trigger, out c.trigger);
        d.TryGetFeatureValue(CommonUsages.primary2DAxis, out c.dpad);
        d.TryGetFeatureValue(CommonUsages.primaryButton, out b);
        c.primaryDown = b && !c.primary;
        c.primaryUp = !b && c.primary;
        c.primary = b;
        d.TryGetFeatureValue(CommonUsages.secondaryButton, out b);
        c.secondaryDown = b && !c.secondary;
        c.secondaryUp = !b && c.secondary;
        c.secondary = b;
        d.TryGetFeatureValue(CommonUsages.gripButton, out b);
        c.gripDown = b && !c.grip;
        c.gripUp = !b && c.grip;
        c.grip = b;
        t.localPosition = p;
        t.localRotation = q;
    }

    private Controller getController(bool left)
    {
        return left ? lc : rc;
    }

    public bool getPrimary(bool left)
    {
        return getController(left).primary;
    }

    public bool getPrimaryUp(bool left)
    {
        return getController(left).primaryUp;
    }

    public bool getPrimaryDown(bool left)
    {
        return getController(left).primaryDown;
    }

    public bool getSecondary(bool left)
    {
        return getController(left).secondary;
    }

    public bool getSecondaryUp(bool left)
    {
        return getController(left).secondaryUp;
    }

    public bool getSecondaryDown(bool left)
    {
        return getController(left).secondaryDown;
    }

    public float getTrigger(bool left)
    {
        return getController(left).trigger;
    }

    public Vector2 getDpad(bool left)
    {
        return getController(left).dpad;
    }

    public bool getGrip(bool left)
    {
        return getController(left).grip;
    }

    public bool getGripUp(bool left)
    {
        return getController(left).gripUp;
    }

    public bool getGripDown(bool left)
    {
        return getController(left).gripDown;
    }

    public void Impulse(bool left, float a, float d)
    {
        (left ? ld : rd).SendHapticImpulse(0, a, d);
    }
}
