namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 备忘录模式    行为型模式
             它用于捕获对象的内部状态并在以后能够将对象恢复到先前的状态。这种模式在需要实现撤销操作或保存对象历史状态的情况下非常有用。下面是一个简单的C#示例，演示备忘录模式的工作原理。 
              
使用场景：当需要实现撤销和恢复功能时，备忘录模式是一种有效的选择，如文本编辑器、图形编辑器等应用程序。
当需要保存对象的内部状态历史记录以支持时间旅行或版本控制时，备忘录模式非常有用。
当需要分离对象状态的保存和恢复逻辑以提高代码的可维护性时，备忘录模式是一个不错的选择。

优点：
撤销和恢复：备忘录模式允许对象保存其内部状态的历史记录，使得可以轻松实现撤销和恢复操作。
分离关注点：备忘录模式将状态保存和恢复的职责与原发器对象分离，从而提高了代码的可维护性和可扩展性。

缺点：保存大量状态的备忘录对象可能会消耗大量内存，特别是在需要保存大量状态历史记录时。

速记: 公共文本编辑器 保留历史状态 
*/

            var editor = new Editor();
            var historyManager = new HistoryManager();

            editor.Content = "aaabbbb";
            historyManager.Save(editor.Save());

            editor.Content = "bbbbgggg";
            historyManager.Save(editor.Save());

            var his =  historyManager.Get(0);

            editor.Restore(his);


            Console.ReadLine();
        }
    }
}