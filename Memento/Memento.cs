using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    //public abstract class Memento
    //{

    //    /// <summary>
    //    /// 状态
    //    /// </summary>
    //    public string State { get; set; }
    //}

    /// <summary>
    /// 编辑器
    /// </summary>
    public class Editor
    {
        private string content;

        public string Content
        {
            get { return content; }
            set
            {
                content = value;
                Console.WriteLine($"Content set to: {content}");
            }
        }

        /// <summary>
        /// 保存副本（编辑器内部状态）
        /// </summary>
        /// <returns></returns>
        public EditorMemento Save()
        {
            return new EditorMemento(content);
        }

        /// <summary>
        /// 恢复
        /// </summary>
        /// <param name="memento"></param>
        public void Restore(EditorMemento memento)
        {
            content = memento.SavedContent;
            Console.WriteLine($"Restored to: {content}");
        }
    }

    /// <summary>
    /// 内容
    /// </summary>
    public class EditorMemento /*: Memento*/
    {
        public string SavedContent { get; }

        public EditorMemento(string content)
        {
            SavedContent = content;
        }
    }

    /// <summary>
    /// 存储副本 一个编辑器对应一个实例
    /// </summary>
    public class HistoryManager
    {
        private List<EditorMemento> mementos = new List<EditorMemento>();

        public void Save(EditorMemento memento)
        {
            mementos.Add(memento);
        }

        public EditorMemento Get(int index)
        {
            return mementos[index];
        }
    }

}
