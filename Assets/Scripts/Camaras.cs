using UnityEngine;

public class Camaras : MonoBehaviour
{
    
    public GameObject camJugador;
    public GameObject camUno;
    public GameObject camDos;
    void Start()
    {
        camUno.SetActive(true);
    }

    void Update()
    {
        CambioCamManual();
        if(Input.GetKeyDown(KeyCode.C)){
            CambioCamToggle();
        }
    }

    void CambioCamManual(){
        if(Input.GetKeyDown(KeyCode.O)){
            camJugador.SetActive(false);
            camUno.SetActive(true);
            camDos.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.P)){
            camJugador.SetActive(false);
            camUno.SetActive(false);
            camDos.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.I)){
            camJugador.SetActive(true);
            camUno.SetActive(false);
            camDos.SetActive(false);
        }
    }

    void CambioCamToggle(){
        if(camUno.activeInHierarchy){
            camUno.SetActive(false);
            camJugador.SetActive(false);
            camDos.SetActive(true);
        }else
        {
            if(camDos.activeInHierarchy){
                camJugador.SetActive(true);
                camDos.SetActive(false);
                camUno.SetActive(false);
            }
            else
            {
                camDos.SetActive(false);
                camUno.SetActive(true);
                camJugador.SetActive(false);
            }
        }
    }
}
