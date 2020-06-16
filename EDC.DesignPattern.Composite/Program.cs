//using EDC.DesignPattern.Composite.InitializeVersion;
using EDC.DesignPattern.Composite.RefactoredVersion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Composite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // v1
            //InitializeVersionDemo();
            // v2
            RefactoredVersionDemo();

            Console.ReadKey();
        }

        #region v1
        public static void InitializeVersionDemo()
        {
            //Folder folder1 = new Folder("EDC的资料");
            //Folder folder2 = new Folder("图像文件");
            //Folder folder3 = new Folder("文本文件");

            //ImageFile image1 = new ImageFile("小龙女.jpg");
            //ImageFile image2 = new ImageFile("张无忌.gif");

            //TextFile text1 = new TextFile("九阴真经.txt");
            //TextFile text2 = new TextFile("葵花宝典.doc");

            //folder2.AddImageFile(image1);
            //folder2.AddImageFile(image2);

            //folder3.AddTextFile(text1);
            //folder3.AddTextFile(text2);

            //folder1.AddFolder(folder2);
            //folder1.AddFolder(folder3);

            //folder1.KillVirus();
        }
        #endregion

        #region v2
        public static void RefactoredVersionDemo()
        {
            AbstractFile folder1 = new Folder("EDC的资料");
            AbstractFile folder2 = new Folder("图像文件");
            AbstractFile folder3 = new Folder("文本文件");
            AbstractFile folder4 = new Folder("视频文件");

            AbstractFile image1 = new ImageFile("小龙女.jpg");
            AbstractFile image2 = new ImageFile("张无忌.gif");

            AbstractFile text1 = new TextFile("九阴真经.txt");
            AbstractFile text2 = new TextFile("葵花宝典.doc");

            AbstractFile video1 = new VideoFile("笑傲江湖.rmvb");
            AbstractFile video2 = new VideoFile("天龙八部.mp4");

            folder2.Add(image1);
            folder2.Add(image2);

            folder3.Add(text1);
            folder3.Add(text2);

            folder4.Add(video1);
            folder4.Add(video2);

            folder1.Add(folder2);
            folder1.Add(folder3);
            folder1.Add(folder4);

            //folder1.KillVirus();

            folder3.KillVirus();
        }
        #endregion
    }
}
