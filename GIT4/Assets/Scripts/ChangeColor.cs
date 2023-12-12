using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private int numberType;
    private Material material;
    [SerializeField] private int numberTrigger;
    [SerializeField] private Material[] materials;

    void Start()
    {
        material = GetComponent<MeshRenderer>().material;
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (SceneManager.GetActiveScene().buildIndex)
        {
            case 0:
                OR();
                break;
            case 1:
                AND();
                break;
            case 2:
                NAND();
                break;
            case 3:
                XOR();
                break;
        }
        Destroy(other.gameObject);
    }

    private void OR()
    {
        bool isTriggerOne = numberTrigger == 1;
        material.color = materials[isTriggerOne || numberType == 1 ? 1 : 0].color;
    }

    private void AND()
    {
        bool isTriggerAndTypeOne = numberTrigger == 1 && numberType == 1;
        material.color = materials[isTriggerAndTypeOne ? 1 : 0].color;
    }

    private void NAND()
    {
        bool isNand = !(numberTrigger == 1 && numberType == 1);
        material.color = materials[isNand ? 1 : 0].color;
    }

    private void XOR()
    {
        bool isXor = numberTrigger == 1 ^ numberType == 1;
        material.color = materials[isXor ? 1 : 0].color;
    }
}