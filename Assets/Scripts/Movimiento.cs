using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float speed=2;
    void Start()
    {
        
    }

    
    void Update()
    {
        MovimientoJugador();
    }
    
    //Función para mover jugador con Teclado (Felchas y AWSD)
    void MovimientoJugador(){
        float hor= Input.GetAxis("Horizontal");//Lee Eje Horizontal
        float ver= Input.GetAxis("Vertical");//Lee Eje Vertical

        transform.Translate(new Vector3(hor,0,ver)*speed*Time.deltaTime);
        transform.Rotate(0,hor,0);
    }
}
