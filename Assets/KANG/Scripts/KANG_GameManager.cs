using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class KANG_GameManager : MonoBehaviourPunCallbacks
{
    public static KANG_GameManager Instance;

    GameObject ship;

    int rescueCount;
    public int RescueCount
    {
        get { return rescueCount; }
        set { rescueCount = value; }
    }

    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        //OnPhotonSerializeView ȣ�� ��
        PhotonNetwork.SerializationRate = 60;
        //Rpc ȣ�� ��
        PhotonNetwork.SendRate = 60;
        GameObject ship = PhotonNetwork.Instantiate("Spaceship", new Vector3(0, 2, 0), Quaternion.identity);
        //ship = GameObject.Find("Spaceship");
        if (PhotonNetwork.IsMasterClient)
        {
            GameObject player = PhotonNetwork.Instantiate("Player", ship.transform.position, Quaternion.identity);
            player.transform.SetParent(ship.transform);
            player.gameObject.name = "Player";
        }
        else
        {
            GameObject player = PhotonNetwork.Instantiate("Player2", ship.transform.position, Quaternion.identity);
            player.transform.SetParent(ship.transform);
            player.gameObject.name = "Player";
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
