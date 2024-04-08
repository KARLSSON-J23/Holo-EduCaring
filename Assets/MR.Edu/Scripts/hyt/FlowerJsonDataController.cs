using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using TMPro;

public class FlowerJsonDataController : MonoBehaviour
{
    public TextAsset jsonData;
    private List<RadicalData> radicalDataList;
    public TextMeshProUGUI[] textMeshPros;
    public GameObject[] flowerObjects;
    public string searchText;

    void Start()
    { 
        ParseJSONData();
        searchRadical();
    }

    public void searchRadical() {
        searchText = "木";
        textMeshPros[0].text = searchText;
        GetRelatedWordsByRadical(searchText);
    }

    private void ParseJSONData()
    {
        radicalDataList = JsonConvert.DeserializeObject<List<RadicalData>>(jsonData.text);
        Debug.Log("test radicalDataList:" + radicalDataList);
    }

    private void GetRelatedWordsByRadical(string radical)
    {
        RadicalData radicalData = radicalDataList.Find(data => data.radical == radical);

        //string jsonData = JsonConvert.SerializeObject(radicalData, Formatting.Indented);
        //Debug.Log(jsonData);

        if (radicalData != null)
        {
            for (int i = 0; i < flowerObjects.Length-1; i++)
            {
                //Debug.Log("length:"+flowerObjects.Length);
                RelatedWord word = radicalData.relatedWords[i];
                textMeshPros[i+1].text = word.meaning;
                Debug.Log("index:"+i+",Character: " + word.character + ", Meaning: " + word.meaning);
            }
        }
        else
        {
            Debug.Log("No related words found for radical: " + radical);
        }
    }

    public void showWordsInFlower(string word) {
        for (int i = 1; i < flowerObjects.Length; i++)
        {
            // 更新TMP Text元件的文字為相對應的字詞
            textMeshPros[i].text = word;
        }
    }
}
