using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;

    //��ÿһ֡�ı仯
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        //��ʼ������ͷ��λ��
        offset = transform.position - player.transform.position;
	}

    // Update is called once per frame
    // ��Ұ������ı仯���仯
    void LateUpdate () {
        //ÿһ֡��λ�� + �������λ�� 
        transform.position = player.transform.position + offset;
	}
}
