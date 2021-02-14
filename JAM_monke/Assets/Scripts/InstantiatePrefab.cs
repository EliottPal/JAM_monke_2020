using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePrefab : MonoBehaviour
{

    private UnityEngine.Object LoadPrefabFromFile(string filename)
  {
      Debug.Log("Trying to load car prefab from file ("+filename+ ")...");
      var loadedObject = Resources.Load("Models/" + filename);
      return loadedObject;
 }

    public GameObject CarPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Manager.Instance.Value);
        if (Manager.Instance.Value == "Groot")
        {
            var loadedPrefabResource = LoadPrefabFromFile("Past/Medieval village/Cart");
            Instantiate(loadedPrefabResource, new Vector3((float)-260, (float)-7.8, (float)100.92), Quaternion.identity);
        }

        if (Manager.Instance.Value == "Mercold")
        {
            var loadedPrefabResource = LoadPrefabFromFile("Past/MercedesOld/source/Mercold");
            Instantiate(loadedPrefabResource, new Vector3((float)-260, (float)-7.8, (float)100), Quaternion.identity);
        }

        if (Manager.Instance.Value == "Pierrafeu")
        {
            var loadedPrefabResource = LoadPrefabFromFile("Past/Pierrafeu/Pierrafeu");
            Instantiate(loadedPrefabResource, new Vector3((float)-260, (float)-7.8, (float)100), Quaternion.identity);
        }

        if (Manager.Instance.Value == "FefeLambo")
        {
            var loadedPrefabResource = LoadPrefabFromFile("Present/Azerilo/HQ Racing Car Model No.1203/Prefabs/Féfé Lambo");
            Instantiate(loadedPrefabResource, new Vector3((float)-260, (float)-7.8, (float)100), Quaternion.identity);
        }

        if (Manager.Instance.Value == "458Italia")
        {
            var loadedPrefabResource = LoadPrefabFromFile("Present/Ferrari Italia/source/458 Italia");
            Instantiate(loadedPrefabResource, new Vector3((float)-260, (float)-7.8, (float)100), Quaternion.identity);
        }

        if (Manager.Instance.Value == "TerTer")
        {
            var loadedPrefabResource = LoadPrefabFromFile("Present/Best Sports CARS - Pro 3D Models/Vehicle/SportCar20/Prefabs/Ter Ter");
            Instantiate(loadedPrefabResource, new Vector3((float)-260, (float)-7.8, (float)100), Quaternion.identity);
        }

        if (Manager.Instance.Value == "Cyberpunk")
        {
            var loadedPrefabResource = LoadPrefabFromFile("Future/CyberpunkHovercar/source/CyberpunkHovercar");
            Instantiate(loadedPrefabResource, new Vector3((float)-260, (float)-7.8, (float)100), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
