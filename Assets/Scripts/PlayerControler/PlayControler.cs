using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// Note:移动控制
/// @HuoPeng
public class PlayControler : MonoBehaviour
{
    // Start is called before the first frame update
    public float MoveSpeed = 0.5f; // Role's moving speed
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float MoveX = Input.GetAxisRaw("Horizontal"); // Control Horizontal movement A:-1 D:1
        float MoveY = Input.GetAxisRaw("Vertical"); // Control Vertical movement W:1 S:-1

        Vector2 position = transform.position;
        position.x += MoveX * MoveSpeed * Time.deltaTime;
        position.y += MoveY * MoveSpeed * Time.deltaTime;
        transform.position = position;
    }
}
