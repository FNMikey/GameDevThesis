using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class Open:MonoBehaviour
    {
        public Transform player;



        public GameObject chestUI;

        public float interactionDistance;

        private bool isOpen = false;

        void Start()
        {
            if (chestUI != null)
            {
                chestUI.SetActive(false);
            }
        }

        void Update()
        {
            bool open = Openchest();
            if (IsPlayerNearby())
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    ToggleChest();
                }
            }
            else if (open)
            {
                CloseChest();
            }
        }

        public bool Openchest()
        {
            if (chestUI.activeSelf)
            {
                Debug.Log("Chest is opnen");
                return true;
            }
            else
            {
                Debug.Log("Chest is close");
                return false;
            }
        }

        public bool IsPlayerNearby()
        {
            return Vector3.Distance(player.position, transform.position) <=
            interactionDistance;
        }

        private void ToggleChest()
        {
            isOpen = !isOpen;
            if (isOpen)
            {
                Debug.Log("Chest opened!");
            }
            else
            {
                Debug.Log("Chest closed!");
            }
            UpdateChestUI();
        }

        private void CloseChest()
        {
            isOpen = false;
            UpdateChestUI();
            Debug.Log("Chest closed due to distance!");
        }

        private void UpdateChestUI()
        {
            if (isOpen)
            {
                if (chestUI != null)
                {
                    chestUI.SetActive(true);
                }
            }
            else
            {
                if (chestUI != null)
                {
                    chestUI.SetActive(false);
                }
            }
        }
    }