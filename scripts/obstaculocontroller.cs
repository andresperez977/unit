using UnityEngine;

public class obstaculocontroller : MonoBehaviour
{

    [SerializeField]
    private float minSize = 0.3f;
    [SerializeField]
    private float maxSize = 2f;
    [SerializeField]
    private float minForce = 20f;
    [SerializeField]
    private float maxForce = 48f;

    private float minTorque = 20f;
    [SerializeField]
    private float maxTorque = 48f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float size = Random.Range(minSize, maxSize);
        transform.localScale = new Vector3(Random.Range(minSize,maxSize), 3, 1);
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Transform tf = GetComponent<Transform>();
        Vector2 ramdomDirection = Random.insideUnitCircle;
        float force = Random.Range(minForce, maxForce);
        float torque = Random.Range(minTorque, maxTorque);
        rb.AddTorque(-torque);
        Debug.Log(transform == tf);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
