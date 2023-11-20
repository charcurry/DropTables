using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropTable : MonoBehaviour
{
    [Header("Chest Types")]
    [SerializeField] private int woodChest;
    [SerializeField] private int bronzeChest;
    [SerializeField] private int silverChest;
    [SerializeField] private int goldChest;
    [SerializeField] private int platinumChest;
    [SerializeField] private List<string> chestTypes;

    [Header("Wooden Chest")]
    [SerializeField] private int woodCommonDrops;
    [SerializeField] private int woodUncommonDrops;
    [SerializeField] private int woodRareDrops;
    [SerializeField] private int woodEpicDrops;
    [SerializeField] private int woodLegendaryDrops;
    [SerializeField] private List<string> woodChestDrops;

    [Header("Bronze Chest")]
    [SerializeField] private int bronzeCommonDrops;
    [SerializeField] private int bronzeUncommonDrops;
    [SerializeField] private int bronzeRareDrops;
    [SerializeField] private int bronzeEpicDrops;
    [SerializeField] private int bronzeLegendaryDrops;
    [SerializeField] private List<string> bronzeChestDrops;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
