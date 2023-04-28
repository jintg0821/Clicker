using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    public long money;
    public long moneyIncreaseAmount;

    public Text textMoney;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShowInfo();
        MoneyIncrease();
    }

    //������ ����
    void MoneyIncrease()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (EventSystem.current.IsPointerOverGameObject() == false) // UI ���� ���� ���� ��
            {
                money += moneyIncreaseAmount;   // '������'�� '������ ������'��ŭ ������Ŵ
            }
        }
    }

    void ShowInfo()
    {
        if (money == 0)
            textMoney.text = "0";
        else
            textMoney.text = money.ToString("###,###");
    }
}
