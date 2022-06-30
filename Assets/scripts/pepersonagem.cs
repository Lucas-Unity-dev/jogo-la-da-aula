using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pepersonagem : MonoBehaviour
{
    public static bool TaVoando= true;
    // Start is called before the first frame update
    void OnCollisionExit2D(Collision2D pisou)
    {
       if(pisou.gameObject.layer == 8)
       {
           TaVoando = true; 
       } 
    }
void OnCollisionEnter2D(Collision2D OutroObj)
    {
       if(OutroObj.gameObject.layer == 8)
       {
           TaVoando = false;
       } 
}
}

