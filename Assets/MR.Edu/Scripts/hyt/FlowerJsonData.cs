using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class RadicalData
{
    public string radical;
    public List<RelatedWord> relatedWords;
}

[System.Serializable]
public class RelatedWord
{
    public string character;
    public string meaning;
}

