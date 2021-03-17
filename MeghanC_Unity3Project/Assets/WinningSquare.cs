using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningSquare : MonoBehaviour
{
    public Invector.vCharacterController.vThirdPersonInput Input;
    public GameObject Text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter()
    {
        Input.Stop = true;
        Text.SetActive(true);
    }
}
