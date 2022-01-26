using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GameManager : MonoBehaviourPunCallbacks
{
    void Start()
    {
        //실행 화면의 해상도를 960 x 640의 창모드로 설정
        Screen.SetResolution(960, 640, FullScreenMode.Windowed);

        //데이터 송수신 빈도를 매 초당 30회로 설정
        PhotonNetwork.SendRate = 30;
        PhotonNetwork.SerializationRate = 30;
    }

    void Update()
    {
        
    }
}
