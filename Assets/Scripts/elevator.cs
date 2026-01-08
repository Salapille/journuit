using UnityEngine;

public class elevator : MonoBehaviour
{
    [SerializeField] private float maxHight;
    [SerializeField] private float lowerPoint;

    private Transform blockSelf;

    void Start()
    {
        blockSelf = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        ToTop();
        ToBottom();
    }

    private void ToTop()
    {
        while (blockSelf.transform.position.y < maxHight)
        {
            blockSelf.transform.position = new Vector3(0, 1, 0) + blockSelf.transform.position;
        }
    }
    private void ToBottom()
    {
        while (blockSelf.transform.position.y > lowerPoint)
        {
            blockSelf.transform.position = new Vector3(0, -1, 0) + blockSelf.transform.position;
        }
    }

}
