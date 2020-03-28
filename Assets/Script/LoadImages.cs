using System.IO;
using UnityEngine;

public class LoadImages : MonoBehaviour
{
    public Material picture1, picture2;
    void Start()
    {
        File.WriteAllText(Application.persistentDataPath + "/readme.txt", "Place image1.jpg, image2.jpg here");

        Texture2D t1 = new Texture2D(1024, 1024);
        Texture2D t2 = new Texture2D(1024, 1024);

        string fn1 = Application.persistentDataPath + "/image1.jpg";
        string fn2 = Application.persistentDataPath + "/image2.jpg";
        
        if (File.Exists(fn1))
        {
            t1.LoadImage(File.ReadAllBytes(fn1));
            picture1.mainTexture = t1;
        }        
        if (File.Exists(fn2))
        {
            t2.LoadImage(File.ReadAllBytes(fn2));
            picture2.mainTexture = t2;
        }
    }
}
