using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript1 : MonoBehaviour
{
    public GameObject LastHit;
    public Vector3 Collision = Vector3.zero;
    public LayerMask Layer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var ray = new Ray(origin:this.transform.position, direction:this.transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, maxDistance:100))
        {
            LastHit = hit.transform.gameObject;
            Collision = hit.point;
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(Collision, radius:0.2f);
    }
}
