namespace FlyWeight
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 享元模式    结构型模式
        使用场景： 大量相似对象共享部分状态。通常用于图形编辑器、文本处理器和游戏开发等场景，其中需要频繁创建大量相似对象以提高性能。
        优点：减少内存使用，提高性能。
        缺点：增加了复杂性，需要维护共享状态或处理线程冲突。

            速记:共享对象 池化技术
             */

            //引入工厂类
            CharacterFactory factory = new CharacterFactory();

            List<Character> charactersInDocument = new List<Character>();

            string documentText = "Hello, world!";
            foreach (var c in documentText)
            {
                Character character = factory.GetCharacter(c);
                charactersInDocument.Add(character);
            }

            foreach (Character character in charactersInDocument)
            {
                character.Print();
            }

        }
    }
}