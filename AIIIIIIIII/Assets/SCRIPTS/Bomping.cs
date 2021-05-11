using UnityEngine;

public class Bomping : MonoBehaviour
{
    public Rigidbody rigid;

    public Vector3 force;

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag=="Floor") 
        {
            rigid.AddForce(force);
        }
    }
}
