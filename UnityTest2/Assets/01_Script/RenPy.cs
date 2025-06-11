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
        int characterID = SData.GetDialogueData(id).Character; // ��� ���̺��� 1�� ID�� ĳ���� ID �÷��� ������ �´�.
        Text_Name.text = SData.GetCharacterData(characterID).Name; // ĳ���� ���̺��� ĳ���� ID�� �ش��ϴ� �̸��� ������ �´�.
        Text_NameTitle.text = SData.GetCharacterData(characterID).Title; // ĳ���� ���̺��� ĳ���� ID�� Ÿ��Ʋ�� ������ �´�.

        Text_Dialogue.text = SData.GetDialogueData(id).Dialogue;
    }
}