using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using UnityEngine.InputSystem;
using TMPro;


public class ItemPickUp : MonoBehaviour
{
    public int count;
    public TextMeshProUGUI countText;

    void Start()
    {
        count = 0;
        SetCountText();
    }

    [SerializeField] private ItemSerch itemSerch;
    /// <summary>
    /// ItemPickUpにバインドされているボタンが押されたら呼ばれる
    /// </summary>
    public void OnItemPickUp()
    {
        var item = itemSerch.GetNearItem();
        if (item == null) return;
        item.GetComponent<Item>().PickUp();

        count = count + 1;
        print(count);

        SetCountText();
    }

    void SetCountText()
    {
        countText.text = "         " + count.ToString();
    }
}