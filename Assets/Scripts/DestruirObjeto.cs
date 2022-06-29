using UnityEngine;

public class DestruirObjeto : MonoBehaviour
{
    public float delay=5f;
    
    void Start()
    {
        Destroy(gameObject,delay);
    }

    void Update()
    {
        
    }
}
