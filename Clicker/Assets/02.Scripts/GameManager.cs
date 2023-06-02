using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class GameManager : MonoBehaviour
{
    public long money;
    public long moneyIncreaseAmount;
    public TMP_Text textMoney;

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

    //소지금 증가
    void MoneyIncrease()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (EventSystem.current.IsPointerOverGameObject() == false) // UI 위에 있지 않을 때
            {
                money += moneyIncreaseAmount;   // '소지금'을 '소지금 증가량'만큼 증가시킴
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
