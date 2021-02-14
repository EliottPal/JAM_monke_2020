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
            Instantiate(loadedPrefabResource, new Vector3((float)-255, (float)-8, (float)117), transform.rotation * Quaternion.Euler (0f, 39.28f, 0f));
        }

        if (Manager.Instance.Value == "Mercold")
        {
            var loadedPrefabResource = LoadPrefabFromFile("Past/MercedesOld/source/Mercold");
            Instantiate(loadedPrefabResource, new Vector3((float)-254.5, (float)-7.5, (float)118),transform.rotation * Quaternion.Euler (0f, 39.6f, 0f));
        }

        if (Manager.Instance.Value == "Pierrafeu")
        {
            var loadedPrefabResource = LoadPrefabFromFile("Past/Pierrafeu/Pierrafeu");
            Instantiate(loadedPrefabResource, new Vector3((float)-253.5, (float)-8.5, (float)118.5), transform.rotation * Quaternion.Euler (0f, 40.23f, 0f));
        }

        if (Manager.Instance.Value == "FefeLambo")
        {
            var loadedPrefabResource = LoadPrefabFromFile("Present/Azerilo/HQ Racing Car Model No.1203/Prefabs/Féfé Lambo");
            Instantiate(loadedPrefabResource, new Vector3((float)-254, (float)-8.5, (float)118), transform.rotation * Quaternion.Euler (0f, 37.69f, 0f));
        }

        if (Manager.Instance.Value == "458Italia")
        {
            var loadedPrefabResource = LoadPrefabFromFile("Present/Ferrari Italia/source/458 Italia");
            Instantiate(loadedPrefabResource, new Vector3((float)-255, (float)-8.8, (float)116), transform.rotation * Quaternion.Euler (0f, 36.2f, 0f));
        }

        if (Manager.Instance.Value == "TerTer")
        {
            var loadedPrefabResource = LoadPrefabFromFile("Present/Best Sports CARS - Pro 3D Models/Vehicle/SportCar20/Prefabs/Ter Ter");
            Instantiate(loadedPrefabResource, new Vector3((float)-255, (float)-8.5, (float)117.5), transform.rotation * Quaternion.Euler (0f, 36.02f, 0f));
        }

        if (Manager.Instance.Value == "Cyberpunk")
        {
            var loadedPrefabResource = LoadPrefabFromFile("Future/CyberpunkHovercar/source/CyberpunkHovercar");
            Instantiate(loadedPrefabResource, new Vector3((float)-254, (float)-8.5, (float)119), transform.rotation * Quaternion.Euler (0f, 36.46f, 0f));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
