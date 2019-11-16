using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;

    //球每一帧的变化
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        //初始化摄像头的位置
        offset = transform.position - player.transform.position;
	}

    // Update is called once per frame
    // 视野随着球的变化而变化
    void LateUpdate () {
        //每一帧的位置 + 摄像机的位置 
        transform.position = player.transform.position + offset;
	}
}
