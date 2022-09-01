using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxAul : AIController
{
    
    void audiowalk()
    {
        FindObjectOfType<AudioManager>().Play("AulFootsteps");
    }

}
