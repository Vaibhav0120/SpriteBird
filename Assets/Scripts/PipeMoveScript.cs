using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 7;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (this.transform.position.x < -35)
        {
            Destroy(this.gameObject);
        }
    }
}
