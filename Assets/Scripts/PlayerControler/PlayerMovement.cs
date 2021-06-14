using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// Note:移动控制
/// @HuoPeng
public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject myBag;
    bool isBagOpen;
    void Update()
    {
        OpenMyBag();
    }

    // Update is called once per frame
    void OpenMyBag(){
        if (Input.GetKeyDown(KeyCode.O)){
            isBagOpen = !isBagOpen;
            myBag.SetActive(isBagOpen);
        }
    }
    
}
