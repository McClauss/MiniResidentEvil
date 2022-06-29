using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject prefabBala;
    public Transform posicionHueco;
    public int cartucho=30;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CrearProyectil();
    }

    //Funcion para crear dos proyectiles Oprimiendo Teclas Espacio
    void CrearProyectil(){
        
        if(Input.GetKeyDown(KeyCode.Space)){
            if(cartucho>0){
                Instantiate(prefabBala,posicionHueco.position,transform.rotation);
                cartucho--;
            }
            else
            {
                Debug.Log("Cartucho Sin Balas - Recargue!");
            }
        }
    }
}
