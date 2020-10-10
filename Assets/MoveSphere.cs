using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    public float moveRate = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void MoveUp()
    {
        float newY = transform.position.y + moveRate * Time.deltaTime;
        Vector3 newPos = new Vector3 (transform.position.x, newY, transform.position.z);
        transform.position = newPos;
    }

    // Update is called once per frame
    void Update()
    {
        MoveUp();
    }
}
