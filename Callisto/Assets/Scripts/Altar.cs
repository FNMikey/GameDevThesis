using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    public class Altar: MonoBehaviour{
    public InventorySlot chestSlot; 
        InventoryItem itemInSlot = chestSlot.GetComponentInChildren<InventoryItem>();

        if (itemInSlot != null && itemInSlot.item != null)
        {   

             if ( itemInSlot.item.itemName == "GoldenFigure")
            {
                Debug.Log("Figurka jest w slocie");
            }
        }

    }
 