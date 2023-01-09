using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeTester : MonoBehaviour
{
    private void Start()
    {
        //Invoke("CreateCube", 3f);
        InvokeRepeating("CreateCube", 3f, 1f);
    }
    private void Update()
    {
        //CancelInvoke(): �Ű������� �ƹ��͵� ������ �������� ��� Invoke �ߴ�
        //CancelInvoke(Params):�Լ� �̸��� ������ �Լ� �̸����� ����� Invoke�� ����
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            InvokeRepeating("CreateCube", 3f, 1f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            InvokeRepeating("CreateSphere", 3f, 1f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            CancelInvoke("CreateCube");
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            CancelInvoke("CreateSphere");
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CancelInvoke();
        }

        //�κ�ũ ���� Ȯ��: IsInvoking(), IsInvoking("params")
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            Debug.Log("CreateCube " + (IsInvoking("CreateCube") ? "Invoking" : "Not Invoking"));
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            Debug.Log("CreateSphere " + (IsInvoking("CreateSphere") ? "Invoking" : "Not Invoking"));
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            Debug.Log("Somethings " + (IsInvoking() ? "Invoking" : "Not Invoking"));
        }
    }

    public void CreateCube()
    {
        var obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj.transform.position = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f));
    }
    public void CreateSphere()
    {
        var obj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        obj.transform.position = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f));
    }
}


