using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Manager
    {
        protected Project CurrentProject { get; }

        protected Manager(Project currentProject)
        {
            CurrentProject = currentProject;
        }

        /// <summary>
        /// 制定计划
        /// </summary>
        public abstract void SchedulePlan();

        /// <summary>
        /// 任务分配
        /// </summary>
        public abstract void AssignTasks();

        /// <summary>
        /// 进度把控
        /// </summary>
        public abstract void ControlProcess();


        /// <summary>
        /// 项目管理基本三要素 或者说所有继承类共通职责
        /// </summary>
        public virtual void ManageProject()
        {
            SchedulePlan();
            AssignTasks();
            ControlProcess();
        }
    }

    /// <summary>
    /// 项目经理
    /// </summary>
    public class ProjectManager : Manager
    {
        public ProjectManager(Project currentProject) : base(currentProject)
        {
        }

        public override void SchedulePlan()
        {
            base.CurrentProject.MakePlan();
        }

        public override void AssignTasks()
        {
            base.CurrentProject.ScheduleTask();
        }

        public override void ControlProcess()
        {
            base.CurrentProject.ControlProcess();
        }
        public override void ManageProject()
        {
            Console.WriteLine($"项目经理负责【{base.CurrentProject.ProjectName}】：");
            base.ManageProject();
        }

    }

    /// <summary>
    /// 产品经理
    /// </summary>
    public class ProductManger : Manager
    {
        public ProductManger(Project currentProject) : base(currentProject)
        {
        }
        public override void SchedulePlan()
        {
            base.CurrentProject.MakePlan();
        }

        public override void AssignTasks()
        {
            base.CurrentProject.ScheduleTask();
        }

        public override void ControlProcess()
        {
            base.CurrentProject.ControlProcess();
        }
        public void AnalyseRequirement()
        {
            base.CurrentProject.AnalyzeRequirement();
        }

        public void DesignProduct()
        {
            base.CurrentProject.DesignProduct();
        }


        public override void ManageProject()
        {
            Console.WriteLine($"产品经理负责【{base.CurrentProject.ProjectName}】：");


            //这里为产品经理额外做得事
            AnalyseRequirement();
            DesignProduct();
            base.ManageProject();
        }

    }



}
