using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public static bool OpenInventory = false;

    public GameObject UIinventory;

    public Transform itemParents;

    //public GameObject player;

    Inventory inventory;

    InventorySlot[] slots;

    // Start is called before the first frame update
    void Start()
    {
        inventory = Inventory.instance;
        inventory.onItemChangedCallback += UpdateUI;

        slots = itemParents.GetComponentsInChildren<InventorySlot>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (OpenInventory)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    void UpdateUI()
    {
        for(int i=0; i<slots.Length; i++)
        {
            if(i < inventory.items.Count)
            {
                slots[i].addItem(inventory.items[i]);
            }

            else
            {
                slots[i].ClearSlot();
            }
        }
    }

    public void Resume()
    {
        UIinventory.SetActive(false);
        Time.timeScale = 1f;
        OpenInventory = false;
        //player.SetActive(true);
    }

    void Pause()
    {
        UIinventory.SetActive(true);
        Time.timeScale = 0f;
        OpenInventory = true;
        //player.SetActive(false);
    }
}
