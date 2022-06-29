using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public float speedP = 0.0002f;
    public Vector3 direccionP=new Vector3(0,0,10);
    public int damage=2;
    
    void Update()
    {
        transform.position += direccionP*speedP;
    }
}
