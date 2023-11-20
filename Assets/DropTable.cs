using System.Collections.Generic;
using System.Linq;
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
    [SerializeField] private int woodChestCommon;
    [SerializeField] private int woodChestUncommon;
    [SerializeField] private int woodChestRare;
    [SerializeField] private int woodChestEpic;
    [SerializeField] private int woodChestLegendary;
    [SerializeField] private List<string> woodChestDrops;

    [Header("Bronze Chest")]
    [SerializeField] private int bronzeChestCommon;
    [SerializeField] private int bronzeChestUncommon;
    [SerializeField] private int bronzeChestRare;
    [SerializeField] private int bronzeChestEpic;
    [SerializeField] private int bronzeChestLegendary;
    [SerializeField] private List<string> bronzeChestDrops;

    [Header("Silver Chest")]
    [SerializeField] private int silverChestCommon;
    [SerializeField] private int silverChestUncommon;
    [SerializeField] private int silverChestRare;
    [SerializeField] private int silverChestEpic;
    [SerializeField] private int silverChestLegendary;
    [SerializeField] private List<string> silverChestDrops;

    [Header("Gold Chest")]
    [SerializeField] private int goldChestCommon;
    [SerializeField] private int goldChestUncommon;
    [SerializeField] private int goldChestRare;
    [SerializeField] private int goldChestEpic;
    [SerializeField] private int goldChestLegendary;
    [SerializeField] private List<string> goldChestDrops;

    [Header("Platinum Chest")]
    [SerializeField] private int platinumChestCommon;
    [SerializeField] private int platinumChestUncommon;
    [SerializeField] private int platinumChestRare;
    [SerializeField] private int platinumChestEpic;
    [SerializeField] private int platinumChestLegendary;
    [SerializeField] private List<string> platinumChestDrops;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < woodChest; i++)
        {
            chestTypes.Add("Wooden Chest");
        }
        for (int i = 0; i < bronzeChest; i++)
        {
            chestTypes.Add("Bronze Chest");
        }
        for (int i = 0; i < silverChest ; i++)
        {
            chestTypes.Add("Silver Chest");
        }
        for (int i = 0; i < goldChest; i++)
        {
            chestTypes.Add("Gold Chest");
        }
        for (int i = 0;i < platinumChest; i++)
        {
            chestTypes.Add("Platinum Chest");
        }

        woodChestDrops.AddRange(Enumerable.Repeat("Wooden Chest Common", woodChestCommon));
        woodChestDrops.AddRange(Enumerable.Repeat("Wooden Chest Uncommon", woodChestUncommon));
        woodChestDrops.AddRange(Enumerable.Repeat("Wooden Chest Rare", woodChestRare));
        woodChestDrops.AddRange(Enumerable.Repeat("Wooden Chest Epic", woodChestEpic));
        woodChestDrops.AddRange(Enumerable.Repeat("Wooden Chest Legendary", woodChestLegendary));

        bronzeChestDrops.AddRange(Enumerable.Repeat("Bronze Chest Common", bronzeChestCommon));
        bronzeChestDrops.AddRange(Enumerable.Repeat("Bronze Chest Uncommon", bronzeChestUncommon));
        bronzeChestDrops.AddRange(Enumerable.Repeat("Bronze Chest Rare", bronzeChestRare));
        bronzeChestDrops.AddRange(Enumerable.Repeat("Bronze Chest Epic", bronzeChestEpic));
        bronzeChestDrops.AddRange(Enumerable.Repeat("Bronze Chest Legendary", bronzeChestLegendary));

        silverChestDrops.AddRange(Enumerable.Repeat("Silver Chest Common", silverChestCommon));
        silverChestDrops.AddRange(Enumerable.Repeat("Silver Chest Uncommon", silverChestUncommon));
        silverChestDrops.AddRange(Enumerable.Repeat("Silver Chest Rare", silverChestRare));
        silverChestDrops.AddRange(Enumerable.Repeat("Silver Chest Epic", silverChestEpic));
        silverChestDrops.AddRange(Enumerable.Repeat("Silver Chest Legendary", silverChestLegendary));

        goldChestDrops.AddRange(Enumerable.Repeat("Gold Chest Common", goldChestCommon));
        goldChestDrops.AddRange(Enumerable.Repeat("Gold Chest Uncommon", goldChestUncommon));
        goldChestDrops.AddRange(Enumerable.Repeat("Gold Chest Rare", goldChestRare));
        goldChestDrops.AddRange(Enumerable.Repeat("Gold Chest Epic", goldChestEpic));
        goldChestDrops.AddRange(Enumerable.Repeat("Gold Chest Legendary", goldChestLegendary));

        platinumChestDrops.AddRange(Enumerable.Repeat("Platinum Chest Common", platinumChestCommon));
        platinumChestDrops.AddRange(Enumerable.Repeat("Platinum Chest Uncommon", platinumChestUncommon));
        platinumChestDrops.AddRange(Enumerable.Repeat("Platinum Chest Rare", platinumChestRare));
        platinumChestDrops.AddRange(Enumerable.Repeat("Platinum Chest Epic", platinumChestEpic));
        platinumChestDrops.AddRange(Enumerable.Repeat("Platinum Chest Legendary", platinumChestLegendary));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            string generatedChest = chestTypes.ElementAt(Random.Range(0, chestTypes.Count()));

            switch (generatedChest)
            {
                case "Wooden Chest":
                    Debug.Log(generatedChest); 
                    break;
                case "Bronze Chest":
                    Debug.Log(generatedChest);
                    break;
                case "Silver Chest":
                    Debug.Log(generatedChest);
                    break;
                case "Gold Chest":
                    Debug.Log(generatedChest);
                    break;
                case "Platinum Chest":
                    Debug.Log(generatedChest);
                    break;
            }
            //Debug.Log(chestTypes.ElementAt(Random.Range(0, chestTypes.Count())));
        }
    }
}
