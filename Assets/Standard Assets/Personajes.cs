using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personajes : MonoBehaviour
{
    public int nivelHambre;
    public Alimento alimento;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TomarAlimento(int valorAlimentario)
    {
        nivelHambre -= valorAlimentario;

        if (nivelHambre <= 0)
        {
            nivelHambre = 0;
        }
    }
    private void OnTriggerEnter(Collider other)
        {
            Debug.Log("trigger");
            Alimento alimento;
            alimento = other.GetComponent<Alimento>();
        TomarAlimento(alimento.valorAlimentario);
            
        }

    }
