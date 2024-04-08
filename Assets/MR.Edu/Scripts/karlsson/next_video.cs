using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;

public class next_video : MonoBehaviour
{
    public int videoNum = 0;
    public GameObject video;
    VideoPlayer videoPlayer;
    string path;
        
    // Start is called before the first frame update
    void Start()
    {
        path = Application.dataPath;
        videoPlayer = video.GetComponent<VideoPlayer>();
        nextVideo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void nextVideo()
    {
        string tempUrl;
        Debug.Log(path);
        videoNum++;
        
        tempUrl = "file://" + path + "/MR.Edu/Data/mp4/楷書/" + getWord(videoNum);
        Debug.Log(tempUrl);
        videoPlayer.url = tempUrl;
        
    }
    string getWord(int n)
    {
        string[] word = new string[]{"人",
"刀",
"力",
"又",
"土",
"夕",
"大",
"女",
"子",
"尸",
"山",
"巾",
"云",
"心",
"戈",
"戶",
"斗",
"斤",
"谷",
"日",
"月",
"木",
"欠",
"止",
"水",
"火",
"爪",
"牛",
"冊",
"占",
"邑",
"古",
"正",
"玉",
"田",
"申",
"白",
"皮",
"皿",
"目",
"矢",
"石",
"示",
"禾",
"立",
"阜",
"竹",
"米",
"糸",
"缶",
"羊",
"虎",
"老",
"考",
"耳",
"聿",
"肉",
"自",
"至",
"舟",
"虫",
"行",
"衣",
"言",
"豆",
"豕",
"貝",
"走",
"高",
"車",
"辰",
"酉",
"長",
"門",
"隹",
"雨",
"非",
"頁",
"食",
"馬",
"鬼",
"魚",
"鳥",
"鹿",
"龍",
"黑",
"齒",
"韋",
"或",
"今",
"令",
"求",
"莫",
"上",
"取",
"祭",
"工",
"甲",
"八",
"丁",
"家",
"星",
"其",
"各",
"出",
"雷",
"用",
"宗",
"元",
"州",
"萬",
"己",
"中",
"才",
"共",
"朋",
"內",
"勿",
"化",
"少",
"且",
"丙",
"臣",
"句",
"央",
"由",
"父",
"監",
"合",
"東",
"秋",
"吉",
"同",
"因",
"成",
"員",
"兌",
"有",
"余",
"舍",
"母",
"免",
"單",
"足",
"告",
"果",
"區",
"登"};
        return word[n] + ".mp4";
    }
}
