using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    //RigidBody ָ���������˶�
    private Rigidbody rb;
    public float speed;
    public float count;

    public Text countText;
    public Text winText;

    //��ʼ�� rb
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        winText.text = "";
        countText.text = "Coins collected: " + count;
    }

    //ͨ������������������˶�
    //������Ⱦʱ�����仯
    void FixedUpdate()
    {
        //���̿��Ƶ�x��ı仯
        float horiInput = Input.GetAxis("Horizontal");
        //���̿��Ƶ�z��ı仯
        float vertiInput = Input.GetAxis("Vertical");

        //����һ�����������˶�.���²����仯
        Vector3 movement = new Vector3(horiInput, 0, vertiInput);

        //������ӵ�������  
        rb.AddForce(movement * speed);
    }

    //С����ײ����
    void OnTriggerEnter(Collider other)
    {
        //��������֮������
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            count++;
            countText.text = "Coins collected: " + count;

        }

        if (count == 10)
        {
            //you win !
            winText.text = "You Win!!!";
        }
    }



}
