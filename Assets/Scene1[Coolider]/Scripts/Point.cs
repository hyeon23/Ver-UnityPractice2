using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var controller = other.gameObject.GetComponent<SimpleCharacterController>();
        if(controller != null)//�˻� �ݵ�� �ʿ�
        {
            controller.score += 1;
            Destroy(gameObject);
        }
    }
}
