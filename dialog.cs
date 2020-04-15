using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialog : MonoBehaviour
{
    [Header("UI组件")]
    public Text textBox;    //Unity中的Text框

    [Header("文本相关")]
    public TextAsset textFile;  //txt文本
    public int index = 0; //当前行数
    List<string> textList = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        getText(textFile);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T) && index == textList.Count)
        {
            gameObject.SetActive(false);
            index = 0;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            textBox.text = textList[index];
            index++;
        }
    }

    void getText(TextAsset file)
    {
        textList.Clear();
        index = 0;
        var lineData = file.text.Split('\n');
        //for line in lineData:
        foreach (var line in lineData)
        {
            textList.Add(line);
        }

    }
}
