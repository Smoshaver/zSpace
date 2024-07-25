using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Make sure to include TextMeshPro namespace

public class TMPDropdownSpawner : MonoBehaviour
{
    public TMP_Dropdown dropdown;   // Use TMP_Dropdown for TextMeshPro
    public Transform spawnPoint;    // Reference to the spawn location
    public GameObject[] prefabs;    // Array of prefabs to spawn
    public GameObject Cube3x3x3;

    void Start()
    {
        // Add listener to handle dropdown selection
        if (dropdown != null)
        {
            dropdown.onValueChanged.AddListener(DropdownItemSelected);
        }
    }

    void DropdownItemSelected(int index)
    {
        // Ensure index is within bounds
        if (index >= 0 && index < prefabs.Length)
        {
            // Destroy existing objects at spawn point
            foreach (Transform child in spawnPoint)
            {
                Destroy(child.gameObject);
            }

            // Instantiate selected prefab at the spawn point
            Instantiate(prefabs[index], spawnPoint.position, spawnPoint.rotation);
           
        }
    }
}
