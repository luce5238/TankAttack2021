using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PhotonManager : MonoBehaviourPunCallbacks
{
    // Start is called
    private readonly string gameVersion = "v1.0";
    private string UserId = "Luce";

    void Awake()
    {
        PhotonNetwork.GameVersion=gameVersion;
        PhotonNetwork.NickName=UserId;

        //서버접속
        PhotonNetwork.ConnectUsingSettings();
        
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Photon Server");
        PhotonNetwork.JoinRandomRoom();

    }
    // before the first frame update
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        PhotonNetwork.CreateRoom("My Room");
    }
//
    public override void OnCreatedRoom()
    {
        Debug.Log("방 생성 완료");
        //룸 생성시 바로 입장함
    }
    // 룸에 입장했을때 호출되는 콜백함수

    public override void OnJoinedRoom()
    {
        Debug.Log("방 입장 완료");
        Debug.Log(PhotonNetwork.CurrentRoom.Name);
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
           
  
    }

}
