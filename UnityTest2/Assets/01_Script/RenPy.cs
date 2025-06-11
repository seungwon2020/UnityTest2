using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RenPy : MonoBehaviour
{
    [SerializeField] Image Image_BG;
    [SerializeField] Image[] Img_Character;

    [SerializeField] TextMeshProUGUI Text_Name;
    [SerializeField] TextMeshProUGUI Text_NameTitle;
    [SerializeField] TextMeshProUGUI Text_Dialogue;

    int id = 1;

    void Start()
    {
        RefreshUI();
    }

    public void OnClickButton()
    {
        id++; // 2
        RefreshUI();
    }

    void RefreshUI()
    {
        int characterID = SData.GetDialogueData(id).Character; // 대사 테이블의 1번 ID의 캐릭터 ID 컬럼을 가지고 온다.
        Text_Name.text = SData.GetCharacterData(characterID).Name; // 캐릭터 테이블에서 캐릭터 ID에 해당하는 이름을 가지고 온다.
        Text_NameTitle.text = SData.GetCharacterData(characterID).Title; // 캐릭터 테이블에서 캐릭터 ID에 타이틀을 가지고 온다.

        Text_Dialogue.text = SData.GetDialogueData(id).Dialogue;
    }
}