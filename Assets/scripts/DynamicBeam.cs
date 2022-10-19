using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class DynamicBeam : MonoBehaviour
{
    public Color startColor = Color.blue;
    public Color endColor = Color.blue;
    public int lenght= 5;
    public GameObject controllerPrefab;

    private LineRenderer beamLine;

    void Start()
    {
        InitializeLineRenderer();
    }


    void Update()
    {
        UpdatePosition();

        UpdateLenght();

    }
    private void InitializeLineRenderer()
    {
        beamLine = GetComponent<LineRenderer>();
        beamLine.startColor = startColor;
        beamLine.endColor = endColor;
    }

    private void UpdateLenght()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            beamLine.useWorldSpace = true;
            beamLine.SetPosition(0, transform.position);
            beamLine.SetPosition(1, hit.point);

        }
        else
        {
            beamLine.useWorldSpace = false;
            beamLine.SetPosition(0, transform.position);
            beamLine.SetPosition(1, Vector3.forward * lenght);

        }
    }

    private void UpdatePosition()
    {
        transform.position = controllerPrefab.transform.position;
        transform.rotation = controllerPrefab.transform.rotation;
    }
}
