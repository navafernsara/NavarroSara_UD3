using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject destino;

    private UnityEngine.AI.NavMeshAgent agenteDeNavegacion;

    //Usar esto para iniciar
    void Start()
    {
        agenteDeNavegacion = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();

        agenteDeNavegacion.SetDestination(destino.transform.position);

    }

}
